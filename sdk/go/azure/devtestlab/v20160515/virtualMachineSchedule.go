// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160515

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A schedule.
type VirtualMachineSchedule struct {
	pulumi.CustomResourceState

	// The creation date of the schedule.
	CreatedDate pulumi.StringOutput `pulumi:"createdDate"`
	// If the schedule will occur once each day of the week, specify the daily recurrence.
	DailyRecurrence DayDetailsResponsePtrOutput `pulumi:"dailyRecurrence"`
	// If the schedule will occur multiple times a day, specify the hourly recurrence.
	HourlyRecurrence HourDetailsResponsePtrOutput `pulumi:"hourlyRecurrence"`
	// The location of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// Notification settings.
	NotificationSettings NotificationSettingsResponsePtrOutput `pulumi:"notificationSettings"`
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The status of the schedule (i.e. Enabled, Disabled)
	Status pulumi.StringPtrOutput `pulumi:"status"`
	// The tags of the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The resource ID to which the schedule belongs
	TargetResourceId pulumi.StringPtrOutput `pulumi:"targetResourceId"`
	// The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
	TaskType pulumi.StringPtrOutput `pulumi:"taskType"`
	// The time zone ID (e.g. Pacific Standard time).
	TimeZoneId pulumi.StringPtrOutput `pulumi:"timeZoneId"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringPtrOutput `pulumi:"uniqueIdentifier"`
	// If the schedule will occur only some days of the week, specify the weekly recurrence.
	WeeklyRecurrence WeekDetailsResponsePtrOutput `pulumi:"weeklyRecurrence"`
}

// NewVirtualMachineSchedule registers a new resource with the given unique name, arguments, and options.
func NewVirtualMachineSchedule(ctx *pulumi.Context,
	name string, args *VirtualMachineScheduleArgs, opts ...pulumi.ResourceOption) (*VirtualMachineSchedule, error) {
	if args == nil || args.LabName == nil {
		return nil, errors.New("missing required argument 'LabName'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VirtualMachineName == nil {
		return nil, errors.New("missing required argument 'VirtualMachineName'")
	}
	if args == nil {
		args = &VirtualMachineScheduleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:devtestlab/latest:VirtualMachineSchedule"),
		},
		{
			Type: pulumi.String("azure-nextgen:devtestlab/v20180915:VirtualMachineSchedule"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualMachineSchedule
	err := ctx.RegisterResource("azure-nextgen:devtestlab/v20160515:VirtualMachineSchedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualMachineSchedule gets an existing VirtualMachineSchedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualMachineSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualMachineScheduleState, opts ...pulumi.ResourceOption) (*VirtualMachineSchedule, error) {
	var resource VirtualMachineSchedule
	err := ctx.ReadResource("azure-nextgen:devtestlab/v20160515:VirtualMachineSchedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualMachineSchedule resources.
type virtualMachineScheduleState struct {
	// The creation date of the schedule.
	CreatedDate *string `pulumi:"createdDate"`
	// If the schedule will occur once each day of the week, specify the daily recurrence.
	DailyRecurrence *DayDetailsResponse `pulumi:"dailyRecurrence"`
	// If the schedule will occur multiple times a day, specify the hourly recurrence.
	HourlyRecurrence *HourDetailsResponse `pulumi:"hourlyRecurrence"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// Notification settings.
	NotificationSettings *NotificationSettingsResponse `pulumi:"notificationSettings"`
	// The provisioning status of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The status of the schedule (i.e. Enabled, Disabled)
	Status *string `pulumi:"status"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The resource ID to which the schedule belongs
	TargetResourceId *string `pulumi:"targetResourceId"`
	// The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
	TaskType *string `pulumi:"taskType"`
	// The time zone ID (e.g. Pacific Standard time).
	TimeZoneId *string `pulumi:"timeZoneId"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier *string `pulumi:"uniqueIdentifier"`
	// If the schedule will occur only some days of the week, specify the weekly recurrence.
	WeeklyRecurrence *WeekDetailsResponse `pulumi:"weeklyRecurrence"`
}

type VirtualMachineScheduleState struct {
	// The creation date of the schedule.
	CreatedDate pulumi.StringPtrInput
	// If the schedule will occur once each day of the week, specify the daily recurrence.
	DailyRecurrence DayDetailsResponsePtrInput
	// If the schedule will occur multiple times a day, specify the hourly recurrence.
	HourlyRecurrence HourDetailsResponsePtrInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// Notification settings.
	NotificationSettings NotificationSettingsResponsePtrInput
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The status of the schedule (i.e. Enabled, Disabled)
	Status pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The resource ID to which the schedule belongs
	TargetResourceId pulumi.StringPtrInput
	// The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
	TaskType pulumi.StringPtrInput
	// The time zone ID (e.g. Pacific Standard time).
	TimeZoneId pulumi.StringPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringPtrInput
	// If the schedule will occur only some days of the week, specify the weekly recurrence.
	WeeklyRecurrence WeekDetailsResponsePtrInput
}

