using MediatR;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNetCore.Razor.LanguageServer
{
    internal class RazorCodeActionResolutionParams : IRequest<RazorCodeActionResolutionResponse>
    {
        public string Action { get; set; }
        public JObject Data { get; set; }
    }
}
