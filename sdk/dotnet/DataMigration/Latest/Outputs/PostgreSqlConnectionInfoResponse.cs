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
    public sealed class PostgreSqlConnectionInfoResponse
    {
        /// <summary>
        /// Name of the database
        /// </summary>
        public readonly string? DatabaseName;
        /// <summary>
        /// Password credential.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// Port for Server
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Name of the server
        /// </summary>
        public readonly string ServerName;
        /// <summary>
        /// Type of connection info
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User name
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private PostgreSqlConnectionInfoResponse(
            string? databaseName,

            string? password,

            int port,

            string serverName,

            string type,

            string? userName)
        {
            DatabaseName = databaseName;
            Password = password;
            Port = port;
            ServerName = serverName;
            Type = type;
            UserName = userName;
        }
    }
}