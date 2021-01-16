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
    /// Azure ML WebService Input/Output file
    /// </summary>
    public sealed class AzureMLWebServiceFileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The relative file path, including container name, in the Azure Blob Storage specified by the LinkedService. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("filePath", required: true)]
        public Input<object> FilePath { get; set; } = null!;

        /// <summary>
        /// Reference to an Azure Storage LinkedService, where Azure ML WebService Input/Output file located.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        public AzureMLWebServiceFileArgs()
        {
        }
    }
}
