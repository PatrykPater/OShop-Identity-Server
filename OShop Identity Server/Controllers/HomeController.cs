using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace OShop_Identity_Server.Controllers
{
    [SecurityHeaders]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IIdentityServerInteractionService _interactionService;

        public HomeController(IIdentityServerInteractionService interactionService)
        {
            _interactionService = interactionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> error(string errorId) 
        { 
            var errormessage = await _interactionService.GetErrorContextAsync(errorId);
            return View();
        }
    }
}