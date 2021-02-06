// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataShare.V20191101
{
    /// <summary>
    /// A share subscription data transfer object.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:datashare/v20191101:ShareSubscription")]
    public partial class ShareSubscription : Pulumi.CustomResource
    {
        /// <summary>
        /// Time at which the share subscription was created.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The invitation id.
        /// </summary>
        [Output("invitationId")]
        public Output<string> InvitationId { get; private set; } = null!;

        /// <summary>
        /// Name of the azure resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Email of the provider who created the resource
        /// </summary>
        [Output("providerEmail")]
        public Output<string> ProviderEmail { get; private set; } = null!;

        /// <summary>
        /// Name of the provider who created the resource
        /// </summary>
        [Output("providerName")]
        public Output<string> ProviderName { get; private set; } = null!;

        /// <summary>
        /// Tenant name of the provider who created the resource
        /// </summary>
        [Output("providerTenantName")]
        public Output<string> ProviderTenantName { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the share subscription
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Description of share
        /// </summary>
        [Output("shareDescription")]
        public Output<string> ShareDescription { get; private set; } = null!;

        /// <summary>
        /// Kind of share
        /// </summary>
        [Output("shareKind")]
        public Output<string> ShareKind { get; private set; } = null!;

        /// <summary>
        /// Name of the share
        /// </summary>
        [Output("shareName")]
        public Output<string> ShareName { get; private set; } = null!;

        /// <summary>
        /// Gets the current status of share subscription.
        /// </summary>
        [Output("shareSubscriptionStatus")]
        public Output<string> ShareSubscriptionStatus { get; private set; } = null!;

        /// <summary>
        /// Terms of a share
        /// </summary>
        [Output("shareTerms")]
        public Output<string> ShareTerms { get; private set; } = null!;

        /// <summary>
        /// Source share location.
        /// </summary>
        [Output("sourceShareLocation")]
        public Output<string> SourceShareLocation { get; private set; } = null!;

        /// <summary>
        /// Type of the azure resource
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Email of the user who created the resource
        /// </summary>
        [Output("userEmail")]
        public Output<string> UserEmail { get; private set; } = null!;

        /// <summary>
        /// Name of the user who created the resource
        /// </summary>
        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;


        /// <summary>
        /// Create a ShareSubscription resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ShareSubscription(string name, ShareSubscriptionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:datashare/v20191101:ShareSubscription", name, args ?? new ShareSubscriptionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ShareSubscription(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:datashare/v20191101:ShareSubscription", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/latest:ShareSubscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/v20181101preview:ShareSubscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/v20200901:ShareSubscription"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ShareSubscription resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ShareSubscription Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ShareSubscription(name, id, options);
        }
    }

    public sealed class ShareSubscriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The invitation id.
        /// </summary>
        [Input("invitationId", required: true)]
        public Input<string> InvitationId { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public Input<string> ShareSubscriptionName { get; set; } = null!;

        /// <summary>
        /// Source share location.
        /// </summary>
        [Input("sourceShareLocation", required: true)]
        public Input<string> SourceShareLocation { get; set; } = null!;

        public ShareSubscriptionArgs()
        {
        }
    }
}
