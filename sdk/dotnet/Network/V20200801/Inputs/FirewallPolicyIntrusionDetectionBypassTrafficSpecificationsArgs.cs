// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// Intrusion detection bypass traffic specification.
    /// </summary>
    public sealed class FirewallPolicyIntrusionDetectionBypassTrafficSpecificationsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the bypass traffic rule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("destinationAddresses")]
        private InputList<string>? _destinationAddresses;

        /// <summary>
        /// List of destination IP addresses or ranges for this rule.
        /// </summary>
        public InputList<string> DestinationAddresses
        {
            get => _destinationAddresses ?? (_destinationAddresses = new InputList<string>());
            set => _destinationAddresses = value;
        }

        [Input("destinationIpGroups")]
        private InputList<string>? _destinationIpGroups;

        /// <summary>
        /// List of destination IpGroups for this rule.
        /// </summary>
        public InputList<string> DestinationIpGroups
        {
            get => _destinationIpGroups ?? (_destinationIpGroups = new InputList<string>());
            set => _destinationIpGroups = value;
        }

        [Input("destinationPorts")]
        private InputList<string>? _destinationPorts;

        /// <summary>
        /// List of destination ports or ranges.
        /// </summary>
        public InputList<string> DestinationPorts
        {
            get => _destinationPorts ?? (_destinationPorts = new InputList<string>());
            set => _destinationPorts = value;
        }

        /// <summary>
        /// Name of the bypass traffic rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The rule bypass protocol.
        /// </summary>
        [Input("protocol")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20200801.FirewallPolicyIntrusionDetectionProtocol>? Protocol { get; set; }

        [Input("sourceAddresses")]
        private InputList<string>? _sourceAddresses;

        /// <summary>
        /// List of source IP addresses or ranges for this rule.
        /// </summary>
        public InputList<string> SourceAddresses
        {
            get => _sourceAddresses ?? (_sourceAddresses = new InputList<string>());
            set => _sourceAddresses = value;
        }

        [Input("sourceIpGroups")]
        private InputList<string>? _sourceIpGroups;

        /// <summary>
        /// List of source IpGroups for this rule.
        /// </summary>
        public InputList<string> SourceIpGroups
        {
            get => _sourceIpGroups ?? (_sourceIpGroups = new InputList<string>());
            set => _sourceIpGroups = value;
        }

        public FirewallPolicyIntrusionDetectionBypassTrafficSpecificationsArgs()
        {
        }
    }
}
