// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.SignalRService.V20200501.Inputs
{

    /// <summary>
    /// Network ACLs for SignalR
    /// </summary>
    public sealed class SignalRNetworkACLsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Default action when no other rule matches
        /// </summary>
        [Input("defaultAction")]
        public InputUnion<string, Pulumi.AzureNextGen.SignalRService.V20200501.ACLAction>? DefaultAction { get; set; }

        [Input("privateEndpoints")]
        private InputList<Inputs.PrivateEndpointACLArgs>? _privateEndpoints;

        /// <summary>
        /// ACLs for requests from private endpoints
        /// </summary>
        public InputList<Inputs.PrivateEndpointACLArgs> PrivateEndpoints
        {
            get => _privateEndpoints ?? (_privateEndpoints = new InputList<Inputs.PrivateEndpointACLArgs>());
            set => _privateEndpoints = value;
        }

        /// <summary>
        /// ACL for requests from public network
        /// </summary>
        [Input("publicNetwork")]
        public Input<Inputs.NetworkACLArgs>? PublicNetwork { get; set; }

        public SignalRNetworkACLsArgs()
        {
            DefaultAction = "Deny";
        }
    }
}
