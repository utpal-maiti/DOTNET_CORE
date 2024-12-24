using APIConcepts.Services;

using Microsoft.AspNetCore.Mvc;

namespace APIConcepts.Controllers
{
    public class HomeController :ControllerBase
    {
        private readonly IMessageService _messageService; 
        public HomeController(IMessageService messageService) { 
            _messageService = messageService; }
        public string Index() { 
            return _messageService.GetMessage(); 
        }
    }
}
