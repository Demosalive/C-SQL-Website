#pragma checksum "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e6d88ec1dceb33159ca4eab7f2696238a13cab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mission_Mission), @"mvc.1.0.view", @"/Views/Mission/Mission.cshtml")]
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
#line 1 "C:\Users\Curtis\source\repos\Supers\Views\_ViewImports.cshtml"
using Supers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Curtis\source\repos\Supers\Views\_ViewImports.cshtml"
using Supers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e6d88ec1dceb33159ca4eab7f2696238a13cab", @"/Views/Mission/Mission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf5e5e3ec2ca9e9457745e67f91aa81a4928e47", @"/Views/_ViewImports.cshtml")]
    public class Views_Mission_Mission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-bordered shadow table-hover table-info"">
    <tr class=""d-table-row"">
        <th>MissionName</th>
        <th>Difficulty</th>
        <th>DueDate</th>
        <th>Completion Status</th>
        <th>Delete Mission</th>
        
    </tr>
");
#nullable restore
#line 12 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
     foreach (Mission mission in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"d-table-row\">\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
           Write(mission.MissionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
           Write(mission.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
           Write(mission.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 18 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
             if (mission.Completed == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Mission Complete</td>\r\n");
#nullable restore
#line 21 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Mission Incomplete</td>\r\n");
#nullable restore
#line 25 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            <td class=\"btn-outline-warning\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 791, "\"", 837, 2);
            WriteAttributeValue("", 798, "../Mission/DeleteMission?id=", 798, 28, true);
#nullable restore
#line 28 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
WriteAttributeValue("", 826, mission.Id, 826, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete this Mission</a>    ");
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Curtis\source\repos\Supers\Views\Mission\Mission.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"../Mission/AddMission\" class=\"btn-outline-info\">Add a new Mission!</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mission>> Html { get; private set; }
    }
}
#pragma warning restore 1591
