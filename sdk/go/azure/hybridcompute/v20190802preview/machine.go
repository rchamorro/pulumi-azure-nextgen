// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190802preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Describes a hybrid machine.
type Machine struct {
	pulumi.CustomResourceState

	// The hybrid machine agent full version.
	AgentVersion pulumi.StringOutput `pulumi:"agentVersion"`
	// Public Key that the client provides to be used during initial resource onboarding
	ClientPublicKey pulumi.StringPtrOutput `pulumi:"clientPublicKey"`
	// Specifies the hybrid machine display name.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Details about the error state.
	ErrorDetails ErrorDetailResponseArrayOutput `pulumi:"errorDetails"`
	// Machine Extensions information
	Extensions MachineExtensionInstanceViewResponseArrayOutput `pulumi:"extensions"`
	// The time of the last status change.
	LastStatusChange pulumi.StringOutput `pulumi:"lastStatusChange"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Specifies the hybrid machine FQDN.
	MachineFqdn pulumi.StringOutput `pulumi:"machineFqdn"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The Operating System running on the hybrid machine.
	OsName pulumi.StringPtrOutput `pulumi:"osName"`
	// Specifies the operating system settings for the hybrid machine.
	OsProfile OSProfileResponseOutput `pulumi:"osProfile"`
	// The version of Operating System running on the hybrid machine.
	OsVersion pulumi.StringPtrOutput `pulumi:"osVersion"`
	// Resource's Physical Location
	PhysicalLocation pulumi.StringPtrOutput `pulumi:"physicalLocation"`
	// The identity's principal id.
	PrincipalId pulumi.StringOutput `pulumi:"principalId"`
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The status of the hybrid machine agent.
	Status pulumi.StringOutput `pulumi:"status"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The identity's tenant id.
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Specifies the hybrid machine unique ID.
	VmId pulumi.StringOutput `pulumi:"vmId"`
}

// NewMachine registers a new resource with the given unique name, arguments, and options.
func NewMachine(ctx *pulumi.Context,
	name string, args *MachineArgs, opts ...pulumi.ResourceOption) (*Machine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/latest:Machine"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/v20190318preview:Machine"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/v20191212:Machine"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/v20200730preview:Machine"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/v20200802:Machine"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybridcompute/v20200815preview:Machine"),
		},
	})
	opts = append(opts, aliases)
	var resource Machine
	err := ctx.RegisterResource("azure-nextgen:hybridcompute/v20190802preview:Machine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMachine gets an existing Machine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMachine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MachineState, opts ...pulumi.ResourceOption) (*Machine, error) {
	var resource Machine
	err := ctx.ReadResource("azure-nextgen:hybridcompute/v20190802preview:Machine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Machine resources.
type machineState struct {
	// The hybrid machine agent full version.
	AgentVersion *string `pulumi:"agentVersion"`
	// Public Key that the client provides to be used during initial resource onboarding
	ClientPublicKey *string `pulumi:"clientPublicKey"`
	// Specifies the hybrid machine display name.
	DisplayName *string `pulumi:"displayName"`
	// Details about the error state.
	ErrorDetails []ErrorDetailResponse `pulumi:"errorDetails"`
	// Machine Extensions information
	Extensions []MachineExtensionInstanceViewResponse `pulumi:"extensions"`
	// The time of the last status change.
	LastStatusChange *string `pulumi:"lastStatusChange"`
	// Resource location
	Location *string `pulumi:"location"`
	// Specifies the hybrid machine FQDN.
	MachineFqdn *string `pulumi:"machineFqdn"`
	// Resource name
	Name *string `pulumi:"name"`
	// The Operating System running on the hybrid machine.
	OsName *string `pulumi:"osName"`
	// Specifies the operating system settings for the hybrid machine.
	OsProfile *OSProfileResponse `pulumi:"osProfile"`
	// The version of Operating System running on the hybrid machine.
	OsVersion *string `pulumi:"osVersion"`
	// Resource's Physical Location
	PhysicalLocation *string `pulumi:"physicalLocation"`
	// The identity's principal id.
	PrincipalId *string `pulumi:"principalId"`
	// The provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The status of the hybrid machine agent.
	Status *string `pulumi:"status"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// The identity's tenant id.
	TenantId *string `pulumi:"tenantId"`
	// Resource type
	Type *string `pulumi:"type"`
	// Specifies the hybrid machine unique ID.
	VmId *string `pulumi:"vmId"`
}

