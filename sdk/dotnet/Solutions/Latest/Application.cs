// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Solutions.Latest
{
    /// <summary>
    /// Information about managed application.
    /// </summary>
    public partial class Application : Pulumi.CustomResource
    {
        /// <summary>
        /// The fully qualified path of managed application definition Id.
        /// </summary>
        [Output("applicationDefinitionId")]
        public Output<string?> ApplicationDefinitionId { get; private set; } = null!;

        /// <summary>
        /// The collection of managed application artifacts.
        /// </summary>
        [Output("artifacts")]
        public Output<ImmutableArray<Outputs.ApplicationArtifactResponse>> Artifacts { get; private set; } = null!;

        /// <summary>
        /// The  read-only authorizations property that is retrieved from the application package.
        /// </summary>
        [Output("authorizations")]
        public Output<ImmutableArray<Outputs.ApplicationAuthorizationResponse>> Authorizations { get; private set; } = null!;

        /// <summary>
        /// The managed application billing details.
        /// </summary>
        [Output("billingDetails")]
        public Output<Outputs.ApplicationBillingDetailsDefinitionResponse> BillingDetails { get; private set; } = null!;

        /// <summary>
        /// The client entity that created the JIT request.
        /// </summary>
        [Output("createdBy")]
        public Output<Outputs.ApplicationClientDetailsResponse> CreatedBy { get; private set; } = null!;

        /// <summary>
        /// The read-only customer support property that is retrieved from the application package.
        /// </summary>
        [Output("customerSupport")]
        public Output<Outputs.ApplicationPackageContactResponse> CustomerSupport { get; private set; } = null!;

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The managed application Jit access policy.
        /// </summary>
        [Output("jitAccessPolicy")]
        public Output<Outputs.ApplicationJitAccessPolicyResponse?> JitAccessPolicy { get; private set; } = null!;

        /// <summary>
        /// The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// ID of the resource that manages this resource.
        /// </summary>
        [Output("managedBy")]
        public Output<string?> ManagedBy { get; private set; } = null!;

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Output("managedResourceGroupId")]
        public Output<string?> ManagedResourceGroupId { get; private set; } = null!;

        /// <summary>
        /// The managed application management mode.
        /// </summary>
        [Output("managementMode")]
        public Output<string> ManagementMode { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name and value pairs that define the managed application outputs.
        /// </summary>
        [Output("outputs")]
        public Output<object> Outputs { get; private set; } = null!;

        /// <summary>
        /// Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
        /// </summary>
        [Output("parameters")]
        public Output<object?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The plan information.
        /// </summary>
        [Output("plan")]
        public Output<Outputs.PlanResponse?> Plan { get; private set; } = null!;

        /// <summary>
        /// The managed application provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The publisher tenant Id.
        /// </summary>
        [Output("publisherTenantId")]
        public Output<string> PublisherTenantId { get; private set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// The read-only support URLs property that is retrieved from the application package.
        /// </summary>
        [Output("supportUrls")]
        public Output<Outputs.ApplicationPackageSupportUrlsResponse> SupportUrls { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The client entity that last updated the JIT request.
        /// </summary>
        [Output("updatedBy")]
        public Output<Outputs.ApplicationClientDetailsResponse> UpdatedBy { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:solutions/latest:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:solutions/latest:Application", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:solutions/v20170901:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:solutions/v20180601:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:solutions/v20190701:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:solutions/v20200821preview:Application"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Application(name, id, options);
        }
    }

    public sealed class ApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The fully qualified path of managed application definition Id.
        /// </summary>
        [Input("applicationDefinitionId")]
        public Input<string>? ApplicationDefinitionId { get; set; }

        /// <summary>
        /// The name of the managed application.
        /// </summary>
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The managed application Jit access policy.
        /// </summary>
        [Input("jitAccessPolicy")]
        public Input<Inputs.ApplicationJitAccessPolicyArgs>? JitAccessPolicy { get; set; }

        /// <summary>
        /// The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog.
        /// </summary>
        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// ID of the resource that manages this resource.
        /// </summary>
        [Input("managedBy")]
        public Input<string>? ManagedBy { get; set; }

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Input("managedResourceGroupId")]
        public Input<string>? ManagedResourceGroupId { get; set; }

        /// <summary>
        /// Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
        /// </summary>
        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        /// <summary>
        /// The plan information.
        /// </summary>
        [Input("plan")]
        public Input<Inputs.PlanArgs>? Plan { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ApplicationArgs()
        {
        }
    }
}
