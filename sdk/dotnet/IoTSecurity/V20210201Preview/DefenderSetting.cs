// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.IoTSecurity.V20210201Preview
{
    /// <summary>
    /// IoT Defender settings
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:iotsecurity/v20210201preview:DefenderSetting")]
    public partial class DefenderSetting : Pulumi.CustomResource
    {
        /// <summary>
        /// Size of the device quota (as a opposed to a Pay as You Go billing model). Value is required to be in multiples of 1000.
        /// </summary>
        [Output("deviceQuota")]
        public Output<int> DeviceQuota { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Sentinel Workspace Resource Ids
        /// </summary>
        [Output("sentinelWorkspaceResourceIds")]
        public Output<ImmutableArray<string>> SentinelWorkspaceResourceIds { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DefenderSetting resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DefenderSetting(string name, DefenderSettingArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:iotsecurity/v20210201preview:DefenderSetting", name, args ?? new DefenderSettingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DefenderSetting(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:iotsecurity/v20210201preview:DefenderSetting", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DefenderSetting resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DefenderSetting Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DefenderSetting(name, id, options);
        }
    }

    public sealed class DefenderSettingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Size of the device quota (as a opposed to a Pay as You Go billing model). Value is required to be in multiples of 1000.
        /// </summary>
        [Input("deviceQuota", required: true)]
        public Input<int> DeviceQuota { get; set; } = null!;

        [Input("sentinelWorkspaceResourceIds", required: true)]
        private InputList<string>? _sentinelWorkspaceResourceIds;

        /// <summary>
        /// Sentinel Workspace Resource Ids
        /// </summary>
        public InputList<string> SentinelWorkspaceResourceIds
        {
            get => _sentinelWorkspaceResourceIds ?? (_sentinelWorkspaceResourceIds = new InputList<string>());
            set => _sentinelWorkspaceResourceIds = value;
        }

        public DefenderSettingArgs()
        {
        }
    }
}
