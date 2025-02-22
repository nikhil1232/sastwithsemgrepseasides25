using System.Web.Mvc;

public class HomeController : Controller
{
    [HttpPost]
    public ActionResult Profile()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult UpdateDetails()
    {
        return View();
    }
}

[ValidateAntiForgeryToken]
public class SaveController : Controller
{
    [HttpPost]
    public ActionResult Login()
    {
        return View();
    }
}

[AutoValidateAntiforgeryToken]
public class PushController : Controller
{
    [HttpPost]
    public ActionResult Login()
    {
        return View();
    }
}