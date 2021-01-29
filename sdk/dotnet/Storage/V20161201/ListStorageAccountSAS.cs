// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20161201
{
    public static class ListStorageAccountSAS
    {
        public static Task<ListStorageAccountSASResult> InvokeAsync(ListStorageAccountSASArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListStorageAccountSASResult>("azure-nextgen:storage/v20161201:listStorageAccountSAS", args ?? new ListStorageAccountSASArgs(), options.WithVersion());
    }


    public sealed class ListStorageAccountSASArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.  
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// An IP address or a range of IP addresses from which to accept requests.
        /// </summary>
        [Input("iPAddressOrRange")]
        public string? IPAddressOrRange { get; set; }

        /// <summary>
        /// The key to sign the account SAS token with.
        /// </summary>
        [Input("keyToSign")]
        public string? KeyToSign { get; set; }

        /// <summary>
        /// The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
        /// </summary>
        [Input("permissions", required: true)]
        public string Permissions { get; set; } = null!;

        /// <summary>
        /// The protocol permitted for a request made with the account SAS.
        /// </summary>
        [Input("protocols")]
        public Pulumi.AzureNextGen.Storage.V20161201.HttpProtocol? Protocols { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files.
        /// </summary>
        [Input("resourceTypes", required: true)]
        public string ResourceTypes { get; set; } = null!;

        /// <summary>
        /// The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f).
        /// </summary>
        [Input("services", required: true)]
        public string Services { get; set; } = null!;

        /// <summary>
        /// The time at which the shared access signature becomes invalid.
        /// </summary>
        [Input("sharedAccessExpiryTime", required: true)]
        public string SharedAccessExpiryTime { get; set; } = null!;

        /// <summary>
        /// The time at which the SAS becomes valid.
        /// </summary>
        [Input("sharedAccessStartTime")]
        public string? SharedAccessStartTime { get; set; }

        public ListStorageAccountSASArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListStorageAccountSASResult
    {
        /// <summary>
        /// List SAS credentials of storage account.
        /// </summary>
        public readonly string AccountSasToken;

        [OutputConstructor]
        private ListStorageAccountSASResult(string accountSasToken)
        {
            AccountSasToken = accountSasToken;
        }
    }
}
