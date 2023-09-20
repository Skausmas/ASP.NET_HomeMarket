using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MainHomeApplication;
using Microsoft.AspNetCore.Authorization;

namespace MainHomeApplication.Pages
{
    //[Authorize]
    public class CreateHomeModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost([FromServices] IGetHomeIndex idService, [FromServices] IAddHome addHomeService,[FromServices] IGetHomeImagePath imagePath, string address, string ownerName, IFormFile file) {
            Home home = new Home(idService.Index(), address, ownerName);
            addHomeService.AddHome(home);
            FileStream stream = new FileStream("wwwroot/"+imagePath.GetImagePath(home), FileMode.Create);
            file.CopyTo(stream);
            return RedirectToPage("Index");
        }
    }
}
