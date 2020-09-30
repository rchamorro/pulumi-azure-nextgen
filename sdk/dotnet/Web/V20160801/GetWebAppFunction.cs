// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20160801
{
    public static class GetWebAppFunction
    {
        public static Task<GetWebAppFunctionResult> InvokeAsync(GetWebAppFunctionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppFunctionResult>("azure-nextgen:web/v20160801:getWebAppFunction", args ?? new GetWebAppFunctionArgs(), options.WithVersion());
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
        public readonly string FunctionAppId;
        /// <summary>
        /// Function URI.
        /// </summary>
        public readonly string? Href;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
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
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWebAppFunctionResult(
            object? config,

            string? configHref,

            ImmutableDictionary<string, string>? files,

            string functionAppId,

            string? href,

            string? kind,

            string name,

            string? scriptHref,

            string? scriptRootPathHref,

            string? secretsFileHref,

            string? testData,

            string type)
        {
            Config = config;
            ConfigHref = configHref;
            Files = files;
            FunctionAppId = functionAppId;
            Href = href;
            Kind = kind;
            Name = name;
            ScriptHref = scriptHref;
            ScriptRootPathHref = scriptRootPathHref;
            SecretsFileHref = secretsFileHref;
            TestData = testData;
            Type = type;
        }
    }
}
