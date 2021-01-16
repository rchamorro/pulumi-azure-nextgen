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
    public sealed class SSISChildPackageResponse
    {
        /// <summary>
        /// Content for embedded child package. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object PackageContent;
        /// <summary>
        /// Last modified date for embedded child package.
        /// </summary>
        public readonly string? PackageLastModifiedDate;
        /// <summary>
        /// Name for embedded child package.
        /// </summary>
        public readonly string? PackageName;
        /// <summary>
        /// Path for embedded child package. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object PackagePath;

        [OutputConstructor]
        private SSISChildPackageResponse(
            object packageContent,

            string? packageLastModifiedDate,

            string? packageName,

            object packagePath)
        {
            PackageContent = packageContent;
            PackageLastModifiedDate = packageLastModifiedDate;
            PackageName = packageName;
            PackagePath = packagePath;
        }
    }
}
