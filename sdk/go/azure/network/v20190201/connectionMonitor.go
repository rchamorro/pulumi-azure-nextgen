// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about the connection monitor.
type ConnectionMonitor struct {
	pulumi.CustomResourceState

	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrOutput `pulumi:"autoStart"`
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationResponseOutput `pulumi:"destination"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Connection monitor location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds pulumi.IntPtrOutput `pulumi:"monitoringIntervalInSeconds"`
	// The monitoring status of the connection monitor.
	MonitoringStatus pulumi.StringPtrOutput `pulumi:"monitoringStatus"`
	// Name of the connection monitor.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the connection monitor.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceResponseOutput `pulumi:"source"`
	// The date and time when the connection monitor was started.
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
	// Connection monitor tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Connection monitor type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewConnectionMonitor registers a new resource with the given unique name, arguments, and options.
func NewConnectionMonitor(ctx *pulumi.Context,
	name string, args *ConnectionMonitorArgs, opts ...pulumi.ResourceOption) (*ConnectionMonitor, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectionMonitorName == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionMonitorName'")
	}
	if args.Destination == nil {
		return nil, errors.New("invalid value for required argument 'Destination'")
	}
	if args.NetworkWatcherName == nil {
		return nil, errors.New("invalid value for required argument 'NetworkWatcherName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Source == nil {
		return nil, errors.New("invalid value for required argument 'Source'")
	}
	if args.AutoStart == nil {
		args.AutoStart = pulumi.BoolPtr(true)
	}
	if args.MonitoringIntervalInSeconds == nil {
		args.MonitoringIntervalInSeconds = pulumi.IntPtr(60)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:ConnectionMonitor"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:ConnectionMonitor"),
		},
	})
	opts = append(opts, aliases)
	var resource ConnectionMonitor
	err := ctx.RegisterResource("azure-nextgen:network/v20190201:ConnectionMonitor", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectionMonitor gets an existing ConnectionMonitor resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectionMonitor(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectionMonitorState, opts ...pulumi.ResourceOption) (*ConnectionMonitor, error) {
	var resource ConnectionMonitor
	err := ctx.ReadResource("azure-nextgen:network/v20190201:ConnectionMonitor", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectionMonitor resources.
type connectionMonitorState struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart *bool `pulumi:"autoStart"`
	// Describes the destination of connection monitor.
	Destination *ConnectionMonitorDestinationResponse `pulumi:"destination"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Connection monitor location.
	Location *string `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds *int `pulumi:"monitoringIntervalInSeconds"`
	// The monitoring status of the connection monitor.
	MonitoringStatus *string `pulumi:"monitoringStatus"`
	// Name of the connection monitor.
	Name *string `pulumi:"name"`
	// The provisioning state of the connection monitor.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Describes the source of connection monitor.
	Source *ConnectionMonitorSourceResponse `pulumi:"source"`
	// The date and time when the connection monitor was started.
	StartTime *string `pulumi:"startTime"`
	// Connection monitor tags.
	Tags map[string]string `pulumi:"tags"`
	// Connection monitor type.
	Type *string `pulumi:"type"`
}

type ConnectionMonitorState struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrInput
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationResponsePtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Connection monitor location.
	Location pulumi.StringPtrInput
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds pulumi.IntPtrInput
	// The monitoring status of the connection monitor.
	MonitoringStatus pulumi.StringPtrInput
	// Name of the connection monitor.
	Name pulumi.StringPtrInput
	// The provisioning state of the connection monitor.
	ProvisioningState pulumi.StringPtrInput
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceResponsePtrInput
	// The date and time when the connection monitor was started.
	StartTime pulumi.StringPtrInput
	// Connection monitor tags.
	Tags pulumi.StringMapInput
	// Connection monitor type.
	Type pulumi.StringPtrInput
}

func (ConnectionMonitorState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionMonitorState)(nil)).Elem()
}

type connectionMonitorArgs struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart *bool `pulumi:"autoStart"`
	// The name of the connection monitor.
	ConnectionMonitorName string `pulumi:"connectionMonitorName"`
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestination `pulumi:"destination"`
	// Connection monitor location.
	Location *string `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds *int `pulumi:"monitoringIntervalInSeconds"`
	// The name of the Network Watcher resource.
	NetworkWatcherName string `pulumi:"networkWatcherName"`
	// The name of the resource group containing Network Watcher.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Describes the source of connection monitor.
	Source ConnectionMonitorSource `pulumi:"source"`
	// Connection monitor tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ConnectionMonitor resource.
type ConnectionMonitorArgs struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrInput
	// The name of the connection monitor.
	ConnectionMonitorName pulumi.StringInput
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationInput
	// Connection monitor location.
	Location pulumi.StringPtrInput
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds pulumi.IntPtrInput
	// The name of the Network Watcher resource.
	NetworkWatcherName pulumi.StringInput
	// The name of the resource group containing Network Watcher.
	ResourceGroupName pulumi.StringInput
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceInput
	// Connection monitor tags.
	Tags pulumi.StringMapInput
}

func (ConnectionMonitorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionMonitorArgs)(nil)).Elem()
}

type ConnectionMonitorInput interface {
	pulumi.Input

	ToConnectionMonitorOutput() ConnectionMonitorOutput
	ToConnectionMonitorOutputWithContext(ctx context.Context) ConnectionMonitorOutput
}

func (*ConnectionMonitor) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionMonitor)(nil))
}

func (i *ConnectionMonitor) ToConnectionMonitorOutput() ConnectionMonitorOutput {
	return i.ToConnectionMonitorOutputWithContext(context.Background())
}

func (i *ConnectionMonitor) ToConnectionMonitorOutputWithContext(ctx context.Context) ConnectionMonitorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectionMonitorOutput)
}

type ConnectionMonitorOutput struct {
	*pulumi.OutputState
}

func (ConnectionMonitorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionMonitor)(nil))
}

func (o ConnectionMonitorOutput) ToConnectionMonitorOutput() ConnectionMonitorOutput {
	return o
}

func (o ConnectionMonitorOutput) ToConnectionMonitorOutputWithContext(ctx context.Context) ConnectionMonitorOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ConnectionMonitorOutput{})
}
