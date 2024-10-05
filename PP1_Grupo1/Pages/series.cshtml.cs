using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PP1_Grupo1.Pages
{
    public class Series : PageModel
    {
        private readonly ILogger<Series> _logger;

        public Series(ILogger<Series> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
