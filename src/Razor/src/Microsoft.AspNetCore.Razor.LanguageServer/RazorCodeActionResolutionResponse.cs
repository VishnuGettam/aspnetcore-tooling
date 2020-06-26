using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace Microsoft.AspNetCore.Razor.LanguageServer
{
    internal class RazorCodeActionResolutionResponse
    {
        public WorkspaceEdit Edit { get; set; }
    }
}
