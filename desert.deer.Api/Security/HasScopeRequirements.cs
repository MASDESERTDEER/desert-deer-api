using Microsoft.AspNetCore.Authentication;

namespace desert.deer.Api.Security{
    public class HasScopeRequirements{
        public string Issuer {get;}
        public string Scope {get;}
        public HasScopeRequirements(string scope, string issuer){
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}