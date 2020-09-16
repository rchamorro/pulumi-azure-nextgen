// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200515Preview.Inputs
{

    /// <summary>
    /// The dataset reference object.
    /// </summary>
    public sealed class DatasetReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the dataset reference.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The name of the dataset reference.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DatasetReferenceArgs()
        {
        }
    }
}