using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.KeyVault.Models;

namespace portfolio.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        // BRIDGE TO (GREETINGS) CONTACT MODEL
        [BindProperty]         public Contact BridgeContact { get; set; }
    }
}
