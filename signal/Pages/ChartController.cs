using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace signal.Pages
{
    [ApiController]
    [Route("[controller]")]
    public class ChartController : ControllerBase
    {
        private IHubContext<ChatHub> _hub;

        public ChartController(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }
        [HttpGet]
        public IActionResult Index()
        {
            _hub.Clients.All.SendAsync("showMessage");
            return Ok();
        }
    }
}