// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The bandwidth setting.
type BandwidthSetting struct {
	pulumi.CustomResourceState

	// The Kind of the object. Currently only Series8000 is supported
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// The name of the object.
	Name pulumi.StringOutput `pulumi:"name"`
	// The schedules.
	Schedules BandwidthScheduleResponseArrayOutput `pulumi:"schedules"`
	// The hierarchical type of the object.
	Type pulumi.StringOutput `pulumi:"type"`
	// The number of volumes that uses the bandwidth setting.
	VolumeCount pulumi.IntOutput `pulumi:"volumeCount"`
}

// NewBandwidthSetting registers a new resource with the given unique name, arguments, and options.
func NewBandwidthSetting(ctx *pulumi.Context,
	name string, args *BandwidthSettingArgs, opts ...pulumi.ResourceOption) (*BandwidthSetting, error) {
	if args == nil || args.BandwidthSettingName == nil {
		return nil, errors.New("missing required argument 'BandwidthSettingName'")
	}
	if args == nil || args.ManagerName == nil {
		return nil, errors.New("missing required argument 'ManagerName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Schedules == nil {
		return nil, errors.New("missing required argument 'Schedules'")
	}
	if args == nil {
		args = &BandwidthSettingArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storsimple/v20170601:BandwidthSetting"),
		},
	})
	opts = append(opts, aliases)
	var resource BandwidthSetting
	err := ctx.RegisterResource("azure-nextgen:storsimple/latest:BandwidthSetting", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBandwidthSetting gets an existing BandwidthSetting resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBandwidthSetting(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BandwidthSettingState, opts ...pulumi.ResourceOption) (*BandwidthSetting, error) {
	var resource BandwidthSetting
	err := ctx.ReadResource("azure-nextgen:storsimple/latest:BandwidthSetting", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BandwidthSetting resources.
type bandwidthSettingState struct {
	// The Kind of the object. Currently only Series8000 is supported
	Kind *string `pulumi:"kind"`
	// The name of the object.
	Name *string `pulumi:"name"`
	// The schedules.
	Schedules []BandwidthScheduleResponse `pulumi:"schedules"`
	// The hierarchical type of the object.
	Type *string `pulumi:"type"`
	// The number of volumes that uses the bandwidth setting.
	VolumeCount *int `pulumi:"volumeCount"`
}

type BandwidthSettingState struct {
	// The Kind of the object. Currently only Series8000 is supported
	Kind pulumi.StringPtrInput
	// The name of the object.
	Name pulumi.StringPtrInput
	// The schedules.
	Schedules BandwidthScheduleResponseArrayInput
	// The hierarchical type of the object.
	Type pulumi.StringPtrInput
	// The number of volumes that uses the bandwidth setting.
	VolumeCount pulumi.IntPtrInput
}

func (BandwidthSettingState) ElementType() reflect.Type {
	return reflect.TypeOf((*bandwidthSettingState)(nil)).Elem()
}

type bandwidthSettingArgs struct {
	// The bandwidth setting name.
	BandwidthSettingName string `pulumi:"bandwidthSettingName"`
	// The Kind of the object. Currently only Series8000 is supported
	Kind *string `pulumi:"kind"`
	// The manager name
	ManagerName string `pulumi:"managerName"`
	// The resource group name
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The schedules.
	Schedules []BandwidthSchedule `pulumi:"schedules"`
}

// The set of arguments for constructing a BandwidthSetting resource.
type BandwidthSettingArgs struct {
	// The bandwidth setting name.
	BandwidthSettingName pulumi.StringInput
	// The Kind of the object. Currently only Series8000 is supported
	Kind pulumi.StringPtrInput
	// The manager name
	ManagerName pulumi.StringInput
	// The resource group name
	ResourceGroupName pulumi.StringInput
	// The schedules.
	Schedules BandwidthScheduleArrayInput
}

func (BandwidthSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bandwidthSettingArgs)(nil)).Elem()
}