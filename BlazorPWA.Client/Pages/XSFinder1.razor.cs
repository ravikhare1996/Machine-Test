using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;
using MudBlazor.Utilities;
using MudBlazor;
using System.Data;
using XpertStudio.Common.Data;
using XpertStudio.Common.Functions;
using XpertStudio.Common.Controls;
using System.ComponentModel;
using XpertStudio.Common.Enums;
using XS.WinForms.Controls;
using CategoryAttribute = MudBlazor.CategoryAttribute;
using System.ComponentModel.DataAnnotations.Schema;
using MudBlazor.XS.Common;

namespace BlazorPWA.Client.Pages
{
#nullable enable
    public partial class XSFinder1<T> : MudBaseInput<T>, IXSCommonInput<T>, IXpertEntryBase, IDisposable
    {
        /// <summary>
        /// We need a random id for the year items in the year list so we can scroll to the item safely in every DatePicker.
        /// </summary>
        private readonly string _componentId = Guid.NewGuid().ToString();

        /// <summary>
        /// This boolean will keep track if the clear function is called too keep the set text function to be called.
        /// </summary>
        private bool _isCleared;
        private bool _isClearing;
        private bool _isProcessingValue;
        private int _selectedListItemIndex = 0;
        private int _elementKey = 0;
        private int _itemsReturned; //the number of items returned by the search function
        private bool _isOpen;
        private MudInput<string>? _elementReference;
        private CancellationTokenSource? _cancellationTokenSrc;
        private Task? _currentSearchTask;
        private Timer? _timer;
        private T[]? _items;
        private IList<int>? _enabledItemIndices = new List<int>();
        private Func<T?, string?>? _toStringFunc;

        [Inject]
        private IScrollManager? ScrollManager { get; set; }

        [Parameter]
        public Type? FinderPage { get; set; }

        [Parameter]
        public string? FinderUrl { get; set; }

        [Parameter]
        public DataTable? DataSource { get; set; }

        [Parameter]
        public Func<PagedRequest, Task<IEnumerable<IFinderData>>>? GetPaginatedDataMethod { get; set; }

        [Parameter]
        public int TotalRows { get; set; }

        [Parameter]
        public IFinderData? SelectedData { get; set; }

        [Parameter]
        public bool IsCustomFinder { get; set; } = false;

        [Parameter]
        public EventCallback<EventArgs> ValidatingParameters { get; set; }
        //objFinderDialog
        private XSCustomFinderParameters? _CustomFinderParameters;
        public XSCustomFinderParameters? CustomFinderParameters
        {
            get { return _CustomFinderParameters; }
            set
            {
                if (objFinderDialog == null)
                    return;
                _CustomFinderParameters = value;
                if (_CustomFinderParameters != null)
                {
                    objFinderDialog.CustomFinderParameters = _CustomFinderParameters;
                }
            }
        }

        //property to control the multi selection in finder and its dialog
        protected bool IsMultiSelectFinder { get; set; } = false;

        //[Parameter]
        //public List<IFinderData>? SelectedItems { get; set; }

        [Parameter]
        public EventCallback<List<T>> SelectedRowsChanged { get; set; }
        protected async Task ValidateParameters(EventArgs e)
        {
            if (ValidatingParameters.HasDelegate)
            {
                await ValidatingParameters.InvokeAsync(e);
            }
        }
        private FinderDialog1? objFinderDialog;
        protected string Classname =>
            new CssBuilder("mud-select")
            .AddClass(Class)
            .Build();

        protected string AutocompleteClassname =>
            new CssBuilder("mud-select")
            .AddClass("mud-autocomplete")
            .AddClass("mud-width-full", FullWidth)
            .AddClass("mud-autocomplete--with-progress", ShowProgressIndicator && IsLoading)
            .Build();

        protected string CircularProgressClassname =>
            new CssBuilder("progress-indicator-circular")
            .AddClass("progress-indicator-circular--with-adornment", Adornment == Adornment.End)
            .Build();

        /// <summary>
        /// User class names for the popover, separated by space
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public string? PopoverClass { get; set; }

        /// <summary>
        /// User class names for the internal list, separated by space
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public string? ListClass { get; set; }

