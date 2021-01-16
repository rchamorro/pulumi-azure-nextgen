// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class ServiceEndpointPolicyDefinitionResponse
    {
        /// <summary>
        /// A description for this rule. Restricted to 140 chars.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The provisioning state of the service endpoint policy definition resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Service endpoint name.
        /// </summary>
        public readonly string? Service;
        /// <summary>
        /// A list of service resources.
        /// </summary>
        public readonly ImmutableArray<string> ServiceResources;

        [OutputConstructor]
        private ServiceEndpointPolicyDefinitionResponse(
            string? description,

            string etag,

            string? id,

            string? name,

            string provisioningState,

            string? service,

            ImmutableArray<string> serviceResources)
        {
            Description = description;
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            Service = service;
            ServiceResources = serviceResources;
        }
    }
}
