// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160330

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Describes a Virtual Machine.
type VirtualMachine struct {
	pulumi.CustomResourceState

	// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
	AvailabilitySet SubResourceResponsePtrOutput `pulumi:"availabilitySet"`
	// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
	DiagnosticsProfile DiagnosticsProfileResponsePtrOutput `pulumi:"diagnosticsProfile"`
	// Specifies the hardware settings for the virtual machine.
	HardwareProfile HardwareProfileResponsePtrOutput `pulumi:"hardwareProfile"`
	// The identity of the virtual machine, if configured.
	Identity VirtualMachineIdentityResponsePtrOutput `pulumi:"identity"`
	// The virtual machine instance view.
	InstanceView VirtualMachineInstanceViewResponseOutput `pulumi:"instanceView"`
	// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
	LicenseType pulumi.StringPtrOutput `pulumi:"licenseType"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the network interfaces of the virtual machine.
	NetworkProfile NetworkProfileResponsePtrOutput `pulumi:"networkProfile"`
	// Specifies the operating system settings for the virtual machine.
	OsProfile OSProfileResponsePtrOutput `pulumi:"osProfile"`
	// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
	Plan PlanResponsePtrOutput `pulumi:"plan"`
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The virtual machine child extension resources.
	Resources VirtualMachineExtensionResponseArrayOutput `pulumi:"resources"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile StorageProfileResponsePtrOutput `pulumi:"storageProfile"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands.
	VmId pulumi.StringOutput `pulumi:"vmId"`
}

// NewVirtualMachine registers a new resource with the given unique name, arguments, and options.
func NewVirtualMachine(ctx *pulumi.Context,
	name string, args *VirtualMachineArgs, opts ...pulumi.ResourceOption) (*VirtualMachine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VmName == nil {
		return nil, errors.New("invalid value for required argument 'VmName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20150615:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20160430preview:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20170330:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20171201:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180401:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180601:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20181001:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190301:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190701:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191201:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200601:VirtualMachine"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20201201:VirtualMachine"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualMachine
	err := ctx.RegisterResource("azure-nextgen:compute/v20160330:VirtualMachine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualMachine gets an existing VirtualMachine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualMachine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualMachineState, opts ...pulumi.ResourceOption) (*VirtualMachine, error) {
	var resource VirtualMachine
	err := ctx.ReadResource("azure-nextgen:compute/v20160330:VirtualMachine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualMachine resources.
type virtualMachineState struct {
	// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
	AvailabilitySet *SubResourceResponse `pulumi:"availabilitySet"`
	// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
	DiagnosticsProfile *DiagnosticsProfileResponse `pulumi:"diagnosticsProfile"`
	// Specifies the hardware settings for the virtual machine.
	HardwareProfile *HardwareProfileResponse `pulumi:"hardwareProfile"`
	// The identity of the virtual machine, if configured.
	Identity *VirtualMachineIdentityResponse `pulumi:"identity"`
	// The virtual machine instance view.
	InstanceView *VirtualMachineInstanceViewResponse `pulumi:"instanceView"`
	// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
	LicenseType *string `pulumi:"licenseType"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Specifies the network interfaces of the virtual machine.
	NetworkProfile *NetworkProfileResponse `pulumi:"networkProfile"`
	// Specifies the operating system settings for the virtual machine.
	OsProfile *OSProfileResponse `pulumi:"osProfile"`
	// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
	Plan *PlanResponse `pulumi:"plan"`
	// The provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The virtual machine child extension resources.
	Resources []VirtualMachineExtensionResponse `pulumi:"resources"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile *StorageProfileResponse `pulumi:"storageProfile"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands.
	VmId *string `pulumi:"vmId"`
}

type VirtualMachineState struct {
	// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
	AvailabilitySet SubResourceResponsePtrInput
	// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
	DiagnosticsProfile DiagnosticsProfileResponsePtrInput
	// Specifies the hardware settings for the virtual machine.
	HardwareProfile HardwareProfileResponsePtrInput
	// The identity of the virtual machine, if configured.
	Identity VirtualMachineIdentityResponsePtrInput
	// The virtual machine instance view.
	InstanceView VirtualMachineInstanceViewResponsePtrInput
	// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
	LicenseType pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Specifies the network interfaces of the virtual machine.
	NetworkProfile NetworkProfileResponsePtrInput
	// Specifies the operating system settings for the virtual machine.
	OsProfile OSProfileResponsePtrInput
	// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
	Plan PlanResponsePtrInput
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// The virtual machine child extension resources.
	Resources VirtualMachineExtensionResponseArrayInput
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile StorageProfileResponsePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands.
	VmId pulumi.StringPtrInput
}

func (VirtualMachineState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineState)(nil)).Elem()
}

type virtualMachineArgs struct {
	// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
	AvailabilitySet *SubResource `pulumi:"availabilitySet"`
	// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
	DiagnosticsProfile *DiagnosticsProfile `pulumi:"diagnosticsProfile"`
	// Specifies the hardware settings for the virtual machine.
	HardwareProfile *HardwareProfile `pulumi:"hardwareProfile"`
	// The identity of the virtual machine, if configured.
	Identity *VirtualMachineIdentity `pulumi:"identity"`
	// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
	LicenseType *string `pulumi:"licenseType"`
	// Resource location
	Location *string `pulumi:"location"`
	// Specifies the network interfaces of the virtual machine.
	NetworkProfile *NetworkProfile `pulumi:"networkProfile"`
	// Specifies the operating system settings for the virtual machine.
	OsProfile *OSProfile `pulumi:"osProfile"`
	// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
	Plan *Plan `pulumi:"plan"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile *StorageProfile `pulumi:"storageProfile"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// The name of the virtual machine.
	VmName string `pulumi:"vmName"`
}

// The set of arguments for constructing a VirtualMachine resource.
type VirtualMachineArgs struct {
	// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). <br><br> For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
	AvailabilitySet SubResourcePtrInput
	// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
	DiagnosticsProfile DiagnosticsProfilePtrInput
	// Specifies the hardware settings for the virtual machine.
	HardwareProfile HardwareProfilePtrInput
	// The identity of the virtual machine, if configured.
	Identity VirtualMachineIdentityPtrInput
	// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. <br><br> Possible values are: <br><br> Windows_Client <br><br> Windows_Server <br><br> If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) <br><br> Minimum api-version: 2015-06-15
	LicenseType pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Specifies the network interfaces of the virtual machine.
	NetworkProfile NetworkProfilePtrInput
	// Specifies the operating system settings for the virtual machine.
	OsProfile OSProfilePtrInput
	// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started ->**. Enter any required information and then click **Save**.
	Plan PlanPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile StorageProfilePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// The name of the virtual machine.
	VmName pulumi.StringInput
}

func (VirtualMachineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineArgs)(nil)).Elem()
}

type VirtualMachineInput interface {
	pulumi.Input

	ToVirtualMachineOutput() VirtualMachineOutput
	ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput
}

func (*VirtualMachine) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMachine)(nil))
}

func (i *VirtualMachine) ToVirtualMachineOutput() VirtualMachineOutput {
	return i.ToVirtualMachineOutputWithContext(context.Background())
}

func (i *VirtualMachine) ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineOutput)
}

type VirtualMachineOutput struct {
	*pulumi.OutputState
}

func (VirtualMachineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMachine)(nil))
}

func (o VirtualMachineOutput) ToVirtualMachineOutput() VirtualMachineOutput {
	return o
}

func (o VirtualMachineOutput) ToVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualMachineOutput{})
}
