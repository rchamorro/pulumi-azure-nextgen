// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Batch.V20170901.Outputs
{

    [OutputType]
    public sealed class ApplicationPackageResponse
    {
        /// <summary>
        /// The format of the application package, if the package is active.
        /// </summary>
        public readonly string Format;
        /// <summary>
        /// The ID of the application.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The time at which the package was last activated, if the package is active.
        /// </summary>
        public readonly string LastActivationTime;
        /// <summary>
        /// The current state of the application package.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The URL for the application package in Azure Storage.
        /// </summary>
        public readonly string StorageUrl;
        /// <summary>
        /// The UTC time at which the Azure Storage URL will expire.
        /// </summary>
        public readonly string StorageUrlExpiry;
        /// <summary>
        /// The version of the application package.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationPackageResponse(
            string format,

            string id,

            string lastActivationTime,

            string state,

            string storageUrl,

            string storageUrlExpiry,

            string version)
        {
            Format = format;
            Id = id;
            LastActivationTime = lastActivationTime;
            State = state;
            StorageUrl = storageUrl;
            StorageUrlExpiry = storageUrlExpiry;
            Version = version;
        }
    }
}