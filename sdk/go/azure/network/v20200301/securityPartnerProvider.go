// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Security Partner Provider resource.
type SecurityPartnerProvider struct {
	pulumi.CustomResourceState

	// The connection status with the Security Partner Provider.
	ConnectionStatus pulumi.StringOutput `pulumi:"connectionStatus"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the Security Partner Provider resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The security provider name.
	SecurityProviderName pulumi.StringPtrOutput `pulumi:"securityProviderName"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub SubResourceResponsePtrOutput `pulumi:"virtualHub"`
}

// NewSecurityPartnerProvider registers a new resource with the given unique name, arguments, and options.
func NewSecurityPartnerProvider(ctx *pulumi.Context,
	name string, args *SecurityPartnerProviderArgs, opts ...pulumi.ResourceOption) (*SecurityPartnerProvider, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SecurityPartnerProviderName == nil {
		return nil, errors.New("missing required argument 'SecurityPartnerProviderName'")
	}
	if args == nil {
		args = &SecurityPartnerProviderArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:SecurityPartnerProvider"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:SecurityPartnerProvider"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:SecurityPartnerProvider"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:SecurityPartnerProvider"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:SecurityPartnerProvider"),
		},
	})
	opts = append(opts, aliases)
	var resource SecurityPartnerProvider
	err := ctx.RegisterResource("azure-nextgen:network/v20200301:SecurityPartnerProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityPartnerProvider gets an existing SecurityPartnerProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityPartnerProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityPartnerProviderState, opts ...pulumi.ResourceOption) (*SecurityPartnerProvider, error) {
	var resource SecurityPartnerProvider
	err := ctx.ReadResource("azure-nextgen:network/v20200301:SecurityPartnerProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityPartnerProvider resources.
type securityPartnerProviderState struct {
	// The connection status with the Security Partner Provider.
	ConnectionStatus *string `pulumi:"connectionStatus"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the Security Partner Provider resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The security provider name.
	SecurityProviderName *string `pulumi:"securityProviderName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub *SubResourceResponse `pulumi:"virtualHub"`
}

type SecurityPartnerProviderState struct {
	// The connection status with the Security Partner Provider.
	ConnectionStatus pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the Security Partner Provider resource.
	ProvisioningState pulumi.StringPtrInput
	// The security provider name.
	SecurityProviderName pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub SubResourceResponsePtrInput
}

func (SecurityPartnerProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityPartnerProviderState)(nil)).Elem()
}

type securityPartnerProviderArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Security Partner Provider.
	SecurityPartnerProviderName string `pulumi:"securityPartnerProviderName"`
	// The security provider name.
	SecurityProviderName *string `pulumi:"securityProviderName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub *SubResource `pulumi:"virtualHub"`
}

// The set of arguments for constructing a SecurityPartnerProvider resource.
type SecurityPartnerProviderArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the Security Partner Provider.
	SecurityPartnerProviderName pulumi.StringInput
	// The security provider name.
	SecurityProviderName pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The virtualHub to which the Security Partner Provider belongs.
	VirtualHub SubResourcePtrInput
}

func (SecurityPartnerProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityPartnerProviderArgs)(nil)).Elem()
}
