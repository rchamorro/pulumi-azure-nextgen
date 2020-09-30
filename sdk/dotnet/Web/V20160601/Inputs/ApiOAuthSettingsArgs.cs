// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20160601.Inputs
{

    /// <summary>
    /// OAuth settings for the connection provider
    /// </summary>
    public sealed class ApiOAuthSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource provider client id
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// Client Secret needed for OAuth
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        [Input("customParameters")]
        private InputMap<Inputs.ApiOAuthSettingsParameterArgs>? _customParameters;

        /// <summary>
        /// OAuth parameters key is the name of parameter
        /// </summary>
        public InputMap<Inputs.ApiOAuthSettingsParameterArgs> CustomParameters
        {
            get => _customParameters ?? (_customParameters = new InputMap<Inputs.ApiOAuthSettingsParameterArgs>());
            set => _customParameters = value;
        }

        /// <summary>
        /// Identity provider
        /// </summary>
        [Input("identityProvider")]
        public Input<string>? IdentityProvider { get; set; }

        /// <summary>
        /// Read only properties for this oauth setting.
        /// </summary>
        [Input("properties")]
        public Input<object>? Properties { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        [Input("redirectUrl")]
        public Input<string>? RedirectUrl { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// OAuth scopes
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public ApiOAuthSettingsArgs()
        {
        }
    }
}
