/*
 * FINBOURNE Luminesce Web API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace Finbourne.Luminesce.Sdk.Client.Auth
{
    /// <summary>
    /// Available flows for OAuth2 authentication
    /// </summary>
    public enum OAuthFlow
    {
        /// <summary>Authorization code flow</summary>
        ACCESS_CODE,
        /// <summary>Implicit flow</summary>
        IMPLICIT,
        /// <summary>Password flow</summary>
        PASSWORD,
        /// <summary>Client credentials flow</summary>
        APPLICATION
    }
}