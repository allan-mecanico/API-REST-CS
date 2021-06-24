using System;
using System.Collections.Generic;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.RegisterEndpoint
{
    public class GetRegister : RouteMetaData
    {
        public override string Tag { get; } = "Register";
        public override string Description { get; } = "Retorna registros";

        public override RouteMetaDataResponse[] Responses { get; } =
        {
            new RouteMetaDataResponse
            {
                Code = 200,
                Description = $"Cadastros !",
                Response = typeof(IEnumerable<Register>)
            }
        };

        public override string OperationId { get; } = "Register_GetRegister";
    }
}