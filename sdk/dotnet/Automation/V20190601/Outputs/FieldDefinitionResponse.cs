// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20190601.Outputs
{

    [OutputType]
    public sealed class FieldDefinitionResponse
    {
        /// <summary>
        /// Gets or sets the isEncrypted flag of the connection field definition.
        /// </summary>
        public readonly bool? IsEncrypted;
        /// <summary>
        /// Gets or sets the isOptional flag of the connection field definition.
        /// </summary>
        public readonly bool? IsOptional;
        /// <summary>
        /// Gets or sets the type of the connection field definition.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private FieldDefinitionResponse(
            bool? isEncrypted,

            bool? isOptional,

            string type)
        {
            IsEncrypted = isEncrypted;
            IsOptional = isOptional;
            Type = type;
        }
    }
}
