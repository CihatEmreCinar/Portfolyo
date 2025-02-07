﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioE.DAL.Context;

namespace MyPortfolioE.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();  

        public IActionResult Inbox()
        {
            var values = context.Messages.ToList(); 

            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead= true;
            context.SaveChanges();


            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = false;
            context.SaveChanges();


            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var values = context.Messages.Find(id);         
            return View(values);
        }

    }
}
