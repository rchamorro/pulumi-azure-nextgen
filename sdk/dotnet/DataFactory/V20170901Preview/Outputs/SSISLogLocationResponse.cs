// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class SSISLogLocationResponse
    {
        /// <summary>
        /// The package execution log access credential.
        /// </summary>
        public readonly Outputs.SSISAccessCredentialResponse? AccessCredential;
        /// <summary>
        /// The SSIS package execution log path. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object LogPath;
        /// <summary>
        /// Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? LogRefreshInterval;
        /// <summary>
        /// The type of SSIS log location.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SSISLogLocationResponse(
            Outputs.SSISAccessCredentialResponse? accessCredential,

            object logPath,

            object? logRefreshInterval,

            string type)
        {
            AccessCredential = accessCredential;
            LogPath = logPath;
            LogRefreshInterval = logRefreshInterval;
            Type = type;
        }
    }
}
