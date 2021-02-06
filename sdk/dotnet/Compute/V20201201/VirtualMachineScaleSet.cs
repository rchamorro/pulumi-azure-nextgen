// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201
{
    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:compute/v20201201:VirtualMachineScaleSet")]
    public partial class VirtualMachineScaleSet : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
        /// </summary>
        [Output("additionalCapabilities")]
        public Output<Outputs.AdditionalCapabilitiesResponse?> AdditionalCapabilities { get; private set; } = null!;

        /// <summary>
        /// Policy for automatic repairs.
        /// </summary>
        [Output("automaticRepairsPolicy")]
        public Output<Outputs.AutomaticRepairsPolicyResponse?> AutomaticRepairsPolicy { get; private set; } = null!;

        /// <summary>
        /// When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
        /// </summary>
        [Output("doNotRunExtensionsOnOverprovisionedVMs")]
        public Output<bool?> DoNotRunExtensionsOnOverprovisionedVMs { get; private set; } = null!;

        /// <summary>
        /// The extended location of the Virtual Machine Scale Set.
        /// </summary>
        [Output("extendedLocation")]
        public Output<Outputs.ExtendedLocationResponse?> ExtendedLocation { get; private set; } = null!;

        /// <summary>
        /// Specifies information about the dedicated host group that the virtual machine scale set resides in. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// </summary>
        [Output("hostGroup")]
        public Output<Outputs.SubResourceResponse?> HostGroup { get; private set; } = null!;

        /// <summary>
        /// The identity of the virtual machine scale set, if configured.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.VirtualMachineScaleSetIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the orchestration mode for the virtual machine scale set.
        /// </summary>
        [Output("orchestrationMode")]
        public Output<string?> OrchestrationMode { get; private set; } = null!;

        /// <summary>
        /// Specifies whether the Virtual Machine Scale Set should be overprovisioned.
        /// </summary>
        [Output("overprovision")]
        public Output<bool?> Overprovision { get; private set; } = null!;

        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**.
        /// </summary>
        [Output("plan")]
        public Output<Outputs.PlanResponse?> Plan { get; private set; } = null!;

        /// <summary>
        /// Fault Domain count for each placement group.
        /// </summary>
        [Output("platformFaultDomainCount")]
        public Output<int?> PlatformFaultDomainCount { get; private set; } = null!;

        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01.
        /// </summary>
        [Output("proximityPlacementGroup")]
        public Output<Outputs.SubResourceResponse?> ProximityPlacementGroup { get; private set; } = null!;

        /// <summary>
        /// Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in.
        /// </summary>
        [Output("scaleInPolicy")]
        public Output<Outputs.ScaleInPolicyResponse?> ScaleInPolicy { get; private set; } = null!;

        /// <summary>
        /// When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        [Output("singlePlacementGroup")]
        public Output<bool?> SinglePlacementGroup { get; private set; } = null!;

        /// <summary>
        /// The virtual machine scale set sku.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Specifies the ID which uniquely identifies a Virtual Machine Scale Set.
        /// </summary>
        [Output("uniqueId")]
        public Output<string> UniqueId { get; private set; } = null!;

        /// <summary>
        /// The upgrade policy.
        /// </summary>
        [Output("upgradePolicy")]
        public Output<Outputs.UpgradePolicyResponse?> UpgradePolicy { get; private set; } = null!;

        /// <summary>
        /// The virtual machine profile.
        /// </summary>
        [Output("virtualMachineProfile")]
        public Output<Outputs.VirtualMachineScaleSetVMProfileResponse?> VirtualMachineProfile { get; private set; } = null!;

        /// <summary>
        /// Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
        /// </summary>
        [Output("zoneBalance")]
        public Output<bool?> ZoneBalance { get; private set; } = null!;

        /// <summary>
        /// The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set
        /// </summary>
        [Output("zones")]
        public Output<ImmutableArray<string>> Zones { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualMachineScaleSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualMachineScaleSet(string name, VirtualMachineScaleSetArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20201201:VirtualMachineScaleSet", name, args ?? new VirtualMachineScaleSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualMachineScaleSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20201201:VirtualMachineScaleSet", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:compute/latest:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20150615:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20160330:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20160430preview:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20170330:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20171201:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20180401:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20180601:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20181001:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190301:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190701:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20191201:VirtualMachineScaleSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20200601:VirtualMachineScaleSet"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualMachineScaleSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualMachineScaleSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualMachineScaleSet(name, id, options);
        }
    }

    public sealed class VirtualMachineScaleSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
        /// </summary>
        [Input("additionalCapabilities")]
        public Input<Inputs.AdditionalCapabilitiesArgs>? AdditionalCapabilities { get; set; }

        /// <summary>
        /// Policy for automatic repairs.
        /// </summary>
        [Input("automaticRepairsPolicy")]
        public Input<Inputs.AutomaticRepairsPolicyArgs>? AutomaticRepairsPolicy { get; set; }

        /// <summary>
        /// When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
        /// </summary>
        [Input("doNotRunExtensionsOnOverprovisionedVMs")]
        public Input<bool>? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

        /// <summary>
        /// The extended location of the Virtual Machine Scale Set.
        /// </summary>
        [Input("extendedLocation")]
        public Input<Inputs.ExtendedLocationArgs>? ExtendedLocation { get; set; }

        /// <summary>
        /// Specifies information about the dedicated host group that the virtual machine scale set resides in. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.
        /// </summary>
        [Input("hostGroup")]
        public Input<Inputs.SubResourceArgs>? HostGroup { get; set; }

        /// <summary>
        /// The identity of the virtual machine scale set, if configured.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.VirtualMachineScaleSetIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the orchestration mode for the virtual machine scale set.
        /// </summary>
        [Input("orchestrationMode")]
        public Input<Pulumi.AzureNextGen.Compute.V20201201.OrchestrationMode>? OrchestrationMode { get; set; }

        /// <summary>
        /// Specifies whether the Virtual Machine Scale Set should be overprovisioned.
        /// </summary>
        [Input("overprovision")]
        public Input<bool>? Overprovision { get; set; }

        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**.
        /// </summary>
        [Input("plan")]
        public Input<Inputs.PlanArgs>? Plan { get; set; }

        /// <summary>
        /// Fault Domain count for each placement group.
        /// </summary>
        [Input("platformFaultDomainCount")]
        public Input<int>? PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01.
        /// </summary>
        [Input("proximityPlacementGroup")]
        public Input<Inputs.SubResourceArgs>? ProximityPlacementGroup { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in.
        /// </summary>
        [Input("scaleInPolicy")]
        public Input<Inputs.ScaleInPolicyArgs>? ScaleInPolicy { get; set; }

        /// <summary>
        /// When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        [Input("singlePlacementGroup")]
        public Input<bool>? SinglePlacementGroup { get; set; }

        /// <summary>
        /// The virtual machine scale set sku.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The upgrade policy.
        /// </summary>
        [Input("upgradePolicy")]
        public Input<Inputs.UpgradePolicyArgs>? UpgradePolicy { get; set; }

        /// <summary>
        /// The virtual machine profile.
        /// </summary>
        [Input("virtualMachineProfile")]
        public Input<Inputs.VirtualMachineScaleSetVMProfileArgs>? VirtualMachineProfile { get; set; }

        /// <summary>
        /// The name of the VM scale set to create or update.
        /// </summary>
        [Input("vmScaleSetName", required: true)]
        public Input<string> VmScaleSetName { get; set; } = null!;

        /// <summary>
        /// Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
        /// </summary>
        [Input("zoneBalance")]
        public Input<bool>? ZoneBalance { get; set; }

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public VirtualMachineScaleSetArgs()
        {
        }
    }
}
