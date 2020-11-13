// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150521preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A formula.
type FormulaResource struct {
	pulumi.CustomResourceState

	// The author of the formula.
	Author pulumi.StringPtrOutput `pulumi:"author"`
	// The creation date of the formula.
	CreationDate pulumi.StringPtrOutput `pulumi:"creationDate"`
	// The description of the formula.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The content of the formula.
	FormulaContent LabVirtualMachineResponsePtrOutput `pulumi:"formulaContent"`
	// The location of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The OS type of the formula.
	OsType pulumi.StringPtrOutput `pulumi:"osType"`
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmResponsePtrOutput `pulumi:"vm"`
}

// NewFormulaResource registers a new resource with the given unique name, arguments, and options.
func NewFormulaResource(ctx *pulumi.Context,
	name string, args *FormulaResourceArgs, opts ...pulumi.ResourceOption) (*FormulaResource, error) {
	if args == nil || args.LabName == nil {
		return nil, errors.New("missing required argument 'LabName'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &FormulaResourceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devtestlab/latest:FormulaResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20160515:FormulaResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20180915:FormulaResource"),
		},
	})
	opts = append(opts, aliases)
	var resource FormulaResource
	err := ctx.RegisterResource("azure-nextgen:devtestlab/v20150521preview:FormulaResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFormulaResource gets an existing FormulaResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFormulaResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FormulaResourceState, opts ...pulumi.ResourceOption) (*FormulaResource, error) {
	var resource FormulaResource
	err := ctx.ReadResource("azure-nextgen:devtestlab/v20150521preview:FormulaResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FormulaResource resources.
type formulaResourceState struct {
	// The author of the formula.
	Author *string `pulumi:"author"`
	// The creation date of the formula.
	CreationDate *string `pulumi:"creationDate"`
	// The description of the formula.
	Description *string `pulumi:"description"`
	// The content of the formula.
	FormulaContent *LabVirtualMachineResponse `pulumi:"formulaContent"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The OS type of the formula.
	OsType *string `pulumi:"osType"`
	// The provisioning status of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// Information about a VM from which a formula is to be created.
	Vm *FormulaPropertiesFromVmResponse `pulumi:"vm"`
}

type FormulaResourceState struct {
	// The author of the formula.
	Author pulumi.StringPtrInput
	// The creation date of the formula.
	CreationDate pulumi.StringPtrInput
	// The description of the formula.
	Description pulumi.StringPtrInput
	// The content of the formula.
	FormulaContent LabVirtualMachineResponsePtrInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The OS type of the formula.
	OsType pulumi.StringPtrInput
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmResponsePtrInput
}

func (FormulaResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*formulaResourceState)(nil)).Elem()
}

type formulaResourceArgs struct {
	// The author of the formula.
	Author *string `pulumi:"author"`
	// The creation date of the formula.
	CreationDate *string `pulumi:"creationDate"`
	// The description of the formula.
	Description *string `pulumi:"description"`
	// The content of the formula.
	FormulaContent *LabVirtualMachine `pulumi:"formulaContent"`
	// The identifier of the resource.
	Id *string `pulumi:"id"`
	// The name of the lab.
	LabName string `pulumi:"labName"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name string `pulumi:"name"`
	// The OS type of the formula.
	OsType *string `pulumi:"osType"`
	// The provisioning status of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// Information about a VM from which a formula is to be created.
	Vm *FormulaPropertiesFromVm `pulumi:"vm"`
}

// The set of arguments for constructing a FormulaResource resource.
type FormulaResourceArgs struct {
	// The author of the formula.
	Author pulumi.StringPtrInput
	// The creation date of the formula.
	CreationDate pulumi.StringPtrInput
	// The description of the formula.
	Description pulumi.StringPtrInput
	// The content of the formula.
	FormulaContent LabVirtualMachinePtrInput
	// The identifier of the resource.
	Id pulumi.StringPtrInput
	// The name of the lab.
	LabName pulumi.StringInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringInput
	// The OS type of the formula.
	OsType pulumi.StringPtrInput
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmPtrInput
}

func (FormulaResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*formulaResourceArgs)(nil)).Elem()
}

type FormulaResourceInput interface {
	pulumi.Input

	ToFormulaResourceOutput() FormulaResourceOutput
	ToFormulaResourceOutputWithContext(ctx context.Context) FormulaResourceOutput
}

func (FormulaResource) ElementType() reflect.Type {
	return reflect.TypeOf((*FormulaResource)(nil)).Elem()
}

func (i FormulaResource) ToFormulaResourceOutput() FormulaResourceOutput {
	return i.ToFormulaResourceOutputWithContext(context.Background())
}

func (i FormulaResource) ToFormulaResourceOutputWithContext(ctx context.Context) FormulaResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FormulaResourceOutput)
}

type FormulaResourceOutput struct {
	*pulumi.OutputState
}

func (FormulaResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FormulaResourceOutput)(nil)).Elem()
}

func (o FormulaResourceOutput) ToFormulaResourceOutput() FormulaResourceOutput {
	return o
}

func (o FormulaResourceOutput) ToFormulaResourceOutputWithContext(ctx context.Context) FormulaResourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FormulaResourceOutput{})
}
