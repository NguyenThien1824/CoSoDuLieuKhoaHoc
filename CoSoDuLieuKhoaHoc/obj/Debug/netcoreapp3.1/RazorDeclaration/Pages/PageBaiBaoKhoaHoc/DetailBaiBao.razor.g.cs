#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b69c49213c25805c357c6a3377779510021971f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CoSoDuLieuKhoaHoc.Pages.PageBaiBaoKhoaHoc
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
#line 2 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
using DataServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetailBaibao/{ID}")]
    public partial class DetailBaiBao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
       
    string madetai = "CS-DT T2018-190-GD-NN";
    string Tendetai = "Nghiên cứu chiến lược đọc hiểu của sinh viên tiếng Anh không chuyên tại Trường Đại học Ngoại ngữ, Đại học Sư Phạm";
    string capdetai = "Đề tài cấp Cơ sở";
    string donvict = "Trường Đại học Ngoại ngữ";
    string donvith = "Khoa Tiếng Anh chuyên ngành";
    string loaihinh = "Cơ bản";
    string linhvuc = "Khoa học giáo dục học nói chung, bao gồm cả đào tạo, sư phạm học, lý luận giáo dục,..";
    string muctieu = "Nghiên cứu này nhằm mục đích tìm hiểu các chiến lược đọc hiểu được sử dụng bởi sinh viên các lớp tiếng Anh không chuyên bậc 2/6 và 3/6 tại trường Đại học Ngoại Ngữ Huế, đồng thời tìm hiểu sự khác nhau trong việc sử dụng các chiến lược này ở hai nhóm người học. Ngoài ra, nghiên cứu còn đưa ra một số khuyến nghị về cách hướng dẫn các chiến lược đọc trong lớp học đọc hiệu quả";
    string noidung = "Nghiên cứu này được thực hiện với hai mục tiêu: tìm hiểu những chiến lược đọc hiểu các tài liệu tiếng Anh được sử dụng thường xuyên bởi các sinh viên tiếng Anh không chuyên và tìm hiểu sự khác nhau, nếu có, trong việc sử dụng các chiến lược này ở hai nhóm sinh viên có năng lực ngoại ngữ khác nhau. Phương pháp nghiên cứu chủ yếu là theo hướng mô tả với việc sử dụng bảng hỏi là công cụ thu thập số liệu chính.";
    string ketqua = "Kết quả nghiên cứu cho thấy rằng: (1) sinh viên có nhận thức siêu nhận thức về quá trình đọc ở một mức độ nào đó và sử dụng các chiến lược đọc khá thường xuyên. Trong số ba loại chiến lược đọc được nghiên cứu trong nghiên cứu này, chiến lược hỗ trợ được người tham gia sử dụng thường xuyên nhất, với tần suất trung bình là tỷ lệ cao tương đối (M = 3,25). Các chiến lược giải quyết vấn đề theo sau về tần suất sử dụng, có tần suất (M = 3,15). Các chiến lược toàn cầu đã được sử dụng ở mức tần số thấp nhất với tổng điểm trung bình là 2,99. (2) Theo quan điểm của ba loại chiến lược đọc, nghiên cứu hiện tại cho thấy không có sự khác biệt có ý nghĩa thống kê trong việc sử dụng các chiến lược đọc hiểu giữa nhóm sinh viên A2 và B1. Từ đó, khuyến nghị cho việc dạy các chiến lược đọc để cải thiện khả năng đọc tiếng Anh của sinh viên đã được đưa ra.";
    string nambatdau = "2020-08-13";
    string namketthuc = "2020-08-13";
    string xeploai = "Tốt";
    string tinhtrang = "Đã hoàn thành";
    string phanloaisp = "Sản phẩm khác";
    string diachiud = "Khoa Tiếng Anh chuyên ngành";
    string baibaolq = "0";
    string kinhphidetai = "";
    string thamgia = "Nguyễn Thị Phương Lan (Chủ nhiệm), Huỳnh Thị Long Hà, Nguyễn Phạm Thanh Vân";
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
