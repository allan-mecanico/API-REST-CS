using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.RegisterEndpoint
{
    public class PutRegister: RouteMetaData
    {
        public override string Tag { get; } = "Register";
        public override string Description { get; } = "Atualiza um registro";
        
        public override RouteMetaDataRequest[] Requests { get; } =
        {
            new RouteMetaDataRequest
            {
                Request = typeof(Register),
            }
        };
        
        public override RouteMetaDataResponse[] Responses { get; } = 
        { 
            new RouteMetaDataResponse 
            { 
                Code = 204, 
                Description = "Registro atualizado" 
            }
        };
        public override string OperationId { get; } = "Register_PutRegister";
    }
}