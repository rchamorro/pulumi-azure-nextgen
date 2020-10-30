// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AppConfiguration.V20200701Preview.Outputs
{

    [OutputType]
    public sealed class ApiKeyResponseResult
    {
        /// <summary>
        /// A connection string that can be used by supporting clients for authentication.
        /// </summary>
        public readonly string ConnectionString;
        /// <summary>
        /// The key ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The last time any of the key's properties were modified.
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// A name for the key describing its usage.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Whether this key can only be used for read operations.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// The value of the key that is used for authentication purposes.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ApiKeyResponseResult(
            string connectionString,

            string id,

            string lastModified,

            string name,

            bool readOnly,

            string value)
        {
            ConnectionString = connectionString;
            Id = id;
            LastModified = lastModified;
            Name = name;
            ReadOnly = readOnly;
            Value = value;
        }
    }
}