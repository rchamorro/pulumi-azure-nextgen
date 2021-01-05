// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180419
{
    public static class GetProject
    {
        public static Task<GetProjectResult> InvokeAsync(GetProjectArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProjectResult>("azure-nextgen:datamigration/v20180419:getProject", args ?? new GetProjectArgs(), options.WithVersion());
    }


    public sealed class GetProjectArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource group
        /// </summary>
        [Input("groupName", required: true)]
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the project
        /// </summary>
        [Input("projectName", required: true)]
        public string ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the service
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetProjectArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProjectResult
    {
        /// <summary>
        /// UTC Date and time when project was created
        /// </summary>
        public readonly string CreationTime;
        /// <summary>
        /// List of DatabaseInfo
        /// </summary>
        public readonly ImmutableArray<Outputs.DatabaseInfoResponse> DatabasesInfo;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The project's provisioning state
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Information for connecting to source
        /// </summary>
        public readonly object? SourceConnectionInfo;
        /// <summary>
        /// Source platform for the project
        /// </summary>
        public readonly string SourcePlatform;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Information for connecting to target
        /// </summary>
        public readonly object? TargetConnectionInfo;
        /// <summary>
        /// Target platform for the project
        /// </summary>
        public readonly string TargetPlatform;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetProjectResult(
            string creationTime,

            ImmutableArray<Outputs.DatabaseInfoResponse> databasesInfo,

            string id,

            string location,

            string name,

            string provisioningState,

            object? sourceConnectionInfo,

            string sourcePlatform,

            ImmutableDictionary<string, string>? tags,

            object? targetConnectionInfo,

            string targetPlatform,

            string type)
        {
            CreationTime = creationTime;
            DatabasesInfo = databasesInfo;
            Id = id;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SourceConnectionInfo = sourceConnectionInfo;
            SourcePlatform = sourcePlatform;
            Tags = tags;
            TargetConnectionInfo = targetConnectionInfo;
            TargetPlatform = targetPlatform;
            Type = type;
        }
    }
}
