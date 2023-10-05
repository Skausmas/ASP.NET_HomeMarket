using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MainHomeApplication.Pages
{
    public class RegistrationModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(string Email, string Password, string phoneNumber, string gender)
        {
            ServiceUser user = new ServiceUser(Email, Password, phoneNumber, gender, "user");
            ServiceUser.users.Add(user);
            return RedirectToPage("Index");
        }
    }
}
