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
    public sealed class WebHookActivityResponse
    {
        /// <summary>
        /// Authentication method used for calling the endpoint.
        /// </summary>
        public readonly Outputs.WebActivityAuthenticationResponse? Authentication;
        /// <summary>
        /// Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Body;
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Headers;
        /// <summary>
        /// Rest API method for target endpoint.
        /// </summary>
        public readonly string Method;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// When set to true, statusCode, output and error in callback request body will be consumed by activity. The activity can be marked as failed by setting statusCode &gt;= 400 in callback request. Default is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? ReportStatusOnCallBack;
        /// <summary>
        /// The timeout within which the webhook should be called back. If there is no value specified, it defaults to 10 minutes. Type: string. Pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly string? Timeout;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Container'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// WebHook activity target endpoint and path. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Url;
        /// <summary>
        /// Activity user properties.
        /// </summary>
        public readonly ImmutableArray<Outputs.UserPropertyResponse> UserProperties;

        [OutputConstructor]
        private WebHookActivityResponse(
            Outputs.WebActivityAuthenticationResponse? authentication,

            object? body,

            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            object? headers,

            string method,

            string name,

            object? reportStatusOnCallBack,

            string? timeout,

            string type,

            object url,

            ImmutableArray<Outputs.UserPropertyResponse> userProperties)
        {
            Authentication = authentication;
            Body = body;
            DependsOn = dependsOn;
            Description = description;
            Headers = headers;
            Method = method;
            Name = name;
            ReportStatusOnCallBack = reportStatusOnCallBack;
            Timeout = timeout;
            Type = type;
            Url = url;
            UserProperties = userProperties;
        }
    }
}
