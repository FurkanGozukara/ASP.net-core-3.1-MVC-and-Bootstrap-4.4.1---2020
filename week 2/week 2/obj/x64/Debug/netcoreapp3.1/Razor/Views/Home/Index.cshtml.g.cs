#pragma checksum "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c8d7b89f6ae12e17a6f3da549afa1e74f8c84cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 153 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
using week_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8d7b89f6ae12e17a6f3da549afa1e74f8c84cf", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<week_2.Models.Movie>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
  
    Layout = null;
    var vrCustom = "<b>Home Town</b>";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c8d7b89f6ae12e17a6f3da549afa1e74f8c84cf3145", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      Write(Model.srTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c8d7b89f6ae12e17a6f3da549afa1e74f8c84cf4430", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_MenuBar",Model,new ViewDataDictionary(ViewData) { { "index", 75 } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <p>\r\n        The movie <b>");
#nullable restore
#line 16 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                Write(Model.srTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> was\r\n        released\r\n        ");
#nullable restore
#line 18 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
   Write(Model.dtReleaseDate.ToLongDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <p>hello world<br /> my name is ");
#nullable restore
#line 20 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                               Write(Model.srMyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("  2 time is ");
#nullable restore
#line 20 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                                          Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>default encoded : ");
#nullable restore
#line 21 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                    Write(vrCustom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>raw output : ");
#nullable restore
#line 22 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
               Write(Html.Raw(vrCustom));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>raw my name is : ");
#nullable restore
#line 23 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.srMyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        double dblVal1 = 54788 * 5458;
        var myScript = "<script>alert('be alerted')</script>";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p>");
#nullable restore
#line 28 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
  Write(dblVal1.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>default ");
                WriteLiteral("@ behaviour encoded: ");
#nullable restore
#line 29 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                Write(myScript);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 30 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
  Write(Html.Raw(myScript));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>my name is ");
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
              Write("furkan gözükara".ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral(" and my age  is ");
#nullable restore
#line 31 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                                            Write(5 + 5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 32 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        var sum = 32 + 10;
        var greeting = "Hello, world!";
        var text = "";
        for (int i = 0; i < 3; i++)
        {
            text += greeting + " The result is: " + sum + "<br/>";
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h2>CodeBlocks</h2>\r\n    Text: ");
#nullable restore
#line 42 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
     Write(Html.Raw(text));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        var mynumber = 342523431.ToString("N0");

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>\r\n            this is my text\r\n            <b>gg</b>\r\n            inside tag is understood\r\n        </p>\r\n");
#nullable restore
#line 50 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
        // this line commented

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        ");
                WriteLiteral("this is my text <b>gg</b> ");
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        string helloWorldMsg = "Hello, world v2!";
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 58 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
   Write(helloWorldMsg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
     if (DateTime.Now.Year > 2042)
    {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("The year 2042 has finally arrived! ");
                WriteLiteral("\r\n        ");
                WriteLiteral("The year 2042 has finally arrived!\r\n        <span style=\"color:rebeccapurple;\">The year 2042 has finally arrived!</span>\r\n");
#nullable restore
#line 65 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>the current date ");
#nullable restore
#line 68 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral(" is smaller than 2042</div>\r\n        <span>this is span text</span>\r\n        <span>this span text 2</span>\r\n        <div>this is div text</div>\r\n        <span>this span text 3</span>\r\n");
#nullable restore
#line 73 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        List<string> names = new List<string>()
{
            "John Doe",
            "Jane Doe",
            "Joe Doe",
            "Jenna Doe",
            "Doggy Doe"
        };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <ul>\r\n");
#nullable restore
#line 85 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
         for (int i = 0; i < names.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 87 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
           Write(names[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 88 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <ul>\r\n");
#nullable restore
#line 91 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
         foreach (string vrName in names)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 93 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
           Write(vrName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 94 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <ul>\r\n");
#nullable restore
#line 97 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
           int beginIndex = 0;
            while (true)
            {
                if (beginIndex >= names.Count)
                    break;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>");
#nullable restore
#line 102 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
               Write(names[beginIndex]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 103 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                beginIndex++;
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <ul>\r\n");
#nullable restore
#line 108 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
          
            var counter = 0;
            do
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>");
#nullable restore
#line 112 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
               Write(names[counter++]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 113 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
            } while (counter < names.Count);
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n    <ul>\r\n");
#nullable restore
#line 117 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
         for (int i = 0; i < names.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 119 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
           Write(names[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 121 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
             if (i >= 2)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>...and so on</li>\r\n");
#nullable restore
#line 124 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"

                break;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n");
#nullable restore
#line 130 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        string funcReturnProcessedVal(double dbl1, double dbl2)
        {
            return $"<div>{(dbl1 * dbl2).ToString("N0")}</div>";
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 137 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        void funcReturnProcessedVal2(double dbl1, double dbl2)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 141 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
            Write((dbl1 * dbl2).ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 143 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 147 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
Write(Html.Raw(funcReturnProcessedVal(321, 453)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 149 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        funcReturnProcessedVal2(342234, 32141);
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 155 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
      
        Func<dynamic, object> movieTemplate = 

#line default
#line hidden
#nullable disable
                item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
                    PushWriter(__razor_template_writer);
                    WriteLiteral("<div>");
#nullable restore
#line 156 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                               Write(item.srTitle);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" [");
#nullable restore
#line 156 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                                              Write(item.dtReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                    WriteLiteral("]</div>");
                    PopWriter();
                }
                )
#nullable restore
#line 156 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                                                                                                                 ;

List<Movie> movies = new List<Movie>();
movies.Add(new Movie() { srTitle = "The Godfather", dtReleaseDate = new DateTime(1972, 3, 24) });
movies.Add(new Movie() { srTitle = "Forrest Gump", dtReleaseDate = new DateTime(1994, 7, 6) });
movies.Add(new Movie() { srTitle = "Fight Club", dtReleaseDate = new DateTime(1999, 10, 15) });

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 165 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
     foreach (var movie in movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
   Write(movieTemplate(movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\Furkan Gözükara\Desktop\esnek web 2020\week 2\week 2\Views\Home\Index.cshtml"
                             
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<week_2.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