        /// <summary>
        /// Set the anchor origin point to determen where the popover will open from.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public Origin AnchorOrigin { get; set; } = Origin.BottomCenter;

        /// <summary>
        /// Sets the transform origin point for the popover.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public Origin TransformOrigin { get; set; } = Origin.TopCenter;

        /// <summary>
        /// Set the anchor origin point to determen where the popover will open from.
        /// </summary>
        [ExcludeFromCodeCoverage]
        [Obsolete("Use AnchorOrigin or TransformOrigin instead.", true)]
        [Parameter]
        public Direction Direction { get; set; } = Direction.Bottom;

        /// <summary>
        /// If true, the Autocomplete menu will open either before or after the input (left/right).
        /// </summary>
        [ExcludeFromCodeCoverage]
        [Obsolete("Use AnchorOrigin or TransformOrigin instead.", true)]
        [Parameter] public bool OffsetX { get; set; }

        /// <summary>
        /// If true, the Autocomplete menu will open either before or after the input (top/bottom).
        /// </summary>
        [ExcludeFromCodeCoverage]
        [Obsolete("Use AnchorOrigin or TransformOrigin instead.", true)]
        [Parameter] public bool OffsetY { get; set; }

        /// <summary>
        /// If true, compact vertical padding will be applied to all Autocomplete items.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public bool Dense { get; set; }

