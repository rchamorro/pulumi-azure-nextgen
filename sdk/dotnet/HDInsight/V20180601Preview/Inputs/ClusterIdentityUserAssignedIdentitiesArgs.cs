// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HDInsight.V20180601Preview.Inputs
{

    public sealed class ClusterIdentityUserAssignedIdentitiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The tenant id of user assigned identity.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public ClusterIdentityUserAssignedIdentitiesArgs()
        {
        }
    }
}
