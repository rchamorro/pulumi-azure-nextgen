// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EdgeOrder.V20201201Preview
{
    /// <summary>
    /// Address Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:edgeorder/v20201201preview:AddressByName")]
    public partial class AddressByName : Pulumi.CustomResource
    {
        /// <summary>
        /// Contact details for the address
        /// </summary>
        [Output("contactDetails")]
        public Output<Outputs.ContactDetailsResponse> ContactDetails { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Shipping details for the address
        /// </summary>
        [Output("shippingAddress")]
        public Output<Outputs.ShippingAddressResponse?> ShippingAddress { get; private set; } = null!;

        /// <summary>
        /// Represents resource creation and update time
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a AddressByName resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AddressByName(string name, AddressByNameArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:edgeorder/v20201201preview:AddressByName", name, args ?? new AddressByNameArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AddressByName(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:edgeorder/v20201201preview:AddressByName", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AddressByName resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AddressByName Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AddressByName(name, id, options);
        }
    }

    public sealed class AddressByNameArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the address Resource within the specified resource group. address names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
        /// </summary>
        [Input("addressName", required: true)]
        public Input<string> AddressName { get; set; } = null!;

        /// <summary>
        /// Contact details for the address
        /// </summary>
        [Input("contactDetails", required: true)]
        public Input<Inputs.ContactDetailsArgs> ContactDetails { get; set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Shipping details for the address
        /// </summary>
        [Input("shippingAddress")]
        public Input<Inputs.ShippingAddressArgs>? ShippingAddress { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public AddressByNameArgs()
        {
        }
    }
}
