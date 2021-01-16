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
    public sealed class OraclePartitionSettingsResponse
    {
        /// <summary>
        /// The name of the column in integer type that will be used for proceeding range partitioning. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? PartitionColumnName;
        /// <summary>
        /// The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? PartitionLowerBound;
        /// <summary>
        /// Names of the physical partitions of Oracle table. 
        /// </summary>
        public readonly ImmutableArray<object> PartitionNames;
        /// <summary>
        /// The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? PartitionUpperBound;

        [OutputConstructor]
        private OraclePartitionSettingsResponse(
            object? partitionColumnName,

            object? partitionLowerBound,

            ImmutableArray<object> partitionNames,

            object? partitionUpperBound)
        {
            PartitionColumnName = partitionColumnName;
            PartitionLowerBound = partitionLowerBound;
            PartitionNames = partitionNames;
            PartitionUpperBound = partitionUpperBound;
        }
    }
}
