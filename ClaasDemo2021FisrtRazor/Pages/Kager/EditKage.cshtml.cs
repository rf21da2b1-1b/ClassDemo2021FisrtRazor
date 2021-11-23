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
    public class EditKageModel : PageModel
    {
        private IKageKatalog _katalog;

        [BindProperty]
        public Kage Kage { get; set; }


        public EditKageModel(IKageKatalog katalog)
        {
            _katalog = katalog;
        }

        public void OnGet(int id)
        {
            try
            {
                Kage = _katalog.Get(id);
            }
            catch (Exception e)
            {
                // todo passende fejl besked til bruger
            }
        }

        public IActionResult OnPost()
        {
            try
            {
                //Kage.Id = id;
                _katalog.UpdateKage(Kage);
            }
            catch (Exception e)
            {
                // todo passende fejl besked til bruger
                return Page();
            }


            return RedirectToPage("/Index");
        }
    }
}
