using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PP1_Grupo1.Pages
{
    public class Musica : PageModel
    {
        private readonly ILogger<Musica> _logger;

        public Musica(ILogger<Musica> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
