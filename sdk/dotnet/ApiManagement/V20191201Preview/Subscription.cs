// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201Preview
{
    /// <summary>
    /// Subscription details.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/v20191201preview:Subscription")]
    public partial class Subscription : Pulumi.CustomResource
    {
        /// <summary>
        /// Determines whether tracing is enabled
        /// </summary>
        [Output("allowTracing")]
        public Output<bool?> AllowTracing { get; private set; } = null!;

        /// <summary>
        /// Subscription creation date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        [Output("createdDate")]
        public Output<string> CreatedDate { get; private set; } = null!;

        /// <summary>
        /// The name of the subscription, or null if the subscription has no name.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Date when subscription was cancelled or expired. The setting is for audit purposes only and the subscription is not automatically cancelled. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        [Output("endDate")]
        public Output<string?> EndDate { get; private set; } = null!;

        /// <summary>
        /// Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        [Output("expirationDate")]
        public Output<string?> ExpirationDate { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Upcoming subscription expiration notification date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        [Output("notificationDate")]
        public Output<string?> NotificationDate { get; private set; } = null!;

        /// <summary>
        /// The user resource identifier of the subscription owner. The value is a valid relative URL in the format of /users/{userId} where {userId} is a user identifier.
        /// </summary>
        [Output("ownerId")]
        public Output<string?> OwnerId { get; private set; } = null!;

        /// <summary>
        /// Subscription primary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [Output("primaryKey")]
        public Output<string?> PrimaryKey { get; private set; } = null!;

        /// <summary>
        /// Scope like /products/{productId} or /apis or /apis/{apiId}.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;

        /// <summary>
        /// Subscription secondary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [Output("secondaryKey")]
        public Output<string?> SecondaryKey { get; private set; } = null!;

        /// <summary>
        /// Subscription activation date. The setting is for audit purposes only and the subscription is not automatically activated. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        [Output("startDate")]
        public Output<string?> StartDate { get; private set; } = null!;

        /// <summary>
        /// Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Optional subscription comment added by an administrator.
        /// </summary>
        [Output("stateComment")]
        public Output<string?> StateComment { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Subscription resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Subscription(string name, SubscriptionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Subscription", name, args ?? new SubscriptionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Subscription(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Subscription", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20160707:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20161010:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:Subscription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:Subscription"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Subscription resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Subscription Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Subscription(name, id, options);
        }
    }

    public sealed class SubscriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines whether tracing can be enabled
        /// </summary>
        [Input("allowTracing")]
        public Input<bool>? AllowTracing { get; set; }

        /// <summary>
        /// Subscription name.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// Notify change in Subscription State. 
        ///  - If false, do not send any email notification for change of state of subscription 
        ///  - If true, send email notification of change of state of subscription 
        /// </summary>
        [Input("notify")]
        public Input<bool>? Notify { get; set; }

        /// <summary>
        /// User (user id path) for whom subscription is being created in form /users/{userId}
        /// </summary>
        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        /// <summary>
        /// Primary subscription key. If not specified during request key will be generated automatically.
        /// </summary>
        [Input("primaryKey")]
        public Input<string>? PrimaryKey { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Scope like /products/{productId} or /apis or /apis/{apiId}.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// Secondary subscription key. If not specified during request key will be generated automatically.
        /// </summary>
        [Input("secondaryKey")]
        public Input<string>? SecondaryKey { get; set; }

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Subscription entity Identifier. The entity represents the association between a user and a product in API Management.
        /// </summary>
        [Input("sid", required: true)]
        public Input<string> Sid { get; set; } = null!;

        /// <summary>
        /// Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
        /// </summary>
        [Input("state")]
        public Input<Pulumi.AzureNextGen.ApiManagement.V20191201Preview.SubscriptionState>? State { get; set; }

        public SubscriptionArgs()
        {
        }
    }
}
