using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Identity.OAuth.GenesysCloud
{
    /// <summary>
    /// Extension methods to add GenesysCloud authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class GenesysCloudAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="GenesysCloudAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GenesysCloud authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGenesysCloud([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddGenesysCloud(GenesysCloudAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="GenesysCloudAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GenesysCloud authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the GenesysCloud options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGenesysCloud(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<GenesysCloudAuthenticationOptions> configuration)
        {
            return builder.AddGenesysCloud(GenesysCloudAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="GenesysCloudAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GenesysCloud authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the GenesysCloud options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGenesysCloud(
            [NotNull] this AuthenticationBuilder builder, [NotNull] string scheme,
            [NotNull] Action<GenesysCloudAuthenticationOptions> configuration)
        {
            return builder.AddGenesysCloud(scheme, GenesysCloudAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="GenesysCloudAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables GenesysCloud authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the GenesysCloud options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGenesysCloud(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme, string caption,
            [NotNull] Action<GenesysCloudAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<GenesysCloudAuthenticationOptions, GenesysCloudAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}
