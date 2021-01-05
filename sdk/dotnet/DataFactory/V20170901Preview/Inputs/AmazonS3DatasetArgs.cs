// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// A single Amazon Simple Storage Service (S3) object or a set of S3 objects.
    /// </summary>
    public sealed class AmazonS3DatasetArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// The name of the Amazon S3 bucket. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<object> BucketName { get; set; } = null!;

        /// <summary>
        /// The data compression method used for the Amazon S3 object.
        /// </summary>
        [Input("compression")]
        public Input<object>? Compression { get; set; }

        /// <summary>
        /// Dataset description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The format of files.
        /// </summary>
        [Input("format")]
        public Input<object>? Format { get; set; }

        /// <summary>
        /// The key of the Amazon S3 object. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("key")]
        public Input<object>? Key { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// The prefix filter for the S3 object name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("prefix")]
        public Input<object>? Prefix { get; set; }

        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        [Input("structure")]
        public Input<object>? Structure { get; set; }

        /// <summary>
        /// Type of dataset.
        /// Expected value is 'AmazonS3Object'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The version for the S3 object. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("version")]
        public Input<object>? Version { get; set; }

        public AmazonS3DatasetArgs()
        {
        }
    }
}
