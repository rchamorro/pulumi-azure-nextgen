// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class PeriodicModeBackupPolicyResponse
    {
        /// <summary>
        /// Configuration values for periodic mode backup
        /// </summary>
        public readonly Outputs.PeriodicModePropertiesResponse? PeriodicModeProperties;
        /// <summary>
        /// Describes the mode of backups.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PeriodicModeBackupPolicyResponse(
            Outputs.PeriodicModePropertiesResponse? periodicModeProperties,

            string type)
        {
            PeriodicModeProperties = periodicModeProperties;
            Type = type;
        }
    }
}