// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Razor.LanguageServer.Common
{
    public static class LanguageServerConstants
    {
        public const string ProjectConfigurationFile = "project.razor.json";

        public const string RazorSemanticTokensEndpoint = "textDocument/semanticTokens";

        public const string RazorSemanticTokensEditEndpoint = "textDocument/semanticTokens/edits";

        public const string RazorSemanticTokensRangeEndpoint = "textDocument/semanticTokens/range";

        public const string RazorSemanticTokensLegendEndpoint = "_ms_/textDocument/semanticTokensLegend";

        public const string RazorRangeFormattingEndpoint = "razor/rangeFormatting";

        public const string RazorUpdateCSharpBufferEndpoint = "razor/updateCSharpBuffer";

        public const string RazorUpdateHtmlBufferEndpoint = "razor/updateHtmlBuffer";

        public const string RazorLanguageQueryEndpoint = "razor/languageQuery";

        public const string RazorMapToDocumentRangesEndpoint = "razor/mapToDocumentRanges";

<<<<<<< HEAD
        public const string SemanticTokensProviderName = "semanticTokensProvider";

=======
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
        public const string RazorCodeActionResolutionEndpoint = "razor/resolveCodeAction";
    }
}
