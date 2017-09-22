using System;
using System.Net.Http;

namespace ODataExtension.Attributes
{
    public class ODataFunction : ODataRequestAttribute
    {
        public ODataFunction(Type returnType) : base(returnType)
        {
        }
        public override HttpMethod HttpMethod => HttpMethod.Get;
    }
}
