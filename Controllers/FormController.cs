// This brings all the MVC features we need to this file
//the word "using" is like import from React
using Microsoft.AspNetCore.Mvc;

// Be sure to use your own project's namespace here! 
//! Must change name to the name of your file!
// namespace YourNamespace.Controllers;   
namespace DojoSurveyCore.Controllers;   

public class FormData
{
    public string YourName {get; set;}
    public string DojoLocation {get; set;}
    public string FavoriteLanguage {get; set;}
    public string CommentOptional {get; set;}
}
public class FormController : Controller   // Remember inheritance?    
{      

    
    //combining my http method and route:
    [HttpGet("")]  
    public ViewResult Index()        
    {      
        //pass data (kinda like an object with key value pairs = key is viewbag value = overwatch )      
        ViewBag.InputForm = "Please complete the form below:";
        return View();
    }    

    [HttpGet("/results/{formData}")]  
        public ViewResult Results (FormData formData)
        {
            ViewBag.FormData = formData;
            // ViewBag.FormData = TempData["FormResults"] as FormData;
            return View();
        }


    [HttpPost("process")]    
    public IActionResult Process(string YourName, string DojoLocation, string FavoriteLanguage, string CommentOptional)
    {

        Console.WriteLine($"Name: {YourName}");
        Console.WriteLine($"Dojo Location: {DojoLocation}");
        Console.WriteLine($"Favorite Language: {FavoriteLanguage}");
        Console.WriteLine($"Comments Here: {CommentOptional}");


        ViewBag.YourName = YourName;
        ViewBag.DojoLocation = DojoLocation;
        ViewBag.FavoriteLanguage = FavoriteLanguage;
        ViewBag.CommentOptional = CommentOptional;

        // Console.WriteLine(formData.YourName);
        // ViewBag.YourName = formData.YourName.ToString();
        // ViewBag.DojoLocation = "Somewhere";
        // ViewBag.FavoriteLanguage = "Language";
        // ViewBag.CommentOptional = "no";

        // ViewBag.YourName = formData.YourName;
        // ViewBag.DojoLocation = formData.DojoLocation;
        // ViewBag.FavoriteLanguage = formData.FavoriteLanguage;
        // ViewBag.CommentOptional = formData.CommentOptional;
        // TempData["FormResults"] = formData;

        return View("Submitted");
        // return RedirectToAction("Submitted",new {formData = formData});
    }
}

