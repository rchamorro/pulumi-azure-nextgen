// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Linked service for Amazon Redshift.
    /// </summary>
    public sealed class AmazonRedshiftLinkedServiceArgs : Pulumi.ResourceArgs
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
        /// The integration runtime reference.
        /// </summary>
        [Input("connectVia")]
        public Input<Inputs.IntegrationRuntimeReferenceArgs>? ConnectVia { get; set; }

        /// <summary>
        /// The database name of the Amazon Redshift source. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("database", required: true)]
        public Input<object> Database { get; set; } = null!;

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
        /// The password of the Amazon Redshift source.
        /// </summary>
        [Input("password")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? Password { get; set; }

        /// <summary>
        /// The TCP port number that the Amazon Redshift server uses to listen for client connections. The default value is 5439. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("port")]
        public Input<object>? Port { get; set; }

        /// <summary>
        /// The name of the Amazon Redshift server. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("server", required: true)]
        public Input<object> Server { get; set; } = null!;

        /// <summary>
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The username of the Amazon Redshift source. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("username")]
        public Input<object>? Username { get; set; }

        public AmazonRedshiftLinkedServiceArgs()
        {
        }
    }
}
