using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevOpsGitApp_Lab1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("yyy-MMM-dd", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
