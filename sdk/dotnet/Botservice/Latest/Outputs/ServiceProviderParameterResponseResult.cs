// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BotService.Latest.Outputs
{

    [OutputType]
    public sealed class ServiceProviderParameterResponseResult
    {
        /// <summary>
        /// Default Name for the Service Provider
        /// </summary>
        public readonly string Default;
        /// <summary>
        /// Description of the Service Provider
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Display Name of the Service Provider
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Help Url for the  Service Provider
        /// </summary>
        public readonly string HelpUrl;
        /// <summary>
        /// Name of the Service Provider
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Type of the Service Provider
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ServiceProviderParameterResponseResult(
            string @default,

            string description,

            string displayName,

            string helpUrl,

            string name,

            string type)
        {
            Default = @default;
            Description = description;
            DisplayName = displayName;
            HelpUrl = helpUrl;
            Name = name;
            Type = type;
        }
    }
}