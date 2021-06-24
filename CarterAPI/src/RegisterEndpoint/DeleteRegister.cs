using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.RegisterEndpoint
{
    public class DeleteRegister: RouteMetaData
    {
        public override string Tag { get; } = "Registro";
        public override string Description { get; } = "Exclui um registro";

        public override RouteMetaDataResponse[] Responses { get; } = 
        { 
            new RouteMetaDataResponse 
            { 
                Code = 204, 
                Description = "Exclui Pessoa" 
            }
        };

        public override string OperationId { get; } = "Registro_DeleteRegistro";
    }
}