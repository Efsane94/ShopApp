using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Extensions;
using ShopApp.WebUI.Identity;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 IEmailSender emailSender,
                                 ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
        }

        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]

        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser() {
                UserName=model.UserName,
                FullName=model.FullName,
                Email=model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                //generate token

                var code =await  _userManager.GenerateEmailConfirmationTokenAsync(user);

                var callbackUrl = Url.Action("ConfirmEmail", "Account",new
                {
                    userId=user.Id,
                    token=code
                });
                //send mail
                await _emailSender.SendEmailAsync(model.Email, "Hesabinizi Tesdiqleyin.", $"Zehmet olmasa,Email Hesabinizi tesdiqlemek ucun linke <a href='http://localhost:53092{callbackUrl}'> daxil olun.</a>");

                TempData.Put("message", new ResultMessage()
                {
                    Title="Hesab Tesdiqi",
                    Message="Email adresinize gelen mesaji tesdiqleyin.",
                    Css="warning"
                });
                return RedirectToAction("Login", "Account");
            }

            ModelState.AddModelError("", "Bilinmeyen bir sehv bas verdi. Yeniden yoxlayin");
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            }) ;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
      
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu email ile daha once hesap olusturulmamis.");
                return View(model);
            }

            if(!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Zehmet olmasa hesabinizi mail ile tesdiqleyin.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user,model.Password,true,false);

            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Email ve ya parol sehvdir.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Redirect("~/");
        }


        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hesab Tesdiqi",
                    Message = "Hesab tesdiqi ucun melumatlariniz yanlisdir.",
                    Css = "danger"
                });
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {

                    //create cart object
                    _cartService.InitializeCart(user.Id.ToString());


                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Hesab Tesdiqi",
                        Message = "Hesabiniz ugurla tesdiqlenmisdir",
                        Css = "success"
                    });
                    return RedirectToAction("Login", "Account");
                }
            }

            TempData.Put("message", new ResultMessage()
            {
                Title = "Hesab Tesdiqi",
                Message = "Hesab tesdiqi ucun melumatlariniz yanlisdir.",
                Css = "danger"
            });
            return View();
        }


        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Email",
                    Message = "Melumatlariniz sehvdir.",
                    Css = "danger"
                });
                return View();
            }

            var user =await  _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Bilinmeyen istifadeci",
                    Message = "Daxil etdiyiniz melumatlara uygun istifadeci tapilmadi.",
                    Css = "danger"
                });
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("ResetPassword", "Account", new
            {
                token = code
            });
            //send mail
            await _emailSender.SendEmailAsync(Email, "Reset Password.", $"Zehmet olmasa,Parolunuzu yenilemek ucun linke <a href='http://localhost:53092{callbackUrl}'> daxil olun.</a>");

            TempData.Put("message", new ResultMessage()
            {
                Title = "Parol Deyismek",
                Message = "Parolunuzu yenilemek ucun email hesabiniza mesaj gonderildi.",
                Css = "warning"
            });

            return RedirectToAction("Login", "Account");
        }

        public IActionResult ResetPassword(string token)
        {
            if(token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel() { Token = token };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (!result.Succeeded)
            {
                return View(model);
            }

            return RedirectToAction("Login","Account");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}