func (VirtualMachineScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineScheduleState)(nil)).Elem()
}

type virtualMachineScheduleArgs struct {
	// If the schedule will occur once each day of the week, specify the daily recurrence.
	DailyRecurrence *DayDetails `pulumi:"dailyRecurrence"`
	// If the schedule will occur multiple times a day, specify the hourly recurrence.
	HourlyRecurrence *HourDetails `pulumi:"hourlyRecurrence"`
	// The name of the lab.
	LabName string `pulumi:"labName"`
	// The location of the resource.
	Location *string `pulumi:"location"`
	// The name of the schedule.
	Name string `pulumi:"name"`
	// Notification settings.
	NotificationSettings *NotificationSettings `pulumi:"notificationSettings"`
	// The provisioning status of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The status of the schedule (i.e. Enabled, Disabled)
	Status *string `pulumi:"status"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The resource ID to which the schedule belongs
	TargetResourceId *string `pulumi:"targetResourceId"`
	// The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
	TaskType *string `pulumi:"taskType"`
	// The time zone ID (e.g. Pacific Standard time).
	TimeZoneId *string `pulumi:"timeZoneId"`
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier *string `pulumi:"uniqueIdentifier"`
	// The name of the virtual machine.
	VirtualMachineName string `pulumi:"virtualMachineName"`
	// If the schedule will occur only some days of the week, specify the weekly recurrence.
	WeeklyRecurrence *WeekDetails `pulumi:"weeklyRecurrence"`
}

// The set of arguments for constructing a VirtualMachineSchedule resource.
type VirtualMachineScheduleArgs struct {
	// If the schedule will occur once each day of the week, specify the daily recurrence.
	DailyRecurrence DayDetailsPtrInput
	// If the schedule will occur multiple times a day, specify the hourly recurrence.
	HourlyRecurrence HourDetailsPtrInput
	// The name of the lab.
	LabName pulumi.StringInput
	// The location of the resource.
	Location pulumi.StringPtrInput
	// The name of the schedule.
	Name pulumi.StringInput
	// Notification settings.
	NotificationSettings NotificationSettingsPtrInput
	// The provisioning status of the resource.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The status of the schedule (i.e. Enabled, Disabled)
	Status pulumi.StringPtrInput
	// The tags of the resource.
	Tags pulumi.StringMapInput
	// The resource ID to which the schedule belongs
	TargetResourceId pulumi.StringPtrInput
	// The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
	TaskType pulumi.StringPtrInput
	// The time zone ID (e.g. Pacific Standard time).
	TimeZoneId pulumi.StringPtrInput
	// The unique immutable identifier of a resource (Guid).
	UniqueIdentifier pulumi.StringPtrInput
	// The name of the virtual machine.
	VirtualMachineName pulumi.StringInput
	// If the schedule will occur only some days of the week, specify the weekly recurrence.
	WeeklyRecurrence WeekDetailsPtrInput
}

func (VirtualMachineScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineScheduleArgs)(nil)).Elem()
}

type VirtualMachineScheduleInput interface {
	pulumi.Input

	ToVirtualMachineScheduleOutput() VirtualMachineScheduleOutput
	ToVirtualMachineScheduleOutputWithContext(ctx context.Context) VirtualMachineScheduleOutput
}

func (VirtualMachineSchedule) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMachineSchedule)(nil)).Elem()
}

func (i VirtualMachineSchedule) ToVirtualMachineScheduleOutput() VirtualMachineScheduleOutput {
	return i.ToVirtualMachineScheduleOutputWithContext(context.Background())
}

func (i VirtualMachineSchedule) ToVirtualMachineScheduleOutputWithContext(ctx context.Context) VirtualMachineScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineScheduleOutput)
}

type VirtualMachineScheduleOutput struct {
	*pulumi.OutputState
}

func (VirtualMachineScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMachineScheduleOutput)(nil)).Elem()
}

func (o VirtualMachineScheduleOutput) ToVirtualMachineScheduleOutput() VirtualMachineScheduleOutput {
	return o
}

func (o VirtualMachineScheduleOutput) ToVirtualMachineScheduleOutputWithContext(ctx context.Context) VirtualMachineScheduleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualMachineScheduleOutput{})
}
