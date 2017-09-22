using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerExtension.Models
{
    public class ODataRouterEdmModel
    {
        public ODataRouterEdmModel() { }
        public ODataRouterEdmModel(string pre, IEdmModel model)
        {
            this.Key = pre;
            this.EdmModel = model;
        }
        public string Key { get; set; }
        public IEdmModel EdmModel { get; set; }
    }
}
