using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var skill = context.Skills.ToList();
            return View("_Skill", skill);
        }
    }
}
