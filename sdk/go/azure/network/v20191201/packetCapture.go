// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191201

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about packet capture session.
type PacketCapture struct {
	pulumi.CustomResourceState

	// Number of bytes captured per packet, the remaining bytes are truncated.
	BytesToCapturePerPacket pulumi.IntPtrOutput `pulumi:"bytesToCapturePerPacket"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// A list of packet capture filters.
	Filters PacketCaptureFilterResponseArrayOutput `pulumi:"filters"`
	// Name of the packet capture session.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the packet capture session.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The storage location for a packet capture session.
	StorageLocation PacketCaptureStorageLocationResponseOutput `pulumi:"storageLocation"`
	// The ID of the targeted resource, only VM is currently supported.
	Target pulumi.StringOutput `pulumi:"target"`
	// Maximum duration of the capture session in seconds.
	TimeLimitInSeconds pulumi.IntPtrOutput `pulumi:"timeLimitInSeconds"`
	// Maximum size of the capture output.
	TotalBytesPerSession pulumi.IntPtrOutput `pulumi:"totalBytesPerSession"`
}

// NewPacketCapture registers a new resource with the given unique name, arguments, and options.
func NewPacketCapture(ctx *pulumi.Context,
	name string, args *PacketCaptureArgs, opts ...pulumi.ResourceOption) (*PacketCapture, error) {
	if args == nil || args.NetworkWatcherName == nil {
		return nil, errors.New("missing required argument 'NetworkWatcherName'")
	}
	if args == nil || args.PacketCaptureName == nil {
		return nil, errors.New("missing required argument 'PacketCaptureName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StorageLocation == nil {
		return nil, errors.New("missing required argument 'StorageLocation'")
	}
	if args == nil || args.Target == nil {
		return nil, errors.New("missing required argument 'Target'")
	}
	if args == nil {
		args = &PacketCaptureArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:PacketCapture"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:PacketCapture"),
		},
	})
	opts = append(opts, aliases)
	var resource PacketCapture
	err := ctx.RegisterResource("azure-nextgen:network/v20191201:PacketCapture", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPacketCapture gets an existing PacketCapture resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPacketCapture(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PacketCaptureState, opts ...pulumi.ResourceOption) (*PacketCapture, error) {
	var resource PacketCapture
	err := ctx.ReadResource("azure-nextgen:network/v20191201:PacketCapture", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PacketCapture resources.
type packetCaptureState struct {
	// Number of bytes captured per packet, the remaining bytes are truncated.
	BytesToCapturePerPacket *int `pulumi:"bytesToCapturePerPacket"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// A list of packet capture filters.
	Filters []PacketCaptureFilterResponse `pulumi:"filters"`
	// Name of the packet capture session.
	Name *string `pulumi:"name"`
	// The provisioning state of the packet capture session.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The storage location for a packet capture session.
	StorageLocation *PacketCaptureStorageLocationResponse `pulumi:"storageLocation"`
	// The ID of the targeted resource, only VM is currently supported.
	Target *string `pulumi:"target"`
	// Maximum duration of the capture session in seconds.
	TimeLimitInSeconds *int `pulumi:"timeLimitInSeconds"`
	// Maximum size of the capture output.
	TotalBytesPerSession *int `pulumi:"totalBytesPerSession"`
}

type PacketCaptureState struct {
	// Number of bytes captured per packet, the remaining bytes are truncated.
	BytesToCapturePerPacket pulumi.IntPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// A list of packet capture filters.
	Filters PacketCaptureFilterResponseArrayInput
	// Name of the packet capture session.
	Name pulumi.StringPtrInput
	// The provisioning state of the packet capture session.
	ProvisioningState pulumi.StringPtrInput
	// The storage location for a packet capture session.
	StorageLocation PacketCaptureStorageLocationResponsePtrInput
	// The ID of the targeted resource, only VM is currently supported.
	Target pulumi.StringPtrInput
	// Maximum duration of the capture session in seconds.
	TimeLimitInSeconds pulumi.IntPtrInput
	// Maximum size of the capture output.
	TotalBytesPerSession pulumi.IntPtrInput
}

func (PacketCaptureState) ElementType() reflect.Type {
	return reflect.TypeOf((*packetCaptureState)(nil)).Elem()
}

type packetCaptureArgs struct {
	// Number of bytes captured per packet, the remaining bytes are truncated.
	BytesToCapturePerPacket *int `pulumi:"bytesToCapturePerPacket"`
	// A list of packet capture filters.
	Filters []PacketCaptureFilter `pulumi:"filters"`
	// The name of the network watcher.
	NetworkWatcherName string `pulumi:"networkWatcherName"`
	// The name of the packet capture session.
	PacketCaptureName string `pulumi:"packetCaptureName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The storage location for a packet capture session.
	StorageLocation PacketCaptureStorageLocation `pulumi:"storageLocation"`
	// The ID of the targeted resource, only VM is currently supported.
	Target string `pulumi:"target"`
	// Maximum duration of the capture session in seconds.
	TimeLimitInSeconds *int `pulumi:"timeLimitInSeconds"`
	// Maximum size of the capture output.
	TotalBytesPerSession *int `pulumi:"totalBytesPerSession"`
}

// The set of arguments for constructing a PacketCapture resource.
type PacketCaptureArgs struct {
	// Number of bytes captured per packet, the remaining bytes are truncated.
	BytesToCapturePerPacket pulumi.IntPtrInput
	// A list of packet capture filters.
	Filters PacketCaptureFilterArrayInput
	// The name of the network watcher.
	NetworkWatcherName pulumi.StringInput
	// The name of the packet capture session.
	PacketCaptureName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The storage location for a packet capture session.
	StorageLocation PacketCaptureStorageLocationInput
	// The ID of the targeted resource, only VM is currently supported.
	Target pulumi.StringInput
	// Maximum duration of the capture session in seconds.
	TimeLimitInSeconds pulumi.IntPtrInput
	// Maximum size of the capture output.
	TotalBytesPerSession pulumi.IntPtrInput
}

func (PacketCaptureArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*packetCaptureArgs)(nil)).Elem()
}
