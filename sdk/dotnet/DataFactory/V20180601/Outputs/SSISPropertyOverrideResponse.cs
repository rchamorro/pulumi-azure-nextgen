// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class SSISPropertyOverrideResponse
    {
        /// <summary>
        /// Whether SSIS package property override value is sensitive data. Value will be encrypted in SSISDB if it is true
        /// </summary>
        public readonly bool? IsSensitive;
        /// <summary>
        /// SSIS package property override value. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Value;

        [OutputConstructor]
        private SSISPropertyOverrideResponse(
            bool? isSensitive,

            object value)
        {
            IsSensitive = isSensitive;
            Value = value;
        }
    }
}
