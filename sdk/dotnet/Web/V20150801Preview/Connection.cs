// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801Preview
{
    /// <summary>
    /// API Connection
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20150801preview:Connection")]
    public partial class Connection : Pulumi.CustomResource
    {
        /// <summary>
        /// expanded connection provider name
        /// </summary>
        [Output("api")]
        public Output<Outputs.ExpandedParentApiEntityResponse?> Api { get; private set; } = null!;

        /// <summary>
        /// Timestamp of last connection change.
        /// </summary>
        [Output("changedTime")]
        public Output<string?> ChangedTime { get; private set; } = null!;

        /// <summary>
        /// Timestamp of the connection creation
        /// </summary>
        [Output("createdTime")]
        public Output<string?> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// Custom login setting values.
        /// </summary>
        [Output("customParameterValues")]
        public Output<ImmutableDictionary<string, Outputs.ParameterCustomLoginSettingValuesResponse>?> CustomParameterValues { get; private set; } = null!;

        /// <summary>
        /// display name
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Time in UTC when the first expiration of OAuth tokens
        /// </summary>
        [Output("firstExpirationTime")]
        public Output<string?> FirstExpirationTime { get; private set; } = null!;

        /// <summary>
        /// List of Keywords that tag the acl
        /// </summary>
        [Output("keywords")]
        public Output<ImmutableArray<string>> Keywords { get; private set; } = null!;

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        [Output("metadata")]
        public Output<object?> Metadata { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Tokens/Claim
        /// </summary>
        [Output("nonSecretParameterValues")]
        public Output<ImmutableDictionary<string, object>?> NonSecretParameterValues { get; private set; } = null!;

        /// <summary>
        /// Tokens/Claim
        /// </summary>
        [Output("parameterValues")]
        public Output<ImmutableDictionary<string, object>?> ParameterValues { get; private set; } = null!;

        /// <summary>
        /// Status of the connection
        /// </summary>
        [Output("statuses")]
        public Output<ImmutableArray<Outputs.ConnectionStatusResponse>> Statuses { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        [Output("tenantId")]
        public Output<string?> TenantId { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Connection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Connection(string name, ConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801preview:Connection", name, args ?? new ConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Connection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801preview:Connection", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:Connection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160601:Connection"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Connection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Connection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Connection(name, id, options);
        }
    }

    public sealed class ConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// expanded connection provider name
        /// </summary>
        [Input("api")]
        public Input<Inputs.ExpandedParentApiEntityArgs>? Api { get; set; }

        /// <summary>
        /// Timestamp of last connection change.
        /// </summary>
        [Input("changedTime")]
        public Input<string>? ChangedTime { get; set; }

        /// <summary>
        /// The connection name.
        /// </summary>
        [Input("connectionName", required: true)]
        public Input<string> ConnectionName { get; set; } = null!;

        /// <summary>
        /// Timestamp of the connection creation
        /// </summary>
        [Input("createdTime")]
        public Input<string>? CreatedTime { get; set; }

        [Input("customParameterValues")]
        private InputMap<Inputs.ParameterCustomLoginSettingValuesArgs>? _customParameterValues;

        /// <summary>
        /// Custom login setting values.
        /// </summary>
        public InputMap<Inputs.ParameterCustomLoginSettingValuesArgs> CustomParameterValues
        {
            get => _customParameterValues ?? (_customParameterValues = new InputMap<Inputs.ParameterCustomLoginSettingValuesArgs>());
            set => _customParameterValues = value;
        }

        /// <summary>
        /// display name
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Time in UTC when the first expiration of OAuth tokens
        /// </summary>
        [Input("firstExpirationTime")]
        public Input<string>? FirstExpirationTime { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("keywords")]
        private InputList<string>? _keywords;

        /// <summary>
        /// List of Keywords that tag the acl
        /// </summary>
        public InputList<string> Keywords
        {
            get => _keywords ?? (_keywords = new InputList<string>());
            set => _keywords = value;
        }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nonSecretParameterValues")]
        private InputMap<object>? _nonSecretParameterValues;

        /// <summary>
        /// Tokens/Claim
        /// </summary>
        public InputMap<object> NonSecretParameterValues
        {
            get => _nonSecretParameterValues ?? (_nonSecretParameterValues = new InputMap<object>());
            set => _nonSecretParameterValues = value;
        }

        [Input("parameterValues")]
        private InputMap<object>? _parameterValues;

        /// <summary>
        /// Tokens/Claim
        /// </summary>
        public InputMap<object> ParameterValues
        {
            get => _parameterValues ?? (_parameterValues = new InputMap<object>());
            set => _parameterValues = value;
        }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("statuses")]
        private InputList<Inputs.ConnectionStatusArgs>? _statuses;

        /// <summary>
        /// Status of the connection
        /// </summary>
        public InputList<Inputs.ConnectionStatusArgs> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<Inputs.ConnectionStatusArgs>());
            set => _statuses = value;
        }

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

        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ConnectionArgs()
        {
        }
    }
}
