#pragma checksum "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\EditNKh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae62613cd36f7eaccca10dc7b08bf689bdb2ea72"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CoSoDuLieuKhoaHoc.Pages.PageNhaKhoaHoc
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
#line 2 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\EditNKh.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\EditNKh.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\EditNKh.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editnkh")]
    public partial class EditNKh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\ctt\CoSoDuLieuKhoaHoc\Pages\PageNhaKhoaHoc\EditNKh.razor"
       
    void gioitinh()
    {
       
       
    }
    string hoten = "Nguyễn Minh Tâm";
   
    string diachi = "An Dương Vương";

    string dienthoai = "0378730454";
    string email = "nguyenthien1904@gmail.com";
    string nganh = "Lý luận và phương pháp dạy học môn Sinh học";
    string chuỵennganh = "Lý luận và phương pháp dạy học môn Sinh học";
    string chuyenmon = "Động vật học";
    string linhvuc = "Động vật học";
    string ngoaingu = "Tiếng Anh (C - 0000)";
    int namsinh = 19894;


    // thêm các data mẫu

    public class Order
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardHolder { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Country { get; set; }
        public int StoreId { get; set; }
        public string Warehouse { get; set; }
        public string Region { get; set; }
        public string System { get; set; }
        public int TransId { get; set; }
        public string Register { get; set; }
        public string Clerk { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }


    }

    public class CreditCard
    {
        public int CardId { get; set; }
        public string CardNr { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    Order order = new Order()
    {
        ExpiryDate = DateTime.Parse("10/10/2022"),
        OrderDate = DateTime.Now,
        ShipDate = DateTime.Now
    };

    List<CreditCard> cards = new List<CreditCard>()
{
        new CreditCard() { CardId = 1, CardNr = "5555555555554444" },
        new CreditCard() { CardId = 2, CardNr = "33335464564564563" },
        new CreditCard() { CardId = 3, CardNr = "34534645645645645" },
        new CreditCard() { CardId = 4, CardNr = "3453464565" },
        new CreditCard() { CardId = 5, CardNr = "879879789789" },
        new CreditCard() { CardId = 6, CardNr = "6786554634545" },
        new CreditCard() { CardId = 7, CardNr = "5687687687978987" },
        new CreditCard() { CardId = 8, CardNr = "5675687808945423" }
    };
    List<CreditCard> card1 = new List<CreditCard>()
{
        new CreditCard() { CardId = 1, CardNr = "aaaa" },
        new CreditCard() { CardId = 2, CardNr = "33335464564564563" },
        new CreditCard() { CardId = 3, CardNr = "34534645645645645" },
        new CreditCard() { CardId = 4, CardNr = "3453464565" },
        new CreditCard() { CardId = 5, CardNr = "879879789789" },
        new CreditCard() { CardId = 6, CardNr = "6786554634545" },
        new CreditCard() { CardId = 7, CardNr = "5687687687978987" },
        new CreditCard() { CardId = 8, CardNr = "5675687808945423" }
    };

    List<Country> countries = new List<Country>()
{
        new Country() { Id = 1, Name = "USA" },
        new Country() { Id = 2, Name = "Germany" }
    };
    public class Test
    {
        public int id { get; set; }
        public int ithamso1 { get; set; }
        public int ithamso2 { get; set; }
        public string sthamso1 { get; set; }
        public string sthamso2 { get; set; }
        public string sthamso3 { get; set; }
        public string sthamso4 { get; set; }
        public string sthamso5 { get; set; }
        public string sthamso6 { get; set; }
        public float fthamso2 { get; set; }
        public DateTime dtthamso1 { get; set; }
        public string img { get; set; }
    }
    public List<Test> testss = new List<Test>()
{
        new Test() { id = 1, ithamso1 = 12,ithamso2=232 ,sthamso1="Từ : 01/11/2008 Đến : 01/02/2009" ,sthamso2="Tổ Động vật - Khoa Sinh học - TRƯỜNG ĐẠI HỌC SƯ PHẠM" ,sthamso3="Giảng viên hợp đồng tạo nguồn Khoa Sinh, Trường Đại học Sư phạm Huế" ,
             sthamso4="THIS IS THE PAGE" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/0.jpg"},
          new Test() { id = 2, ithamso1 = 12,ithamso2=232 ,sthamso1="Từ : 01/03/2009 Đến : 01/02/2010" ,sthamso2="Tổ Động vật - Khoa Sinh học - TRƯỜNG ĐẠI HỌC SƯ PHẠM" ,sthamso3="Giảng viên hợp đồng tạo nguồn Khoa Sinh, Trường Đại học Sư phạm Huế" ,
             sthamso4="THIS IS THE PAGE" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/avt.png"},
              new Test() { id = 3, ithamso1 = 12,ithamso2=232 ,sthamso1="Từ : 01/03/2009 Đến : 01/02/2010" ,sthamso2="Tổ Động vật - Khoa Sinh học - TRƯỜNG ĐẠI HỌC SƯ PHẠM" ,sthamso3="Giảng viên hợp đồng tạo nguồn Khoa Sinh, Trường Đại học Sư phạm Huế" ,
             sthamso4="THIS IS THE PAGE" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/avt.png"}
          };
    public List<Test> testsss = new List<Test>()
{
         new Test() { id = 1, ithamso1 = 12,ithamso2=232 ,sthamso1="Thạc sĩ" ,sthamso2="Trường Đại học Sư phạm- Đại học Huế" ,sthamso3="	Sư phạm Sinh học" ,
             sthamso4="2011" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/avt.png"},
            new Test() { id = 1, ithamso1 = 12,ithamso2=232 ,sthamso1="Thạc sĩ" ,sthamso2="Trường Đại học Sư phạm- TPHCM" ,sthamso3="	Sư phạm Toán" ,
             sthamso4="2018" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/avt.png"}
    };

    public List<Test> tests = new List<Test>()
{
         new Test() { id = 1, ithamso1 = 12,ithamso2=232 ,sthamso1="dfwa" ,sthamso2="Nguyễn Văn A" ,sthamso3="You are our laptop ." ,
             sthamso4="THIS IS THE PAGE" ,sthamso5="trang chiếu" ,sthamso6="aaaa",fthamso2= 55,dtthamso1=DateTime.Parse("10/10/2022"), img= "images/avt.png"},

        new Test() { id = 2, ithamso1 =23 ,ithamso2=124 ,sthamso1="wEFWE" ,sthamso2="Nguyễn Văn b" ,sthamso3="unlimited battary." ,
             sthamso4="The Best Android Emulator " ,sthamso5="phim 3d" ,sthamso6="bbb",fthamso2=4564 ,dtthamso1= DateTime.Parse("10/10/2022"),img= "images/a1.jpg"},

        new Test() { id = 3, ithamso1 =34 ,ithamso2=34 ,sthamso1="WEFERAG" ,sthamso2="Nguyễn Văn c" ,sthamso3="reeted battary." ,
             sthamso4="videos about how to use this powerful" ,sthamso5="phim hoạt hình" ,sthamso6="",fthamso2=45756 ,dtthamso1= DateTime.Parse("10/10/2022") ,img= "images/avt.png"},
         new Test() { id = 4, ithamso1 =45 ,ithamso2=234 ,sthamso1="ERG.KL" ,sthamso2="Nguyễn Văn d" ,sthamso3="You are battary." ,
             sthamso4="be able to play all your Android apps " ,sthamso5="phim viễn tưởng" ,sthamso6="ccc",fthamso2= 09453,dtthamso1=DateTime.Parse("10/10/2022") ,img="images/map.png"},

        new Test() { id = 5, ithamso1 = 56,ithamso2=65 ,sthamso1="AERGERG" ,sthamso2="Nguyễn Văn e" ,sthamso3="are finascreen." ,
             sthamso4=" PC with larger screen and unlimited" ,sthamso5="phim kinh dị" ,sthamso6="fff",fthamso2=3453 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/avt.png"},

        new Test() { id = 6, ithamso1 =67 ,ithamso2= 089,sthamso1="C;VHTUI," ,sthamso2="Nguyễn Văn f" ,sthamso3="Yable to plattary." ,
             sthamso4="On this page, you can watch the most popular " ,sthamso5="phim thiếu nhi" ,sthamso6="hhhhh",fthamso2=453 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/logosp.png"},

        new Test() { id = 7, ithamso1 =78 ,ithamso2=215 ,sthamso1="RUMHFTRU" ,sthamso2="Nguyễn Văn g" ,sthamso3="You arbattary." ,
             sthamso4="Millions of Games For You to Enjoy" ,sthamso5="phim doraemon" ,sthamso6="jkkkkkk",fthamso2=5678578 ,dtthamso1=DateTime.Parse("10/10/2022"),img= "images/user.png"},

        new Test() { id = 8, ithamso1 =89 ,ithamso2= 562,sthamso1="TYJTEYJ" ,sthamso2="Nguyễn Văn h" ,sthamso3=" Android aped battary." ,
             sthamso4="Popular Mobile Games on PC" ,sthamso5="phim tiểu thuyết" ,sthamso6="dddf",fthamso2=7678 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/avt.png"},

        new Test() { id = 9, ithamso1 =90 ,ithamso2=124 ,sthamso1="TYJTEFJ6" ,sthamso2="Nguyễn Văn i" ,sthamso3="inally be able toed battary." ,
             sthamso4="Featured Games" ,sthamso5="phim trinh thám" ,sthamso6="kklll",fthamso2=2342 ,dtthamso1= DateTime.Parse("10/10/2022"),img= "images/avt.png"},

        new Test() { id = 10, ithamso1 =100 ,ithamso2=264 ,sthamso1="TYJDFCTJE" ,sthamso2="Nguyễn Văn j" ,sthamso3="Youndroid app unlry." ,
             sthamso4="okokokokoko" ,sthamso5="thế giới khoa học" ,sthamso6="xxxx",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/avt.png"},
          new Test() { id = 11, ithamso1 =100 ,ithamso2=264 ,sthamso1="fwegr" ,sthamso2="Nguyễn Văn ưe" ,sthamso3="ffe app unlry." ,
             sthamso4="okokokokoko" ,sthamso5="thế gưefwefehọc" ,sthamso6="ẻgwef",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2022") ,img= "images/map.png"},
          new Test() { id = 12, ithamso1 =343 ,ithamso2=54645 ,sthamso1="Tham số 1" ,sthamso2="Nguyễn Văn 43rg" ,sthamso3="aaaaaaaaaaaaaaaaaaaaaaaaaaa." ,
             sthamso4="aaaaaaaaaaaaaaaaaaaaaaaaaa" ,sthamso5="thế gưefwefehọc" ,sthamso6="ẻgwef",fthamso2=3633 ,dtthamso1=DateTime.Parse("10/10/2033") ,img= "images/avt.png"}
    };
    public Test t = new Test()
    {
        id = 1,
        ithamso1 = 12,
        ithamso2 = 232,
        sthamso1 = "dfwa",
        sthamso2 = "Nguyễn Văn A",
        sthamso3 = "You are our laptop .",
        sthamso4 = "THIS IS THE PAGE",
        sthamso5 = "trang chiếu",
        sthamso6 = "aaaa",
        fthamso2 = 55,
        dtthamso1 = DateTime.Parse("10/10/2022"),
        img = "images/avt.png"
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
