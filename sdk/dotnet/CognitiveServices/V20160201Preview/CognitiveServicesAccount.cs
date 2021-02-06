// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CognitiveServices.V20160201Preview
{
    /// <summary>
    /// Cognitive Services Account is an Azure resource representing the provisioned account, its type, location and SKU.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:cognitiveservices/v20160201preview:CognitiveServicesAccount")]
    public partial class CognitiveServicesAccount : Pulumi.CustomResource
    {
        /// <summary>
        /// Endpoint of the created account
        /// </summary>
        [Output("endpoint")]
        public Output<string?> Endpoint { get; private set; } = null!;

        /// <summary>
        /// Entity Tag
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Type of cognitive service account.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// The location of the resource
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the created account
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Gets the status of the cognitive services account at the time the operation was called.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The SKU of the cognitive services account.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a CognitiveServicesAccount resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CognitiveServicesAccount(string name, CognitiveServicesAccountArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:cognitiveservices/v20160201preview:CognitiveServicesAccount", name, args ?? new CognitiveServicesAccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CognitiveServicesAccount(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:cognitiveservices/v20160201preview:CognitiveServicesAccount", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:cognitiveservices/latest:CognitiveServicesAccount"},
                    new Pulumi.Alias { Type = "azure-nextgen:cognitiveservices/v20170418:CognitiveServicesAccount"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CognitiveServicesAccount resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CognitiveServicesAccount Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CognitiveServicesAccount(name, id, options);
        }
    }

    public sealed class CognitiveServicesAccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the cognitive services account within the specified resource group. Cognitive Services account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// Required. Indicates the type of cognitive service account.
        /// </summary>
        [Input("kind", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.CognitiveServices.V20160201Preview.Kind> Kind { get; set; } = null!;

        /// <summary>
        /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update the request will succeed.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the cognitive services account.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.SkuArgs> Sku { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public CognitiveServicesAccountArgs()
        {
        }
    }
}
