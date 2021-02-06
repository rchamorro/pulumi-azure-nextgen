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
    /// A Trigger data transfer object.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:datashare/v20191101:Trigger")]
    public partial class Trigger : Pulumi.CustomResource
    {
        /// <summary>
        /// Kind of synchronization
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Name of the azure resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Type of the azure resource
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Trigger resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Trigger(string name, TriggerArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:datashare/v20191101:Trigger", name, args ?? new TriggerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Trigger(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:datashare/v20191101:Trigger", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/latest:Trigger"},
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/v20181101preview:Trigger"},
                    new Pulumi.Alias { Type = "azure-nextgen:datashare/v20200901:Trigger"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Trigger resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Trigger Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Trigger(name, id, options);
        }
    }

    public sealed class TriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// Kind of synchronization
        /// </summary>
        [Input("kind", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataShare.V20191101.Kind> Kind { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the share subscription which will hold the data set sink.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public Input<string> ShareSubscriptionName { get; set; } = null!;

        /// <summary>
        /// The name of the trigger.
        /// </summary>
        [Input("triggerName", required: true)]
        public Input<string> TriggerName { get; set; } = null!;

        public TriggerArgs()
        {
        }
    }
}
