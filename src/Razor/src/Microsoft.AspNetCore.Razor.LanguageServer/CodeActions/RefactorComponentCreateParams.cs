using System;

namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions
{
    internal class RefactorComponentCreateParams
    {
        public Uri Uri { get; set; }
        public string Name { get; set; }
        public string Where { get; set;  }
    }
}
