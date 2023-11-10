using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class AboutmeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var model = context.AboutMes.FirstOrDefault();
            return View("_Aboutme",model);
        }
    }
}
