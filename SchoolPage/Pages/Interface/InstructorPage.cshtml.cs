using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolPage.Pages.DB;
using SchoolPage.Pages.DBClasses;


namespace SchoolPage.Pages.Interface
{


    public class InstructorPageModel : PageModel
    {
        [BindProperty]
        public Instructor AddInstructor { get; set; }
        [BindProperty]
        public Credentials AddCredentials { get; set; }
        

        public void OnGet()
        {

        }

       

        public IActionResult OnPost()
        {
            DBClass.InsertCredentials(AddCredentials);

            DBClass.SchoolDBConnection.Close();



            DBClass.InsertInstructor(AddInstructor);

            DBClass.SchoolDBConnection.Close();

            return Page();



        }

    }
}
