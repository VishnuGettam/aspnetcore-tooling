// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;


namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions
{
    struct RazorCodeActionContext
    {
        public RazorCodeActionContext(CodeActionParams request, DocumentSnapshot documentSnapshot, RazorCodeDocument codeDocument, SourceLocation location)
        {
            Request = request;
            DocumentSnapshot = documentSnapshot;
            CodeDocument = codeDocument;
            Location = location;
        }

        public readonly CodeActionParams Request { get; }
        public readonly DocumentSnapshot DocumentSnapshot { get; }
        public readonly RazorCodeDocument CodeDocument {get; }
        public readonly SourceLocation Location { get; }
    }
}
