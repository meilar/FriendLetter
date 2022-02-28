using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Friend!";}
 
     [Route("/goodbye")]
    public string Goodbye() { return "Goodbye, Friend";}

    [Route("/")]
    public string Letter() {  return "Our virual postcard will go here soon.";}
  }
}