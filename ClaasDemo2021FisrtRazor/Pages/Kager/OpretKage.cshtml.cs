using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;
using ClaasDemo2021FisrtRazor.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClaasDemo2021FisrtRazor.Pages.Kager
{
    public class OpretKageModel : PageModel
    {
        private IKageKatalog _kageKatalog;

        [BindProperty]
        public Kage Kage { get; set; }

        public OpretKageModel(IKageKatalog kageKatalog)
        {
            _kageKatalog = kageKatalog;
        }

        public IActionResult OnGet()
        {
            

            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (_kageKatalog.Kager.Count == 0)
            {
                Kage.Id = 1;
            }
            else
            {
                Kage.Id = _kageKatalog.Kager.Max(k => k.Id) + 1;
            }

            _kageKatalog.AddKage(Kage);

            return RedirectToPage("/Index");
        }
    }
}
