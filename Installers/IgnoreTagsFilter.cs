using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Installers
{
    public class IgnoreTagsFilter : IDocumentFilter
    {
        private readonly string[] _ignoredTags = new string[] { "FileConfiguration", "OutputCache" };

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var pathItem in swaggerDoc.Paths.Values)
            {
                var keys = pathItem.Operations.Keys;
                foreach (var operationType in keys)
                {
                    if (pathItem.Operations[operationType].Tags.Select(t => t.Name).Intersect(_ignoredTags).Any())
                    {
                        pathItem.Operations.Remove(operationType);
                    }
                }
            }
        }
    }
}
