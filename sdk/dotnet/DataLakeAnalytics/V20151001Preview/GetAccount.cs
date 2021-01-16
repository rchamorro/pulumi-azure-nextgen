// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataLakeAnalytics.V20151001Preview
{
    public static class GetAccount
    {
        public static Task<GetAccountResult> InvokeAsync(GetAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAccountResult>("azure-nextgen:datalakeanalytics/v20151001preview:getAccount", args ?? new GetAccountArgs(), options.WithVersion());
    }


    public sealed class GetAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Data Lake Analytics account to retrieve.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the Azure resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAccountArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAccountResult
    {
        /// <summary>
        /// The unique identifier associated with this Data Lake Analytics account.
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// The list of compute policies associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.ComputePolicyResponse> ComputePolicies;
        /// <summary>
        /// The account creation time.
        /// </summary>
        public readonly string CreationTime;
        /// <summary>
        /// The commitment tier in use for the current month.
        /// </summary>
        public readonly string CurrentTier;
        /// <summary>
        /// The list of Data Lake Store accounts associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.DataLakeStoreAccountInformationResponse> DataLakeStoreAccounts;
        /// <summary>
        /// The current state of the DebugDataAccessLevel for this account.
        /// </summary>
        public readonly string DebugDataAccessLevel;
        /// <summary>
        /// The default Data Lake Store account associated with this account.
        /// </summary>
        public readonly string DefaultDataLakeStoreAccount;
        /// <summary>
        /// The full CName endpoint for this account.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        /// </summary>
        public readonly string FirewallAllowAzureIps;
        /// <summary>
        /// The list of firewall rules associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.FirewallRuleResponse> FirewallRules;
        /// <summary>
        /// The current state of the IP address firewall for this account.
        /// </summary>
        public readonly string FirewallState;
        /// <summary>
        /// The list of hiveMetastores associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.HiveMetastoreResponse> HiveMetastores;
        /// <summary>
        /// The resource identifer.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The account last modified time.
        /// </summary>
        public readonly string LastModifiedTime;
        /// <summary>
        /// The resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The maximum supported degree of parallelism for this account.
        /// </summary>
        public readonly int? MaxDegreeOfParallelism;
        /// <summary>
        /// The maximum supported degree of parallelism per job for this account.
        /// </summary>
        public readonly int MaxDegreeOfParallelismPerJob;
        /// <summary>
        /// The maximum supported jobs running under the account at the same time.
        /// </summary>
        public readonly int? MaxJobCount;
        /// <summary>
        /// The minimum supported priority per job for this account.
        /// </summary>
        public readonly int MinPriorityPerJob;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The commitment tier for the next month.
        /// </summary>
        public readonly string NewTier;
        /// <summary>
        /// The provisioning status of the Data Lake Analytics account.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The number of days that job metadata is retained.
        /// </summary>
        public readonly int? QueryStoreRetention;
        /// <summary>
        /// The state of the Data Lake Analytics account.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The list of Azure Blob Storage accounts associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.StorageAccountInformationResponse> StorageAccounts;
        /// <summary>
        /// The system defined maximum supported degree of parallelism for this account, which restricts the maximum value of parallelism the user can set for the account.
        /// </summary>
        public readonly int SystemMaxDegreeOfParallelism;
        /// <summary>
        /// The system defined maximum supported jobs running under the account at the same time, which restricts the maximum number of running jobs the user can set for the account.
        /// </summary>
        public readonly int SystemMaxJobCount;
        /// <summary>
        /// The resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The list of virtualNetwork rules associated with this account.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNetworkRuleResponse> VirtualNetworkRules;

        [OutputConstructor]
        private GetAccountResult(
            string accountId,

            ImmutableArray<Outputs.ComputePolicyResponse> computePolicies,

            string creationTime,

            string currentTier,

            ImmutableArray<Outputs.DataLakeStoreAccountInformationResponse> dataLakeStoreAccounts,

            string debugDataAccessLevel,

            string defaultDataLakeStoreAccount,

            string endpoint,

            string firewallAllowAzureIps,

            ImmutableArray<Outputs.FirewallRuleResponse> firewallRules,

            string firewallState,

            ImmutableArray<Outputs.HiveMetastoreResponse> hiveMetastores,

            string id,

            string lastModifiedTime,

            string location,

            int? maxDegreeOfParallelism,

            int maxDegreeOfParallelismPerJob,

            int? maxJobCount,

            int minPriorityPerJob,

            string name,

            string newTier,

            string provisioningState,

            int? queryStoreRetention,

            string state,

            ImmutableArray<Outputs.StorageAccountInformationResponse> storageAccounts,

            int systemMaxDegreeOfParallelism,

            int systemMaxJobCount,

            ImmutableDictionary<string, string> tags,

            string type,

            ImmutableArray<Outputs.VirtualNetworkRuleResponse> virtualNetworkRules)
        {
            AccountId = accountId;
            ComputePolicies = computePolicies;
            CreationTime = creationTime;
            CurrentTier = currentTier;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            DebugDataAccessLevel = debugDataAccessLevel;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            Endpoint = endpoint;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            HiveMetastores = hiveMetastores;
            Id = id;
            LastModifiedTime = lastModifiedTime;
            Location = location;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MaxJobCount = maxJobCount;
            MinPriorityPerJob = minPriorityPerJob;
            Name = name;
            NewTier = newTier;
            ProvisioningState = provisioningState;
            QueryStoreRetention = queryStoreRetention;
            State = state;
            StorageAccounts = storageAccounts;
            SystemMaxDegreeOfParallelism = systemMaxDegreeOfParallelism;
            SystemMaxJobCount = systemMaxJobCount;
            Tags = tags;
            Type = type;
            VirtualNetworkRules = virtualNetworkRules;
        }
    }
}
