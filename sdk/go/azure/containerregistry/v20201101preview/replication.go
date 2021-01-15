// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An object that represents a replication for a container registry.
type Replication struct {
	pulumi.CustomResourceState

	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the replication at the time the operation was called.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.
	RegionEndpointEnabled pulumi.BoolPtrOutput `pulumi:"regionEndpointEnabled"`
	// The status of the replication at the time the operation was called.
	Status StatusResponseOutput `pulumi:"status"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// Whether or not zone redundancy is enabled for this container registry replication
	ZoneRedundancy pulumi.StringPtrOutput `pulumi:"zoneRedundancy"`
}

// NewReplication registers a new resource with the given unique name, arguments, and options.
func NewReplication(ctx *pulumi.Context,
	name string, args *ReplicationArgs, opts ...pulumi.ResourceOption) (*Replication, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.RegistryName == nil {
		return nil, errors.New("invalid value for required argument 'RegistryName'")
	}
	if args.ReplicationName == nil {
		return nil, errors.New("invalid value for required argument 'ReplicationName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.RegionEndpointEnabled == nil {
		args.RegionEndpointEnabled = pulumi.BoolPtr(true)
	}
	if args.ZoneRedundancy == nil {
		args.ZoneRedundancy = pulumi.StringPtr("Disabled")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:containerregistry/latest:Replication"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20170601preview:Replication"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20171001:Replication"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20190501:Replication"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerregistry/v20191201preview:Replication"),
		},
	})
	opts = append(opts, aliases)
	var resource Replication
	err := ctx.RegisterResource("azure-nextgen:containerregistry/v20201101preview:Replication", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReplication gets an existing Replication resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReplicationState, opts ...pulumi.ResourceOption) (*Replication, error) {
	var resource Replication
	err := ctx.ReadResource("azure-nextgen:containerregistry/v20201101preview:Replication", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Replication resources.
type replicationState struct {
	// The location of the resource. This cannot be changed after the resource is created.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the replication at the time the operation was called.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.
	RegionEndpointEnabled *bool `pulumi:"regionEndpointEnabled"`
	// The status of the replication at the time the operation was called.
	Status *StatusResponse `pulumi:"status"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// Whether or not zone redundancy is enabled for this container registry replication
	ZoneRedundancy *string `pulumi:"zoneRedundancy"`
}

type ReplicationState struct {
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the replication at the time the operation was called.
	ProvisioningState pulumi.StringPtrInput
	// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.
	RegionEndpointEnabled pulumi.BoolPtrInput
	// The status of the replication at the time the operation was called.
	Status StatusResponsePtrInput
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponsePtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// Whether or not zone redundancy is enabled for this container registry replication
	ZoneRedundancy pulumi.StringPtrInput
}

func (ReplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationState)(nil)).Elem()
}

type replicationArgs struct {
	// The location of the resource. This cannot be changed after the resource is created.
	Location string `pulumi:"location"`
	// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.
	RegionEndpointEnabled *bool `pulumi:"regionEndpointEnabled"`
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the replication.
	ReplicationName string `pulumi:"replicationName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// Whether or not zone redundancy is enabled for this container registry replication
	ZoneRedundancy *string `pulumi:"zoneRedundancy"`
}

// The set of arguments for constructing a Replication resource.
type ReplicationArgs struct {
	// The location of the resource. This cannot be changed after the resource is created.
	Location pulumi.StringInput
	// Specifies whether the replication's regional endpoint is enabled. Requests will not be routed to a replication whose regional endpoint is disabled, however its data will continue to be synced with other replications.
	RegionEndpointEnabled pulumi.BoolPtrInput
	// The name of the container registry.
	RegistryName pulumi.StringInput
	// The name of the replication.
	ReplicationName pulumi.StringInput
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName pulumi.StringInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// Whether or not zone redundancy is enabled for this container registry replication
	ZoneRedundancy pulumi.StringPtrInput
}

func (ReplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationArgs)(nil)).Elem()
}

type ReplicationInput interface {
	pulumi.Input

	ToReplicationOutput() ReplicationOutput
	ToReplicationOutputWithContext(ctx context.Context) ReplicationOutput
}

func (*Replication) ElementType() reflect.Type {
	return reflect.TypeOf((*Replication)(nil))
}

func (i *Replication) ToReplicationOutput() ReplicationOutput {
	return i.ToReplicationOutputWithContext(context.Background())
}

func (i *Replication) ToReplicationOutputWithContext(ctx context.Context) ReplicationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicationOutput)
}

type ReplicationOutput struct {
	*pulumi.OutputState
}

func (ReplicationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Replication)(nil))
}

func (o ReplicationOutput) ToReplicationOutput() ReplicationOutput {
	return o
}

func (o ReplicationOutput) ToReplicationOutputWithContext(ctx context.Context) ReplicationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ReplicationOutput{})
}
