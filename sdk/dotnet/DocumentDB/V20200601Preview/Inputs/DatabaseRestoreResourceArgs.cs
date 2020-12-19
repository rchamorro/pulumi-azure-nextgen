// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200601Preview.Inputs
{

    /// <summary>
    /// Specific Databases to restore.
    /// </summary>
    public sealed class DatabaseRestoreResourceArgs : Pulumi.ResourceArgs
    {
        [Input("collectionNames")]
        private InputList<string>? _collectionNames;

        /// <summary>
        /// The names of the collections available for restore.
        /// </summary>
        public InputList<string> CollectionNames
        {
            get => _collectionNames ?? (_collectionNames = new InputList<string>());
            set => _collectionNames = value;
        }

        /// <summary>
        /// The name of the database available for restore.
        /// </summary>
        [Input("databaseName")]
        public Input<string>? DatabaseName { get; set; }

        public DatabaseRestoreResourceArgs()
        {
        }
    }
}
