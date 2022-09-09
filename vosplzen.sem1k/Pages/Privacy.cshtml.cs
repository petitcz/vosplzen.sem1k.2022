﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vosplzen.sem1k.Pages
{
    public class PrivacyModel : PageModel
    {

        public PrivacyModel()
        {
       
        }

        public void OnGet()
        {
            ViewData["Title"] = "Soukromí";
        }
    }
}
