﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuthAspApp.Models;
using AuthAspApp.Services.Interfaces;

namespace AuthAspApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService) => _authService = authService;

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            try
            {
                await _authService.SignInAsync(model.Email, model.Password);
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignUp() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            try
            {
                await _authService.SignUpAsync(model.Email, model.UserName, model.Password);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _authService.Logout();

            return RedirectToAction("Index", "Home");
        }
    }
}
