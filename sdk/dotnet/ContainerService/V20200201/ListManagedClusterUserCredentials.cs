// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20200201
{
    public static class ListManagedClusterUserCredentials
    {
        public static Task<ListManagedClusterUserCredentialsResult> InvokeAsync(ListManagedClusterUserCredentialsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListManagedClusterUserCredentialsResult>("azure-nextgen:containerservice/v20200201:listManagedClusterUserCredentials", args ?? new ListManagedClusterUserCredentialsArgs(), options.WithVersion());
    }


    public sealed class ListManagedClusterUserCredentialsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the managed cluster resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public ListManagedClusterUserCredentialsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListManagedClusterUserCredentialsResult
    {
        /// <summary>
        /// Base64-encoded Kubernetes configuration file.
        /// </summary>
        public readonly ImmutableArray<Outputs.CredentialResultResponseResult> Kubeconfigs;

        [OutputConstructor]
        private ListManagedClusterUserCredentialsResult(ImmutableArray<Outputs.CredentialResultResponseResult> kubeconfigs)
        {
            Kubeconfigs = kubeconfigs;
        }
    }
}