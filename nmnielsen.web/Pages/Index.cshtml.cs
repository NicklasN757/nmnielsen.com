using Microsoft.AspNetCore.Mvc.RazorPages;

namespace nmnielsen.web.Pages;

public class IndexModel : PageModel
{
    public string Greeting { get; set; }

    public void OnGet()
    {
        DateTime currentTime = DateTime.Now;
        if (currentTime.Hour >= 5 && currentTime.Hour < 12)
        {
            Greeting = "Good morning";
        }
        else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
        {
            Greeting = "Good afternoon";
        }
        else
        {
            Greeting = "Good evening";
        }
    }
}