// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20180122.Outputs
{

    [OutputType]
    public sealed class SharedAccessSignatureAuthorizationRuleResponse
    {
        /// <summary>
        /// The name of the shared access policy.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// The primary key.
        /// </summary>
        public readonly string? PrimaryKey;
        /// <summary>
        /// The permissions assigned to the shared access policy.
        /// </summary>
        public readonly string Rights;
        /// <summary>
        /// The secondary key.
        /// </summary>
        public readonly string? SecondaryKey;

        [OutputConstructor]
        private SharedAccessSignatureAuthorizationRuleResponse(
            string keyName,

            string? primaryKey,

            string rights,

            string? secondaryKey)
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            Rights = rights;
            SecondaryKey = secondaryKey;
        }
    }
}