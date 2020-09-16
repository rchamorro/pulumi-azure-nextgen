// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426.Inputs
{

    /// <summary>
    /// Connector mapping property structure.
    /// </summary>
    public sealed class ConnectorMappingStructureArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The column name of the import file.
        /// </summary>
        [Input("columnName", required: true)]
        public Input<string> ColumnName { get; set; } = null!;

        /// <summary>
        /// Custom format specifier for input parsing.
        /// </summary>
        [Input("customFormatSpecifier")]
        public Input<string>? CustomFormatSpecifier { get; set; }

        /// <summary>
        /// Indicates if the column is encrypted.
        /// </summary>
        [Input("isEncrypted")]
        public Input<bool>? IsEncrypted { get; set; }

        /// <summary>
        /// The property name of the mapping entity.
        /// </summary>
        [Input("propertyName", required: true)]
        public Input<string> PropertyName { get; set; } = null!;

        public ConnectorMappingStructureArgs()
        {
        }
    }
}