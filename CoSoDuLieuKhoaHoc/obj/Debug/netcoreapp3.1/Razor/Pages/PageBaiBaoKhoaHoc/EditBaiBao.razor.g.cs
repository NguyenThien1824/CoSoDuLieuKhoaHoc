#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7ac3e7221925da1e3e7ed7f1dcc27a690a8e73"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
using DataServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditBaiBao")]
    public partial class EditBaiBao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"margin-left:3rem\">Chỉnh Sửa Thông Tin Báo Khoa Học </h1>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "listcardbb");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddContent(8, " ");
                __builder2.AddMarkupContent(9, "<b>Tên bài báo:\t</b>");
                __builder2.AddContent(10, 
#nullable restore
#line 10 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                      Tendetai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, " <br>\r\n\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "d-flex justify-content-between");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "cardttbaibao");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddContent(19, "  ");
                __builder2.AddMarkupContent(20, "<b> Lĩnh vực:</b>");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(21);
                __builder2.AddAttribute(22, "Style", "width:100%");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                  capdetai

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddContent(26, "  ");
                __builder2.AddMarkupContent(27, "<b>Danh mục: </b>");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(28);
                __builder2.AddAttribute(29, "Style", "width:100%");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                  donvict

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddContent(33, "  ");
                __builder2.AddMarkupContent(34, "<b>Tác giả:</b>");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(35);
                __builder2.AddAttribute(36, "Style", "width:100%");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                donvith

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddContent(40, "  ");
                __builder2.AddMarkupContent(41, "<b>Liên kết:</b>");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(42);
                __builder2.AddAttribute(43, "Style", "width:100%");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                 loaihinh

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "cardtapchi");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddMarkupContent(54, "<b>Bài báo thuộc tạp chí:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(55);
                    __builder3.AddAttribute(56, "Style", "width:100%");
                    __builder3.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                                Tendetai

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddContent(60, "   ");
                    __builder3.AddMarkupContent(61, "<b> ISSN:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "Style", "width:100%");
                    __builder3.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                   donvith

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n                    ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddContent(67, "  ");
                    __builder3.AddMarkupContent(68, "<b>Tạp chí:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(69);
                    __builder3.AddAttribute(70, "Style", "width:100%");
                    __builder3.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                    donvict

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddContent(74, " ");
                    __builder3.AddMarkupContent(75, "<b>Cơ quan xuất bản:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(76);
                    __builder3.AddAttribute(77, "Style", "width:100%");
                    __builder3.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                            xeploai

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n                    ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddContent(81, " ");
                    __builder3.AddMarkupContent(82, "<b>Loại tạp chí:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(83);
                    __builder3.AddAttribute(84, "Style", "width:100%");
                    __builder3.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                        loaihinh

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                    ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddMarkupContent(88, "<b>Cấp tạp chí:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(89);
                    __builder3.AddAttribute(90, "Style", "width:100%");
                    __builder3.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                      phanloaisp

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n                    ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddContent(94, " ");
                    __builder3.AddMarkupContent(95, "<b>Năm đăng:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(96);
                    __builder3.AddAttribute(97, "Style", "width:100%");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                    nambatdau

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n                    ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddContent(101, " ");
                    __builder3.AddMarkupContent(102, "<b> Tập:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(103);
                    __builder3.AddAttribute(104, "Style", "width:100%");
                    __builder3.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                id.ToString()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\r\n                    ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddContent(108, "  ");
                    __builder3.AddMarkupContent(109, "<b> Số:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(110);
                    __builder3.AddAttribute(111, "Style", "width:100%");
                    __builder3.AddAttribute(112, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
                                                                                baibaolq

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                    ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddContent(115, " ");
                    __builder3.AddMarkupContent(116, "<b> trang:</b>");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(117);
                    __builder3.AddAttribute(118, "Style", "width:100%");
                    __builder3.AddAttribute(119, "Value", "1243");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\EditBaiBao.razor"
       
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
