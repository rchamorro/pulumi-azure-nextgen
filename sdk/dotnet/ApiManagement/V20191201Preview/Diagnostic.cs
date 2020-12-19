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
    /// Diagnostic details.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/v20191201preview:Diagnostic")]
    public partial class Diagnostic : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies for what type of messages sampling settings should not apply.
        /// </summary>
        [Output("alwaysLog")]
        public Output<string?> AlwaysLog { get; private set; } = null!;

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Backend
        /// </summary>
        [Output("backend")]
        public Output<Outputs.PipelineDiagnosticSettingsResponse?> Backend { get; private set; } = null!;

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
        /// </summary>
        [Output("frontend")]
        public Output<Outputs.PipelineDiagnosticSettingsResponse?> Frontend { get; private set; } = null!;

        /// <summary>
        /// Sets correlation protocol to use for Application Insights diagnostics.
        /// </summary>
        [Output("httpCorrelationProtocol")]
        public Output<string?> HttpCorrelationProtocol { get; private set; } = null!;

        /// <summary>
        /// Log the ClientIP. Default is false.
        /// </summary>
        [Output("logClientIp")]
        public Output<bool?> LogClientIp { get; private set; } = null!;

        /// <summary>
        /// Resource Id of a target logger.
        /// </summary>
        [Output("loggerId")]
        public Output<string> LoggerId { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Sampling settings for Diagnostic.
        /// </summary>
        [Output("sampling")]
        public Output<Outputs.SamplingSettingsResponse?> Sampling { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The verbosity level applied to traces emitted by trace policies.
        /// </summary>
        [Output("verbosity")]
        public Output<string?> Verbosity { get; private set; } = null!;


        /// <summary>
        /// Create a Diagnostic resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Diagnostic(string name, DiagnosticArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Diagnostic", name, args ?? new DiagnosticArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Diagnostic(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Diagnostic", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:Diagnostic"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:Diagnostic"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Diagnostic resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Diagnostic Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Diagnostic(name, id, options);
        }
    }

    public sealed class DiagnosticArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies for what type of messages sampling settings should not apply.
        /// </summary>
        [Input("alwaysLog")]
        public InputUnion<string, Pulumi.AzureNextGen.ApiManagement.V20191201Preview.AlwaysLog>? AlwaysLog { get; set; }

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Backend
        /// </summary>
        [Input("backend")]
        public Input<Inputs.PipelineDiagnosticSettingsArgs>? Backend { get; set; }

        /// <summary>
        /// Diagnostic identifier. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("diagnosticId", required: true)]
        public Input<string> DiagnosticId { get; set; } = null!;

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
        /// </summary>
        [Input("frontend")]
        public Input<Inputs.PipelineDiagnosticSettingsArgs>? Frontend { get; set; }

        /// <summary>
        /// Sets correlation protocol to use for Application Insights diagnostics.
        /// </summary>
        [Input("httpCorrelationProtocol")]
        public InputUnion<string, Pulumi.AzureNextGen.ApiManagement.V20191201Preview.HttpCorrelationProtocol>? HttpCorrelationProtocol { get; set; }

        /// <summary>
        /// Log the ClientIP. Default is false.
        /// </summary>
        [Input("logClientIp")]
        public Input<bool>? LogClientIp { get; set; }

        /// <summary>
        /// Resource Id of a target logger.
        /// </summary>
        [Input("loggerId", required: true)]
        public Input<string> LoggerId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Sampling settings for Diagnostic.
        /// </summary>
        [Input("sampling")]
        public Input<Inputs.SamplingSettingsArgs>? Sampling { get; set; }

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// The verbosity level applied to traces emitted by trace policies.
        /// </summary>
        [Input("verbosity")]
        public InputUnion<string, Pulumi.AzureNextGen.ApiManagement.V20191201Preview.Verbosity>? Verbosity { get; set; }

        public DiagnosticArgs()
        {
        }
    }
}
