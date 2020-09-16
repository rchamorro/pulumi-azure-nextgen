import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Describes a virtual machine scale set virtual machine.
 */
export declare class VirtualMachineScaleSetVM extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineScaleSetVM resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineScaleSetVM;
    /**
     * Returns true if the given object is an instance of VirtualMachineScaleSetVM.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is VirtualMachineScaleSetVM;
    /**
     * Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
     */
    readonly additionalCapabilities: pulumi.Output<outputs.compute.v20191201.AdditionalCapabilitiesResponse | undefined>;
    /**
     * Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
     */
    readonly availabilitySet: pulumi.Output<outputs.compute.v20191201.SubResourceResponse | undefined>;
    /**
     * Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
     */
    readonly diagnosticsProfile: pulumi.Output<outputs.compute.v20191201.DiagnosticsProfileResponse | undefined>;
    /**
     * Specifies the hardware settings for the virtual machine.
     */
    readonly hardwareProfile: pulumi.Output<outputs.compute.v20191201.HardwareProfileResponse | undefined>;
    /**
     * The virtual machine instance ID.
     */
    readonly instanceId: pulumi.Output<string>;
    /**
     * The virtual machine instance view.
     */
    readonly instanceView: pulumi.Output<outputs.compute.v20191201.VirtualMachineScaleSetVMInstanceViewResponse>;
    /**
     * Specifies whether the latest model has been applied to the virtual machine.
     */
    readonly latestModelApplied: pulumi.Output<boolean>;
    /**
     * Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
     */
    readonly licenseType: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine.
     */
    readonly modelDefinitionApplied: pulumi.Output<string>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Specifies the network interfaces of the virtual machine.
     */
    readonly networkProfile: pulumi.Output<outputs.compute.v20191201.NetworkProfileResponse | undefined>;
    /**
     * Specifies the network profile configuration of the virtual machine.
     */
    readonly networkProfileConfiguration: pulumi.Output<outputs.compute.v20191201.VirtualMachineScaleSetVMNetworkProfileConfigurationResponse | undefined>;
    /**
     * Specifies the operating system settings for the virtual machine.
     */
    readonly osProfile: pulumi.Output<outputs.compute.v20191201.OSProfileResponse | undefined>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    readonly plan: pulumi.Output<outputs.compute.v20191201.PlanResponse | undefined>;
    /**
     * Specifies the protection policy of the virtual machine.
     */
    readonly protectionPolicy: pulumi.Output<outputs.compute.v20191201.VirtualMachineScaleSetVMProtectionPolicyResponse | undefined>;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The virtual machine child extension resources.
     */
    readonly resources: pulumi.Output<outputs.compute.v20191201.VirtualMachineExtensionResponse[]>;
    /**
     * The virtual machine SKU.
     */
    readonly sku: pulumi.Output<outputs.compute.v20191201.SkuResponse>;
    /**
     * Specifies the storage settings for the virtual machine disks.
     */
    readonly storageProfile: pulumi.Output<outputs.compute.v20191201.StorageProfileResponse | undefined>;
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
     * Azure VM unique ID.
     */
    readonly vmId: pulumi.Output<string>;
    /**
     * The virtual machine zones.
     */
    readonly zones: pulumi.Output<string[]>;
    /**
     * Create a VirtualMachineScaleSetVM resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineScaleSetVMArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a VirtualMachineScaleSetVM resource.
 */
export interface VirtualMachineScaleSetVMArgs {
    /**
     * Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
     */
    readonly additionalCapabilities?: pulumi.Input<inputs.compute.v20191201.AdditionalCapabilities>;
    /**
     * Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
     */
    readonly availabilitySet?: pulumi.Input<inputs.compute.v20191201.SubResource>;
    /**
     * Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
     */
    readonly diagnosticsProfile?: pulumi.Input<inputs.compute.v20191201.DiagnosticsProfile>;
    /**
     * Specifies the hardware settings for the virtual machine.
     */
    readonly hardwareProfile?: pulumi.Input<inputs.compute.v20191201.HardwareProfile>;
    /**
     * The instance ID of the virtual machine.
     */
    readonly instanceId: pulumi.Input<string>;
    /**
     * Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies the network interfaces of the virtual machine.
     */
    readonly networkProfile?: pulumi.Input<inputs.compute.v20191201.NetworkProfile>;
    /**
     * Specifies the network profile configuration of the virtual machine.
     */
    readonly networkProfileConfiguration?: pulumi.Input<inputs.compute.v20191201.VirtualMachineScaleSetVMNetworkProfileConfiguration>;
    /**
     * Specifies the operating system settings for the virtual machine.
     */
    readonly osProfile?: pulumi.Input<inputs.compute.v20191201.OSProfile>;
    /**
     * Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
     */
    readonly plan?: pulumi.Input<inputs.compute.v20191201.Plan>;
    /**
     * Specifies the protection policy of the virtual machine.
     */
    readonly protectionPolicy?: pulumi.Input<inputs.compute.v20191201.VirtualMachineScaleSetVMProtectionPolicy>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the storage settings for the virtual machine disks.
     */
    readonly storageProfile?: pulumi.Input<inputs.compute.v20191201.StorageProfile>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The name of the VM scale set where the extension should be create or updated.
     */
    readonly vmScaleSetName: pulumi.Input<string>;
}