using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPWA.Client.Pages
{
    public class MyInterop
    {
        internal static ValueTask<object> CreateQuill(IJSRuntime jsRuntime, ElementReference quillElement, ElementReference toolbar, bool? readOnly, string placeholder, string theme, string? debugLevel, List<string>? customFonts = null)
        {
            return JSRuntimeExtensions.InvokeAsync<object>(jsRuntime, "QuillFunctions.createQuill", new object[7] { quillElement, toolbar, readOnly, placeholder, theme, debugLevel, customFonts });
        }

        internal static ValueTask<string> GetText(IJSRuntime jsRuntime, ElementReference quillElement)
        {
            return JSRuntimeExtensions.InvokeAsync<string>(jsRuntime, "QuillFunctions.getQuillText", new object[1] { quillElement });
        }

        internal static ValueTask<string?> GetHtml(IJSRuntime jsRuntime, ElementReference quillElement)
        {
            return JSRuntimeExtensions.InvokeAsync<string>(jsRuntime, "QuillFunctions.getQuillHTML", new object[1] { quillElement });
        }

        internal static ValueTask<string?> GetContent(IJSRuntime jsRuntime, ElementReference quillElement)
        {
            return JSRuntimeExtensions.InvokeAsync<string>(jsRuntime, "QuillFunctions.getQuillContent", new object[1] { quillElement });
        }

        internal static ValueTask<object> LoadQuillContent(IJSRuntime jsRuntime, ElementReference quillElement, string? content)
        {
            return JSRuntimeExtensions.InvokeAsync<object>(jsRuntime, "QuillFunctions.loadQuillContent", new object[2] { quillElement, content });
        }

        internal static ValueTask<object> LoadQuillHtmlContent(IJSRuntime jsRuntime, ElementReference quillElement, string quillHtmlContent)
        {
            return JSRuntimeExtensions.InvokeAsync<object>(jsRuntime, "QuillFunctions.loadQuillHTMLContent", new object[2] { quillElement, quillHtmlContent });
        }

        internal static ValueTask<object> EnableQuillEditor(IJSRuntime jsRuntime, ElementReference quillElement, bool mode)
        {
            return JSRuntimeExtensions.InvokeAsync<object>(jsRuntime, "QuillFunctions.enableQuillEditor", new object[2] { quillElement, mode });
        }

        internal static ValueTask<object> InsertQuillImage(IJSRuntime jsRuntime, ElementReference quillElement, string imageUrl)
        {
            return JSRuntimeExtensions.InvokeAsync<object>(jsRuntime, "QuillFunctions.insertQuillImage", new object[2] { quillElement, imageUrl });
        }
    }
}
