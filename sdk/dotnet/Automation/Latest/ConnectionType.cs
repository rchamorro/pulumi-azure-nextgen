// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.Latest
{
    /// <summary>
    /// Definition of the connection type.
    /// Latest API Version: 2019-06-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:automation/latest:ConnectionType")]
    public partial class ConnectionType : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets the creation time.
        /// </summary>
        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Gets the field definitions of the connection type.
        /// </summary>
        [Output("fieldDefinitions")]
        public Output<ImmutableDictionary<string, Outputs.FieldDefinitionResponse>> FieldDefinitions { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a Boolean value to indicate if the connection type is global.
        /// </summary>
        [Output("isGlobal")]
        public Output<bool?> IsGlobal { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string?> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// Gets the name of the connection type.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ConnectionType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConnectionType(string name, ConnectionTypeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/latest:ConnectionType", name, args ?? new ConnectionTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ConnectionType(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/latest:ConnectionType", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:automation/v20151031:ConnectionType"},
                    new Pulumi.Alias { Type = "azure-nextgen:automation/v20190601:ConnectionType"},
                    new Pulumi.Alias { Type = "azure-nextgen:automation/v20200113preview:ConnectionType"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ConnectionType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConnectionType Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ConnectionType(name, id, options);
        }
    }

    public sealed class ConnectionTypeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The parameters supplied to the create or update connection type operation.
        /// </summary>
        [Input("connectionTypeName", required: true)]
        public Input<string> ConnectionTypeName { get; set; } = null!;

        [Input("fieldDefinitions", required: true)]
        private InputMap<Inputs.FieldDefinitionArgs>? _fieldDefinitions;

        /// <summary>
        /// Gets or sets the field definitions of the connection type.
        /// </summary>
        public InputMap<Inputs.FieldDefinitionArgs> FieldDefinitions
        {
            get => _fieldDefinitions ?? (_fieldDefinitions = new InputMap<Inputs.FieldDefinitionArgs>());
            set => _fieldDefinitions = value;
        }

        /// <summary>
        /// Gets or sets a Boolean value to indicate if the connection type is global.
        /// </summary>
        [Input("isGlobal")]
        public Input<bool>? IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets the name of the connection type.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ConnectionTypeArgs()
        {
        }
    }
}
