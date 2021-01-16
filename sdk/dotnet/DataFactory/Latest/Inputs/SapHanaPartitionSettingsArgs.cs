// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// The settings that will be leveraged for SAP HANA source partitioning.
    /// </summary>
    public sealed class SapHanaPartitionSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("partitionColumnName")]
        public Input<object>? PartitionColumnName { get; set; }

        public SapHanaPartitionSettingsArgs()
        {
        }
    }
}
