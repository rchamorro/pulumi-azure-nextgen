// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20171201.Outputs
{

    [OutputType]
    public sealed class VirtualMachineExtensionResponse
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
        /// Resource Id
        /// </summary>
        public readonly string Id;
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
        private VirtualMachineExtensionResponse(
            bool? autoUpgradeMinorVersion,

            string? forceUpdateTag,

            string id,

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
            Id = id;
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
