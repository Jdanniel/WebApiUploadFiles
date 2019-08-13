//using Swashbuckle.AspNetCore.Swagger;
//using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
namespace WebApiUpload.Operation
{
    public class FileUploadOperation : IOperationFilter
    {
        public void Apply(Swashbuckle.AspNetCore.Swagger.Operation operation, OperationFilterContext context)
        {
            if(operation.OperationId.ToLower() == "postodt")
            {
                operation.Parameters.Clear();
                operation.Parameters.Add(new NonBodyParameter
                {
                    Name = "archivos",
                    In = "formData",
                    Description = "Upload File",
                    Required = true,
                    Type = "file"
                });
                operation.Parameters.Add(new NonBodyParameter
                {
                    Name = "noar",
                    In = "formData",
                    Type = "string",
                    Required = false
                });
                operation.Consumes.Add("multipart/form-data");
            }
        }
    }
}
*/