using System.Web;
using System.Web.Mvc;

public class ExampleController : Controller
{
    private readonly string[] allowedUrls = { "/", "/login", "/logout" };

    [HttpGet]
    public void Redirectinsecure(string url)
    {
        Response.Redirect(url);
    }

    [HttpGet]
    public void Redirect(string url)
    {
        if (allowedUrls.Contains(url))
        {
            Response.Redirect(url);
        }
    }
}