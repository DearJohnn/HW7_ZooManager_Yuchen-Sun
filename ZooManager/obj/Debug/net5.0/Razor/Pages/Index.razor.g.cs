#pragma checksum "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c623b7eca27cfc760c0e728e7d9daad3c6adb0db"
// <auto-generated/>
#pragma warning disable 1591
namespace ZooManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\_Imports.razor"
using ZooManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
using ZooManager;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    button {
        width: 75px;
        height: 75px;
        font-size: 50px;
    }

        button.sm {
            display: inline-flex;
            width: 50px;
            height: 50px;
            justify-content: center;
            align-items: center;
            font-size: 30px;
        }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add Zones:</h1></div>\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-1");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddZones(Direction.down)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(12, "<h2>⏬</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-1");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddZones(Direction.right)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(20, "<h2>⏩</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.AddMarkupContent(22, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add Animal to Holding:</h1></div>\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-1");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddAnimalToHolding("cat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(32, "<h2>🐱</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-1");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddAnimalToHolding("mouse")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(40, "<h2>🐭</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-1");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddAnimalToHolding("raptor")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(48, "<h2>🦅</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-1");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                () => Game.AddAnimalToHolding("chick")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(56, "<h2>🐥</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n    ");
            __builder.AddMarkupContent(58, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "row");
            __builder.AddMarkupContent(61, "<div class=\"col-6\"><h1 style=\"text-align:end\">Holding Pen:</h1></div>");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-6");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "disabled");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-outline-dark");
            __builder.OpenElement(68, "h2");
            __builder.AddContent(69, 
#nullable restore
#line 95 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                     Game.holdingPen.emoji

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(70, "sup");
            __builder.AddContent(71, 
#nullable restore
#line 95 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                                Game.holdingPen.rtLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n    ");
            __builder.AddMarkupContent(73, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "align", "center");
#nullable restore
#line 107 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                 for (var y = 0; y < Game.numCellsY; y++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "tr");
#nullable restore
#line 110 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                         for (var x = 0; x < Game.numCellsX; x++)
                        {
                            var a = Game.animalZones[y][x];

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "td");
            __builder.OpenElement(82, "button");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                                    () => Game.ZoneClick(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "type", "button");
            __builder.AddAttribute(85, "class", "btn btn-outline-dark");
            __builder.OpenElement(86, "h2");
            __builder.AddContent(87, 
#nullable restore
#line 116 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                         a.emoji

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(88, "sup");
            __builder.AddContent(89, 
#nullable restore
#line 116 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                                                      a.rtLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 119 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 121 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "D:\6308\C#\Week7\W7_ZooManager_HW\ZooManager\Pages\Index.razor"
       
    protected override void OnInitialized()
    {
        Game.SetUpGame();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
