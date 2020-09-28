using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace Identity.OAuth.GenesysCloud
{
    /// <summary>
    /// Defines a set of options used by <see cref="GenesysCloudAuthenticationHandler"/>.
    /// </summary>
    public class GenesysCloudAuthenticationOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenesysCloudAuthenticationOptions"/> class.
        /// </summary>
        public GenesysCloudAuthenticationOptions()
        {
            ClaimsIssuer = GenesysCloudAuthenticationDefaults.Issuer;
            CallbackPath = GenesysCloudAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = GenesysCloudAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = GenesysCloudAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = GenesysCloudAuthenticationDefaults.UserInformationEndpoint;

            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "username");
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "email");

            SaveTokens = true;
        }

        /// <summary>
        /// Gets the list of fields to retrieve from the user information endpoint.
        /// </summary>
        public ISet<string> Fields { get; } = new HashSet<string>
        {
            "email",
            "name",
            "user_id"
        };
        public string RedirectUri { get; set; }
    }
}