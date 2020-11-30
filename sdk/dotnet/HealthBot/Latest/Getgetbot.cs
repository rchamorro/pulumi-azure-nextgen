// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthBot.Latest
{
    public static class Getgetbot
    {
        public static Task<GetgetbotResult> InvokeAsync(GetgetbotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetgetbotResult>("azure-nextgen:healthbot/latest:getgetbot", args ?? new GetgetbotArgs(), options.WithVersion());
    }


    public sealed class GetgetbotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Bot resource group in the user subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Bot resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetgetbotArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetgetbotResult
    {
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The set of properties specific to healthcare bot resource.
        /// </summary>
        public readonly Outputs.HealthBotPropertiesResponse Properties;
        /// <summary>
        /// SKU of the HealthBot.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetgetbotResult(
            string location,

            string name,

            Outputs.HealthBotPropertiesResponse properties,

            Outputs.SkuResponse? sku,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Location = location;
            Name = name;
            Properties = properties;
            Sku = sku;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}