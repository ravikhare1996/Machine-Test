using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Components.XS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XpertStudio.Common.Controls;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using XS.WinForms.Controls;

namespace BlazorPWA.Client.Pages
{
#nullable enable
    public partial class XSTextEditorLocal : IXSCommonInput<string>, IXpertEntryBase
    {
        [Parameter]
        public Toolbar? Toolbar { get; set; }
        [Parameter]
        public List<string>? Fonts { get; set; }
        [Parameter]
        public string? EditorContainerId { get; set; }
        [Parameter]
        public RenderFragment? EditorContent { get; set; }

        [Parameter]
        public RenderFragment? ToolbarContent { get; set; }

        //[Parameter]
        //public bool ReadOnly { get; set; } = false;

        //[Parameter]
        //public string? Placeholder { get; set; } = "Compose an epic...";

        [Parameter]
        public string? Theme { get; set; } = "snow";

        [Parameter]
        public string? DebugLevel { get; set; } = "info";

        private ElementReference _quillElement;
        private ElementReference _toolBar;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await MyInterop.CreateQuill(
                    _jsRuntime,
                    _quillElement,
                    _toolBar,
                    ReadOnly,
                    Placeholder!,
                    Theme!,
                    DebugLevel, Fonts);
            }
        }

        public async Task<string> GetText()
        {
            return await MyInterop.GetText(
                _jsRuntime, _quillElement);
        }

        public async Task<string?> GetHtml()
        {
            _Value = await MyInterop.GetHtml(
                _jsRuntime, _quillElement);
            return _Value;
        }

        public async Task<string?> GetContent()
        {
            return await MyInterop.GetContent(
                _jsRuntime, _quillElement);
        }

        public async Task LoadContent(string? content)
        {
            var quillDelta =
                await MyInterop.LoadQuillContent(
                    _jsRuntime, _quillElement, content);
        }

        public async Task LoadHtmlContent(string quillHtmlContent)
        {
            var quillDelta =
                await MyInterop.LoadQuillHtmlContent(
                    _jsRuntime, _quillElement, quillHtmlContent);
        }

        public async Task InsertImage(string imageUrl)
        {
            var quillDelta =
                await MyInterop.InsertQuillImage(
                    _jsRuntime, _quillElement, imageUrl);
        }

        public async Task EnableEditor(bool mode)
        {
            var quillDelta =
                await MyInterop.EnableQuillEditor(
                    _jsRuntime, _quillElement, mode);
        }

        //IXSCommonUI
        private string? _Text;
        public new string? Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                LoadContent(value).AndForget();
                _Text = XpertCommonFunctions.myCstr(_Text);
                base.SetValueAsync(_Text).AndForget();
                base.ForceUpdate().AndForget();
            }
        }
        private bool _Enabled;
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                _Enabled = value;
                this.EnableEditor(value).AndForget();
            }
        }
        private string? _Value;
        public new string? Value
        {
            get { GetHtml().AndForget(); return _Value; }
            set { LoadHtmlContent(XpertCommonFunctions.myCstr(value)).AndForget(); }
        }

        public new string? Label
        {
            get { return Placeholder; }
            set { Placeholder = value; }
        }

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
            get { return ControlTypes.TextEditor; }
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
        [MudBlazor.CategoryAttribute("Functional Properties"), DescriptionAttribute("Mapped Control: Respective Blazor control for WinForms controls and WinForms control for Web Controls.")]
        [DisplayName("Mapped Control")]
        [Browsable(false)]
        public virtual string? XSMapper_Control
        {
            get
            {
                if (XpertCommonFunctions.myLen(_XSMapper_Control) <= 0)
                {
                    _XSMapper_Control = "XpertTextEditor";
                }
                return _XSMapper_Control;
            }
            set
            {
                _XSMapper_Control = value;
            }
        }
        public int TabIndex { get; set; }
    }
}
