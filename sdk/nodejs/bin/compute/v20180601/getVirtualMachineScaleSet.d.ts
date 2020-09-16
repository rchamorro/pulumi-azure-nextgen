import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVirtualMachineScaleSet(args: GetVirtualMachineScaleSetArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualMachineScaleSetResult>;
export interface GetVirtualMachineScaleSetArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VM scale set.
     */
    readonly vmScaleSetName: string;
}
/**
 * Describes a Virtual Machine Scale Set.
 */
export interface GetVirtualMachineScaleSetResult {
    /**
     * The identity of the virtual machine scale set, if configured.
     */
    readonly identity?: outputs.compute.v20180601.VirtualMachineScaleSetIdentityResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Specifies whether the Virtual Machine Scale Set should be overprovisioned.
     */
    readonly overprovision?: boolean;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    readonly plan?: outputs.compute.v20180601.PlanResponse;
    /**
     * Fault Domain count for each placement group.
     */
    readonly platformFaultDomainCount?: number;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. <br><br>Minimum api-version: 2018-04-01.
     */
    readonly proximityPlacementGroup?: outputs.compute.v20180601.SubResourceResponse;
    /**
     * When true this limits the scale set to a single placement group, of max size 100 virtual machines.
     */
    readonly singlePlacementGroup?: boolean;
    /**
     * The virtual machine scale set sku.
     */
    readonly sku?: outputs.compute.v20180601.SkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Specifies the ID which uniquely identifies a Virtual Machine Scale Set.
     */
    readonly uniqueId: string;
    /**
     * The upgrade policy.
     */
    readonly upgradePolicy?: outputs.compute.v20180601.UpgradePolicyResponse;
    /**
     * The virtual machine profile.
     */
    readonly virtualMachineProfile?: outputs.compute.v20180601.VirtualMachineScaleSetVMProfileResponse;
    /**
     * Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage.
     */
    readonly zoneBalance?: boolean;
    /**
     * The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set.
     */
    readonly zones?: string[];
}