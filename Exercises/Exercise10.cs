using Microsoft.AspNetCore.Authorization;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult Profile()
    { return View();}

    [HttpPost]
    [Authorize]
    public ActionResult UpdateDetails()
    { return View();}
}

[Authorize]
public class SaveController : Controller
{
    [HttpPost]
    public ActionResult Profile()
    { return View();}
}

[Authorize]
public class PushController : Controller
{
    [AllowAnonymous]
    [HttpPost]
    public ActionResult Profile()
    { return View();}
}

[Authorize (Role ="Admin")]
public class AdminController : Controller
{
    [AllowAnonymous]
    [HttpPost]
    public ActionResult Profile()
    { return View();}
}