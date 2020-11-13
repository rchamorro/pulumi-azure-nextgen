// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ExpressRoute Circuit Authorization
type Authorization struct {
	pulumi.CustomResourceState

	// The ID of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationId pulumi.StringOutput `pulumi:"expressRouteAuthorizationId"`
	// The key of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationKey pulumi.StringOutput `pulumi:"expressRouteAuthorizationKey"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The state of the  ExpressRoute Circuit Authorization provisioning
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAuthorization registers a new resource with the given unique name, arguments, and options.
func NewAuthorization(ctx *pulumi.Context,
	name string, args *AuthorizationArgs, opts ...pulumi.ResourceOption) (*Authorization, error) {
	if args == nil || args.AuthorizationName == nil {
		return nil, errors.New("missing required argument 'AuthorizationName'")
	}
	if args == nil || args.PrivateCloudName == nil {
		return nil, errors.New("missing required argument 'PrivateCloudName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &AuthorizationArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:avs/v20200320:Authorization"),
		},
		{
			Type: pulumi.String("azure-nextgen:avs/v20200717preview:Authorization"),
		},
	})
	opts = append(opts, aliases)
	var resource Authorization
	err := ctx.RegisterResource("azure-nextgen:avs/latest:Authorization", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAuthorization gets an existing Authorization resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAuthorization(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AuthorizationState, opts ...pulumi.ResourceOption) (*Authorization, error) {
	var resource Authorization
	err := ctx.ReadResource("azure-nextgen:avs/latest:Authorization", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Authorization resources.
type authorizationState struct {
	// The ID of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationId *string `pulumi:"expressRouteAuthorizationId"`
	// The key of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationKey *string `pulumi:"expressRouteAuthorizationKey"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The state of the  ExpressRoute Circuit Authorization provisioning
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type AuthorizationState struct {
	// The ID of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationId pulumi.StringPtrInput
	// The key of the ExpressRoute Circuit Authorization
	ExpressRouteAuthorizationKey pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The state of the  ExpressRoute Circuit Authorization provisioning
	ProvisioningState pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (AuthorizationState) ElementType() reflect.Type {
	return reflect.TypeOf((*authorizationState)(nil)).Elem()
}

type authorizationArgs struct {
	// Name of the ExpressRoute Circuit Authorization in the private cloud
	AuthorizationName string `pulumi:"authorizationName"`
	// The name of the private cloud.
	PrivateCloudName string `pulumi:"privateCloudName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a Authorization resource.
type AuthorizationArgs struct {
	// Name of the ExpressRoute Circuit Authorization in the private cloud
	AuthorizationName pulumi.StringInput
	// The name of the private cloud.
	PrivateCloudName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (AuthorizationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*authorizationArgs)(nil)).Elem()
}

type AuthorizationInput interface {
	pulumi.Input

	ToAuthorizationOutput() AuthorizationOutput
	ToAuthorizationOutputWithContext(ctx context.Context) AuthorizationOutput
}

func (Authorization) ElementType() reflect.Type {
	return reflect.TypeOf((*Authorization)(nil)).Elem()
}

func (i Authorization) ToAuthorizationOutput() AuthorizationOutput {
	return i.ToAuthorizationOutputWithContext(context.Background())
}

func (i Authorization) ToAuthorizationOutputWithContext(ctx context.Context) AuthorizationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AuthorizationOutput)
}

type AuthorizationOutput struct {
	*pulumi.OutputState
}

func (AuthorizationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AuthorizationOutput)(nil)).Elem()
}

func (o AuthorizationOutput) ToAuthorizationOutput() AuthorizationOutput {
	return o
}

func (o AuthorizationOutput) ToAuthorizationOutputWithContext(ctx context.Context) AuthorizationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AuthorizationOutput{})
}
