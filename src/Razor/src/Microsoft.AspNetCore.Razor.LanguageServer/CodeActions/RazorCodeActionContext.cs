using System;
using Microsoft.AspNetCore.Razor.Language;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions
{
    internal struct RazorCodeActionContext
    {
        public readonly CodeActionParams Request { get; }
        public readonly RazorCodeDocument Document { get; }
        public readonly SourceLocation Location { get; }

        public RazorCodeActionContext(CodeActionParams request, RazorCodeDocument document, SourceLocation location)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (document is null)
            {
                throw new ArgumentNullException(nameof(document));
            }

            Request = request;
            Document = document;
            Location = location;
        }
    }
}
