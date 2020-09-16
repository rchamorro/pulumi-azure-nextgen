// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.Latest.Outputs
{

    [OutputType]
    public sealed class MiSqlConnectionInfoResponse
    {
        /// <summary>
        /// Resource id for Azure SQL database Managed instance
        /// </summary>
        public readonly string ManagedInstanceResourceId;
        /// <summary>
        /// Password credential.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// Type of connection info
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User name
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private MiSqlConnectionInfoResponse(
            string managedInstanceResourceId,

            string? password,

            string type,

            string? userName)
        {
            ManagedInstanceResourceId = managedInstanceResourceId;
            Password = password;
            Type = type;
            UserName = userName;
        }
    }
}