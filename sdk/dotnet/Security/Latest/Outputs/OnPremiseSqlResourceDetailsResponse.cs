// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Security.Latest.Outputs
{

    [OutputType]
    public sealed class OnPremiseSqlResourceDetailsResponse
    {
        /// <summary>
        /// The Sql database name installed on the machine
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// The name of the machine
        /// </summary>
        public readonly string MachineName;
        /// <summary>
        /// The Sql server name installed on the machine
        /// </summary>
        public readonly string ServerName;
        /// <summary>
        /// The platform where the assessed resource resides
        /// Expected value is 'OnPremise'.
        /// </summary>
        public readonly string Source;
        /// <summary>
        /// The oms agent Id installed on the machine
        /// </summary>
        public readonly string SourceComputerId;
        /// <summary>
        /// The unique Id of the machine
        /// </summary>
        public readonly string Vmuuid;
        /// <summary>
        /// Azure resource Id of the workspace the machine is attached to
        /// </summary>
        public readonly string WorkspaceId;

        [OutputConstructor]
        private OnPremiseSqlResourceDetailsResponse(
            string databaseName,

            string machineName,

            string serverName,

            string source,

            string sourceComputerId,

            string vmuuid,

            string workspaceId)
        {
            DatabaseName = databaseName;
            MachineName = machineName;
            ServerName = serverName;
            Source = source;
            SourceComputerId = sourceComputerId;
            Vmuuid = vmuuid;
            WorkspaceId = workspaceId;
        }
    }
}
