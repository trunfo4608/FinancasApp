using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancasApp.presentation.Models;
using FinancasApp.Data.Entities;
using FinancasApp.Data.Repositories;

namespace FinancasApp.presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {

            if(ModelState.IsValid)
            {
                try
                {
                    var usuarioRepository = new UsuarioRepository();
                    if(usuarioRepository.GetByEmail(model.Email) != null)
                    {
                        TempData["MensagemAlerta"] = "Email informado já está cadastrado para outro usuário.";
                    }
                    else
                    {
                        var usuario = new Usuario
                        {
                            Id = Guid.NewGuid(),
                            Nome = model.Nome,
                            Email = model.Email,
                            Senha = model.Senha,
                            DataHoraCriacao = DateTime.Now

                        };

                        usuarioRepository.Create(usuario);

                        TempData["MensagemSucesso"] = $"Parabéns {usuario.Nome}, sua conta foi criada com sucesso!";
                        ModelState.Clear();
                    }
  
                }
                catch (Exception e)
                {

                    TempData["MensagemErro"] = e.Message;
                }
            }
            else
            {
                TempData["MensagemAlerta"] = "Ocorreram erros de validação no preenchimento do usuário .";
            }


            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
