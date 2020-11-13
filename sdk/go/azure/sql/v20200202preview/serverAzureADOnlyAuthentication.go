// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200202preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Azure Active Directory only authentication.
type ServerAzureADOnlyAuthentication struct {
	pulumi.CustomResourceState

	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication pulumi.BoolOutput `pulumi:"azureADOnlyAuthentication"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewServerAzureADOnlyAuthentication registers a new resource with the given unique name, arguments, and options.
func NewServerAzureADOnlyAuthentication(ctx *pulumi.Context,
	name string, args *ServerAzureADOnlyAuthenticationArgs, opts ...pulumi.ResourceOption) (*ServerAzureADOnlyAuthentication, error) {
	if args == nil || args.AuthenticationName == nil {
		return nil, errors.New("missing required argument 'AuthenticationName'")
	}
	if args == nil || args.AzureADOnlyAuthentication == nil {
		return nil, errors.New("missing required argument 'AzureADOnlyAuthentication'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil {
		args = &ServerAzureADOnlyAuthenticationArgs{}
	}
	var resource ServerAzureADOnlyAuthentication
	err := ctx.RegisterResource("azure-nextgen:sql/v20200202preview:ServerAzureADOnlyAuthentication", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerAzureADOnlyAuthentication gets an existing ServerAzureADOnlyAuthentication resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerAzureADOnlyAuthentication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerAzureADOnlyAuthenticationState, opts ...pulumi.ResourceOption) (*ServerAzureADOnlyAuthentication, error) {
	var resource ServerAzureADOnlyAuthentication
	err := ctx.ReadResource("azure-nextgen:sql/v20200202preview:ServerAzureADOnlyAuthentication", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerAzureADOnlyAuthentication resources.
type serverAzureADOnlyAuthenticationState struct {
	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication *bool `pulumi:"azureADOnlyAuthentication"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ServerAzureADOnlyAuthenticationState struct {
	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication pulumi.BoolPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ServerAzureADOnlyAuthenticationState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverAzureADOnlyAuthenticationState)(nil)).Elem()
}

type serverAzureADOnlyAuthenticationArgs struct {
	// The name of server azure active directory only authentication.
	AuthenticationName string `pulumi:"authenticationName"`
	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication bool `pulumi:"azureADOnlyAuthentication"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
}

// The set of arguments for constructing a ServerAzureADOnlyAuthentication resource.
type ServerAzureADOnlyAuthenticationArgs struct {
	// The name of server azure active directory only authentication.
	AuthenticationName pulumi.StringInput
	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication pulumi.BoolInput
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
}

func (ServerAzureADOnlyAuthenticationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverAzureADOnlyAuthenticationArgs)(nil)).Elem()
}

type ServerAzureADOnlyAuthenticationInput interface {
	pulumi.Input

	ToServerAzureADOnlyAuthenticationOutput() ServerAzureADOnlyAuthenticationOutput
	ToServerAzureADOnlyAuthenticationOutputWithContext(ctx context.Context) ServerAzureADOnlyAuthenticationOutput
}

func (ServerAzureADOnlyAuthentication) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerAzureADOnlyAuthentication)(nil)).Elem()
}

func (i ServerAzureADOnlyAuthentication) ToServerAzureADOnlyAuthenticationOutput() ServerAzureADOnlyAuthenticationOutput {
	return i.ToServerAzureADOnlyAuthenticationOutputWithContext(context.Background())
}

func (i ServerAzureADOnlyAuthentication) ToServerAzureADOnlyAuthenticationOutputWithContext(ctx context.Context) ServerAzureADOnlyAuthenticationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerAzureADOnlyAuthenticationOutput)
}

type ServerAzureADOnlyAuthenticationOutput struct {
	*pulumi.OutputState
}

func (ServerAzureADOnlyAuthenticationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerAzureADOnlyAuthenticationOutput)(nil)).Elem()
}

func (o ServerAzureADOnlyAuthenticationOutput) ToServerAzureADOnlyAuthenticationOutput() ServerAzureADOnlyAuthenticationOutput {
	return o
}

func (o ServerAzureADOnlyAuthenticationOutput) ToServerAzureADOnlyAuthenticationOutputWithContext(ctx context.Context) ServerAzureADOnlyAuthenticationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServerAzureADOnlyAuthenticationOutput{})
}
