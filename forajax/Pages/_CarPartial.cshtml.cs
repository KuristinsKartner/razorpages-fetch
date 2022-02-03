using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace forajax.Pages
{
    public class _CarPartialModel : PageModel
    {
        public string Text { get; set; }
        public void OnGet()
        {

        }
        public PartialViewResult OnGetCar()
        {
            Text = new string("OK");
            return Partial("_CarPartial", Text);
        }
    }
}
