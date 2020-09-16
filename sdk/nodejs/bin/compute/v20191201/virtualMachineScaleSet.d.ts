import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Describes a Virtual Machine Scale Set.
 */
export declare class VirtualMachineScaleSet extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineScaleSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineScaleSet;
    /**
     * Returns true if the given object is an instance of VirtualMachineScaleSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is VirtualMachineScaleSet;
    /**
     * Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
     */
    readonly additionalCapabilities: pulumi.Output<outputs.compute.v20191201.AdditionalCapabilitiesResponse | undefined>;
    /**
     * Policy for automatic repairs.
     */
    readonly automaticRepairsPolicy: pulumi.Output<outputs.compute.v20191201.AutomaticRepairsPolicyResponse | undefined>;
    /**
     * When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
     */
    readonly doNotRunExtensionsOnOverprovisionedVMs: pulumi.Output<boolean | undefined>;
    /**
     * The identity of the virtual machine scale set, if configured.
     */
    readonly identity: pulumi.Output<outputs.compute.v20191201.VirtualMachineScaleSetIdentityResponse | undefined>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Specifies whether the Virtual Machine Scale Set should be overprovisioned.
     */
    readonly overprovision: pulumi.Output<boolean | undefined>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    readonly plan: pulumi.Output<outputs.compute.v20191201.PlanResponse | undefined>;
    /**
     * Fault Domain count for each placement group.
     */
    readonly platformFaultDomainCount: pulumi.Output<number | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. <br><br>Minimum api-version: 2018-04-01.
     */
    readonly proximityPlacementGroup: pulumi.Output<outputs.compute.v20191201.SubResourceResponse | undefined>;
    /**
     * Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in.
     */
    readonly scaleInPolicy: pulumi.Output<outputs.compute.v20191201.ScaleInPolicyResponse | undefined>;
    /**
     * When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
     */
    readonly singlePlacementGroup: pulumi.Output<boolean | undefined>;
    /**
     * The virtual machine scale set sku.
     */
    readonly sku: pulumi.Output<outputs.compute.v20191201.SkuResponse | undefined>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Specifies the ID which uniquely identifies a Virtual Machine Scale Set.
     */
    readonly uniqueId: pulumi.Output<string>;
    /**
     * The upgrade policy.
     */
    readonly upgradePolicy: pulumi.Output<outputs.compute.v20191201.UpgradePolicyResponse | undefined>;
    /**
     * The virtual machine profile.
     */
    readonly virtualMachineProfile: pulumi.Output<outputs.compute.v20191201.VirtualMachineScaleSetVMProfileResponse | undefined>;
    /**
     * Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
     */
    readonly zoneBalance: pulumi.Output<boolean | undefined>;
    /**
     * The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set
     */
    readonly zones: pulumi.Output<string[] | undefined>;
    /**
     * Create a VirtualMachineScaleSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineScaleSetArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a VirtualMachineScaleSet resource.
 */
export interface VirtualMachineScaleSetArgs {
    /**
     * Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
     */
    readonly additionalCapabilities?: pulumi.Input<inputs.compute.v20191201.AdditionalCapabilities>;
    /**
     * Policy for automatic repairs.
     */
    readonly automaticRepairsPolicy?: pulumi.Input<inputs.compute.v20191201.AutomaticRepairsPolicy>;
    /**
     * When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
     */
    readonly doNotRunExtensionsOnOverprovisionedVMs?: pulumi.Input<boolean>;
    /**
     * The identity of the virtual machine scale set, if configured.
     */
    readonly identity?: pulumi.Input<inputs.compute.v20191201.VirtualMachineScaleSetIdentity>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies whether the Virtual Machine Scale Set should be overprovisioned.
     */
    readonly overprovision?: pulumi.Input<boolean>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    readonly plan?: pulumi.Input<inputs.compute.v20191201.Plan>;
    /**
     * Fault Domain count for each placement group.
     */
    readonly platformFaultDomainCount?: pulumi.Input<number>;
    /**
     * Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. <br><br>Minimum api-version: 2018-04-01.
     */
    readonly proximityPlacementGroup?: pulumi.Input<inputs.compute.v20191201.SubResource>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in.
     */
    readonly scaleInPolicy?: pulumi.Input<inputs.compute.v20191201.ScaleInPolicy>;
    /**
     * When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
     */
    readonly singlePlacementGroup?: pulumi.Input<boolean>;
    /**
     * The virtual machine scale set sku.
     */
    readonly sku?: pulumi.Input<inputs.compute.v20191201.Sku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The upgrade policy.
     */
    readonly upgradePolicy?: pulumi.Input<inputs.compute.v20191201.UpgradePolicy>;
    /**
     * The virtual machine profile.
     */
    readonly virtualMachineProfile?: pulumi.Input<inputs.compute.v20191201.VirtualMachineScaleSetVMProfile>;
    /**
     * The name of the VM scale set to create or update.
     */
    readonly vmScaleSetName: pulumi.Input<string>;
    /**
     * Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
     */
    readonly zoneBalance?: pulumi.Input<boolean>;
    /**
     * The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}