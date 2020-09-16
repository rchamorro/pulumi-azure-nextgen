// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DevTestLab.V20180915
{
    public static class GetEnvironment
    {
        public static Task<GetEnvironmentResult> InvokeAsync(GetEnvironmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentResult>("azure-nextgen:devtestlab/v20180915:getEnvironment", args ?? new GetEnvironmentArgs(), options.WithVersion());
    }


    public sealed class GetEnvironmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specify the $expand query. Example: 'properties($select=deploymentProperties)'
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public string LabName { get; set; } = null!;

        /// <summary>
        /// The name of the environment.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the user profile.
        /// </summary>
        [Input("userName", required: true)]
        public string UserName { get; set; } = null!;

        public GetEnvironmentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEnvironmentResult
    {
        /// <summary>
        /// The display name of the Azure Resource Manager template that produced the environment.
        /// </summary>
        public readonly string? ArmTemplateDisplayName;
        /// <summary>
        /// The creator of the environment.
        /// </summary>
        public readonly string CreatedByUser;
        /// <summary>
        /// The deployment properties of the environment.
        /// </summary>
        public readonly Outputs.EnvironmentDeploymentPropertiesResponse? DeploymentProperties;
        /// <summary>
        /// The location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The identifier of the resource group containing the environment's resources.
        /// </summary>
        public readonly string ResourceGroupId;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The unique immutable identifier of a resource (Guid).
        /// </summary>
        public readonly string UniqueIdentifier;

        [OutputConstructor]
        private GetEnvironmentResult(
            string? armTemplateDisplayName,

            string createdByUser,

            Outputs.EnvironmentDeploymentPropertiesResponse? deploymentProperties,

            string? location,

            string name,

            string provisioningState,

            string resourceGroupId,

            ImmutableDictionary<string, string>? tags,

            string type,

            string uniqueIdentifier)
        {
            ArmTemplateDisplayName = armTemplateDisplayName;
            CreatedByUser = createdByUser;
            DeploymentProperties = deploymentProperties;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceGroupId = resourceGroupId;
            Tags = tags;
            Type = type;
            UniqueIdentifier = uniqueIdentifier;
        }
    }
}