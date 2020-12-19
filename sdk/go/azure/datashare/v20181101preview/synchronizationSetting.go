// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Synchronization Setting data transfer object.
type SynchronizationSetting struct {
	pulumi.CustomResourceState

	// Kind of synchronization
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Name of the azure resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Type of the azure resource
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSynchronizationSetting registers a new resource with the given unique name, arguments, and options.
func NewSynchronizationSetting(ctx *pulumi.Context,
	name string, args *SynchronizationSettingArgs, opts ...pulumi.ResourceOption) (*SynchronizationSetting, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.Kind == nil {
		return nil, errors.New("invalid value for required argument 'Kind'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ShareName == nil {
		return nil, errors.New("invalid value for required argument 'ShareName'")
	}
	if args.SynchronizationSettingName == nil {
		return nil, errors.New("invalid value for required argument 'SynchronizationSettingName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:datashare/latest:SynchronizationSetting"),
		},
		{
			Type: pulumi.String("azure-nextgen:datashare/v20191101:SynchronizationSetting"),
		},
	})
	opts = append(opts, aliases)
	var resource SynchronizationSetting
	err := ctx.RegisterResource("azure-nextgen:datashare/v20181101preview:SynchronizationSetting", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSynchronizationSetting gets an existing SynchronizationSetting resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSynchronizationSetting(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SynchronizationSettingState, opts ...pulumi.ResourceOption) (*SynchronizationSetting, error) {
	var resource SynchronizationSetting
	err := ctx.ReadResource("azure-nextgen:datashare/v20181101preview:SynchronizationSetting", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SynchronizationSetting resources.
type synchronizationSettingState struct {
	// Kind of synchronization
	Kind *string `pulumi:"kind"`
	// Name of the azure resource
	Name *string `pulumi:"name"`
	// Type of the azure resource
	Type *string `pulumi:"type"`
}

type SynchronizationSettingState struct {
	// Kind of synchronization
	Kind pulumi.StringPtrInput
	// Name of the azure resource
	Name pulumi.StringPtrInput
	// Type of the azure resource
	Type pulumi.StringPtrInput
}

func (SynchronizationSettingState) ElementType() reflect.Type {
	return reflect.TypeOf((*synchronizationSettingState)(nil)).Elem()
}

type synchronizationSettingArgs struct {
	// The name of the share account.
	AccountName string `pulumi:"accountName"`
	// Kind of synchronization
	Kind string `pulumi:"kind"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the share to add the synchronization setting to.
	ShareName string `pulumi:"shareName"`
	// The name of the synchronizationSetting.
	SynchronizationSettingName string `pulumi:"synchronizationSettingName"`
}

// The set of arguments for constructing a SynchronizationSetting resource.
type SynchronizationSettingArgs struct {
	// The name of the share account.
	AccountName pulumi.StringInput
	// Kind of synchronization
	Kind pulumi.StringInput
	// The resource group name.
	ResourceGroupName pulumi.StringInput
	// The name of the share to add the synchronization setting to.
	ShareName pulumi.StringInput
	// The name of the synchronizationSetting.
	SynchronizationSettingName pulumi.StringInput
}

func (SynchronizationSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*synchronizationSettingArgs)(nil)).Elem()
}

type SynchronizationSettingInput interface {
	pulumi.Input

	ToSynchronizationSettingOutput() SynchronizationSettingOutput
	ToSynchronizationSettingOutputWithContext(ctx context.Context) SynchronizationSettingOutput
}

func (*SynchronizationSetting) ElementType() reflect.Type {
	return reflect.TypeOf((*SynchronizationSetting)(nil))
}

func (i *SynchronizationSetting) ToSynchronizationSettingOutput() SynchronizationSettingOutput {
	return i.ToSynchronizationSettingOutputWithContext(context.Background())
}

func (i *SynchronizationSetting) ToSynchronizationSettingOutputWithContext(ctx context.Context) SynchronizationSettingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SynchronizationSettingOutput)
}

type SynchronizationSettingOutput struct {
	*pulumi.OutputState
}

func (SynchronizationSettingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SynchronizationSetting)(nil))
}

func (o SynchronizationSettingOutput) ToSynchronizationSettingOutput() SynchronizationSettingOutput {
	return o
}

func (o SynchronizationSettingOutput) ToSynchronizationSettingOutputWithContext(ctx context.Context) SynchronizationSettingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SynchronizationSettingOutput{})
}
