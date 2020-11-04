// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about the connection monitor.
type ConnectionMonitor struct {
	pulumi.CustomResourceState

	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrOutput `pulumi:"autoStart"`
	// Type of connection monitor.
	ConnectionMonitorType pulumi.StringOutput `pulumi:"connectionMonitorType"`
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationResponsePtrOutput `pulumi:"destination"`
	// List of connection monitor endpoints.
	Endpoints ConnectionMonitorEndpointResponseArrayOutput `pulumi:"endpoints"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Connection monitor location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds pulumi.IntPtrOutput `pulumi:"monitoringIntervalInSeconds"`
	// The monitoring status of the connection monitor.
	MonitoringStatus pulumi.StringOutput `pulumi:"monitoringStatus"`
	// Name of the connection monitor.
	Name pulumi.StringOutput `pulumi:"name"`
	// Optional notes to be associated with the connection monitor.
	Notes pulumi.StringPtrOutput `pulumi:"notes"`
	// List of connection monitor outputs.
	Outputs ConnectionMonitorOutputResponseArrayOutput `pulumi:"outputs"`
	// The provisioning state of the connection monitor.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceResponsePtrOutput `pulumi:"source"`
	// The date and time when the connection monitor was started.
	StartTime pulumi.StringOutput `pulumi:"startTime"`
	// Connection monitor tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// List of connection monitor test configurations.
	TestConfigurations ConnectionMonitorTestConfigurationResponseArrayOutput `pulumi:"testConfigurations"`
	// List of connection monitor test groups.
	TestGroups ConnectionMonitorTestGroupResponseArrayOutput `pulumi:"testGroups"`
	// Connection monitor type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewConnectionMonitor registers a new resource with the given unique name, arguments, and options.
func NewConnectionMonitor(ctx *pulumi.Context,
	name string, args *ConnectionMonitorArgs, opts ...pulumi.ResourceOption) (*ConnectionMonitor, error) {
	if args == nil || args.ConnectionMonitorName == nil {
		return nil, errors.New("missing required argument 'ConnectionMonitorName'")
	}
	if args == nil || args.NetworkWatcherName == nil {
		return nil, errors.New("missing required argument 'NetworkWatcherName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ConnectionMonitorArgs{}
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
			Type: pulumi.String("azure-nextgen:network/v20190201:ConnectionMonitor"),
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
			Type: pulumi.String("azure-nextgen:network/v20200701:ConnectionMonitor"),
		},
	})
	opts = append(opts, aliases)
	var resource ConnectionMonitor
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:ConnectionMonitor", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:network/v20200601:ConnectionMonitor", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectionMonitor resources.
type connectionMonitorState struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart *bool `pulumi:"autoStart"`
	// Type of connection monitor.
	ConnectionMonitorType *string `pulumi:"connectionMonitorType"`
	// Describes the destination of connection monitor.
	Destination *ConnectionMonitorDestinationResponse `pulumi:"destination"`
	// List of connection monitor endpoints.
	Endpoints []ConnectionMonitorEndpointResponse `pulumi:"endpoints"`
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
	// Optional notes to be associated with the connection monitor.
	Notes *string `pulumi:"notes"`
	// List of connection monitor outputs.
	Outputs []ConnectionMonitorOutputResponse `pulumi:"outputs"`
	// The provisioning state of the connection monitor.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Describes the source of connection monitor.
	Source *ConnectionMonitorSourceResponse `pulumi:"source"`
	// The date and time when the connection monitor was started.
	StartTime *string `pulumi:"startTime"`
	// Connection monitor tags.
	Tags map[string]string `pulumi:"tags"`
	// List of connection monitor test configurations.
	TestConfigurations []ConnectionMonitorTestConfigurationResponse `pulumi:"testConfigurations"`
	// List of connection monitor test groups.
	TestGroups []ConnectionMonitorTestGroupResponse `pulumi:"testGroups"`
	// Connection monitor type.
	Type *string `pulumi:"type"`
}

type ConnectionMonitorState struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrInput
	// Type of connection monitor.
	ConnectionMonitorType pulumi.StringPtrInput
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationResponsePtrInput
	// List of connection monitor endpoints.
	Endpoints ConnectionMonitorEndpointResponseArrayInput
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
	// Optional notes to be associated with the connection monitor.
	Notes pulumi.StringPtrInput
	// List of connection monitor outputs.
	Outputs ConnectionMonitorOutputResponseArrayInput
	// The provisioning state of the connection monitor.
	ProvisioningState pulumi.StringPtrInput
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourceResponsePtrInput
	// The date and time when the connection monitor was started.
	StartTime pulumi.StringPtrInput
	// Connection monitor tags.
	Tags pulumi.StringMapInput
	// List of connection monitor test configurations.
	TestConfigurations ConnectionMonitorTestConfigurationResponseArrayInput
	// List of connection monitor test groups.
	TestGroups ConnectionMonitorTestGroupResponseArrayInput
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
	Destination *ConnectionMonitorDestination `pulumi:"destination"`
	// List of connection monitor endpoints.
	Endpoints []ConnectionMonitorEndpoint `pulumi:"endpoints"`
	// Connection monitor location.
	Location *string `pulumi:"location"`
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds *int `pulumi:"monitoringIntervalInSeconds"`
	// The name of the Network Watcher resource.
	NetworkWatcherName string `pulumi:"networkWatcherName"`
	// Optional notes to be associated with the connection monitor.
	Notes *string `pulumi:"notes"`
	// List of connection monitor outputs.
	Outputs []ConnectionMonitorOutput `pulumi:"outputs"`
	// The name of the resource group containing Network Watcher.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Describes the source of connection monitor.
	Source *ConnectionMonitorSource `pulumi:"source"`
	// Connection monitor tags.
	Tags map[string]string `pulumi:"tags"`
	// List of connection monitor test configurations.
	TestConfigurations []ConnectionMonitorTestConfiguration `pulumi:"testConfigurations"`
	// List of connection monitor test groups.
	TestGroups []ConnectionMonitorTestGroup `pulumi:"testGroups"`
}

// The set of arguments for constructing a ConnectionMonitor resource.
type ConnectionMonitorArgs struct {
	// Determines if the connection monitor will start automatically once created.
	AutoStart pulumi.BoolPtrInput
	// The name of the connection monitor.
	ConnectionMonitorName pulumi.StringInput
	// Describes the destination of connection monitor.
	Destination ConnectionMonitorDestinationPtrInput
	// List of connection monitor endpoints.
	Endpoints ConnectionMonitorEndpointArrayInput
	// Connection monitor location.
	Location pulumi.StringPtrInput
	// Monitoring interval in seconds.
	MonitoringIntervalInSeconds pulumi.IntPtrInput
	// The name of the Network Watcher resource.
	NetworkWatcherName pulumi.StringInput
	// Optional notes to be associated with the connection monitor.
	Notes pulumi.StringPtrInput
	// List of connection monitor outputs.
	Outputs ConnectionMonitorOutputArrayInput
	// The name of the resource group containing Network Watcher.
	ResourceGroupName pulumi.StringInput
	// Describes the source of connection monitor.
	Source ConnectionMonitorSourcePtrInput
	// Connection monitor tags.
	Tags pulumi.StringMapInput
	// List of connection monitor test configurations.
	TestConfigurations ConnectionMonitorTestConfigurationArrayInput
	// List of connection monitor test groups.
	TestGroups ConnectionMonitorTestGroupArrayInput
}

func (ConnectionMonitorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionMonitorArgs)(nil)).Elem()
}
