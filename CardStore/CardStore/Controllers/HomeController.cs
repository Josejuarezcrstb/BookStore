using CardStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CardStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Simple static Store page
        public IActionResult Store()
        {
            return View();
        }

        // Profile page (registration form)
        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        private string UsersFilePath => Path.Combine(Directory.GetCurrentDirectory(), "App_Data", "users.json");

        private List<User> ReadUsers()
        {
            try
            {
                var dir = Path.GetDirectoryName(UsersFilePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                if (!System.IO.File.Exists(UsersFilePath))
                {
                    return new List<User>();
                }

                var json = System.IO.File.ReadAllText(UsersFilePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<User>();
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            catch
            {
                return new List<User>();
            }
        }

        private void SaveUsers(List<User> users)
        {
            var dir = Path.GetDirectoryName(UsersFilePath);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(UsersFilePath, json);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([FromForm] User model)
        {
            if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
            {
                TempData["RegisterError"] = "Username and password are required.";
                return RedirectToAction("Profile");
            }

            var users = ReadUsers();
            if (users.Any(u => string.Equals(u.Username, model.Username, System.StringComparison.OrdinalIgnoreCase)))
            {
                TempData["RegisterError"] = "Username already exists.";
                return RedirectToAction("Profile");
            }

            users.Add(new User
            {
                Username = model.Username,
                Password = model.Password, // demo only
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            });

            SaveUsers(users);

            // Set a cookie to keep the user logged in
            Response.Cookies.Append("username", model.Username, new Microsoft.AspNetCore.Http.CookieOptions { HttpOnly = false, Expires = System.DateTimeOffset.UtcNow.AddDays(7) });

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([FromForm] string username, [FromForm] string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                TempData["LoginError"] = "Username and password are required.";
                return RedirectToAction("Index");
            }

            var users = ReadUsers();
            var match = users.FirstOrDefault(u => string.Equals(u.Username, username, System.StringComparison.OrdinalIgnoreCase) && u.Password == password);
            if (match == null)
            {
                TempData["LoginError"] = "Invalid username or password.";
                return RedirectToAction("Index");
            }

            Response.Cookies.Append("username", match.Username, new Microsoft.AspNetCore.Http.CookieOptions { HttpOnly = false, Expires = System.DateTimeOffset.UtcNow.AddDays(7) });
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("username");
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
