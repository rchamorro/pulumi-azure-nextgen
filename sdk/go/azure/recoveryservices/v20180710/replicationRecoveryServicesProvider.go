// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180710

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provider details.
type ReplicationRecoveryServicesProvider struct {
	pulumi.CustomResourceState

	// Resource Location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringOutput `pulumi:"name"`
	// Provider properties.
	Properties RecoveryServicesProviderPropertiesResponseOutput `pulumi:"properties"`
	// Resource Type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewReplicationRecoveryServicesProvider registers a new resource with the given unique name, arguments, and options.
func NewReplicationRecoveryServicesProvider(ctx *pulumi.Context,
	name string, args *ReplicationRecoveryServicesProviderArgs, opts ...pulumi.ResourceOption) (*ReplicationRecoveryServicesProvider, error) {
	if args == nil || args.FabricName == nil {
		return nil, errors.New("missing required argument 'FabricName'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil || args.ProviderName == nil {
		return nil, errors.New("missing required argument 'ProviderName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ResourceName == nil {
		return nil, errors.New("missing required argument 'ResourceName'")
	}
	if args == nil {
		args = &ReplicationRecoveryServicesProviderArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:recoveryservices/latest:ReplicationRecoveryServicesProvider"),
		},
		{
			Type: pulumi.String("azure-nextgen:recoveryservices/v20180110:ReplicationRecoveryServicesProvider"),
		},
	})
	opts = append(opts, aliases)
	var resource ReplicationRecoveryServicesProvider
	err := ctx.RegisterResource("azure-nextgen:recoveryservices/v20180710:ReplicationRecoveryServicesProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReplicationRecoveryServicesProvider gets an existing ReplicationRecoveryServicesProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReplicationRecoveryServicesProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReplicationRecoveryServicesProviderState, opts ...pulumi.ResourceOption) (*ReplicationRecoveryServicesProvider, error) {
	var resource ReplicationRecoveryServicesProvider
	err := ctx.ReadResource("azure-nextgen:recoveryservices/v20180710:ReplicationRecoveryServicesProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReplicationRecoveryServicesProvider resources.
type replicationRecoveryServicesProviderState struct {
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Provider properties.
	Properties *RecoveryServicesProviderPropertiesResponse `pulumi:"properties"`
	// Resource Type
	Type *string `pulumi:"type"`
}

type ReplicationRecoveryServicesProviderState struct {
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Provider properties.
	Properties RecoveryServicesProviderPropertiesResponsePtrInput
	// Resource Type
	Type pulumi.StringPtrInput
}

func (ReplicationRecoveryServicesProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationRecoveryServicesProviderState)(nil)).Elem()
}

type replicationRecoveryServicesProviderArgs struct {
	// Fabric name.
	FabricName string `pulumi:"fabricName"`
	// The properties of an add provider request.
	Properties AddRecoveryServicesProviderInputProperties `pulumi:"properties"`
	// Recovery services provider name.
	ProviderName string `pulumi:"providerName"`
	// The name of the resource group where the recovery services vault is present.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the recovery services vault.
	ResourceName string `pulumi:"resourceName"`
}

// The set of arguments for constructing a ReplicationRecoveryServicesProvider resource.
type ReplicationRecoveryServicesProviderArgs struct {
	// Fabric name.
	FabricName pulumi.StringInput
	// The properties of an add provider request.
	Properties AddRecoveryServicesProviderInputPropertiesInput
	// Recovery services provider name.
	ProviderName pulumi.StringInput
	// The name of the resource group where the recovery services vault is present.
	ResourceGroupName pulumi.StringInput
	// The name of the recovery services vault.
	ResourceName pulumi.StringInput
}

func (ReplicationRecoveryServicesProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationRecoveryServicesProviderArgs)(nil)).Elem()
}

type ReplicationRecoveryServicesProviderInput interface {
	pulumi.Input

	ToReplicationRecoveryServicesProviderOutput() ReplicationRecoveryServicesProviderOutput
	ToReplicationRecoveryServicesProviderOutputWithContext(ctx context.Context) ReplicationRecoveryServicesProviderOutput
}

func (ReplicationRecoveryServicesProvider) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicationRecoveryServicesProvider)(nil)).Elem()
}

func (i ReplicationRecoveryServicesProvider) ToReplicationRecoveryServicesProviderOutput() ReplicationRecoveryServicesProviderOutput {
	return i.ToReplicationRecoveryServicesProviderOutputWithContext(context.Background())
}

func (i ReplicationRecoveryServicesProvider) ToReplicationRecoveryServicesProviderOutputWithContext(ctx context.Context) ReplicationRecoveryServicesProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicationRecoveryServicesProviderOutput)
}

type ReplicationRecoveryServicesProviderOutput struct {
	*pulumi.OutputState
}

func (ReplicationRecoveryServicesProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicationRecoveryServicesProviderOutput)(nil)).Elem()
}

func (o ReplicationRecoveryServicesProviderOutput) ToReplicationRecoveryServicesProviderOutput() ReplicationRecoveryServicesProviderOutput {
	return o
}

func (o ReplicationRecoveryServicesProviderOutput) ToReplicationRecoveryServicesProviderOutputWithContext(ctx context.Context) ReplicationRecoveryServicesProviderOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ReplicationRecoveryServicesProviderOutput{})
}
