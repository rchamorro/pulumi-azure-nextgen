// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class WebLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Web linked service properties.
        /// </summary>
        public readonly Union<Outputs.WebAnonymousAuthenticationResponse, Union<Outputs.WebBasicAuthenticationResponse, Outputs.WebClientCertificateAuthenticationResponse>> TypeProperties;

        [OutputConstructor]
        private WebLinkedServiceResponse(
            ImmutableArray<object> annotations,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            string type,

            Union<Outputs.WebAnonymousAuthenticationResponse, Union<Outputs.WebBasicAuthenticationResponse, Outputs.WebClientCertificateAuthenticationResponse>> typeProperties)
        {
            Annotations = annotations;
            ConnectVia = connectVia;
            Description = description;
            Parameters = parameters;
            Type = type;
            TypeProperties = typeProperties;
        }
    }
}
