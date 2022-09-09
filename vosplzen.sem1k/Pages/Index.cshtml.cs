using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vosplzen.sem1k.Model;

namespace vosplzen.sem1k.Pages
{
    public class IndexModel : PageModel
    {

        public string PageContent { get; set; }

        [BindProperty]
        public CalculatorData CalculatorData { get; set; }

        public IndexModel()
        {
            CalculatorData = new CalculatorData();
        }

        public void OnGet()
        {

            //throw new Exception("Toto je nejaká chyba");

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            CalculatorData.Vysledek = (int)CalculatorData.Cislo1 * (int)CalculatorData.Cislo2;

            ModelState.Clear();

            return Page();
        }

    }
}
