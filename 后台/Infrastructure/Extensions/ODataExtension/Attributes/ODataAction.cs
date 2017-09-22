using System;
using System.Net.Http;

namespace ODataExtension.Attributes
{
    public class ODataAction : ODataRequestAttribute
    {
        public ODataAction() { }
        public ODataAction(Type returnType) : base(returnType)
        {
        }
        public override HttpMethod HttpMethod => HttpMethod.Post;
    }
}
