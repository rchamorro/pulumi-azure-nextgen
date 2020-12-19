// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200501
{
    /// <summary>
    /// Virtual Appliance Site resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20200501:VirtualApplianceSite")]
    public partial class VirtualApplianceSite : Pulumi.CustomResource
    {
        /// <summary>
        /// Address Prefix.
        /// </summary>
        [Output("addressPrefix")]
        public Output<string?> AddressPrefix { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Name of the virtual appliance site.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Office 365 Policy.
        /// </summary>
        [Output("o365Policy")]
        public Output<Outputs.Office365PolicyPropertiesResponse?> O365Policy { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Site type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualApplianceSite resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualApplianceSite(string name, VirtualApplianceSiteArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200501:VirtualApplianceSite", name, args ?? new VirtualApplianceSiteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualApplianceSite(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200501:VirtualApplianceSite", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VirtualApplianceSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:VirtualApplianceSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VirtualApplianceSite"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualApplianceSite resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualApplianceSite Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualApplianceSite(name, id, options);
        }
    }

    public sealed class VirtualApplianceSiteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Address Prefix.
        /// </summary>
        [Input("addressPrefix")]
        public Input<string>? AddressPrefix { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the virtual appliance site.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Network Virtual Appliance.
        /// </summary>
        [Input("networkVirtualApplianceName", required: true)]
        public Input<string> NetworkVirtualApplianceName { get; set; } = null!;

        /// <summary>
        /// Office 365 Policy.
        /// </summary>
        [Input("o365Policy")]
        public Input<Inputs.Office365PolicyPropertiesArgs>? O365Policy { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the site.
        /// </summary>
        [Input("siteName", required: true)]
        public Input<string> SiteName { get; set; } = null!;

        public VirtualApplianceSiteArgs()
        {
        }
    }
}
