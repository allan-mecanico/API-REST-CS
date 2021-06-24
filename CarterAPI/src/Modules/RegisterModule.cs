using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Carter;
using Carter.ModelBinding;
using Carter.Request;
using Carter.Response;
using CarterAPI.Repositories;
using CarterAPI.Models;
using CarterAPI.OpenApi.RegisterEndpoint;

namespace CarterAPI.Modules
{
    public class RegisterModule : CarterModule
    {
        public readonly RegisterRepository repository;
        public RegisterModule()
        {
            repository = new RegisterRepository();
            Get<GetRegister>("/register/", (req, res) => {
                var registers = repository.GetAll();
                return res.AsJson(registers);
            });
            Get<GetRegisterById>("/register/{id:int}", (req, res) =>
            {
                var id = req.RouteValues.As<int>("id");
                var register = repository.Get(id);
                if(register == null)
                {
                    res.StatusCode = 404;
                    return Task.CompletedTask;
                }
                return res.Negotiate(register);
            });
            Post<PostRegister>("/register/", async (req, res) =>
            {
                var register = await req.Bind<Register>();
               

                repository.Add(register);

                res.StatusCode = 201;
                await res.Negotiate(register);
                return;
            });
            Put<PutRegister>("/register/{id:int}", async (req, res) =>
            {
                var register = await req.Bind<Register>();

                register.Id = req.RouteValues.As<int>("id");

                repository.Edit(register);

                res.StatusCode = 204;
                return;
            });
            Delete<DeleteRegister>("/register/{id:int}", (req, res) =>
            {
                var id = req.RouteValues.As<int>("id");
                repository.Delete(id);
                res.StatusCode = 204;
                return Task.CompletedTask;
            });
        }
    }
}