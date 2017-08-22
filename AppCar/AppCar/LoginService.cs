﻿using AppCar.Models;
using AppCar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCar
{
    public class LoginService
    {
        public async Task FazerLogin(Login login)
        {
            using (var cliente = new HttpClient())
            {
                var camposFormulario = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("email", login.email),
                        new KeyValuePair<string, string>("senha", login.senha)
                    });

                cliente.BaseAddress = new Uri("https://aluracar.herokuapp.com");
                var resultado = await cliente.PostAsync("/login", camposFormulario);

                if (resultado.IsSuccessStatusCode)
                    MessagingCenter.Send<Usuario>(new Usuario(), "SucessoLogin");
                else
                    MessagingCenter.Send<LoginException>(new LoginException("Usuário ou senha incorretos."), "FalhaLogin");

            }

        }

    }

    class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }

    }
}
