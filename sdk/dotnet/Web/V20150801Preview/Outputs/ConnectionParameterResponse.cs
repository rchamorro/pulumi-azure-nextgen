// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801Preview.Outputs
{

    [OutputType]
    public sealed class ConnectionParameterResponse
    {
        /// <summary>
        /// Default parameter value
        /// </summary>
        public readonly object? DefaultValue;
        /// <summary>
        /// Settings defining OAuth flow for the back end provider
        /// </summary>
        public readonly Outputs.ApiOAuthSettingsResponse? OAuthSettings;
        /// <summary>
        /// Type of the parameter
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// UI definitions
        /// </summary>
        public readonly object? UiDefinition;

        [OutputConstructor]
        private ConnectionParameterResponse(
            object? defaultValue,

            Outputs.ApiOAuthSettingsResponse? oAuthSettings,

            string? type,

            object? uiDefinition)
        {
            DefaultValue = defaultValue;
            OAuthSettings = oAuthSettings;
            Type = type;
            UiDefinition = uiDefinition;
        }
    }
}
