// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Compute role.
type Role struct {
	pulumi.CustomResourceState

	// Role type.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// The object name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The hierarchical type of the object.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRole registers a new resource with the given unique name, arguments, and options.
func NewRole(ctx *pulumi.Context,
	name string, args *RoleArgs, opts ...pulumi.ResourceOption) (*Role, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DeviceName == nil {
		return nil, errors.New("invalid value for required argument 'DeviceName'")
	}
	if args.Kind == nil {
		return nil, errors.New("invalid value for required argument 'Kind'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:databoxedge/latest:Role"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190301:Role"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190701:Role"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20190801:Role"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20200901:Role"),
		},
		{
			Type: pulumi.String("azure-nextgen:databoxedge/v20200901preview:Role"),
		},
	})
	opts = append(opts, aliases)
	var resource Role
	err := ctx.RegisterResource("azure-nextgen:databoxedge/v20200501preview:Role", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRole gets an existing Role resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRole(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RoleState, opts ...pulumi.ResourceOption) (*Role, error) {
	var resource Role
	err := ctx.ReadResource("azure-nextgen:databoxedge/v20200501preview:Role", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Role resources.
type roleState struct {
	// Role type.
	Kind *string `pulumi:"kind"`
	// The object name.
	Name *string `pulumi:"name"`
	// The hierarchical type of the object.
	Type *string `pulumi:"type"`
}

type RoleState struct {
	// Role type.
	Kind pulumi.StringPtrInput
	// The object name.
	Name pulumi.StringPtrInput
	// The hierarchical type of the object.
	Type pulumi.StringPtrInput
}

func (RoleState) ElementType() reflect.Type {
	return reflect.TypeOf((*roleState)(nil)).Elem()
}

type roleArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// Role type.
	Kind string `pulumi:"kind"`
	// The role name.
	Name string `pulumi:"name"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a Role resource.
type RoleArgs struct {
	// The device name.
	DeviceName pulumi.StringInput
	// Role type.
	Kind pulumi.StringInput
	// The role name.
	Name pulumi.StringInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
}

func (RoleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*roleArgs)(nil)).Elem()
}

type RoleInput interface {
	pulumi.Input

	ToRoleOutput() RoleOutput
	ToRoleOutputWithContext(ctx context.Context) RoleOutput
}

func (*Role) ElementType() reflect.Type {
	return reflect.TypeOf((*Role)(nil))
}

func (i *Role) ToRoleOutput() RoleOutput {
	return i.ToRoleOutputWithContext(context.Background())
}

func (i *Role) ToRoleOutputWithContext(ctx context.Context) RoleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoleOutput)
}

type RoleOutput struct {
	*pulumi.OutputState
}

func (RoleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Role)(nil))
}

func (o RoleOutput) ToRoleOutput() RoleOutput {
	return o
}

func (o RoleOutput) ToRoleOutputWithContext(ctx context.Context) RoleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RoleOutput{})
}
