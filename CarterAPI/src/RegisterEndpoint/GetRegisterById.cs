using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.RegisterEndpoint
{
    public class GetRegisterById: RouteMetaData
    {
        public override string Tag { get; } = "Registro";
        public override string Description { get; } = "Obtém registro pelo id";

        public override RouteMetaDataResponse[] Responses { get; } =
        {
            new RouteMetaDataResponse
            {
                Code = 200, 
                Description = $"Um registro",
                Response = typeof(Register)
            },
            new RouteMetaDataResponse
            {
                Code = 404,
                Description = $"Registro não encontrado"
            }
        };

        public override string OperationId { get; } = "Register_GetRegisterById";
    }
}