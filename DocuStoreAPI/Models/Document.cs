using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocuStoreAPI.Models
{
    public class Document
    {
        public int Id { get; set; }
        [Display(Name ="Document Name")]
        public string DocumentName { get; set; }

        [DisplayName("Date Added")]  //Reference to formatting below
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime? DateAdded { get; set; }
    }
}

//Model:

//public class MyViewModel
//{
//    [DisplayName("date of birth")]
//    [DataType(DataType.Date)]
//    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
//    public DateTime? Birth { get; set; }
//}
//Controller:

//public class HomeController : Controller
//{
//    public ActionResult Index()
//    {
//        return View(new MyViewModel
//        {
//            Birth = DateTime.Now
//        });
//    }

//    [HttpPost]
//    public ActionResult Index(MyViewModel model)
//    {
//        return View(model);
//    }
//}
//View:

//@model MyViewModel

//@using(Html.BeginForm())
//{
//    @Html.LabelFor(x => x.Birth)
//    @Html.EditorFor(x => x.Birth)
//    @Html.ValidationMessageFor(x => x.Birth)
//    <button type = "submit" > OK </ button >
//}