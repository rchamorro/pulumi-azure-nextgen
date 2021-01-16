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
    public sealed class ExecuteDataFlowActivityTypePropertiesResponseCompute
    {
        /// <summary>
        /// Compute type of the cluster which will execute data flow job. Possible values include: 'General', 'MemoryOptimized', 'ComputeOptimized'. Type: string (or Expression with resultType string)
        /// </summary>
        public readonly object? ComputeType;
        /// <summary>
        /// Core count of the cluster which will execute data flow job. Supported values are: 8, 16, 32, 48, 80, 144 and 272. Type: integer (or Expression with resultType integer)
        /// </summary>
        public readonly object? CoreCount;

        [OutputConstructor]
        private ExecuteDataFlowActivityTypePropertiesResponseCompute(
            object? computeType,

            object? coreCount)
        {
            ComputeType = computeType;
            CoreCount = coreCount;
        }
    }
}
