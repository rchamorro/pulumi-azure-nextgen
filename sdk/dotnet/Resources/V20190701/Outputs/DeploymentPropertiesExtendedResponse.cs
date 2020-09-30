// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20190701.Outputs
{

    [OutputType]
    public sealed class DeploymentPropertiesExtendedResponse
    {
        /// <summary>
        /// The correlation ID of the deployment.
        /// </summary>
        public readonly string CorrelationId;
        /// <summary>
        /// The debug setting of the deployment.
        /// </summary>
        public readonly Outputs.DebugSettingResponse? DebugSetting;
        /// <summary>
        /// The list of deployment dependencies.
        /// </summary>
        public readonly ImmutableArray<Outputs.DependencyResponse> Dependencies;
        /// <summary>
        /// The duration of the template deployment.
        /// </summary>
        public readonly string Duration;
        /// <summary>
        /// The deployment mode. Possible values are Incremental and Complete.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The deployment on error behavior.
        /// </summary>
        public readonly Outputs.OnErrorDeploymentExtendedResponse? OnErrorDeployment;
        /// <summary>
        /// Key/value pairs that represent deployment output.
        /// </summary>
        public readonly object? Outputs;
        /// <summary>
        /// Deployment parameters. Use only one of Parameters or ParametersLink.
        /// </summary>
        public readonly object? Parameters;
        /// <summary>
        /// The URI referencing the parameters. Use only one of Parameters or ParametersLink.
        /// </summary>
        public readonly Outputs.ParametersLinkResponse? ParametersLink;
        /// <summary>
        /// The list of resource providers needed for the deployment.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProviderResponse> Providers;
        /// <summary>
        /// The state of the provisioning.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The template content. Use only one of Template or TemplateLink.
        /// </summary>
        public readonly object? Template;
        /// <summary>
        /// The URI referencing the template. Use only one of Template or TemplateLink.
        /// </summary>
        public readonly Outputs.TemplateLinkResponse? TemplateLink;
        /// <summary>
        /// The timestamp of the template deployment.
        /// </summary>
        public readonly string Timestamp;

        [OutputConstructor]
        private DeploymentPropertiesExtendedResponse(
            string correlationId,

            Outputs.DebugSettingResponse? debugSetting,

            ImmutableArray<Outputs.DependencyResponse> dependencies,

            string duration,

            string? mode,

            Outputs.OnErrorDeploymentExtendedResponse? onErrorDeployment,

            object? outputs,

            object? parameters,

            Outputs.ParametersLinkResponse? parametersLink,

            ImmutableArray<Outputs.ProviderResponse> providers,

            string provisioningState,

            object? template,

            Outputs.TemplateLinkResponse? templateLink,

            string timestamp)
        {
            CorrelationId = correlationId;
            DebugSetting = debugSetting;
            Dependencies = dependencies;
            Duration = duration;
            Mode = mode;
            OnErrorDeployment = onErrorDeployment;
            Outputs = outputs;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Providers = providers;
            ProvisioningState = provisioningState;
            Template = template;
            TemplateLink = templateLink;
            Timestamp = timestamp;
        }
    }
}
