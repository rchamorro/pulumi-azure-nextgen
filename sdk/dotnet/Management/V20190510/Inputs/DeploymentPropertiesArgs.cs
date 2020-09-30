// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20190510.Inputs
{

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public sealed class DeploymentPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The debug setting of the deployment.
        /// </summary>
        [Input("debugSetting")]
        public Input<Inputs.DebugSettingArgs>? DebugSetting { get; set; }

        /// <summary>
        /// The mode that is used to deploy resources. This value can be either Incremental or Complete. In Incremental mode, resources are deployed without deleting existing resources that are not included in the template. In Complete mode, resources are deployed and existing resources in the resource group that are not included in the template are deleted. Be careful when using Complete mode as you may unintentionally delete resources.
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        /// <summary>
        /// The deployment on error behavior.
        /// </summary>
        [Input("onErrorDeployment")]
        public Input<Inputs.OnErrorDeploymentArgs>? OnErrorDeployment { get; set; }

        /// <summary>
        /// Name and value pairs that define the deployment parameters for the template. You use this element when you want to provide the parameter values directly in the request rather than link to an existing parameter file. Use either the parametersLink property or the parameters property, but not both. It can be a JObject or a well formed JSON string.
        /// </summary>
        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        /// <summary>
        /// The URI of parameters file. You use this element to link to an existing parameters file. Use either the parametersLink property or the parameters property, but not both.
        /// </summary>
        [Input("parametersLink")]
        public Input<Inputs.ParametersLinkArgs>? ParametersLink { get; set; }

        /// <summary>
        /// The template content. You use this element when you want to pass the template syntax directly in the request rather than link to an existing template. It can be a JObject or well-formed JSON string. Use either the templateLink property or the template property, but not both.
        /// </summary>
        [Input("template")]
        public Input<object>? Template { get; set; }

        /// <summary>
        /// The URI of the template. Use either the templateLink property or the template property, but not both.
        /// </summary>
        [Input("templateLink")]
        public Input<Inputs.TemplateLinkArgs>? TemplateLink { get; set; }

        public DeploymentPropertiesArgs()
        {
        }
    }
}
