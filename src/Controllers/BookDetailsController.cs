using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace src.Controllers
{
    public class BookDetailsController : Controller
    {
        // 
        // GET: /BookDetails/

        public string Index()
        {
            return "Hello, this is the BookDetails index page.";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "<h1>Hello, this is the BookDetails welcome page.</h1>";
        }
    }
}