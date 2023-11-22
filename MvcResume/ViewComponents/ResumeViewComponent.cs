using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class ResumeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View("_Resume");
        }
     
    }
}
