using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MainHomeApplication;
using Microsoft.AspNetCore.Authorization;

namespace MainHomeApplication.Pages
{
    [Authorize]
    public class CreateHomeModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost([FromServices] IGetHomeIndex idService, [FromServices] IAddHome addHomeService, string address, string ownerName, IFormFile file) {
            addHomeService.AddHome(new Home(idService.Index(),address,ownerName));
            var path = "wwwroot/images";
            Directory.CreateDirectory(path);
            FileStream stream = new FileStream(path + $"/home_{idService.Index()}.jpg", FileMode.Create);
            file.CopyTo(stream);
            return RedirectToPage("Index");
        }
    }
}
