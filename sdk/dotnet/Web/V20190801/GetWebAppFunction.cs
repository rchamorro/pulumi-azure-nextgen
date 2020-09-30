// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20190801
{
    public static class GetWebAppFunction
    {
        public static Task<GetWebAppFunctionResult> InvokeAsync(GetWebAppFunctionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppFunctionResult>("azure-nextgen:web/v20190801:getWebAppFunction", args ?? new GetWebAppFunctionArgs(), options.WithVersion());
    }


    public sealed class GetWebAppFunctionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Function name.
        /// </summary>
        [Input("functionName", required: true)]
        public string FunctionName { get; set; } = null!;

        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetWebAppFunctionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWebAppFunctionResult
    {
        /// <summary>
        /// Config information.
        /// </summary>
        public readonly object? Config;
        /// <summary>
        /// Config URI.
        /// </summary>
        public readonly string? ConfigHref;
        /// <summary>
        /// File list.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Files;
        /// <summary>
        /// Function App ID.
        /// </summary>
        public readonly string? FunctionAppId;
        /// <summary>
        /// Function URI.
        /// </summary>
        public readonly string? Href;
        /// <summary>
        /// The invocation URL
        /// </summary>
        public readonly string? InvokeUrlTemplate;
        /// <summary>
        /// Gets or sets a value indicating whether the function is disabled
        /// </summary>
        public readonly bool? IsDisabled;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// The function language
        /// </summary>
        public readonly string? Language;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Script URI.
        /// </summary>
        public readonly string? ScriptHref;
        /// <summary>
        /// Script root path URI.
        /// </summary>
        public readonly string? ScriptRootPathHref;
        /// <summary>
        /// Secrets file URI.
        /// </summary>
        public readonly string? SecretsFileHref;
        /// <summary>
        /// Test data used when testing via the Azure Portal.
        /// </summary>
        public readonly string? TestData;
        /// <summary>
        /// Test data URI.
        /// </summary>
        public readonly string? TestDataHref;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWebAppFunctionResult(
            object? config,

            string? configHref,

            ImmutableDictionary<string, string>? files,

            string? functionAppId,

            string? href,

            string? invokeUrlTemplate,

            bool? isDisabled,

            string? kind,

            string? language,

            string name,

            string? scriptHref,

            string? scriptRootPathHref,

            string? secretsFileHref,

            string? testData,

            string? testDataHref,

            string type)
        {
            Config = config;
            ConfigHref = configHref;
            Files = files;
            FunctionAppId = functionAppId;
            Href = href;
            InvokeUrlTemplate = invokeUrlTemplate;
            IsDisabled = isDisabled;
            Kind = kind;
            Language = language;
            Name = name;
            ScriptHref = scriptHref;
            ScriptRootPathHref = scriptRootPathHref;
            SecretsFileHref = secretsFileHref;
            TestData = testData;
            TestDataHref = testDataHref;
            Type = type;
        }
    }
}
