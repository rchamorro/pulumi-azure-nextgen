// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A report config resource.
type ReportConfig struct {
	pulumi.CustomResourceState

	// Has definition for the report config.
	Definition ReportConfigDefinitionResponseOutput `pulumi:"definition"`
	// Has delivery information for the report config.
	DeliveryInfo ReportConfigDeliveryInfoResponseOutput `pulumi:"deliveryInfo"`
	// The format of the report being delivered.
	Format pulumi.StringPtrOutput `pulumi:"format"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Has schedule information for the report config.
	Schedule ReportConfigScheduleResponsePtrOutput `pulumi:"schedule"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewReportConfig registers a new resource with the given unique name, arguments, and options.
func NewReportConfig(ctx *pulumi.Context,
	name string, args *ReportConfigArgs, opts ...pulumi.ResourceOption) (*ReportConfig, error) {
	if args == nil || args.Definition == nil {
		return nil, errors.New("missing required argument 'Definition'")
	}
	if args == nil || args.DeliveryInfo == nil {
		return nil, errors.New("missing required argument 'DeliveryInfo'")
	}
	if args == nil || args.ReportConfigName == nil {
		return nil, errors.New("missing required argument 'ReportConfigName'")
	}
	if args == nil {
		args = &ReportConfigArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20180531:ReportConfig"),
		},
	})
	opts = append(opts, aliases)
	var resource ReportConfig
	err := ctx.RegisterResource("azure-nextgen:costmanagement/latest:ReportConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReportConfig gets an existing ReportConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReportConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReportConfigState, opts ...pulumi.ResourceOption) (*ReportConfig, error) {
	var resource ReportConfig
	err := ctx.ReadResource("azure-nextgen:costmanagement/latest:ReportConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReportConfig resources.
type reportConfigState struct {
	// Has definition for the report config.
	Definition *ReportConfigDefinitionResponse `pulumi:"definition"`
	// Has delivery information for the report config.
	DeliveryInfo *ReportConfigDeliveryInfoResponse `pulumi:"deliveryInfo"`
	// The format of the report being delivered.
	Format *string `pulumi:"format"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Has schedule information for the report config.
	Schedule *ReportConfigScheduleResponse `pulumi:"schedule"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ReportConfigState struct {
	// Has definition for the report config.
	Definition ReportConfigDefinitionResponsePtrInput
	// Has delivery information for the report config.
	DeliveryInfo ReportConfigDeliveryInfoResponsePtrInput
	// The format of the report being delivered.
	Format pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Has schedule information for the report config.
	Schedule ReportConfigScheduleResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ReportConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*reportConfigState)(nil)).Elem()
}

type reportConfigArgs struct {
	// Has definition for the report config.
	Definition ReportConfigDefinition `pulumi:"definition"`
	// Has delivery information for the report config.
	DeliveryInfo ReportConfigDeliveryInfo `pulumi:"deliveryInfo"`
	// The format of the report being delivered.
	Format *string `pulumi:"format"`
	// Report Config Name.
	ReportConfigName string `pulumi:"reportConfigName"`
	// Has schedule information for the report config.
	Schedule *ReportConfigSchedule `pulumi:"schedule"`
}

// The set of arguments for constructing a ReportConfig resource.
type ReportConfigArgs struct {
	// Has definition for the report config.
	Definition ReportConfigDefinitionInput
	// Has delivery information for the report config.
	DeliveryInfo ReportConfigDeliveryInfoInput
	// The format of the report being delivered.
	Format pulumi.StringPtrInput
	// Report Config Name.
	ReportConfigName pulumi.StringInput
	// Has schedule information for the report config.
	Schedule ReportConfigSchedulePtrInput
}

func (ReportConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*reportConfigArgs)(nil)).Elem()
}

type ReportConfigInput interface {
	pulumi.Input

	ToReportConfigOutput() ReportConfigOutput
	ToReportConfigOutputWithContext(ctx context.Context) ReportConfigOutput
}

func (ReportConfig) ElementType() reflect.Type {
	return reflect.TypeOf((*ReportConfig)(nil)).Elem()
}

func (i ReportConfig) ToReportConfigOutput() ReportConfigOutput {
	return i.ToReportConfigOutputWithContext(context.Background())
}

func (i ReportConfig) ToReportConfigOutputWithContext(ctx context.Context) ReportConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReportConfigOutput)
}

type ReportConfigOutput struct {
	*pulumi.OutputState
}

func (ReportConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReportConfigOutput)(nil)).Elem()
}

func (o ReportConfigOutput) ToReportConfigOutput() ReportConfigOutput {
	return o
}

func (o ReportConfigOutput) ToReportConfigOutputWithContext(ctx context.Context) ReportConfigOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ReportConfigOutput{})
}
