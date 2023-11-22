using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var educate = context.Educations.ToList();
            return View("_Education",educate);
        }
    }
}
