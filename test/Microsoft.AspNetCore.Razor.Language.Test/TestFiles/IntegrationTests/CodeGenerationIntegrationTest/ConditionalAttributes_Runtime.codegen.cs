#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088be4e50958bcab0f1d1ac04d2c28dcd8049bf5"
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_ConditionalAttributes_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
  
    var ch = true;
    var cls = "bar";

#line default
#line hidden
            WriteLiteral("    <a href=\"Foo\" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 74, "\"", 86, 1);
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue("", 82, cls, 82, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 98, "\"", 114, 2);
            WriteAttributeValue("", 106, "foo", 106, 3, true);
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue(" ", 109, cls, 110, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 126, "\"", 142, 2);
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue("", 134, cls, 134, 4, false);

#line default
#line hidden
            WriteAttributeValue(" ", 138, "foo", 139, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 174, "\"", 187, 1);
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue("", 184, ch, 184, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 219, "\"", 236, 2);
            WriteAttributeValue("", 229, "foo", 229, 3, true);
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue(" ", 232, ch, 233, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p");
            BeginWriteAttribute("class", " class=\"", 248, "\"", 281, 1);
            WriteAttributeValue("", 256, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
               if(cls != null) { 

#line default
#line hidden
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
                            Write(cls);

#line default
#line hidden
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
                                      }

#line default
#line hidden
                PopWriter();
            }
            ), 256, 25, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <a href=\"~/Foo\" />\r\n    <script");
            BeginWriteAttribute("src", " src=\"", 322, "\"", 373, 1);
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue("", 328, Url.Content("~/Scripts/jquery-1.6.2.min.js"), 328, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
            BeginWriteAttribute("src", " src=\"", 420, "\"", 487, 1);
#line 13 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/ConditionalAttributes.cshtml"
WriteAttributeValue("", 426, Url.Content("~/Scripts/modernizr-2.0.6-development-only.js"), 426, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script src=\"http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.min.js\" type=\"text/javascript\"></script>\r\n");
        }
        #pragma warning restore 1998
    }
}
