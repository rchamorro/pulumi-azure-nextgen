// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Kusto.V20200215.Outputs
{

    [OutputType]
    public sealed class FollowerDatabaseDefinitionResponseResult
    {
        /// <summary>
        /// Resource name of the attached database configuration in the follower cluster.
        /// </summary>
        public readonly string AttachedDatabaseConfigurationName;
        /// <summary>
        /// Resource id of the cluster that follows a database owned by this cluster.
        /// </summary>
        public readonly string ClusterResourceId;
        /// <summary>
        /// The database name owned by this cluster that was followed. * in case following all databases.
        /// </summary>
        public readonly string DatabaseName;

        [OutputConstructor]
        private FollowerDatabaseDefinitionResponseResult(
            string attachedDatabaseConfigurationName,

            string clusterResourceId,

            string databaseName)
        {
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
            ClusterResourceId = clusterResourceId;
            DatabaseName = databaseName;
        }
    }
}