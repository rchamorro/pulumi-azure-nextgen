// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20190601Preview.Outputs
{

    [OutputType]
    public sealed class WorkspaceRepositoryConfigurationResponse
    {
        /// <summary>
        /// Account name
        /// </summary>
        public readonly string? AccountName;
        /// <summary>
        /// Collaboration branch
        /// </summary>
        public readonly string? CollaborationBranch;
        /// <summary>
        /// GitHub Enterprise host name. For example: https://github.mydomain.com
        /// </summary>
        public readonly string? HostName;
        /// <summary>
        /// VSTS project name
        /// </summary>
        public readonly string? ProjectName;
        /// <summary>
        /// Repository name
        /// </summary>
        public readonly string? RepositoryName;
        /// <summary>
        /// Root folder to use in the repository
        /// </summary>
        public readonly string? RootFolder;
        /// <summary>
        /// Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private WorkspaceRepositoryConfigurationResponse(
            string? accountName,

            string? collaborationBranch,

            string? hostName,

            string? projectName,

            string? repositoryName,

            string? rootFolder,

            string? type)
        {
            AccountName = accountName;
            CollaborationBranch = collaborationBranch;
            HostName = hostName;
            ProjectName = projectName;
            RepositoryName = repositoryName;
            RootFolder = rootFolder;
            Type = type;
        }
    }
}
