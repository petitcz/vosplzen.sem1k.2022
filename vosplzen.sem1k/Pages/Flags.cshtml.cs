using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using vosplzen.sem1k.Model;

namespace vosplzen.sem1k.Pages
{
    public class FlagsModel : PageModel
    {

        [BindProperty]
        public FlagInput FlagInput { get; set; }

        public void OnGet()
        {
            FlagInput = new FlagInput()
            {   
            };
        
        }

        public IActionResult OnPost()
        {


            if (FlagInput.NatCode.Equals("en"))
            {
                FlagInput.Url = @"https://upload.wikimedia.org/wikipedia/en/thumb/b/be/Flag_of_England.svg/383px-Flag_of_England.svg.png";
            }
            else if (FlagInput.NatCode.Equals("de"))
            {
                FlagInput.Url = @"https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/383px-Flag_of_Germany.svg.png";
            }

            ModelState.Clear();

            return Page();

        }
    }
}
