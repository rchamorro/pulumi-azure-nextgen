// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20201201
{
    /// <summary>
    /// IP firewall rule
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:synapse/v20201201:IpFirewallRule")]
    public partial class IpFirewallRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
        /// </summary>
        [Output("endIpAddress")]
        public Output<string?> EndIpAddress { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource provisioning state
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv4 format
        /// </summary>
        [Output("startIpAddress")]
        public Output<string?> StartIpAddress { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IpFirewallRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpFirewallRule(string name, IpFirewallRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20201201:IpFirewallRule", name, args ?? new IpFirewallRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IpFirewallRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20201201:IpFirewallRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:synapse/v20190601preview:IpFirewallRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IpFirewallRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpFirewallRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IpFirewallRule(name, id, options);
        }
    }

    public sealed class IpFirewallRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
        /// </summary>
        [Input("endIpAddress")]
        public Input<string>? EndIpAddress { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The IP firewall rule name
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv4 format
        /// </summary>
        [Input("startIpAddress")]
        public Input<string>? StartIpAddress { get; set; }

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public IpFirewallRuleArgs()
        {
        }
    }
}
