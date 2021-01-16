// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class CopyActivityLogSettingsResponse
    {
        /// <summary>
        /// Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? EnableReliableLogging;
        /// <summary>
        /// Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? LogLevel;

        [OutputConstructor]
        private CopyActivityLogSettingsResponse(
            object? enableReliableLogging,

            object? logLevel)
        {
            EnableReliableLogging = enableReliableLogging;
            LogLevel = logLevel;
        }
    }
}
