using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var contactmodel = context.Contacts.FirstOrDefault();    
            return View("_Contact",contactmodel);
        }
    }
}
