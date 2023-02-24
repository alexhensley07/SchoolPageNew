using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolPage.Pages.DB;
using SchoolPage.Pages.DBClasses;

namespace SchoolPage.Pages.Interface
{
    public class InstructorLoginModel : PageModel
    {
        [BindProperty]
        public String? Username { get; set; }

        [BindProperty]
        public String? Password { get; set; }
     
        public void OnGet()
        {
       
        }

        public IActionResult OnPost()
        {
            if (DBClass.SecureLogin(Username, Password) > 0)
            {
                HttpContext.Session.SetString("username", Username);
                ViewData["LoginMessage"] = "Login Successful!";

            }
            else
            {
                ViewData["LoginMessage"] = "Incorrect Username or password";
            }

            DBClass.SchoolDBConnection.Close();
            return RedirectToPage("InstructorFront");

        }
    }
}
