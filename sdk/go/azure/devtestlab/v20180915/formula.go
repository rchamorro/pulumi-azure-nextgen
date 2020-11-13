// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180915

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A formula for creating a VM, specifying an image base and other parameters
type Formula struct {
	pulumi.CustomResourceState

	// The author of the formula.
	Author pulumi.StringPtrOutput `pulumi:"author"`
	// The creation date of the formula.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// The description of the formula.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The content of the formula.
	FormulaContent LabVirtualMachineCreationParameterResponsePtrOutput `pulumi:"formulaContent"`
	// The location of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The OS type of the formula.
	OsType pulumi.StringPtrOutput `pulumi:"osType"`
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringOutput `pulumi:"uniqueIdentifier"`
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmResponsePtrOutput `pulumi:"vm"`
}

// NewFormula registers a new resource with the given unique name, arguments, and options.
func NewFormula(ctx *pulumi.Context,
	name string, args *FormulaArgs, opts ...pulumi.ResourceOption) (*Formula, error) {
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
		args = &FormulaArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devtestlab/latest:Formula"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20150521preview:Formula"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20160515:Formula"),
		},
	})
	opts = append(opts, aliases)
	var resource Formula
	err := ctx.RegisterResource("azure-nextgen:devtestlab/v20180915:Formula", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFormula gets an existing Formula resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFormula(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FormulaState, opts ...pulumi.ResourceOption) (*Formula, error) {
	var resource Formula
	err := ctx.ReadResource("azure-nextgen:devtestlab/v20180915:Formula", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Formula resources.
type formulaState struct {
	// The author of the formula.
	Author *string `pulumi:"author"`
	// The creation date of the formula.
	CreationDate *string `pulumi:"creationDate"`
	// The description of the formula.
	Description *string `pulumi:"description"`
	// The content of the formula.
	FormulaContent *LabVirtualMachineCreationParameterResponse `pulumi:"formulaContent"`
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
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier *string `pulumi:"uniqueIdentifier"`
	// Information about a VM from which a formula is to be created.
	Vm *FormulaPropertiesFromVmResponse `pulumi:"vm"`
}

type FormulaState struct {
	// The author of the formula.
	Author pulumi.StringPtrInput
	// The creation date of the formula.
	CreationDate pulumi.StringPtrInput
	// The description of the formula.
	Description pulumi.StringPtrInput
	// The content of the formula.
	FormulaContent LabVirtualMachineCreationParameterResponsePtrInput
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
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringPtrInput
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmResponsePtrInput
}

func (FormulaState) ElementType() reflect.Type {
	return reflect.TypeOf((*formulaState)(nil)).Elem()
}

type formulaArgs struct {
	// The author of the formula.
	Author *string `pulumi:"author"`
	// The description of the formula.
	Description *string `pulumi:"description"`
	// The content of the formula.
	FormulaContent *LabVirtualMachineCreationParameter `pulumi:"formulaContent"`
	// The name of the lab.
	LabName string `pulumi:"labName"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the formula.
	Name string `pulumi:"name"`
	// The OS type of the formula.
	OsType *string `pulumi:"osType"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// Information about a VM from which a formula is to be created.
	Vm *FormulaPropertiesFromVm `pulumi:"vm"`
}

// The set of arguments for constructing a Formula resource.
type FormulaArgs struct {
	// The author of the formula.
	Author pulumi.StringPtrInput
	// The description of the formula.
	Description pulumi.StringPtrInput
	// The content of the formula.
	FormulaContent LabVirtualMachineCreationParameterPtrInput
	// The name of the lab.
	LabName pulumi.StringInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the formula.
	Name pulumi.StringInput
	// The OS type of the formula.
	OsType pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// Information about a VM from which a formula is to be created.
	Vm FormulaPropertiesFromVmPtrInput
}

func (FormulaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*formulaArgs)(nil)).Elem()
}

type FormulaInput interface {
	pulumi.Input

	ToFormulaOutput() FormulaOutput
	ToFormulaOutputWithContext(ctx context.Context) FormulaOutput
}

func (Formula) ElementType() reflect.Type {
	return reflect.TypeOf((*Formula)(nil)).Elem()
}

func (i Formula) ToFormulaOutput() FormulaOutput {
	return i.ToFormulaOutputWithContext(context.Background())
}

func (i Formula) ToFormulaOutputWithContext(ctx context.Context) FormulaOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FormulaOutput)
}

type FormulaOutput struct {
	*pulumi.OutputState
}

func (FormulaOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FormulaOutput)(nil)).Elem()
}

func (o FormulaOutput) ToFormulaOutput() FormulaOutput {
	return o
}

func (o FormulaOutput) ToFormulaOutputWithContext(ctx context.Context) FormulaOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FormulaOutput{})
}
