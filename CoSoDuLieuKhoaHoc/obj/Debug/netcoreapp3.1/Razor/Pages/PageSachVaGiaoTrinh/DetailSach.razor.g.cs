#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19eb82838c2131070d4f7fa99673184ee2e07e5"
// <auto-generated/>
#pragma warning disable 1591
namespace CoSoDuLieuKhoaHoc.Pages.PageSachVaGiaoTrinh
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using CoSoDuLieuKhoaHoc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ctt\CoSoDuLieuKhoaHoc\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
using DataServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailSach/{ID}")]
    public partial class DetailSach : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Thông Tin Sách Giáo Trình </h1>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "h5");
                __builder2.AddContent(8, " ");
                __builder2.AddMarkupContent(9, "<b>Tên sách:\t</b>");
                __builder2.AddContent(10, 
#nullable restore
#line 10 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                              tensach

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, " <br>\r\n\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddContent(15, " ");
                __builder2.AddMarkupContent(16, "<b>ISBN: </b>");
                __builder2.AddContent(17, 
#nullable restore
#line 13 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                    ISBN

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "<br>\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddContent(20, " ");
                __builder2.AddMarkupContent(21, "<b>Loại sách: </b>");
                __builder2.AddContent(22, 
#nullable restore
#line 14 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                         theloai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "<br>\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddContent(25, " ");
                __builder2.AddMarkupContent(26, "<b>Lĩnh vực: </b>");
                __builder2.AddContent(27, 
#nullable restore
#line 15 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                        linhvuc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "<br>\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddContent(30, " ");
                __builder2.AddMarkupContent(31, "<b>Nhà xuất bản: </b>");
                __builder2.AddContent(32, 
#nullable restore
#line 16 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                            tennsb

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "<br>\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddContent(35, " ");
                __builder2.AddMarkupContent(36, "<b>Năm xuất bản: </b>");
                __builder2.AddContent(37, 
#nullable restore
#line 17 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                            namxuatban

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddContent(40, " ");
                __builder2.AddMarkupContent(41, "<b> Tác Giả: </b>");
                __builder2.AddContent(42, 
#nullable restore
#line 18 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                        dstacgia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddContent(45, " ");
                __builder2.AddMarkupContent(46, "<b> File đính kèm: </b>");
                __builder2.AddContent(47, 
#nullable restore
#line 19 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
                                              filedinhkem

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor"
       
    public int sluong = 142;
    string tennsb = "NXB Đại Học Sư Phạm, 2020";
    string theloai = "Sách tham khảo";
    string linhvuc = "Khoa Học Tự Nhiên";
    string dstacgia = "Lê Văn Thăng, Trần Anh Tuấn, Đường Văn Hiếu, Hoàng Công Tín";
    string tensach = "Chiến lược và Chính sách Môi trường";
    string masach = "DTQG NVQG-2019/ĐT.06";
    string ISBN = "978-604-974-612-3";
    DateTime namxuatban = DateTime.Now;
    string filedinhkem = "IMG-6614.JPG";
    int id = 123;
    [Parameter] public int ID { get; set; }

    protected override async Task OnInitializedAsync()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Radzen.DialogService dialogService { get; set; }
    }
}
#pragma warning restore 1591
