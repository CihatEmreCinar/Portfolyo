﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioE.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
