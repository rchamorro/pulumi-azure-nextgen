// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class SsisEnvironmentReferenceResponseResult
    {
        /// <summary>
        /// Environment folder name.
        /// </summary>
        public readonly string? EnvironmentFolderName;
        /// <summary>
        /// Environment name.
        /// </summary>
        public readonly string? EnvironmentName;
        /// <summary>
        /// Environment reference id.
        /// </summary>
        public readonly double? Id;
        /// <summary>
        /// Reference type
        /// </summary>
        public readonly string? ReferenceType;

        [OutputConstructor]
        private SsisEnvironmentReferenceResponseResult(
            string? environmentFolderName,

            string? environmentName,

            double? id,

            string? referenceType)
        {
            EnvironmentFolderName = environmentFolderName;
            EnvironmentName = environmentName;
            Id = id;
            ReferenceType = referenceType;
        }
    }
}
