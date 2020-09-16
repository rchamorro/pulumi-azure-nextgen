// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class EnvelopeEncryptionResponse
    {
        /// <summary>
        /// Representing which tracks should not be encrypted
        /// </summary>
        public readonly ImmutableArray<Outputs.TrackSelectionResponse> ClearTracks;
        /// <summary>
        /// Representing default content key for each encryption scheme and separate content keys for specific tracks
        /// </summary>
        public readonly Outputs.StreamingPolicyContentKeysResponse? ContentKeys;
        /// <summary>
        /// KeyAcquisitionUrlTemplate is used to point to user specified service to delivery content keys
        /// </summary>
        public readonly string? CustomKeyAcquisitionUrlTemplate;
        /// <summary>
        /// Representing supported protocols
        /// </summary>
        public readonly Outputs.EnabledProtocolsResponse? EnabledProtocols;

        [OutputConstructor]
        private EnvelopeEncryptionResponse(
            ImmutableArray<Outputs.TrackSelectionResponse> clearTracks,

            Outputs.StreamingPolicyContentKeysResponse? contentKeys,

            string? customKeyAcquisitionUrlTemplate,

            Outputs.EnabledProtocolsResponse? enabledProtocols)
        {
            ClearTracks = clearTracks;
            ContentKeys = contentKeys;
            CustomKeyAcquisitionUrlTemplate = customKeyAcquisitionUrlTemplate;
            EnabledProtocols = enabledProtocols;
        }
    }
}