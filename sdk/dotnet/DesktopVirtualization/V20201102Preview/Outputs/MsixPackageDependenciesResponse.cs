// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DesktopVirtualization.V20201102Preview.Outputs
{

    [OutputType]
    public sealed class MsixPackageDependenciesResponse
    {
        /// <summary>
        /// Name of package dependency.
        /// </summary>
        public readonly string? DependencyName;
        /// <summary>
        /// Dependency version required.
        /// </summary>
        public readonly string? MinVersion;
        /// <summary>
        /// Name of dependency publisher.
        /// </summary>
        public readonly string? Publisher;

        [OutputConstructor]
        private MsixPackageDependenciesResponse(
            string? dependencyName,

            string? minVersion,

            string? publisher)
        {
            DependencyName = dependencyName;
            MinVersion = minVersion;
            Publisher = publisher;
        }
    }
}