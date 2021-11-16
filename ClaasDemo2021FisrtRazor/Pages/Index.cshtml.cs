using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClaasDemo2021FisrtRazor.model;
using ClaasDemo2021FisrtRazor.services;

namespace ClaasDemo2021FisrtRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Kage _kage;
        private IKageKatalog _kageKatalog;


        public Kage Kage
        {
            get => _kage;
            set => _kage = value;
        }

        public IKageKatalog KageKatalog
        {
            get => _kageKatalog;
            set => _kageKatalog = value;
        }


        public IndexModel(ILogger<IndexModel> logger, IKageKatalog kageKatalog)
        {
            _logger = logger;
            _kageKatalog = kageKatalog;
        }

        public IActionResult OnGet()
        {
            _kage = new Kage(3, "kaj", 23, KageSlagsType.Flødeskumskage);
            //_kageKatalog = new KageKatalog(); - ikke relevant sættes i konstruktør
            return Page();
        }
    }
}
