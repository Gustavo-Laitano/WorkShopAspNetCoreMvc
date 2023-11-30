using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            ViewData["Message"] = "Salles Web MVC App From C# Course";
            ViewData["Aluno"] = "Gustavo Laitano Penteado";
        }
    }
}
