#pragma checksum "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87af85ba2257a2b7fe4686378606dfe710e2e3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmptyFlow.Pages.Pages_Post), @"mvc.1.0.razor-page", @"/Pages/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Post.cshtml", typeof(EmptyFlow.Pages.Pages_Post), null)]
namespace EmptyFlow.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\_ViewImports.cshtml"
using EmptyFlow;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87af85ba2257a2b7fe4686378606dfe710e2e3fb", @"/Pages/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18e0ba6530b3241ae9c7966b4b289e6976ee6a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Post : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml"
  
    ViewData["Title"] = "Post";

#line default
#line hidden
            BeginContext(81, 78, true);
            WriteLiteral("\r\n<h2>Post</h2>\r\n\r\n\r\n<div class=\"blog-post\">\r\n    <h2 class=\"blog-post-title\">");
            EndContext();
            BeginContext(160, 46, false);
#line 11 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml"
                           Write(Html.DisplayFor(model => model.BlogPost.Title));

#line default
#line hidden
            EndContext();
            BeginContext(206, 38, true);
            WriteLiteral("</h2>\r\n    <p class=\"blog-post-meta\"> ");
            EndContext();
            BeginContext(245, 49, false);
#line 12 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml"
                          Write(Html.DisplayFor(model => model.BlogPost.PostDate));

#line default
#line hidden
            EndContext();
            BeginContext(294, 5, true);
            WriteLiteral(" by  ");
            EndContext();
            BeginContext(300, 47, false);
#line 12 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.BlogPost.Author));

#line default
#line hidden
            EndContext();
            BeginContext(347, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(361, 45, false);
#line 13 "C:\Users\Developer\source\repos\EmptyFlow\EmptyFlow\Pages\Post.cshtml"
  Write(Html.DisplayFor(model => model.BlogPost.Post));

#line default
#line hidden
            EndContext();
            BeginContext(406, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmptyFlow.Pages.PostModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmptyFlow.Pages.PostModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmptyFlow.Pages.PostModel>)PageContext?.ViewData;
        public EmptyFlow.Pages.PostModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
