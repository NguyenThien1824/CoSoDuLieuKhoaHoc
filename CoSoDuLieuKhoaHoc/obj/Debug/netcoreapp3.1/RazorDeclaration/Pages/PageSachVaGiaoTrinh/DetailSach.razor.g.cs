#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageSachVaGiaoTrinh\DetailSach.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19eb82838c2131070d4f7fa99673184ee2e07e5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
