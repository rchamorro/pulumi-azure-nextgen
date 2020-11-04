// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Network watcher in a resource group.
type NetworkWatcher struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the network watcher resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNetworkWatcher registers a new resource with the given unique name, arguments, and options.
func NewNetworkWatcher(ctx *pulumi.Context,
	name string, args *NetworkWatcherArgs, opts ...pulumi.ResourceOption) (*NetworkWatcher, error) {
	if args == nil || args.NetworkWatcherName == nil {
		return nil, errors.New("missing required argument 'NetworkWatcherName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &NetworkWatcherArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:NetworkWatcher"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:NetworkWatcher"),
		},
	})
	opts = append(opts, aliases)
	var resource NetworkWatcher
	err := ctx.RegisterResource("azure-nextgen:network/v20200601:NetworkWatcher", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkWatcher gets an existing NetworkWatcher resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkWatcher(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkWatcherState, opts ...pulumi.ResourceOption) (*NetworkWatcher, error) {
	var resource NetworkWatcher
	err := ctx.ReadResource("azure-nextgen:network/v20200601:NetworkWatcher", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkWatcher resources.
type networkWatcherState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the network watcher resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type NetworkWatcherState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the network watcher resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (NetworkWatcherState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkWatcherState)(nil)).Elem()
}

type networkWatcherArgs struct {
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the network watcher.
	NetworkWatcherName string `pulumi:"networkWatcherName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NetworkWatcher resource.
type NetworkWatcherArgs struct {
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the network watcher.
	NetworkWatcherName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (NetworkWatcherArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkWatcherArgs)(nil)).Elem()
}
