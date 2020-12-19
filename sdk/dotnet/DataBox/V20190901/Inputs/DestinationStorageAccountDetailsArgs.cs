// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20190901.Inputs
{

    /// <summary>
    /// Details for the destination storage account.
    /// </summary>
    public sealed class DestinationStorageAccountDetailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Arm Id of the destination where the data has to be moved.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Data Destination Type.
        /// Expected value is 'StorageAccount'.
        /// </summary>
        [Input("dataDestinationType", required: true)]
        public Input<string> DataDestinationType { get; set; } = null!;

        /// <summary>
        /// Share password to be shared by all shares in SA.
        /// </summary>
        [Input("sharePassword")]
        public Input<string>? SharePassword { get; set; }

        /// <summary>
        /// Destination Storage Account Arm Id.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public Input<string> StorageAccountId { get; set; } = null!;

        public DestinationStorageAccountDetailsArgs()
        {
        }
    }
}
