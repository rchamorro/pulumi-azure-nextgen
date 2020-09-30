// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridCompute.V20200730Preview
{
    public static class GetMachineExtension
    {
        public static Task<GetMachineExtensionResult> InvokeAsync(GetMachineExtensionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMachineExtensionResult>("azure-nextgen:hybridcompute/v20200730preview:getMachineExtension", args ?? new GetMachineExtensionArgs(), options.WithVersion());
    }


    public sealed class GetMachineExtensionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the machine extension.
        /// </summary>
        [Input("extensionName", required: true)]
        public string ExtensionName { get; set; } = null!;

        /// <summary>
        /// The name of the machine containing the extension.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetMachineExtensionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMachineExtensionResult
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        public readonly bool? AutoUpgradeMinorVersion;
        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        public readonly string? ForceUpdateTag;
        /// <summary>
        /// The machine extension instance view.
        /// </summary>
        public readonly Outputs.MachineExtensionPropertiesResponseInstanceView? InstanceView;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        public readonly object? ProtectedSettings;
        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        public readonly string? Publisher;
        /// <summary>
        /// Json formatted public settings for the extension.
        /// </summary>
        public readonly object? Settings;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        public readonly string? TypeHandlerVersion;

        [OutputConstructor]
        private GetMachineExtensionResult(
            bool? autoUpgradeMinorVersion,

            string? forceUpdateTag,

            Outputs.MachineExtensionPropertiesResponseInstanceView? instanceView,

            string location,

            string name,

            object? protectedSettings,

            string provisioningState,

            string? publisher,

            object? settings,

            ImmutableDictionary<string, string>? tags,

            string type,

            string? typeHandlerVersion)
        {
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            ForceUpdateTag = forceUpdateTag;
            InstanceView = instanceView;
            Location = location;
            Name = name;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            Publisher = publisher;
            Settings = settings;
            Tags = tags;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
        }
    }
}