        /// <summary>
        /// The Open Autocomplete Icon
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Appearance)]
        public string OpenIcon { get; set; } = Icons.Material.Filled.ArrowDropDown;

        /// <summary>
        /// The Close Autocomplete Icon
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Appearance)]
        public string CloseIcon { get; set; } = Icons.Material.Filled.ArrowDropUp;

        /// <summary>
        /// The maximum height of the Autocomplete when it is open.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListAppearance)]
        public int MaxHeight { get; set; } = 300;

        /// <summary>
        /// Defines how values are displayed in the drop-down list
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public Func<T?, string?>? ToStringFunc
        {
            get => _toStringFunc;
            set
            {
                if (_toStringFunc == value)
                    return;
                _toStringFunc = value;
                Converter = new Converter<T>
                {
                    SetFunc = _toStringFunc ?? (x => x?.ToString()),
                };
            }
        }

        /// <summary>
        /// Whether to show the progress indicator. 
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool ShowProgressIndicator { get; set; } = false;

        /// <summary>
        /// The color of the progress indicator. 
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Appearance)]
        public Color ProgressIndicatorColor { get; set; } = Color.Default;

        /// <summary>
        /// Func that returns a list of items matching the typed text. Provides a cancellation token that
        /// is marked as cancelled when the user changes the search text or selects a value from the list. 
        /// This can be used to cancel expensive asynchronous work occuring within the SearchFunc itself.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public Func<string?, CancellationToken?, Task<IEnumerable<T>>>? SearchFuncWithCancel { get; set; }

        /// <summary>
        /// The SearchFunc returns a list of items matching the typed text
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public Func<string, Task<IEnumerable<T>>>? SearchFunc { get; set; }

        /// <summary>
        /// Maximum items to display, defaults to 10.
        /// A null value will display all items.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public int? MaxItems { get; set; } = null;

        /// <summary>
        /// Minimum characters to initiate a search
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public int MinCharacters { get; set; } = 0;

        /// <summary>
        /// Reset value if user deletes the text
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool ResetValueOnEmptyText { get; set; } = false;

        /// <summary>
        /// If true, clicking the text field will select (highlight) its contents.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool SelectOnClick { get; set; } = true;

        /// <summary>
        /// If false, clicking on the Autocomplete after selecting an option will query the Search method again with an empty string. This makes it easier to view and select other options without resetting the Value.
        /// T must either be a record or override GetHashCode and Equals.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool Strict { get; set; } = true;

        /// <summary>
        /// Debounce interval in milliseconds.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public int DebounceInterval { get; set; } = 100;

        /// <summary>
        /// Optional presentation template for unselected items
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment<T>? ItemTemplate { get; set; }

        /// <summary>
        /// Optional presentation template for the selected item
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment<T>? ItemSelectedTemplate { get; set; }

        /// <summary>
        /// Optional presentation template for disabled item
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment<T>? ItemDisabledTemplate { get; set; }

        /// <summary>
        /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? MoreItemsTemplate { get; set; }

        /// <summary>
        /// Optional presentation template for when no items were returned from the Search function
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? NoItemsTemplate { get; set; }


        /// <summary>
        /// Optional presentation template that is always shown at the top of the list
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? BeforeItemsTemplate { get; set; }

        /// <summary>
        /// Optional presentation template that is always shown at the bottom of the list
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? AfterItemsTemplate { get; set; }

        /// <summary>
        /// Optional template for progress indicator
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? ProgressIndicatorTemplate { get; set; }

        /// <summary>
        /// Optional template for showing progress indicator inside the popover
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public RenderFragment? ProgressIndicatorInPopoverTemplate { get; set; }

        /// <summary>
        /// On drop-down close override Text with selected Value. This makes it clear to the user
        /// which list value is currently selected and disallows incomplete values in Text.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool CoerceText { get; set; } = true;

        /// <summary>
        /// If user input is not found by the search func and CoerceValue is set to true the user input
        /// will be applied to the Value which allows to validate it and display an error message.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool CoerceValue { get; set; }

        /// <summary>
        /// Function to be invoked when checking whether an item should be disabled or not
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public Func<T, bool>? ItemDisabledFunc { get; set; }

        /// <summary>
        /// An event triggered when the state of IsOpen has changed
        /// </summary>
        [Parameter]
        public EventCallback<bool> IsOpenChanged { get; set; }

        /// <summary>
        /// If true, the currently selected item from the drop-down (if it is open) is selected.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.ListBehavior)]
        public bool SelectValueOnTab { get; set; } = false;

        /// <summary>
        /// Show clear button.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.FormComponent.Behavior)]
        public bool Clearable { get; set; } = false;

        /// <summary>
        /// Button click event for clear button. Called after text and value has been cleared.
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> OnClearButtonClick { get; set; }

        /// <summary>
        /// Returns the open state of the drop-down.
        /// </summary>
        public bool IsOpen
        {
            get => _isOpen;
            // Note: the setter is protected because it was needed by a user who derived his own autocomplete from this class.
            // Note: setting IsOpen will not open or close it. Use ToggleMenu() for that. 
            protected set
            {
                if (_isOpen == value)
                    return;
                _isOpen = value;

                IsOpenChanged.InvokeAsync(_isOpen).AndForget();
            }
        }

        private bool IsLoading => _currentSearchTask is { IsCompleted: false };

        private string CurrentIcon => !string.IsNullOrWhiteSpace(AdornmentIcon) ? AdornmentIcon : _isOpen ? CloseIcon : OpenIcon;

        public XSFinder1()
        {
            Adornment = Adornment.End;
            IconSize = Size.Medium;
            if (SelectedData == null)
            {
                SelectedData = new FinderData();
            }
            //New Code(07082024)
            if (objFinderDialog != null)
            {
                if (IsMultiSelectFinder)
                {
                    objFinderDialog.SelectedItems = SelectedValues?.Cast<IFinderData>().ToList();
                }
                else
                {
                    objFinderDialog.SelectedFinderData = SelectedData;
                }
            }
            _cancellationTokenSrc = null;
            SearchFunc = null;
        }

        public async Task SelectOption(T value)
        {
            _isProcessingValue = true;
            try
            {
                await SetValueAsync(value);
                if (_items != null)
                    _selectedListItemIndex = Array.IndexOf(_items, value);
                var optionText = GetItemString(value);
                if (!_isCleared)
                    await SetTextAsync(optionText, false);
                _timer?.Dispose();
                IsOpen = false;
                await BeginValidateAsync();
                if (!_isCleared)
                    _elementReference?.SetText(optionText);
                _elementReference?.FocusAsync().AndForget();
                StateHasChanged();
            }
            finally
            {
                _isProcessingValue = false;
            }
        }
        public async Task SelectMultiOption(List<T>? values)
        {
            if (values == null)
            {
                return;
            }
            _isProcessingValue = true;
            try
            {
                if (values != null && values.Count > 0)
                {
                    //set first item so that Value property can be updated and validated
                    await SetValueAsync(values.FirstOrDefault());
                }

                SelectedValues = values;
                await SelectedRowsChanged.InvokeAsync();
                if (_items != null)
                    _selectedListItemIndex = Array.IndexOf(_items, values);
                var optionText = XpertCommonFunctions.GetMulcallStringWithComma(values?.Cast<IFinderData>().Select(x => x.Code + "-" + x.Name).ToList());
                if (!_isCleared)
                    await SetTextAsync(optionText, false);
                _timer?.Dispose();
                //IsOpen = false;
                //validate the data
                await BeginValidateAsync();
                if (!_isCleared)
                    _elementReference?.SetText(optionText);
                _elementReference?.FocusAsync().AndForget();
                StateHasChanged();
            }
            finally
            {
                _isProcessingValue = false;
            }
        }

        //protected override async Task SetValueAsync(T value, bool updateText = true, bool force = false)
        //{
        //    if (!IsMultiSelectFinder)
        //    {
        //        await base.SetValueAsync(value, updateText);
        //    }
        //    else
        //    {

        //    }
        //    if (!EqualityComparer<T>.Default.Equals(Value, value) || force == true)
        //    {
        //        _isDirty = true;
        //        Value = value;
        //        await ValueChanged.InvokeAsync(Value);
        //        if (updateText)
        //            await UpdateTextPropertyAsync(false);
        //        FieldChanged(Value);
        //        await BeginValidateAsync();
        //    }
        //}

        /// <summary>
        /// Toggle the menu (if not disabled or not readonly, and is opened).
        /// </summary>
        public async Task ToggleMenu()
        {
            if ((GetDisabledState() || GetReadOnlyState()) && !IsOpen)
                return;
            await ChangeMenu(!IsOpen);
        }

        private async Task ChangeMenu(bool open)
        {
            if (_elementReference == null)
                return;
            if (open)
            {
                if (SelectOnClick)
                    await _elementReference.SelectAsync();
                await OnSearchAsync();
            }
            else
            {
                _timer?.Dispose();
                await RestoreScrollPositionAsync();
                await CoerceTextToValue();
                IsOpen = false;
                StateHasChanged();
            }
        }

        protected override void OnInitialized()
        {
            if (Value != null)
            {
                var text = GetItemString(Value);
                if (!string.IsNullOrWhiteSpace(text))
                    Text = text;
            }
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (_isClearing || _isProcessingValue)
            {
                //When you select a value in the popover, SelectOption will be called.
                //When it reaches SetValueAsync, it will be awaited.
                //Meanwhile, in parallel, the Clear method will be called, which sets isCleared to true.
                //However, by the time SetValueAsync is released and SelectOption continues its execution, an OnAfterRender event might fire, setting isCleared back to false.
                //This can result in a race condition.
                //https://github.com/MudBlazor/MudBlazor/pull/6701
                base.OnAfterRender(firstRender);
                return;
            }
            _isCleared = false;
            base.OnAfterRender(firstRender);
        }

        protected override Task UpdateTextPropertyAsync(bool updateValue)
        {
            _timer?.Dispose();
            // This keeps the text from being set when clear() was called
            if (_isCleared)
                return Task.CompletedTask;
            return base.UpdateTextPropertyAsync(updateValue);
        }

        protected override async Task UpdateValuePropertyAsync(bool updateText)
        {
            _timer?.Dispose();

            if (ResetValueOnEmptyText && string.IsNullOrWhiteSpace(Text))
            {
                await SetValueAsync(default(T), updateText);
            }

            if (DebounceInterval <= 0)
                await OnSearchAsync();
            else
            {
                _timer = new Timer(OnTimerComplete, null, DebounceInterval, Timeout.Infinite);
            }

        }
        protected override async Task SetValueAsync(T? value, bool updateText = true, bool force = false)
        {
            if (value != null)
            {
                await base.SetValueAsync(value, updateText, force);
            }
        }
        private void OnTimerComplete(object? stateInfo) => InvokeAsync(OnSearchAsync);

        private void CancelToken()
        {
            try
            {
                _cancellationTokenSrc?.Cancel();
            }
            catch { /*ignored*/ }
            finally
            {
                _cancellationTokenSrc = new CancellationTokenSource();
            }
        }

        /// <remarks>
        /// This async method needs to return a task and be awaited in order for
        /// unit tests that trigger this method to work correctly.
        /// </remarks>
        private async Task OnSearchAsync()
        {

            if (MinCharacters > 0 && (string.IsNullOrWhiteSpace(Text) || Text.Length < MinCharacters))
            {
                IsOpen = false;
                StateHasChanged();
                return;
            }

            var searchedItems = Array.Empty<T>();
            CancelToken();

            var searchingWhileSelected = false;
            try
            {
                if (ProgressIndicatorInPopoverTemplate != null)
                {
                    IsOpen = true;
                }

                searchingWhileSelected = !Strict && Value != null && (Value.ToString() == Text || (ToStringFunc != null && ToStringFunc(Value) == Text)); //search while selected if enabled and the Text is equivalent to the Value
                var searchText = searchingWhileSelected ? string.Empty : Text;

                var searchTask = SearchFuncWithCancel != null ?
                    SearchFuncWithCancel(searchText, _cancellationTokenSrc?.Token) :
                   (SearchFunc != null ? SearchFunc(searchText) : null);

                _currentSearchTask = searchTask;

                StateHasChanged();
                if (searchTask != null)
                {
                    var searchItems = await searchTask ?? Enumerable.Empty<T>();
                    searchedItems = searchItems.ToArray();
                }

            }
            catch (TaskCanceledException)
            {
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception e)
            {
                Logger.LogWarning("The search function failed to return results: " + e.Message);
            }

            _itemsReturned = searchedItems.Length;

            if (MaxItems.HasValue)
            {
                searchedItems = searchedItems.Take(MaxItems.Value).ToArray();
            }
            _items = searchedItems.ToArray();
            var enabledItems = _items.Select((item, idx) => (item, idx)).Where(tuple => ItemDisabledFunc?.Invoke(tuple.item) != true).ToList();
            _enabledItemIndices = enabledItems.Select(tuple => tuple.idx).ToList();
            if (searchingWhileSelected) //compute the index of the currently select value, if it exists
            {
                _selectedListItemIndex = Array.IndexOf(_items, Value);
            }
            else
            {
                _selectedListItemIndex = _enabledItemIndices.Any() ? _enabledItemIndices.First() : -1;
            }

            IsOpen = true;

            if (_items?.Length == 0)
            {
                await CoerceValueToText();
                StateHasChanged();
                return;
            }

            StateHasChanged();
        }

        /// <summary>
        /// Clears the autocomplete's text
        /// </summary>
        public async Task Clear()
        {
            _isClearing = true;
            try
            {
                _isCleared = true;
                IsOpen = false;
                await SetTextAsync(null, updateValue: false);
                await CoerceValueToText();
                if (_elementReference != null)
                    await _elementReference.SetText("");
                _timer?.Dispose();
                StateHasChanged();
            }
            finally
            {
                _isClearing = false;
            }
        }

        [Obsolete($"Use {nameof(ResetValueAsync)} instead. This will be removed in v7")]
        [ExcludeFromCodeCoverage]
        protected override async void ResetValue() => await Clear();

        protected override Task ResetValueAsync() => Clear();

        private string? GetItemString(T item)
        {
            if (item == null)
                return string.Empty;
            try
            {
                return Converter.Set(item);
            }
            catch (NullReferenceException) { }
            return "null";
        }

        internal virtual async Task OnInputKeyDown(KeyboardEventArgs args)
        {
            switch (args.Key)
            {
                case "Tab":
                    // NOTE: We need to catch Tab in Keydown because a tab will move focus to the next element and thus
                    // in OnInputKeyUp we'd never get the tab key
                    if (!IsOpen)
                        return;
                    if (SelectValueOnTab)
                        await OnEnterKey();
                    else
                        IsOpen = false;
                    break;
            }
            await base.InvokeKeyDownAsync(args);
        }

        internal virtual async Task OnInputKeyUp(KeyboardEventArgs args)
        {
            switch (args.Key)
            {
                case "Enter":
                case "NumpadEnter":
                    if (!IsOpen)
                    {
                        await ToggleMenu();
                    }
                    else
                    {
                        await OnEnterKey();
                    }
                    break;
                case "ArrowDown":
                    if (!IsOpen)
                    {
                        await ToggleMenu();
                    }
                    else
                    {
                        if (_enabledItemIndices != null)
                        {
                            var increment = _enabledItemIndices.ElementAtOrDefault(_enabledItemIndices.IndexOf(_selectedListItemIndex) + 1) - _selectedListItemIndex;
                            await SelectNextItem(increment < 0 ? 1 : increment);
                        }

                    }
                    break;
                case "ArrowUp":
                    if (args.AltKey == true)
                    {
                        await ChangeMenu(open: false);
                    }
                    else if (!IsOpen)
                    {
                        await ToggleMenu();
                    }
                    else
                    {
                        if (_enabledItemIndices != null)
                        {
                            var decrement = _selectedListItemIndex - _enabledItemIndices.ElementAtOrDefault(_enabledItemIndices.IndexOf(_selectedListItemIndex) - 1);
                            await SelectNextItem(-(decrement < 0 ? 1 : decrement));
                        }
                    }
                    break;
                case "Escape":
                    await ChangeMenu(open: false);
                    break;
                case "Tab":
                    await Task.Delay(1);
                    if (!IsOpen)
                        return;
                    if (SelectValueOnTab)
                        await OnEnterKey();
                    else
                        await ToggleMenu();
                    break;
                case "Backspace":
                    if (args.CtrlKey == true && args.ShiftKey == true)
                    {
                        // await ResetAsync();
                    }
                    break;
            }
            await base.InvokeKeyUpAsync(args);
        }

        private ValueTask SelectNextItem(int increment)
        {
            if (_enabledItemIndices != null)
            {
                if (increment == 0 || _items == null || _items.Length == 0 || !_enabledItemIndices.Any())
                    return ValueTask.CompletedTask;
            }
            else
            {
                if (increment == 0 || _items == null || _items.Length == 0)
                    return ValueTask.CompletedTask;
            }

            // if we are at the end, or the beginning we just do an rollover
            _selectedListItemIndex = Math.Clamp(value: (10 * _items.Length + _selectedListItemIndex + increment) % _items.Length, min: 0, max: _items.Length - 1);
            return ScrollToListItem(_selectedListItemIndex);
        }

        // <summary>
        // Scroll to a specific item index in the Autocomplete list of items.
        // </summary>
        // <param name="index">the index to scroll to</param>
        // <param name="increment">not used</param>
        // <returns>ValueTask</returns>
        //[Obsolete("Use ScrollToListItem without increment parameter instead")]
        //public Task ScrollToListItem(int index, int increment)
        //    => ScrollToListItem(index).AsTask();

        /// <summary>
        /// Scroll to a specific item index in the Autocomplete list of items.
        /// </summary>
        /// <param name="index">the index to scroll to</param>
        public ValueTask ScrollToListItem(int index)
        {
            var id = GetListItemId(index);
            //id of the scrolled element
            if (ScrollManager != null)
            {
                return ScrollManager.ScrollToListItemAsync(id);
            }
            else
            {
                return ValueTask.CompletedTask;
            }
        }

        //This restores the scroll position after closing the menu and element being 0
        private ValueTask RestoreScrollPositionAsync()
        {
            if (_selectedListItemIndex != 0) return ValueTask.CompletedTask;
            if (ScrollManager != null)
            {
                return ScrollManager.ScrollToListItemAsync(GetListItemId(0));
            }
            else
            {
                return ValueTask.CompletedTask;
            }

        }

        private string GetListItemId(in int index)
        {
            return $"{_componentId}_item{index}";
        }

        internal async Task OnEnterKey()
        {
            if (IsOpen == false)
                return;
            try
            {
                if (_items == null || _items.Length == 0)
                    return;
                if (_selectedListItemIndex >= 0 && _selectedListItemIndex < _items.Length)
                    await SelectOption(_items[_selectedListItemIndex]);
            }
            finally
            {
                if (IsOpen)
                    IsOpen = false;
            }
        }

        private Task OnInputBlurred(FocusEventArgs args)
        {
            return OnBlur.InvokeAsync(args);
            // we should not validate on blur in autocomplete, because the user needs to click out of the input to select a value,
            // resulting in a premature validation. thus, don't call base
            //base.OnBlurred(args);
        }

        private Task CoerceTextToValue()
        {
            if (CoerceText == false)
                return Task.CompletedTask;

            _timer?.Dispose();

            var text = Value == null ? null : GetItemString(Value);

            // Don't update the value to prevent the popover from opening again after coercion
            if (text != Text)
                return SetTextAsync(text, updateValue: false);

            return Task.CompletedTask;
        }

        private Task CoerceValueToText()
        {
            if (CoerceValue == false)
                return Task.CompletedTask;
            _timer?.Dispose();
            var value = Converter.Get(Text);
            if (value != null)
                return SetValueAsync(value, updateText: false);
            else
                return Task.CompletedTask;
        }

        protected override void Dispose(bool disposing)
        {
            _timer?.Dispose();

            if (_cancellationTokenSrc != null)
            {
                try
                {
                    _cancellationTokenSrc.Dispose();
                }
                catch { /*ignored*/ }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Focus the input in the Autocomplete component.
        /// </summary>
        public override ValueTask FocusAsync()
        {
            if (_elementReference != null)
            {
                return _elementReference.FocusAsync();
            }
            else
            {
                return base.FocusAsync();
            }
        }

        /// <summary>
        /// Blur from the input in the Autocomplete component.
        /// </summary>
        public override ValueTask BlurAsync()
        {
            if (_elementReference != null)
            {
                return _elementReference.BlurAsync();
            }
            else
            {
                return base.BlurAsync();
            }

        }

        /// <summary>
        /// Select all text within the Autocomplete input.
        /// </summary>
        public override ValueTask SelectAsync()
        {
            if (_elementReference != null)
            {
                return _elementReference.SelectAsync();
            }
            else
            {
                return base.SelectAsync();
            }
        }

        /// <summary>
        /// Select all text within the Autocomplete input and aligns its start and end points to the text content of the current input.
        /// </summary>
        public override ValueTask SelectRangeAsync(int pos1, int pos2)
        {
            if (_elementReference != null)
            {
                return _elementReference.SelectRangeAsync(pos1, pos2);
            }
            else
            {
                return base.SelectRangeAsync(pos1, pos2);
            }

        }

        private async Task OnTextChanged(string text)
        {
            await base.TextChanged.InvokeAsync(text);

            if (text == null)
                return;
            await SetTextAsync(text, true);
        }

        private Task ListItemOnClick(T item) => SelectOption(item);

        public async void OnFinderDataChanged(IFinderData selectedData)
        {
            if (selectedData != null)
            {
                // Do something with the new data
                SelectedData = selectedData;
                await SelectOption((T)selectedData);
                //IsOpen = false;
                //SelectedDataChanged(this.SelectedData);
            }

        }

        public async void OnFinderSelectedRowsChanged(List<IFinderData> selectedRows)
        {

            // Do something with the new data
            //SelectedItems = selectedRows;
            await SelectMultiOption(selectedRows?.Cast<T>().ToList());
            // await SelectOption((T)selectedRows?.FirstOrDefault());
            //IsOpen = false;
            //SelectedDataChanged(this.SelectedData);
        }
        private T? _Value;
        public new T? Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                if (_Value != null)
                {
                    SetValueAsync(_Value).AndForget();
                }
                //Value = _Text;
                ForceUpdate().AndForget();
            }
        }
        private List<T>? _selectedValues = new List<T>();
        [Parameter]
        [Category(CategoryTypes.FormComponent.Data)]
        public IEnumerable<T>? SelectedValues
        {
            get
            {
                if (_selectedValues == null)
                    _selectedValues = new List<T>();
                return _selectedValues;
            }
            set
            {
                if (_selectedValues == null)
                {
                    return;
                }
                var set = value ?? new List<T>();
                if (SelectedValues?.Count() == set.Count() && _selectedValues.All(x => set.Contains(x)))
                    return;
                _selectedValues = new List<T>(set);
                //SelectionChangedFromOutside?.Invoke(_selectedValues);
                if (!IsMultiSelectFinder)
                {
                    if (_selectedValues != null && _selectedValues.First() != null)
                    {
                        SetValueAsync(_selectedValues.First()).AndForget();
                    }
                }

                else
                {
                    SetTextAsync(string.Join("-", _selectedValues.Select(x => Converter.Set(x))), updateValue: false).AndForget();
                }
                //SelectedValuesChanged.InvokeAsync(new HashSet<T>(SelectedValues, _comparer));
                if (IsMultiSelectFinder && typeof(T) == typeof(string))
                    SetValueAsync((T)(object)Text, updateText: false).AndForget();
            }
        }

        //IXSCommonUI
        public bool Enabled
        {
            get { return !this.Disabled; }
            set { this.Disabled = !value; }
        }
        //public new object? Value
        //{
        //    get { return base.Value; }
        //    set { base.Value = (T)value; }
        //}

        //IXpertEntryBase
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field Name: Name of the field in class as well as database.")]
        [DisplayName("Field Name")]
        public string? Field_Name { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Display Name: Name by which the field will be visible to end user on screen.")]
        [DisplayName("Display Name")]
        public string? Display_Name { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field Description: Any description to describe the field.")]
        [DisplayName("Field Description")]
        public string? Field_Description { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Column Name: Name of the column of in database mapped with field.")]
        [DisplayName("Column Name")]
        public string? Column_Name { get; set; }

        [Browsable(true), ReadOnly(false)]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Metadata Type: Auto/Manual/NotMapped.")]
        [DisplayName("Metadata Type")]
        public XpertMetadataTypes? Metadata_Type { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculative: select whether field is calculative(Yes or No)")]
        public bool Calculative { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculation Type: select None/Database/Designer/Both")]
        [DisplayName("Calculation Type")]
        public CalculationTypes Calculation_Type { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Calculation Expression: Enter formula/expression for Calculation")]
        [DisplayName("Calculation Expression")]
        public string? Calculation_Expression { get; set; }

        [Browsable(false)]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("MendatroryField: select whether field is mandatory or optional(Yes or No)")]
        [DisplayName("Mandatory")]
        public bool MendatroryField { get; set; }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Field_Type: select Domain Field Type from the list.")]
        [DisplayName("Field Domain Type")]
        public XpertFieldTypes Field_Type { get; set; }


        private XpertFieldCreateOptions _Create_Option;
        [DisplayName("Create Option")]
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Create Option: select physical existence of the field in different layers of the application.")]
        public XpertFieldCreateOptions Create_Option
        {
            get { return _Create_Option; }
            set { _Create_Option = value; }
        }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Custom Data?: Select true if the control have a separate logic for to format its value at Model layer.")]
        [DisplayName("Custom Data?")]
        public bool Custom_Data
        {
            get;
            set;
        }

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control Name: Name of the control.")]
        [DisplayName("Custom Format?")]
        public bool Custom_Default { get; set; }


        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control Name: Name of the control.")]
        [DisplayName("Control Name")]
        public string? Control_Name
        {
            get;
            set;
        }

        private ControlGroups _Control_Group;
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control_Group: Read only property of the control group")]
        [ReadOnly(true)]
        [DisplayName("Control Group")]
        public ControlGroups Control_Group
        {
            get { return ControlGroups.DataEntry; }
            set { _Control_Group = value; }
        }

        private ControlTypes _Control_Type;
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Control_Type: Read only property of the control Type")]
        [ReadOnly(true)]
        [DisplayName("Control Type")]
        public ControlTypes Control_Type
        {
            get { return ControlTypes.Finder; }
            set { _Control_Type = value; }
        }


        private XS_SkipTypes _XS_Skip;

        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Skip Code Generation: Select Skip Type to skip the standard code generation of XpertStudio to customize selected field and associated property.")]
        [DisplayName("Skip Code Generation")]
        public XS_SkipTypes XS_Skip
        {
            get
            {
                return _XS_Skip;
            }
            set
            {
                _XS_Skip = value;
                //Visible = !value;
            }
        }
        [NotMapped]
        [Browsable(false)]
        public bool Generated { get; set; }

        private string? _XSMapper_Control;
        [CategoryAttribute("Functional Properties"), DescriptionAttribute("Mapped Control: Respective Blazor control for WinForms controls and WinForms control for Web Controls.")]
        [DisplayName("Mapped Control")]
        [Browsable(false)]
        public virtual string? XSMapper_Control
        {
            get
            {
                if (XpertCommonFunctions.myLen(_XSMapper_Control) <= 0)
                {
                    _XSMapper_Control = "XpertFinder";
                }
                return _XSMapper_Control;
            }
            set
            {
                _XSMapper_Control = value;
            }
        }
    }
}
