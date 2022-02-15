using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dz1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DateTime _date;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string GetToday()
        {
            return _date.DayOfYear.ToString(); 
        }

        public char RandomChar()
        {
            Random a = new Random();
            int b = a.Next(0, 2);
            if (b == 0)
            {
                return _ = (char)a.Next('\u0041', '\u005A');
            }
            else
            {
                return _ = (char)a.Next('\u0061', '\u007A');
            }
        }

        public void OnGet()
        {

        }
    }
}
