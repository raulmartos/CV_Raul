using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using CV_Raul.Models;
using CV_Raul.Services;

namespace CV_Raul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Experiencia()
        {
            return View();
        }

        public IActionResult SobreMi()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Estudios()
        {
            return View();
        }

        public IActionResult Cv()
        {
            return View();
        }

        public IActionResult php()
        {
            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.VMartos = new RepositoryOfProjects().GetProjects();
            return View();
        }

        [HttpPost]
        public IActionResult metodoEmail(ClassEmail classEmail)
        {
            email(classEmail);
            return View("contact");
        }

        private void email(ClassEmail classEmail)
        {
            MailMessage mail = new MailMessage();

            mail.To.Add("raulmartos2001@gmail.com");
            mail.From = new MailAddress(classEmail.email);
            mail.Subject = classEmail.asunto;
            mail.Body = classEmail.mensaje;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("raulmartos2001@gmail.com", "raulmartosriveiro10");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}