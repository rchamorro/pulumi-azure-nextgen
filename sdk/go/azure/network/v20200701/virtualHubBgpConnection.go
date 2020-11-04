// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual Appliance Site resource.
type VirtualHubBgpConnection struct {
	pulumi.CustomResourceState

	// The current state of the VirtualHub to Peer.
	ConnectionState pulumi.StringOutput `pulumi:"connectionState"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Name of the connection.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Peer ASN.
	PeerAsn pulumi.IntPtrOutput `pulumi:"peerAsn"`
	// Peer IP.
	PeerIp pulumi.StringPtrOutput `pulumi:"peerIp"`
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Connection type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewVirtualHubBgpConnection registers a new resource with the given unique name, arguments, and options.
func NewVirtualHubBgpConnection(ctx *pulumi.Context,
	name string, args *VirtualHubBgpConnectionArgs, opts ...pulumi.ResourceOption) (*VirtualHubBgpConnection, error) {
	if args == nil || args.ConnectionName == nil {
		return nil, errors.New("missing required argument 'ConnectionName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VirtualHubName == nil {
		return nil, errors.New("missing required argument 'VirtualHubName'")
	}
	if args == nil {
		args = &VirtualHubBgpConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:VirtualHubBgpConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:VirtualHubBgpConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:VirtualHubBgpConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualHubBgpConnection
	err := ctx.RegisterResource("azure-nextgen:network/v20200701:VirtualHubBgpConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualHubBgpConnection gets an existing VirtualHubBgpConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualHubBgpConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualHubBgpConnectionState, opts ...pulumi.ResourceOption) (*VirtualHubBgpConnection, error) {
	var resource VirtualHubBgpConnection
	err := ctx.ReadResource("azure-nextgen:network/v20200701:VirtualHubBgpConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualHubBgpConnection resources.
type virtualHubBgpConnectionState struct {
	// The current state of the VirtualHub to Peer.
	ConnectionState *string `pulumi:"connectionState"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Name of the connection.
	Name *string `pulumi:"name"`
	// Peer ASN.
	PeerAsn *int `pulumi:"peerAsn"`
	// Peer IP.
	PeerIp *string `pulumi:"peerIp"`
	// The provisioning state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Connection type.
	Type *string `pulumi:"type"`
}

type VirtualHubBgpConnectionState struct {
	// The current state of the VirtualHub to Peer.
	ConnectionState pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Name of the connection.
	Name pulumi.StringPtrInput
	// Peer ASN.
	PeerAsn pulumi.IntPtrInput
	// Peer IP.
	PeerIp pulumi.StringPtrInput
	// The provisioning state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// Connection type.
	Type pulumi.StringPtrInput
}

func (VirtualHubBgpConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualHubBgpConnectionState)(nil)).Elem()
}

type virtualHubBgpConnectionArgs struct {
	// The name of the connection.
	ConnectionName string `pulumi:"connectionName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Name of the connection.
	Name *string `pulumi:"name"`
	// Peer ASN.
	PeerAsn *int `pulumi:"peerAsn"`
	// Peer IP.
	PeerIp *string `pulumi:"peerIp"`
	// The resource group name of the VirtualHub.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the VirtualHub.
	VirtualHubName string `pulumi:"virtualHubName"`
}

// The set of arguments for constructing a VirtualHubBgpConnection resource.
type VirtualHubBgpConnectionArgs struct {
	// The name of the connection.
	ConnectionName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Name of the connection.
	Name pulumi.StringPtrInput
	// Peer ASN.
	PeerAsn pulumi.IntPtrInput
	// Peer IP.
	PeerIp pulumi.StringPtrInput
	// The resource group name of the VirtualHub.
	ResourceGroupName pulumi.StringInput
	// The name of the VirtualHub.
	VirtualHubName pulumi.StringInput
}

func (VirtualHubBgpConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualHubBgpConnectionArgs)(nil)).Elem()
}
