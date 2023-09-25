using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MainHomeApplication.Pages
{
    [Authorize(Policy = "AdminAccess")]
    public class AdminPanel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
