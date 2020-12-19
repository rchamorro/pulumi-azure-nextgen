// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101
{
    /// <summary>
    /// Premier add-on.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20181101:WebAppPremierAddOn")]
    public partial class WebAppPremierAddOn : Pulumi.CustomResource
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Premier add on Marketplace offer.
        /// </summary>
        [Output("marketplaceOffer")]
        public Output<string?> MarketplaceOffer { get; private set; } = null!;

        /// <summary>
        /// Premier add on Marketplace publisher.
        /// </summary>
        [Output("marketplacePublisher")]
        public Output<string?> MarketplacePublisher { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Premier add on Product.
        /// </summary>
        [Output("product")]
        public Output<string?> Product { get; private set; } = null!;

        /// <summary>
        /// Premier add on SKU.
        /// </summary>
        [Output("sku")]
        public Output<string?> Sku { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Premier add on Vendor.
        /// </summary>
        [Output("vendor")]
        public Output<string?> Vendor { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppPremierAddOn resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppPremierAddOn(string name, WebAppPremierAddOnArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:WebAppPremierAddOn", name, args ?? new WebAppPremierAddOnArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppPremierAddOn(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:WebAppPremierAddOn", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppPremierAddOn"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppPremierAddOn"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppPremierAddOn resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppPremierAddOn Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppPremierAddOn(name, id, options);
        }
    }

    public sealed class WebAppPremierAddOnArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Premier add on Marketplace offer.
        /// </summary>
        [Input("marketplaceOffer")]
        public Input<string>? MarketplaceOffer { get; set; }

        /// <summary>
        /// Premier add on Marketplace publisher.
        /// </summary>
        [Input("marketplacePublisher")]
        public Input<string>? MarketplacePublisher { get; set; }

        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Add-on name.
        /// </summary>
        [Input("premierAddOnName", required: true)]
        public Input<string> PremierAddOnName { get; set; } = null!;

        /// <summary>
        /// Premier add on Product.
        /// </summary>
        [Input("product")]
        public Input<string>? Product { get; set; }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Premier add on SKU.
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

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

        /// <summary>
        /// Premier add on Vendor.
        /// </summary>
        [Input("vendor")]
        public Input<string>? Vendor { get; set; }

        public WebAppPremierAddOnArgs()
        {
        }
    }
}
