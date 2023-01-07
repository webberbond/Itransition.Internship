﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AuthAspApp.Constants;
using AuthAspApp.Models;
using AuthAspApp.Services.Interfaces;

namespace AuthAspApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public HomeController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return User.Identity.IsAuthenticated ? View(_mapper.Map<List<UserViewModel>>(_userService.FindAll().ToList())) : View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessForm(IList<UserViewModel> users, string submit)
        {
            var selected = users.Where(x => x.Selected);

            switch (submit)
            {
                case "Block":
                    await UpdateUsersStatus(selected, UserStatuses.Blocked);
                    break;
                case "Unblock":
                    await UpdateUsersStatus(selected, UserStatuses.Active);
                    break;
                case "Delete":
                    await DeleteUsers(selected);
                    break;
                default:
                    break;
            }

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        private async Task DeleteUsers(IEnumerable<UserViewModel> users)
        {
            foreach (var user in users)
            {
                await _userService.DeleteUser(user.Id.ToString());
            }
        }

        private async Task UpdateUsersStatus(IEnumerable<UserViewModel> users, UserStatuses status)
        {
            foreach (var user in users)
            {
                await _userService.ChangeStatus(user.Id.ToString(), status);
            }
        }
    }
}
