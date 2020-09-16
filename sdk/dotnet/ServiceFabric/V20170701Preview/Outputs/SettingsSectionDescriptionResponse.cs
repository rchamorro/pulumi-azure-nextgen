// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20170701Preview.Outputs
{

    [OutputType]
    public sealed class SettingsSectionDescriptionResponse
    {
        /// <summary>
        /// The section name of the fabric settings.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The collection of parameters in the section.
        /// </summary>
        public readonly ImmutableArray<Outputs.SettingsParameterDescriptionResponse> Parameters;

        [OutputConstructor]
        private SettingsSectionDescriptionResponse(
            string name,

            ImmutableArray<Outputs.SettingsParameterDescriptionResponse> parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}