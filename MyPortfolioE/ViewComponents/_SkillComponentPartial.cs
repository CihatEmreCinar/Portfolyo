﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;

namespace MyPortfolioE.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
