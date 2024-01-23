﻿using WX.DVDCentral.BL;
using Microsoft.AspNetCore.Mvc;

namespace WX.DVDCentral.UI.ViewComponents
{
    public class Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(GenreManager.Load().OrderBy(g=>g.Description));
        }
    }
}