type MachineState struct {
	// The hybrid machine agent full version.
	AgentVersion pulumi.StringPtrInput
	// Public Key that the client provides to be used during initial resource onboarding
	ClientPublicKey pulumi.StringPtrInput
	// Specifies the hybrid machine display name.
	DisplayName pulumi.StringPtrInput
	// Details about the error state.
	ErrorDetails ErrorDetailResponseArrayInput
	// Machine Extensions information
	Extensions MachineExtensionInstanceViewResponseArrayInput
	// The time of the last status change.
	LastStatusChange pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Specifies the hybrid machine FQDN.
	MachineFqdn pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// The Operating System running on the hybrid machine.
	OsName pulumi.StringPtrInput
	// Specifies the operating system settings for the hybrid machine.
	OsProfile OSProfileResponsePtrInput
	// The version of Operating System running on the hybrid machine.
	OsVersion pulumi.StringPtrInput
	// Resource's Physical Location
	PhysicalLocation pulumi.StringPtrInput
	// The identity's principal id.
	PrincipalId pulumi.StringPtrInput
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// The status of the hybrid machine agent.
	Status pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// The identity's tenant id.
	TenantId pulumi.StringPtrInput
	// Resource type
	Type pulumi.StringPtrInput
	// Specifies the hybrid machine unique ID.
	VmId pulumi.StringPtrInput
}

func (MachineState) ElementType() reflect.Type {
	return reflect.TypeOf((*machineState)(nil)).Elem()
}

type machineArgs struct {
	// Public Key that the client provides to be used during initial resource onboarding
	ClientPublicKey *string `pulumi:"clientPublicKey"`
	// Machine Extensions information
	Extensions []MachineExtensionInstanceView `pulumi:"extensions"`
	// Resource location
	Location *string `pulumi:"location"`
	// The name of the hybrid machine.
	Name string `pulumi:"name"`
	// The Operating System running on the hybrid machine.
	OsName *string `pulumi:"osName"`
	// The version of Operating System running on the hybrid machine.
	OsVersion *string `pulumi:"osVersion"`
	// Resource's Physical Location
	PhysicalLocation *string `pulumi:"physicalLocation"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// The identity type.
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a Machine resource.
type MachineArgs struct {
	// Public Key that the client provides to be used during initial resource onboarding
	ClientPublicKey pulumi.StringPtrInput
	// Machine Extensions information
	Extensions MachineExtensionInstanceViewArrayInput
	// Resource location
	Location pulumi.StringPtrInput
	// The name of the hybrid machine.
	Name pulumi.StringInput
	// The Operating System running on the hybrid machine.
	OsName pulumi.StringPtrInput
	// The version of Operating System running on the hybrid machine.
	OsVersion pulumi.StringPtrInput
	// Resource's Physical Location
	PhysicalLocation pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// The identity type.
	Type pulumi.StringPtrInput
}

func (MachineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*machineArgs)(nil)).Elem()
}

type MachineInput interface {
	pulumi.Input

	ToMachineOutput() MachineOutput
	ToMachineOutputWithContext(ctx context.Context) MachineOutput
}

func (*Machine) ElementType() reflect.Type {
	return reflect.TypeOf((*Machine)(nil))
}

func (i *Machine) ToMachineOutput() MachineOutput {
	return i.ToMachineOutputWithContext(context.Background())
}

func (i *Machine) ToMachineOutputWithContext(ctx context.Context) MachineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MachineOutput)
}

type MachineOutput struct {
	*pulumi.OutputState
}

func (MachineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Machine)(nil))
}

func (o MachineOutput) ToMachineOutput() MachineOutput {
	return o
}

func (o MachineOutput) ToMachineOutputWithContext(ctx context.Context) MachineOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MachineOutput{})
}
