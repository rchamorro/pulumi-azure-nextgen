// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831Preview.Outputs
{

    [OutputType]
    public sealed class RoutePropertiesResponse
    {
        /// <summary>
        /// The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to true by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
        /// </summary>
        public readonly string? Condition;
        /// <summary>
        /// The list of endpoints to which messages that satisfy the condition are routed. Currently only one endpoint is allowed.
        /// </summary>
        public readonly ImmutableArray<string> EndpointNames;
        /// <summary>
        /// Used to specify whether a route is enabled.
        /// </summary>
        public readonly bool IsEnabled;
        /// <summary>
        /// The name of the route. The name can only include alphanumeric characters, periods, underscores, hyphens, has a maximum length of 64 characters, and must be unique.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The source that the routing rule is to be applied to, such as DeviceMessages.
        /// </summary>
        public readonly string Source;

        [OutputConstructor]
        private RoutePropertiesResponse(
            string? condition,

            ImmutableArray<string> endpointNames,

            bool isEnabled,

            string name,

            string source)
        {
            Condition = condition;
            EndpointNames = endpointNames;
            IsEnabled = isEnabled;
            Name = name;
            Source = source;
        }
    }
}
