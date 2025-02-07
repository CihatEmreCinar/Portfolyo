using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;

namespace MyPortfolioE.ViewComponents.LayoutHeadComponent
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x=>x.Status == false).ToList();
            return View(values);
        }
    }
}
