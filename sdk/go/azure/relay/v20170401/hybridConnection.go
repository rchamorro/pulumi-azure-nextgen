// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Description of hybrid connection resource.
type HybridConnection struct {
	pulumi.CustomResourceState

	// The time the hybrid connection was created.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported.
	ListenerCount pulumi.IntOutput `pulumi:"listenerCount"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Returns true if client authorization is needed for this hybrid connection; otherwise, false.
	RequiresClientAuthorization pulumi.BoolPtrOutput `pulumi:"requiresClientAuthorization"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The time the namespace was updated.
	UpdatedAt pulumi.StringOutput `pulumi:"updatedAt"`
	// The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored.
	UserMetadata pulumi.StringPtrOutput `pulumi:"userMetadata"`
}

// NewHybridConnection registers a new resource with the given unique name, arguments, and options.
func NewHybridConnection(ctx *pulumi.Context,
	name string, args *HybridConnectionArgs, opts ...pulumi.ResourceOption) (*HybridConnection, error) {
	if args == nil || args.HybridConnectionName == nil {
		return nil, errors.New("missing required argument 'HybridConnectionName'")
	}
	if args == nil || args.NamespaceName == nil {
		return nil, errors.New("missing required argument 'NamespaceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &HybridConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:relay/latest:HybridConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:relay/v20160701:HybridConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource HybridConnection
	err := ctx.RegisterResource("azure-nextgen:relay/v20170401:HybridConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHybridConnection gets an existing HybridConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHybridConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HybridConnectionState, opts ...pulumi.ResourceOption) (*HybridConnection, error) {
	var resource HybridConnection
	err := ctx.ReadResource("azure-nextgen:relay/v20170401:HybridConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HybridConnection resources.
type hybridConnectionState struct {
	// The time the hybrid connection was created.
	CreatedAt *string `pulumi:"createdAt"`
	// The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported.
	ListenerCount *int `pulumi:"listenerCount"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Returns true if client authorization is needed for this hybrid connection; otherwise, false.
	RequiresClientAuthorization *bool `pulumi:"requiresClientAuthorization"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The time the namespace was updated.
	UpdatedAt *string `pulumi:"updatedAt"`
	// The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored.
	UserMetadata *string `pulumi:"userMetadata"`
}

type HybridConnectionState struct {
	// The time the hybrid connection was created.
	CreatedAt pulumi.StringPtrInput
	// The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported.
	ListenerCount pulumi.IntPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Returns true if client authorization is needed for this hybrid connection; otherwise, false.
	RequiresClientAuthorization pulumi.BoolPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The time the namespace was updated.
	UpdatedAt pulumi.StringPtrInput
	// The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored.
	UserMetadata pulumi.StringPtrInput
}

func (HybridConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*hybridConnectionState)(nil)).Elem()
}

type hybridConnectionArgs struct {
	// The hybrid connection name.
	HybridConnectionName string `pulumi:"hybridConnectionName"`
	// The namespace name
	NamespaceName string `pulumi:"namespaceName"`
	// Returns true if client authorization is needed for this hybrid connection; otherwise, false.
	RequiresClientAuthorization *bool `pulumi:"requiresClientAuthorization"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored.
	UserMetadata *string `pulumi:"userMetadata"`
}

// The set of arguments for constructing a HybridConnection resource.
type HybridConnectionArgs struct {
	// The hybrid connection name.
	HybridConnectionName pulumi.StringInput
	// The namespace name
	NamespaceName pulumi.StringInput
	// Returns true if client authorization is needed for this hybrid connection; otherwise, false.
	RequiresClientAuthorization pulumi.BoolPtrInput
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored.
	UserMetadata pulumi.StringPtrInput
}

func (HybridConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*hybridConnectionArgs)(nil)).Elem()
}

type HybridConnectionInput interface {
	pulumi.Input

	ToHybridConnectionOutput() HybridConnectionOutput
	ToHybridConnectionOutputWithContext(ctx context.Context) HybridConnectionOutput
}

func (HybridConnection) ElementType() reflect.Type {
	return reflect.TypeOf((*HybridConnection)(nil)).Elem()
}

func (i HybridConnection) ToHybridConnectionOutput() HybridConnectionOutput {
	return i.ToHybridConnectionOutputWithContext(context.Background())
}

func (i HybridConnection) ToHybridConnectionOutputWithContext(ctx context.Context) HybridConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HybridConnectionOutput)
}

type HybridConnectionOutput struct {
	*pulumi.OutputState
}

func (HybridConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*HybridConnectionOutput)(nil)).Elem()
}

func (o HybridConnectionOutput) ToHybridConnectionOutput() HybridConnectionOutput {
	return o
}

func (o HybridConnectionOutput) ToHybridConnectionOutputWithContext(ctx context.Context) HybridConnectionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(HybridConnectionOutput{})
}
