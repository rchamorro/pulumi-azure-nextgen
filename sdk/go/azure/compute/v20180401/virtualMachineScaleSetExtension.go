// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180401

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Describes a Virtual Machine Scale Set Extension.
type VirtualMachineScaleSetExtension struct {
	pulumi.CustomResourceState

	// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
	AutoUpgradeMinorVersion pulumi.BoolPtrOutput `pulumi:"autoUpgradeMinorVersion"`
	// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
	ForceUpdateTag pulumi.StringPtrOutput `pulumi:"forceUpdateTag"`
	// The name of the extension.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
	ProtectedSettings pulumi.AnyOutput `pulumi:"protectedSettings"`
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The name of the extension handler publisher.
	Publisher pulumi.StringPtrOutput `pulumi:"publisher"`
	// Json formatted public settings for the extension.
	Settings pulumi.AnyOutput `pulumi:"settings"`
	// Specifies the type of the extension; an example is "CustomScriptExtension".
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// Specifies the version of the script handler.
	TypeHandlerVersion pulumi.StringPtrOutput `pulumi:"typeHandlerVersion"`
}

// NewVirtualMachineScaleSetExtension registers a new resource with the given unique name, arguments, and options.
func NewVirtualMachineScaleSetExtension(ctx *pulumi.Context,
	name string, args *VirtualMachineScaleSetExtensionArgs, opts ...pulumi.ResourceOption) (*VirtualMachineScaleSetExtension, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VmScaleSetName == nil {
		return nil, errors.New("missing required argument 'VmScaleSetName'")
	}
	if args == nil || args.VmssExtensionName == nil {
		return nil, errors.New("missing required argument 'VmssExtensionName'")
	}
	if args == nil {
		args = &VirtualMachineScaleSetExtensionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20170330:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20171201:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180601:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20181001:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190301:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190701:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191201:VirtualMachineScaleSetExtension"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200601:VirtualMachineScaleSetExtension"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualMachineScaleSetExtension
	err := ctx.RegisterResource("azure-nextgen:compute/v20180401:VirtualMachineScaleSetExtension", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualMachineScaleSetExtension gets an existing VirtualMachineScaleSetExtension resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualMachineScaleSetExtension(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualMachineScaleSetExtensionState, opts ...pulumi.ResourceOption) (*VirtualMachineScaleSetExtension, error) {
	var resource VirtualMachineScaleSetExtension
	err := ctx.ReadResource("azure-nextgen:compute/v20180401:VirtualMachineScaleSetExtension", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualMachineScaleSetExtension resources.
type virtualMachineScaleSetExtensionState struct {
	// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
	AutoUpgradeMinorVersion *bool `pulumi:"autoUpgradeMinorVersion"`
	// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
	ForceUpdateTag *string `pulumi:"forceUpdateTag"`
	// The name of the extension.
	Name *string `pulumi:"name"`
	// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
	ProtectedSettings interface{} `pulumi:"protectedSettings"`
	// The provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the extension handler publisher.
	Publisher *string `pulumi:"publisher"`
	// Json formatted public settings for the extension.
	Settings interface{} `pulumi:"settings"`
	// Specifies the type of the extension; an example is "CustomScriptExtension".
	Type *string `pulumi:"type"`
	// Specifies the version of the script handler.
	TypeHandlerVersion *string `pulumi:"typeHandlerVersion"`
}

type VirtualMachineScaleSetExtensionState struct {
	// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
	AutoUpgradeMinorVersion pulumi.BoolPtrInput
	// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
	ForceUpdateTag pulumi.StringPtrInput
	// The name of the extension.
	Name pulumi.StringPtrInput
	// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
	ProtectedSettings pulumi.Input
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// The name of the extension handler publisher.
	Publisher pulumi.StringPtrInput
	// Json formatted public settings for the extension.
	Settings pulumi.Input
	// Specifies the type of the extension; an example is "CustomScriptExtension".
	Type pulumi.StringPtrInput
	// Specifies the version of the script handler.
	TypeHandlerVersion pulumi.StringPtrInput
}

func (VirtualMachineScaleSetExtensionState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineScaleSetExtensionState)(nil)).Elem()
}

type virtualMachineScaleSetExtensionArgs struct {
	// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
	AutoUpgradeMinorVersion *bool `pulumi:"autoUpgradeMinorVersion"`
	// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
	ForceUpdateTag *string `pulumi:"forceUpdateTag"`
	// The name of the extension.
	Name *string `pulumi:"name"`
	// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
	ProtectedSettings interface{} `pulumi:"protectedSettings"`
	// The name of the extension handler publisher.
	Publisher *string `pulumi:"publisher"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Json formatted public settings for the extension.
	Settings interface{} `pulumi:"settings"`
	// Specifies the type of the extension; an example is "CustomScriptExtension".
	Type *string `pulumi:"type"`
	// Specifies the version of the script handler.
	TypeHandlerVersion *string `pulumi:"typeHandlerVersion"`
	// The name of the VM scale set where the extension should be create or updated.
	VmScaleSetName string `pulumi:"vmScaleSetName"`
	// The name of the VM scale set extension.
	VmssExtensionName string `pulumi:"vmssExtensionName"`
}

// The set of arguments for constructing a VirtualMachineScaleSetExtension resource.
type VirtualMachineScaleSetExtensionArgs struct {
	// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
	AutoUpgradeMinorVersion pulumi.BoolPtrInput
	// If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.
	ForceUpdateTag pulumi.StringPtrInput
	// The name of the extension.
	Name pulumi.StringPtrInput
	// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
	ProtectedSettings pulumi.Input
	// The name of the extension handler publisher.
	Publisher pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Json formatted public settings for the extension.
	Settings pulumi.Input
	// Specifies the type of the extension; an example is "CustomScriptExtension".
	Type pulumi.StringPtrInput
	// Specifies the version of the script handler.
	TypeHandlerVersion pulumi.StringPtrInput
	// The name of the VM scale set where the extension should be create or updated.
	VmScaleSetName pulumi.StringInput
	// The name of the VM scale set extension.
	VmssExtensionName pulumi.StringInput
}

func (VirtualMachineScaleSetExtensionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineScaleSetExtensionArgs)(nil)).Elem()
}
