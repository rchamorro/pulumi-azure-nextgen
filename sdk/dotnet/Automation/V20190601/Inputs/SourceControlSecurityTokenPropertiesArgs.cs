// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20190601.Inputs
{

    public sealed class SourceControlSecurityTokenPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access token.
        /// </summary>
        [Input("accessToken")]
        public Input<string>? AccessToken { get; set; }

        /// <summary>
        /// The refresh token.
        /// </summary>
        [Input("refreshToken")]
        public Input<string>? RefreshToken { get; set; }

        /// <summary>
        /// The token type. Must be either PersonalAccessToken or Oauth.
        /// </summary>
        [Input("tokenType")]
        public InputUnion<string, Pulumi.AzureNextGen.Automation.V20190601.TokenType>? TokenType { get; set; }

        public SourceControlSecurityTokenPropertiesArgs()
        {
        }
    }
}
