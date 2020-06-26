<<<<<<< HEAD
=======
﻿using System.Collections.Generic;
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
using MediatR;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNetCore.Razor.LanguageServer
{
<<<<<<< HEAD
    internal class RazorCodeActionResolutionParams : IRequest<RazorCodeActionResolutionResponse>
=======
    class RazorCodeActionResolutionParams : IRequest<RazorCodeActionResolutionResponse>
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
    {
        public string Action { get; set; }
        public JObject Data { get; set; }
    }
}
