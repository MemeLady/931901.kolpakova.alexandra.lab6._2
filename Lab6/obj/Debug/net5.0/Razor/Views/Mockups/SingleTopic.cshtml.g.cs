#pragma checksum "D:\downloads\Web-Forum-master\Lab6\Views\Mockups\SingleTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f491f0e7b26a644278c1c196524785e3ae982fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_SingleTopic), @"mvc.1.0.view", @"/Views/Mockups/SingleTopic.cshtml")]
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
#line 1 "D:\downloads\Web-Forum-master\Lab6\Views\_ViewImports.cshtml"
using YANENAVIZYETYLABY;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\downloads\Web-Forum-master\Lab6\Views\_ViewImports.cshtml"
using YANENAVIZYETYLABY.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f491f0e7b26a644278c1c196524785e3ae982fcb", @"/Views/Mockups/SingleTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145ab17bd8bfa24e23c9a47867bd9a517d44336a", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_SingleTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\downloads\Web-Forum-master\Lab6\Views\Mockups\SingleTopic.cshtml"
   ViewBag.Title = "Topic"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>First topic</h2>\n");
#nullable restore
#line 4 "D:\downloads\Web-Forum-master\Lab6\Views\Mockups\SingleTopic.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    <a href=\"#\">Reply</a>\n    | <a href=\"#\">Edit</a>\n    | <a href=\"#\">Delete</a>\n    | <a href=\"#\">Back to Forum 1</a>\n</p>");
#nullable restore
#line 11 "D:\downloads\Web-Forum-master\Lab6\Views\Mockups\SingleTopic.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div>
            admin@example.com, Monday, June 12, 2020 3:42:50 PM (edited Monday, June 12, 2020 3:43:15 PM)
            | <a href=""#"">Edit</a>
            | <a href=""#"">Delete</a>
            | <a href=""#"">Attach</a>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""forum-message-text"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus porta bibendum ante et lacinia. Sed diam massa, pulvinar sit amet commodo consectetur, tempus consequat diam. Aliquam ultrices, massa et pharetra luctus, eros libero egestas ligula, a egestas augue nulla aliquet dui. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec congue tellus ac odio finibus, id sagittis tellus varius. Aliquam eu consequat nunc. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Orci varius natoque penatibus et magnis dis parturient montes, nas");
            WriteLiteral(@"cetur ridiculus mus. Cras aliquet aliquet libero, vel faucibus mauris tincidunt id. Nullam aliquam ultricies mi. Etiam nulla nunc, pharetra a orci ultricies, varius pharetra est. Nullam quis risus tortor. Nullam lobortis scelerisque lorem, quis finibus quam venenatis ut.

            Nunc fermentum gravida ligula, non condimentum nibh luctus quis. Suspendisse potenti. Sed aliquam, odio eu dapibus molestie, nisl ipsum eleifend augue, at feugiat velit eros vitae libero. Aliquam erat volutpat. Cras euismod at metus in faucibus. Donec iaculis ac justo id rhoncus. Fusce dapibus, ligula sit amet malesuada tincidunt, nulla lorem porta arcu, rutrum rutrum turpis arcu sed urna. Aliquam in mauris condimentum, tristique odio a, viverra ipsum. Cras non odio tellus. Etiam id cursus nunc. Fusce suscipit ac quam nec malesuada. Aliquam gravida sollicitudin iaculis.
        </div>
        <div class=""row"">
            <div class=""col-sm-6 col-md-4"">
                <div class=""thumbnail"">
                    
                ");
            WriteLiteral(@"    <a href=""https://pbs.twimg.com/media/DGT45FQVwAA6p4Z.jpg"" target=""__blank"">
                        <img src="" https://sun9-38.userapi.com/s/v1/if2/tQNCcwFE0JqbIuaYC2OWs0hJq-phVuN52C4sxGxDSyfKhS_wLa1uLioAs0SqpmhMdiFp5fdrXoNiBbyv93EIIIgQ.jpg?size=1080x1080&quality=96&type=album.jpg"" alt=""Attachment"" />
                    </a>
                </div>
                <div class=""caption"">
                    <p><a href=""#"" class=""btn btn-sm btn-danger"">Delete</a></p>
                </div>
            </div>
            <div class=""col-sm-6 col-md-4"">
                <div class=""thumbnail"">
                    <a href=""https://cs8.pikabu.ru/post_img/2017/02/12/8/1486901558147741239.png"" target=""__blank"">
                        <img src=""https://sun9-74.userapi.com/s/v1/if2/9LfcMW3BWi3zXhWT767PAtJWCl2WzJ-K9uHRb2SPRB3EUUeWA_C-gZN6a4ygeb1NVxunYkZaFysgnDJVnRYY1ceK.jpg?size=712x710&quality=96&type=album.jpg"" alt=""Attachment"" />
                    </a>
                </div>
                <div class=""caption"">");
            WriteLiteral(@"
                    <p><a href=""#"" class=""btn btn-sm btn-danger"">Delete</a></p>
                </div>
            </div>
            <div class=""col-sm-6 col-md-4"">
                <div class=""thumbnail"">
                    <a href=""https://pbs.twimg.com/media/DGT45FPU0AA2MCz.jpg"" target=""__blank"">
                        <img src=""https://sun4-10.userapi.com/s/v1/if2/ETd1ae45jTfsaHnE04vEL8YfYlI1xa1Fcqd9gTubA2WF-kGO08_Gtxt81chTCJrKFHbOxb2scU2nd9vfz4TM4rNk.jpg?size=1080x1080&quality=96&type=album.jpg"" alt=""Attachment"" />
                    </a>
                </div>
                <div class=""caption"">
                    <p><a href=""#"" class=""btn btn-sm btn-danger"">Delete</a></p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div>
            admin@example.com, Monday, June 12, 2020 3:42:50 PM (edited Monday, June 12, 2020 3:43:15 PM)
            | <a href=""#"">Edit</a>
            | <a href=""#"">Delete");
            WriteLiteral(@"</a>
            | <a href=""#"">Attach</a>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""forum-message-text"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus porta bibendum ante et lacinia. Sed diam massa, pulvinar sit amet commodo consectetur, tempus consequat diam. Aliquam ultrices, massa et pharetra luctus, eros libero egestas ligula, a egestas augue nulla aliquet dui. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec congue tellus ac odio finibus, id sagittis tellus varius. Aliquam eu consequat nunc. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras aliquet aliquet libero, vel faucibus mauris tincidunt id. Nullam aliquam ultricies mi. Etiam nulla nunc, pharetra a orci ultricies, varius pharetra est. Nullam quis risus tortor. Nullam lobortis scelerisque lorem, quis finibus q");
            WriteLiteral(@"uam venenatis ut.

            Nunc fermentum gravida ligula, non condimentum nibh luctus quis. Suspendisse potenti. Sed aliquam, odio eu dapibus molestie, nisl ipsum eleifend augue, at feugiat velit eros vitae libero. Aliquam erat volutpat. Cras euismod at metus in faucibus. Donec iaculis ac justo id rhoncus. Fusce dapibus, ligula sit amet malesuada tincidunt, nulla lorem porta arcu, rutrum rutrum turpis arcu sed urna. Aliquam in mauris condimentum, tristique odio a, viverra ipsum. Cras non odio tellus. Etiam id cursus nunc. Fusce suscipit ac quam nec malesuada. Aliquam gravida sollicitudin iaculis.
        </div>
    </div>
</div>
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div>
            admin@example.com, Monday, June 12, 2020 3:42:50 PM
            | <a href=""#"">Edit</a>
            | <a href=""#"">Delete</a>
            | <a href=""#"">Attach</a>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""forum-message-text"">
            Lorem ipsum dolor sit ");
            WriteLiteral(@"amet, consectetur adipiscing elit. Vivamus porta bibendum ante et lacinia. Sed diam massa, pulvinar sit amet commodo consectetur, tempus consequat diam. Aliquam ultrices, massa et pharetra luctus, eros libero egestas ligula, a egestas augue nulla aliquet dui. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec congue tellus ac odio finibus, id sagittis tellus varius. Aliquam eu consequat nunc. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras aliquet aliquet libero, vel faucibus mauris tincidunt id. Nullam aliquam ultricies mi. Etiam nulla nunc, pharetra a orci ultricies, varius pharetra est. Nullam quis risus tortor. Nullam lobortis scelerisque lorem, quis finibus quam venenatis ut.

            Nunc fermentum gravida ligula, non condimentum nibh luctus quis. Suspendisse potenti. Sed aliquam, odio eu dapibus molestie, nisl ipsum eleif");
            WriteLiteral(@"end augue, at feugiat velit eros vitae libero. Aliquam erat volutpat. Cras euismod at metus in faucibus. Donec iaculis ac justo id rhoncus. Fusce dapibus, ligula sit amet malesuada tincidunt, nulla lorem porta arcu, rutrum rutrum turpis arcu sed urna. Aliquam in mauris condimentum, tristique odio a, viverra ipsum. Cras non odio tellus. Etiam id cursus nunc. Fusce suscipit ac quam nec malesuada. Aliquam gravida sollicitudin iaculis.
        </div>
    </div>
</div>
<div class=""panel panel-default"">
    <div class=""panel-heading"">
        <div>
            admin@example.com, Monday, June 12, 2020 3:42:50 PM
            | <a href=""#"">Edit</a>
            | <a href=""#"">Delete</a>
            | <a href=""#"">Attach</a>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""forum-message-text"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus porta bibendum ante et lacinia. Sed diam massa, pulvinar sit amet commodo consectetur, tempus consequat diam. Aliquam ultrices, m");
            WriteLiteral(@"assa et pharetra luctus, eros libero egestas ligula, a egestas augue nulla aliquet dui. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec congue tellus ac odio finibus, id sagittis tellus varius. Aliquam eu consequat nunc. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Cras aliquet aliquet libero, vel faucibus mauris tincidunt id. Nullam aliquam ultricies mi. Etiam nulla nunc, pharetra a orci ultricies, varius pharetra est. Nullam quis risus tortor. Nullam lobortis scelerisque lorem, quis finibus quam venenatis ut.

            Nunc fermentum gravida ligula, non condimentum nibh luctus quis. Suspendisse potenti. Sed aliquam, odio eu dapibus molestie, nisl ipsum eleifend augue, at feugiat velit eros vitae libero. Aliquam erat volutpat. Cras euismod at metus in faucibus. Donec iaculis ac justo id rhoncus. Fusce dapibus, ligula sit amet m");
            WriteLiteral(@"alesuada tincidunt, nulla lorem porta arcu, rutrum rutrum turpis arcu sed urna. Aliquam in mauris condimentum, tristique odio a, viverra ipsum. Cras non odio tellus. Etiam id cursus nunc. Fusce suscipit ac quam nec malesuada. Aliquam gravida sollicitudin iaculis.
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
