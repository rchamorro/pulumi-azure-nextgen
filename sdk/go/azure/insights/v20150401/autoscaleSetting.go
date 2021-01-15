// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The autoscale setting resource.
type AutoscaleSetting struct {
	pulumi.CustomResourceState

	// the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// the collection of notifications.
	Notifications AutoscaleNotificationResponseArrayOutput `pulumi:"notifications"`
	// the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
	Profiles AutoscaleProfileResponseArrayOutput `pulumi:"profiles"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// the resource identifier of the resource that the autoscale setting should be added to.
	TargetResourceUri pulumi.StringPtrOutput `pulumi:"targetResourceUri"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAutoscaleSetting registers a new resource with the given unique name, arguments, and options.
func NewAutoscaleSetting(ctx *pulumi.Context,
	name string, args *AutoscaleSettingArgs, opts ...pulumi.ResourceOption) (*AutoscaleSetting, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoscaleSettingName == nil {
		return nil, errors.New("invalid value for required argument 'AutoscaleSettingName'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.Profiles == nil {
		return nil, errors.New("invalid value for required argument 'Profiles'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Enabled == nil {
		args.Enabled = pulumi.BoolPtr(true)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:insights/latest:AutoscaleSetting"),
		},
	})
	opts = append(opts, aliases)
	var resource AutoscaleSetting
	err := ctx.RegisterResource("azure-nextgen:insights/v20150401:AutoscaleSetting", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutoscaleSetting gets an existing AutoscaleSetting resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutoscaleSetting(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutoscaleSettingState, opts ...pulumi.ResourceOption) (*AutoscaleSetting, error) {
	var resource AutoscaleSetting
	err := ctx.ReadResource("azure-nextgen:insights/v20150401:AutoscaleSetting", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AutoscaleSetting resources.
type autoscaleSettingState struct {
	// the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
	Enabled *bool `pulumi:"enabled"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// the collection of notifications.
	Notifications []AutoscaleNotificationResponse `pulumi:"notifications"`
	// the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
	Profiles []AutoscaleProfileResponse `pulumi:"profiles"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// the resource identifier of the resource that the autoscale setting should be added to.
	TargetResourceUri *string `pulumi:"targetResourceUri"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type AutoscaleSettingState struct {
	// the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
	Enabled pulumi.BoolPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// the collection of notifications.
	Notifications AutoscaleNotificationResponseArrayInput
	// the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
	Profiles AutoscaleProfileResponseArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// the resource identifier of the resource that the autoscale setting should be added to.
	TargetResourceUri pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (AutoscaleSettingState) ElementType() reflect.Type {
	return reflect.TypeOf((*autoscaleSettingState)(nil)).Elem()
}

type autoscaleSettingArgs struct {
	// The autoscale setting name.
	AutoscaleSettingName string `pulumi:"autoscaleSettingName"`
	// the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
	Enabled *bool `pulumi:"enabled"`
	// Resource location
	Location string `pulumi:"location"`
	// the name of the autoscale setting.
	Name *string `pulumi:"name"`
	// the collection of notifications.
	Notifications []AutoscaleNotification `pulumi:"notifications"`
	// the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
	Profiles []AutoscaleProfile `pulumi:"profiles"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// the resource identifier of the resource that the autoscale setting should be added to.
	TargetResourceUri *string `pulumi:"targetResourceUri"`
}

// The set of arguments for constructing a AutoscaleSetting resource.
type AutoscaleSettingArgs struct {
	// The autoscale setting name.
	AutoscaleSettingName pulumi.StringInput
	// the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
	Enabled pulumi.BoolPtrInput
	// Resource location
	Location pulumi.StringInput
	// the name of the autoscale setting.
	Name pulumi.StringPtrInput
	// the collection of notifications.
	Notifications AutoscaleNotificationArrayInput
	// the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
	Profiles AutoscaleProfileArrayInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// the resource identifier of the resource that the autoscale setting should be added to.
	TargetResourceUri pulumi.StringPtrInput
}

func (AutoscaleSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*autoscaleSettingArgs)(nil)).Elem()
}

type AutoscaleSettingInput interface {
	pulumi.Input

	ToAutoscaleSettingOutput() AutoscaleSettingOutput
	ToAutoscaleSettingOutputWithContext(ctx context.Context) AutoscaleSettingOutput
}

func (*AutoscaleSetting) ElementType() reflect.Type {
	return reflect.TypeOf((*AutoscaleSetting)(nil))
}

func (i *AutoscaleSetting) ToAutoscaleSettingOutput() AutoscaleSettingOutput {
	return i.ToAutoscaleSettingOutputWithContext(context.Background())
}

func (i *AutoscaleSetting) ToAutoscaleSettingOutputWithContext(ctx context.Context) AutoscaleSettingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AutoscaleSettingOutput)
}

type AutoscaleSettingOutput struct {
	*pulumi.OutputState
}

func (AutoscaleSettingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AutoscaleSetting)(nil))
}

func (o AutoscaleSettingOutput) ToAutoscaleSettingOutput() AutoscaleSettingOutput {
	return o
}

func (o AutoscaleSettingOutput) ToAutoscaleSettingOutputWithContext(ctx context.Context) AutoscaleSettingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AutoscaleSettingOutput{})
}
