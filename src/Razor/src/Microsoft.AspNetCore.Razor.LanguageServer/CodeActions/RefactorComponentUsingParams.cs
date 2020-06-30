using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions
{
    internal class RefactorComponentUsingParams
    {
        public Uri Uri { get; set; }
        public string[] Namespaces { get; set; }
    }
}
