#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b69c49213c25805c357c6a3377779510021971f"
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
            __builder.AddMarkupContent(0, "<h1>Thông Tin Bài Báo Khoa Học </h1>\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddContent(7, " ");
                __builder2.AddMarkupContent(8, "<b>Tên bài báo:\t</b>");
                __builder2.AddContent(9, 
#nullable restore
#line 10 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                      Tendetai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, " <br>\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "d-flex justify-content-between");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddContent(17, " ");
                __builder2.AddMarkupContent(18, "<b>Lĩnh vực: </b>");
                __builder2.AddContent(19, 
#nullable restore
#line 14 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                        capdetai

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "<br>\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddContent(22, " ");
                __builder2.AddMarkupContent(23, "<b>Danh mục:</b>");
                __builder2.AddContent(24, 
#nullable restore
#line 15 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                       donvict

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "<br>\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddContent(27, " ");
                __builder2.AddMarkupContent(28, "<b>Tác giả:</b>");
                __builder2.AddContent(29, 
#nullable restore
#line 16 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                      donvith

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "<br>\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddContent(32, " ");
                __builder2.AddMarkupContent(33, "<b>Liên kết:</b>");
                __builder2.AddContent(34, 
#nullable restore
#line 17 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                       loaihinh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "<br>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "cardtapchi");
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                    ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddContent(44, " ");
                    __builder3.AddMarkupContent(45, "<b>Bài báo thuộc tạp chí: </b>");
                    __builder3.AddContent(46, 
#nullable restore
#line 21 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                                         Tendetai

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddContent(49, " ");
                    __builder3.AddMarkupContent(50, "<b> ISSN: </b>");
                    __builder3.AddContent(51, 
#nullable restore
#line 22 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                         donvith

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddContent(54, " ");
                    __builder3.AddMarkupContent(55, "<b> Tạp chí: </b>");
                    __builder3.AddContent(56, 
#nullable restore
#line 23 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                            donvict

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                    ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddContent(59, " ");
                    __builder3.AddMarkupContent(60, "<b>Cơ quan xuất bản:  </b>");
                    __builder3.AddContent(61, 
#nullable restore
#line 24 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                                     xeploai

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n                    ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddContent(64, " ");
                    __builder3.AddMarkupContent(65, "<b> Loại tạp chí: </b>");
                    __builder3.AddContent(66, 
#nullable restore
#line 25 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                                 loaihinh

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddContent(69, " ");
                    __builder3.AddMarkupContent(70, "<b> Cấp tạp chí: </b>");
                    __builder3.AddContent(71, 
#nullable restore
#line 26 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                                phanloaisp

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddContent(74, " ");
                    __builder3.AddMarkupContent(75, "<b>Năm đăng:  </b>");
                    __builder3.AddContent(76, 
#nullable restore
#line 27 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                             nambatdau

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                    ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddContent(79, " ");
                    __builder3.AddMarkupContent(80, "<b> Tập: </b>");
                    __builder3.AddContent(81, 
#nullable restore
#line 28 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                        id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\r\n                    ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddContent(84, " ");
                    __builder3.AddMarkupContent(85, "<b>Số: </b>");
                    __builder3.AddContent(86, 
#nullable restore
#line 29 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageBaiBaoKhoaHoc\DetailBaiBao.razor"
                                      baibaolq

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                    ");
                    __builder3.AddMarkupContent(88, "<div> <b>Trang </b>1243</div>\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
            }
            ));
            __builder.CloseComponent();
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
