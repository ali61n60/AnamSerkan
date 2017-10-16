using System;
using System.Collections.Generic;
using System.Linq;
using AnamSerkan.Infrastructure;
using AnamSerkan.Models;
using AnamSerkan.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnamSerkan.Controllers
{
    public class HomeController : Controller
    {
        private MessageDbContext _messageDbContext;
        public HomeController(MessageDbContext messageDbContext)
        {
            _messageDbContext = messageDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["SecurityCode"] = new Random().Next(1000, 9999).ToString();
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Message message, string originalSecurityCode)
        {
            if (originalSecurityCode != message.SecurityCode)
            {
                return Contact();
            }
            //TODOD take the message and save it in database
            MessageRepository messageRepository = new MessageRepository();
            messageRepository.SaveMessage(message);
            Email email=new Email();
            email.SendEmail("info@anamserkan.com", message);
            _messageDbContext.Messages.Add(new Message()
            {
                Name = message.Name,
                Email = message.Email,
                PhoneNumber = message.PhoneNumber,
                Title = message.Title,
                MessageDetail = message.MessageDetail
            });

            _messageDbContext.SaveChanges();

            return View("MessageReceived");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View(ProductRepository.GetAllProducts());
        }

        public IActionResult Equivalent()
        {
            return View();
        }

        [Authorize(Roles = "Admins")]
        public IActionResult ShowMessages()
        {
            IEnumerable<Message> allMessages = MessageRepository.GetAllMessages(_messageDbContext);
            return View(allMessages);
        }
        [Authorize(Roles = "Admins")]
        public IActionResult DeleteMessage(int messageId)
        {
            //remove the message
            Message messageToBeDeleted = _messageDbContext.Messages.FirstOrDefault(message => message.id == messageId);
            _messageDbContext.Messages.Remove(messageToBeDeleted);
            _messageDbContext.SaveChanges();
            return RedirectToAction("ShowMessages");
        }
    }
}
