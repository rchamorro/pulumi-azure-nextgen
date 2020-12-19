// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NotificationHubs.V20160301
{
    /// <summary>
    /// Description of a NotificationHub Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:notificationhubs/v20160301:NotificationHub")]
    public partial class NotificationHub : Pulumi.CustomResource
    {
        /// <summary>
        /// The AdmCredential of the created NotificationHub
        /// </summary>
        [Output("admCredential")]
        public Output<Outputs.AdmCredentialResponse?> AdmCredential { get; private set; } = null!;

        /// <summary>
        /// The ApnsCredential of the created NotificationHub
        /// </summary>
        [Output("apnsCredential")]
        public Output<Outputs.ApnsCredentialResponse?> ApnsCredential { get; private set; } = null!;

        /// <summary>
        /// The AuthorizationRules of the created NotificationHub
        /// </summary>
        [Output("authorizationRules")]
        public Output<ImmutableArray<Outputs.SharedAccessAuthorizationRulePropertiesResponse>> AuthorizationRules { get; private set; } = null!;

        /// <summary>
        /// The BaiduCredential of the created NotificationHub
        /// </summary>
        [Output("baiduCredential")]
        public Output<Outputs.BaiduCredentialResponse?> BaiduCredential { get; private set; } = null!;

        /// <summary>
        /// The GcmCredential of the created NotificationHub
        /// </summary>
        [Output("gcmCredential")]
        public Output<Outputs.GcmCredentialResponse?> GcmCredential { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The MpnsCredential of the created NotificationHub
        /// </summary>
        [Output("mpnsCredential")]
        public Output<Outputs.MpnsCredentialResponse?> MpnsCredential { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The RegistrationTtl of the created NotificationHub
        /// </summary>
        [Output("registrationTtl")]
        public Output<string?> RegistrationTtl { get; private set; } = null!;

        /// <summary>
        /// The sku of the created namespace
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

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
        /// The WnsCredential of the created NotificationHub
        /// </summary>
        [Output("wnsCredential")]
        public Output<Outputs.WnsCredentialResponse?> WnsCredential { get; private set; } = null!;


        /// <summary>
        /// Create a NotificationHub resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NotificationHub(string name, NotificationHubArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:notificationhubs/v20160301:NotificationHub", name, args ?? new NotificationHubArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NotificationHub(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:notificationhubs/v20160301:NotificationHub", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:notificationhubs/latest:NotificationHub"},
                    new Pulumi.Alias { Type = "azure-nextgen:notificationhubs/v20140901:NotificationHub"},
                    new Pulumi.Alias { Type = "azure-nextgen:notificationhubs/v20170401:NotificationHub"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NotificationHub resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NotificationHub Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NotificationHub(name, id, options);
        }
    }

    public sealed class NotificationHubArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The AdmCredential of the created NotificationHub
        /// </summary>
        [Input("admCredential")]
        public Input<Inputs.AdmCredentialArgs>? AdmCredential { get; set; }

        /// <summary>
        /// The ApnsCredential of the created NotificationHub
        /// </summary>
        [Input("apnsCredential")]
        public Input<Inputs.ApnsCredentialArgs>? ApnsCredential { get; set; }

        [Input("authorizationRules")]
        private InputList<Inputs.SharedAccessAuthorizationRulePropertiesArgs>? _authorizationRules;

        /// <summary>
        /// The AuthorizationRules of the created NotificationHub
        /// </summary>
        public InputList<Inputs.SharedAccessAuthorizationRulePropertiesArgs> AuthorizationRules
        {
            get => _authorizationRules ?? (_authorizationRules = new InputList<Inputs.SharedAccessAuthorizationRulePropertiesArgs>());
            set => _authorizationRules = value;
        }

        /// <summary>
        /// The BaiduCredential of the created NotificationHub
        /// </summary>
        [Input("baiduCredential")]
        public Input<Inputs.BaiduCredentialArgs>? BaiduCredential { get; set; }

        /// <summary>
        /// The GcmCredential of the created NotificationHub
        /// </summary>
        [Input("gcmCredential")]
        public Input<Inputs.GcmCredentialArgs>? GcmCredential { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The MpnsCredential of the created NotificationHub
        /// </summary>
        [Input("mpnsCredential")]
        public Input<Inputs.MpnsCredentialArgs>? MpnsCredential { get; set; }

        /// <summary>
        /// The NotificationHub name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The notification hub name.
        /// </summary>
        [Input("notificationHubName", required: true)]
        public Input<string> NotificationHubName { get; set; } = null!;

        /// <summary>
        /// The RegistrationTtl of the created NotificationHub
        /// </summary>
        [Input("registrationTtl")]
        public Input<string>? RegistrationTtl { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The sku of the created namespace
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

        /// <summary>
        /// The WnsCredential of the created NotificationHub
        /// </summary>
        [Input("wnsCredential")]
        public Input<Inputs.WnsCredentialArgs>? WnsCredential { get; set; }

        public NotificationHubArgs()
        {
        }
    }
}
