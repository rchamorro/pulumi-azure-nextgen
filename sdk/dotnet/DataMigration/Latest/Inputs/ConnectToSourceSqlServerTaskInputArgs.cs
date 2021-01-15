// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.Latest.Inputs
{

    /// <summary>
    /// Input for the task that validates connection to SQL Server and also validates source server requirements
    /// </summary>
    public sealed class ConnectToSourceSqlServerTaskInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Permission group for validations
        /// </summary>
        [Input("checkPermissionsGroup")]
        public InputUnion<string, Pulumi.AzureNextGen.DataMigration.Latest.ServerLevelPermissionsGroup>? CheckPermissionsGroup { get; set; }

        /// <summary>
        /// Flag for whether to collect agent jobs from source server.
        /// </summary>
        [Input("collectAgentJobs")]
        public Input<bool>? CollectAgentJobs { get; set; }

        /// <summary>
        /// Flag for whether to collect logins from source server.
        /// </summary>
        [Input("collectLogins")]
        public Input<bool>? CollectLogins { get; set; }

        /// <summary>
        /// Connection information for Source SQL Server
        /// </summary>
        [Input("sourceConnectionInfo", required: true)]
        public Input<Inputs.SqlConnectionInfoArgs> SourceConnectionInfo { get; set; } = null!;

        public ConnectToSourceSqlServerTaskInputArgs()
        {
            CollectAgentJobs = false;
            CollectLogins = false;
        }
    }
}
