// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101.Inputs
{

    /// <summary>
    /// Application logs to file system configuration.
    /// </summary>
    public sealed class FileSystemApplicationLogsConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Log level.
        /// </summary>
        [Input("level")]
        public Input<Pulumi.AzureNextGen.Web.V20181101.LogLevel>? Level { get; set; }

        public FileSystemApplicationLogsConfigArgs()
        {
            Level = Pulumi.AzureNextGen.Web.V20181101.LogLevel.Off;
        }
    }
}
