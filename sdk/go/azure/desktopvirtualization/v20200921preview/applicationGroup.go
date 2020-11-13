// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200921preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a ApplicationGroup definition.
type ApplicationGroup struct {
	pulumi.CustomResourceState

	// Resource Type of ApplicationGroup.
	ApplicationGroupType pulumi.StringOutput `pulumi:"applicationGroupType"`
	// Description of ApplicationGroup.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Friendly name of ApplicationGroup.
	FriendlyName pulumi.StringPtrOutput `pulumi:"friendlyName"`
	// HostPool arm path of ApplicationGroup.
	HostPoolArmPath pulumi.StringOutput `pulumi:"hostPoolArmPath"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// Workspace arm path of ApplicationGroup.
	WorkspaceArmPath pulumi.StringOutput `pulumi:"workspaceArmPath"`
}

// NewApplicationGroup registers a new resource with the given unique name, arguments, and options.
func NewApplicationGroup(ctx *pulumi.Context,
	name string, args *ApplicationGroupArgs, opts ...pulumi.ResourceOption) (*ApplicationGroup, error) {
	if args == nil || args.ApplicationGroupName == nil {
		return nil, errors.New("missing required argument 'ApplicationGroupName'")
	}
	if args == nil || args.ApplicationGroupType == nil {
		return nil, errors.New("missing required argument 'ApplicationGroupType'")
	}
	if args == nil || args.HostPoolArmPath == nil {
		return nil, errors.New("missing required argument 'HostPoolArmPath'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ApplicationGroupArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:desktopvirtualization/v20190123preview:ApplicationGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:desktopvirtualization/v20190924preview:ApplicationGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:desktopvirtualization/v20191210preview:ApplicationGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:desktopvirtualization/v20201019preview:ApplicationGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:desktopvirtualization/v20201102preview:ApplicationGroup"),
		},
	})
	opts = append(opts, aliases)
	var resource ApplicationGroup
	err := ctx.RegisterResource("azure-nextgen:desktopvirtualization/v20200921preview:ApplicationGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplicationGroup gets an existing ApplicationGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplicationGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplicationGroupState, opts ...pulumi.ResourceOption) (*ApplicationGroup, error) {
	var resource ApplicationGroup
	err := ctx.ReadResource("azure-nextgen:desktopvirtualization/v20200921preview:ApplicationGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApplicationGroup resources.
type applicationGroupState struct {
	// Resource Type of ApplicationGroup.
	ApplicationGroupType *string `pulumi:"applicationGroupType"`
	// Description of ApplicationGroup.
	Description *string `pulumi:"description"`
	// Friendly name of ApplicationGroup.
	FriendlyName *string `pulumi:"friendlyName"`
	// HostPool arm path of ApplicationGroup.
	HostPoolArmPath *string `pulumi:"hostPoolArmPath"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// Workspace arm path of ApplicationGroup.
	WorkspaceArmPath *string `pulumi:"workspaceArmPath"`
}

type ApplicationGroupState struct {
	// Resource Type of ApplicationGroup.
	ApplicationGroupType pulumi.StringPtrInput
	// Description of ApplicationGroup.
	Description pulumi.StringPtrInput
	// Friendly name of ApplicationGroup.
	FriendlyName pulumi.StringPtrInput
	// HostPool arm path of ApplicationGroup.
	HostPoolArmPath pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// Workspace arm path of ApplicationGroup.
	WorkspaceArmPath pulumi.StringPtrInput
}

func (ApplicationGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationGroupState)(nil)).Elem()
}

type applicationGroupArgs struct {
	// The name of the application group
	ApplicationGroupName string `pulumi:"applicationGroupName"`
	// Resource Type of ApplicationGroup.
	ApplicationGroupType string `pulumi:"applicationGroupType"`
	// Description of ApplicationGroup.
	Description *string `pulumi:"description"`
	// Friendly name of ApplicationGroup.
	FriendlyName *string `pulumi:"friendlyName"`
	// HostPool arm path of ApplicationGroup.
	HostPoolArmPath string `pulumi:"hostPoolArmPath"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ApplicationGroup resource.
type ApplicationGroupArgs struct {
	// The name of the application group
	ApplicationGroupName pulumi.StringInput
	// Resource Type of ApplicationGroup.
	ApplicationGroupType pulumi.StringInput
	// Description of ApplicationGroup.
	Description pulumi.StringPtrInput
	// Friendly name of ApplicationGroup.
	FriendlyName pulumi.StringPtrInput
	// HostPool arm path of ApplicationGroup.
	HostPoolArmPath pulumi.StringInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ApplicationGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationGroupArgs)(nil)).Elem()
}

type ApplicationGroupInput interface {
	pulumi.Input

	ToApplicationGroupOutput() ApplicationGroupOutput
	ToApplicationGroupOutputWithContext(ctx context.Context) ApplicationGroupOutput
}

func (ApplicationGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplicationGroup)(nil)).Elem()
}

func (i ApplicationGroup) ToApplicationGroupOutput() ApplicationGroupOutput {
	return i.ToApplicationGroupOutputWithContext(context.Background())
}

func (i ApplicationGroup) ToApplicationGroupOutputWithContext(ctx context.Context) ApplicationGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplicationGroupOutput)
}

type ApplicationGroupOutput struct {
	*pulumi.OutputState
}

func (ApplicationGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplicationGroupOutput)(nil)).Elem()
}

func (o ApplicationGroupOutput) ToApplicationGroupOutput() ApplicationGroupOutput {
	return o
}

func (o ApplicationGroupOutput) ToApplicationGroupOutputWithContext(ctx context.Context) ApplicationGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ApplicationGroupOutput{})
}
