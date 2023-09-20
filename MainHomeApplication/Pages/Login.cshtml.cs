using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MainHomeApplication.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(string email, string password)
        {
            return RedirectToPage("Index");
        }
    }
}
