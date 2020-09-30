// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20160330
{
    public static class GetVirtualMachineExtension
    {
        public static Task<GetVirtualMachineExtensionResult> InvokeAsync(GetVirtualMachineExtensionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineExtensionResult>("azure-nextgen:compute/v20160330:getVirtualMachineExtension", args ?? new GetVirtualMachineExtensionArgs(), options.WithVersion());
    }


    public sealed class GetVirtualMachineExtensionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The expand expression to apply on the operation.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual machine extension.
        /// </summary>
        [Input("vmExtensionName", required: true)]
        public string VmExtensionName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual machine containing the extension.
        /// </summary>
        [Input("vmName", required: true)]
        public string VmName { get; set; } = null!;

        public GetVirtualMachineExtensionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineExtensionResult
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
        /// The virtual machine extension instance view.
        /// </summary>
        public readonly Outputs.VirtualMachineExtensionInstanceViewResponse? InstanceView;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
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
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        public readonly string? TypeHandlerVersion;

        [OutputConstructor]
        private GetVirtualMachineExtensionResult(
            bool? autoUpgradeMinorVersion,

            string? forceUpdateTag,

            Outputs.VirtualMachineExtensionInstanceViewResponse? instanceView,

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
