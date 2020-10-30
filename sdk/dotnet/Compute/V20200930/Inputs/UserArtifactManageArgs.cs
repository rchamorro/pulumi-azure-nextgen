// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20200930.Inputs
{

    public sealed class UserArtifactManageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Required. The path and arguments to install the gallery application. This is limited to 4096 characters.
        /// </summary>
        [Input("install", required: true)]
        public Input<string> Install { get; set; } = null!;

        /// <summary>
        /// Required. The path and arguments to remove the gallery application. This is limited to 4096 characters.
        /// </summary>
        [Input("remove", required: true)]
        public Input<string> Remove { get; set; } = null!;

        /// <summary>
        /// Optional. The path and arguments to update the gallery application. If not present, then update operation will invoke remove command on the previous version and install command on the current version of the gallery application. This is limited to 4096 characters.
        /// </summary>
        [Input("update")]
        public Input<string>? Update { get; set; }

        public UserArtifactManageArgs()
        {
        }
    }
}