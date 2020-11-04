// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190901

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// VirtualRouter Resource.
type VirtualRouter struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway SubResourceResponsePtrOutput `pulumi:"hostedGateway"`
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet SubResourceResponsePtrOutput `pulumi:"hostedSubnet"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// List of references to VirtualRouterPeerings.
	Peerings SubResourceResponseArrayOutput `pulumi:"peerings"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// VirtualRouter ASN.
	VirtualRouterAsn pulumi.IntPtrOutput `pulumi:"virtualRouterAsn"`
	// VirtualRouter IPs.
	VirtualRouterIps pulumi.StringArrayOutput `pulumi:"virtualRouterIps"`
}

// NewVirtualRouter registers a new resource with the given unique name, arguments, and options.
func NewVirtualRouter(ctx *pulumi.Context,
	name string, args *VirtualRouterArgs, opts ...pulumi.ResourceOption) (*VirtualRouter, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VirtualRouterName == nil {
		return nil, errors.New("missing required argument 'VirtualRouterName'")
	}
	if args == nil {
		args = &VirtualRouterArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualRouter"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:VirtualRouter"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualRouter
	err := ctx.RegisterResource("azure-nextgen:network/v20190901:VirtualRouter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualRouter gets an existing VirtualRouter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualRouter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualRouterState, opts ...pulumi.ResourceOption) (*VirtualRouter, error) {
	var resource VirtualRouter
	err := ctx.ReadResource("azure-nextgen:network/v20190901:VirtualRouter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualRouter resources.
type virtualRouterState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway *SubResourceResponse `pulumi:"hostedGateway"`
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet *SubResourceResponse `pulumi:"hostedSubnet"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// List of references to VirtualRouterPeerings.
	Peerings []SubResourceResponse `pulumi:"peerings"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// VirtualRouter ASN.
	VirtualRouterAsn *int `pulumi:"virtualRouterAsn"`
	// VirtualRouter IPs.
	VirtualRouterIps []string `pulumi:"virtualRouterIps"`
}

type VirtualRouterState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway SubResourceResponsePtrInput
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet SubResourceResponsePtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// List of references to VirtualRouterPeerings.
	Peerings SubResourceResponseArrayInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// VirtualRouter ASN.
	VirtualRouterAsn pulumi.IntPtrInput
	// VirtualRouter IPs.
	VirtualRouterIps pulumi.StringArrayInput
}

func (VirtualRouterState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualRouterState)(nil)).Elem()
}

type virtualRouterArgs struct {
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway *SubResource `pulumi:"hostedGateway"`
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet *SubResource `pulumi:"hostedSubnet"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// VirtualRouter ASN.
	VirtualRouterAsn *int `pulumi:"virtualRouterAsn"`
	// VirtualRouter IPs.
	VirtualRouterIps []string `pulumi:"virtualRouterIps"`
	// The name of the Virtual Router.
	VirtualRouterName string `pulumi:"virtualRouterName"`
}

// The set of arguments for constructing a VirtualRouter resource.
type VirtualRouterArgs struct {
	// The Gateway on which VirtualRouter is hosted.
	HostedGateway SubResourcePtrInput
	// The Subnet on which VirtualRouter is hosted.
	HostedSubnet SubResourcePtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// VirtualRouter ASN.
	VirtualRouterAsn pulumi.IntPtrInput
	// VirtualRouter IPs.
	VirtualRouterIps pulumi.StringArrayInput
	// The name of the Virtual Router.
	VirtualRouterName pulumi.StringInput
}

func (VirtualRouterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualRouterArgs)(nil)).Elem()
}
