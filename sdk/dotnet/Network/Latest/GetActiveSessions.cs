// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest
{
    public static class GetActiveSessions
    {
        public static Task<GetActiveSessionsResult> InvokeAsync(GetActiveSessionsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetActiveSessionsResult>("azure-nextgen:network/latest:getActiveSessions", args ?? new GetActiveSessionsArgs(), options.WithVersion());
    }


    public sealed class GetActiveSessionsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bastion Host.
        /// </summary>
        [Input("bastionHostName", required: true)]
        public string BastionHostName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetActiveSessionsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetActiveSessionsResult
    {
        /// <summary>
        /// The URL to get the next set of results.
        /// </summary>
        public readonly string? NextLink;
        /// <summary>
        /// List of active sessions on the bastion.
        /// </summary>
        public readonly ImmutableArray<Outputs.BastionActiveSessionResponseResult> Value;

        [OutputConstructor]
        private GetActiveSessionsResult(
            string? nextLink,

            ImmutableArray<Outputs.BastionActiveSessionResponseResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}