// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20190701.Inputs
{

    /// <summary>
    /// Describes a Virtual Machine Scale Set Extension.
    /// </summary>
    public sealed class VirtualMachineScaleSetExtensionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Input("autoUpgradeMinorVersion")]
        public Input<bool>? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Input("forceUpdateTag")]
        public Input<string>? ForceUpdateTag { get; set; }

        /// <summary>
        /// The name of the extension.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Input("protectedSettings")]
        public Input<object>? ProtectedSettings { get; set; }

        [Input("provisionAfterExtensions")]
        private InputList<string>? _provisionAfterExtensions;

        /// <summary>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </summary>
        public InputList<string> ProvisionAfterExtensions
        {
            get => _provisionAfterExtensions ?? (_provisionAfterExtensions = new InputList<string>());
            set => _provisionAfterExtensions = value;
        }

        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        [Input("publisher")]
        public Input<string>? Publisher { get; set; }

        /// <summary>
        /// Json formatted public settings for the extension.
        /// </summary>
        [Input("settings")]
        public Input<object>? Settings { get; set; }

        /// <summary>
        /// Specifies the type of the extension; an example is "CustomScriptExtension".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        [Input("typeHandlerVersion")]
        public Input<string>? TypeHandlerVersion { get; set; }

        public VirtualMachineScaleSetExtensionArgs()
        {
        }
    }
}
