// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_TagHelpersWithTemplate_DesignTime
    {
        private global::DivTagHelper __DivTagHelper;
        private global::InputTagHelper __InputTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TagHelpersWithTemplate.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TagHelpersWithTemplate.cshtml"
      
        RenderTemplate(
            "Template: ",
            

#line default
#line hidden
#nullable disable
            item => new Template(async(__razor_template_writer) => {
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TagHelpersWithTemplate.cshtml"
                                  __o = item;

#line default
#line hidden
#nullable disable
                __InputTagHelper = CreateTagHelper<global::InputTagHelper>();
                __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            }
            )
#nullable restore
#line 16 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TagHelpersWithTemplate.cshtml"
                                                                                               );
    

#line default
#line hidden
#nullable disable
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TagHelpersWithTemplate.cshtml"
            
    public void RenderTemplate(string title, Func<string, HelperResult> template)
    {
        Output.WriteLine("<br /><p><em>Rendering Template:</em></p>");
        var helperResult = template(title);
        helperResult.WriteTo(Output, HtmlEncoder);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591