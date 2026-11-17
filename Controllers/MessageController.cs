using Microsoft.AspNetCore.Mvc;
using MYAcademy_IdentityEmailProject.Context;

namespace MYAcademy_IdentityEmailProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _context;

        public MessageController(EmailContext context)
        {
            _context = context;
        }

        public IActionResult Inbox()
        {
            var values = _context.Messages.Where(x => x.ReceiverEmail == "").ToList();
            return View(values);
        }
    }
}
