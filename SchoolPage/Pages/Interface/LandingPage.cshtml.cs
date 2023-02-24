using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SchoolPage.Pages.Interface
{
    public class LandingPageModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToPage("InstructorPage");
            }
            return Page();
        }
    }
}
