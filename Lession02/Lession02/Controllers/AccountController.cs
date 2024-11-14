using Lession02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Lession02.Controllers
{
    public class AccountController : Controller
    {
        //định nghĩa url và nam cho action

        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id=1,
                    Name="Test",
                    Email="Leduytien2003yl@gmail.com",
                    Phone="0981705963",
                    Address="Hà nôi",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday=new DateTime(2003,6,2)
                },
                new Account()
                {
                    Id=2,
                    Name="Test",
                    Email="Leduytien2003yl@gmail.com",
                    Phone="0981705963",
                    Address="Hà nôi",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday=new DateTime(2003,6,2)
                },
                new Account()
                {
                    Id=3,
                    Name="Test",
                    Email="Leduytien2003yl@gmail.com",
                    Phone="0981705963",
                    Address="Hà nôi",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday=new DateTime(2003,6,2)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
            {
                Id = 1,
                Name = "tiến",
                Email = "leduytien2003yl@gmail.com",
                Phone = "0981705963",
                Address = "Hà nội",
                Avatar = Url.Content("~/images/Avatar/1.jpg"),
                Gender = 1,
                Bio = "handsome",
                Birthday = new DateTime(2003, 6, 2)
            },
                new Account()
            {
                Id = 1,
                Name = "tiến",
                Email = "leduytien2003yl@gmail.com",
                Phone = "0981705963",
                Address = "Hà nội",
                Avatar = Url.Content("~/images/Avatar/1.jpg"),
                Gender = 1,
                Bio = "handsome",
                Birthday = new DateTime(2003, 6, 2)
            },
                new Account()
            {
                Id = 1,
                Name = "tiến",
                Email = "leduytien2003yl@gmail.com",
                Phone = "0981705963",
                Address = "Hà nội",
                Avatar = Url.Content("~/images/Avatar/1.jpg"),
                Gender = 1,
                Bio = "handsome",
                Birthday = new DateTime(2003, 6, 2)
            },
        };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.account = account;
            return View();
        }
    }
}
