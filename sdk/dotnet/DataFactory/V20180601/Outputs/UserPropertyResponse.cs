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
    public sealed class UserPropertyResponse
    {
        /// <summary>
        /// User property name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// User property value. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Value;

        [OutputConstructor]
        private UserPropertyResponse(
            string name,

            object value)
        {
            Name = name;
            Value = value;
        }
    }
}
