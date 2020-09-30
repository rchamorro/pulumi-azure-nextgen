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
    /// HDInsight linked service.
    /// </summary>
    public sealed class HDInsightLinkedServiceArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// HDInsight cluster URI. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("clusterUri", required: true)]
        public Input<object> ClusterUri { get; set; } = null!;

        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        [Input("connectVia")]
        public Input<Inputs.IntegrationRuntimeReferenceArgs>? ConnectVia { get; set; }

        /// <summary>
        /// Linked service description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("encryptedCredential")]
        public Input<object>? EncryptedCredential { get; set; }

        /// <summary>
        /// Specify the FileSystem if the main storage for the HDInsight is ADLS Gen2. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("fileSystem")]
        public Input<object>? FileSystem { get; set; }

        /// <summary>
        /// A reference to the Azure SQL linked service that points to the HCatalog database.
        /// </summary>
        [Input("hcatalogLinkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? HcatalogLinkedServiceName { get; set; }

        /// <summary>
        /// Specify if the HDInsight is created with ESP (Enterprise Security Package). Type: Boolean.
        /// </summary>
        [Input("isEspEnabled")]
        public Input<object>? IsEspEnabled { get; set; }

        /// <summary>
        /// The Azure Storage linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// HDInsight cluster password.
        /// </summary>
        [Input("password")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? Password { get; set; }

        /// <summary>
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// HDInsight cluster user name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("userName")]
        public Input<object>? UserName { get; set; }

        public HDInsightLinkedServiceArgs()
        {
        }
    }
}
