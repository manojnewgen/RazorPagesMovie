using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class AboutModel : PageModel
    {
    // heelo
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }

    //hello ji ha
}
