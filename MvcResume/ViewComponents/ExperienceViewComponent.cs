using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var model = context.Experiences.ToList();   
            return View("_Experience",model);
        }
    }
}
