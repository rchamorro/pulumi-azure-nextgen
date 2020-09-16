// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20190601.Inputs
{

    /// <summary>
    /// Settings properties for Active Directory (AD).
    /// </summary>
    public sealed class ActiveDirectoryPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the security identifier (SID) for Azure Storage.
        /// </summary>
        [Input("azureStorageSid", required: true)]
        public Input<string> AzureStorageSid { get; set; } = null!;

        /// <summary>
        /// Specifies the domain GUID.
        /// </summary>
        [Input("domainGuid", required: true)]
        public Input<string> DomainGuid { get; set; } = null!;

        /// <summary>
        /// Specifies the primary domain that the AD DNS server is authoritative for.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// Specifies the security identifier (SID).
        /// </summary>
        [Input("domainSid", required: true)]
        public Input<string> DomainSid { get; set; } = null!;

        /// <summary>
        /// Specifies the Active Directory forest to get.
        /// </summary>
        [Input("forestName", required: true)]
        public Input<string> ForestName { get; set; } = null!;

        /// <summary>
        /// Specifies the NetBIOS domain name.
        /// </summary>
        [Input("netBiosDomainName", required: true)]
        public Input<string> NetBiosDomainName { get; set; } = null!;

        public ActiveDirectoryPropertiesArgs()
        {
        }
    }
}