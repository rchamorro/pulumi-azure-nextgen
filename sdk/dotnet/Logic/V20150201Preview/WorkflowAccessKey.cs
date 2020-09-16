// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20150201Preview
{
    public partial class WorkflowAccessKey : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets the workflow access key name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the not-after time.
        /// </summary>
        [Output("notAfter")]
        public Output<string?> NotAfter { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the not-before time.
        /// </summary>
        [Output("notBefore")]
        public Output<string?> NotBefore { get; private set; } = null!;

        /// <summary>
        /// Gets the workflow access key type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WorkflowAccessKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WorkflowAccessKey(string name, WorkflowAccessKeyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20150201preview:WorkflowAccessKey", name, args ?? new WorkflowAccessKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WorkflowAccessKey(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20150201preview:WorkflowAccessKey", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing WorkflowAccessKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WorkflowAccessKey Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WorkflowAccessKey(name, id, options);
        }
    }

    public sealed class WorkflowAccessKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The workflow access key name.
        /// </summary>
        [Input("accessKeyName", required: true)]
        public Input<string> AccessKeyName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Gets or sets the not-after time.
        /// </summary>
        [Input("notAfter")]
        public Input<string>? NotAfter { get; set; }

        /// <summary>
        /// Gets or sets the not-before time.
        /// </summary>
        [Input("notBefore")]
        public Input<string>? NotBefore { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The workflow name.
        /// </summary>
        [Input("workflowName", required: true)]
        public Input<string> WorkflowName { get; set; } = null!;

        public WorkflowAccessKeyArgs()
        {
        }
    }
}