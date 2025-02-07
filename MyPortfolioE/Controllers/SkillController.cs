using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;
using MyPortfolioE.DAL.Entities;

namespace MyPortfolioE.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        //Sayfa çalıştığında tetiklenicek 
        [HttpGet]
        public IActionResult CreateSkill() 
        {
        return View();
        }
        // butona tıklandığında tetiklenecek
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();  
            return RedirectToAction("SkillList");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = context.Skills.Find(id);
            context.Skills.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = context.Skills.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }

}
