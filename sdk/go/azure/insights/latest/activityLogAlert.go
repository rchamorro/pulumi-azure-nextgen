// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An activity log alert resource.
// Latest API Version: 2017-04-01.
type ActivityLogAlert struct {
	pulumi.CustomResourceState

	// The actions that will activate when the condition is met.
	Actions ActivityLogAlertActionListResponseOutput `pulumi:"actions"`
	// The condition that will cause this alert to activate.
	Condition ActivityLogAlertAllOfConditionResponseOutput `pulumi:"condition"`
	// A description of this activity log alert.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewActivityLogAlert registers a new resource with the given unique name, arguments, and options.
func NewActivityLogAlert(ctx *pulumi.Context,
	name string, args *ActivityLogAlertArgs, opts ...pulumi.ResourceOption) (*ActivityLogAlert, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Actions == nil {
		return nil, errors.New("invalid value for required argument 'Actions'")
	}
	if args.ActivityLogAlertName == nil {
		return nil, errors.New("invalid value for required argument 'ActivityLogAlertName'")
	}
	if args.Condition == nil {
		return nil, errors.New("invalid value for required argument 'Condition'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Scopes == nil {
		return nil, errors.New("invalid value for required argument 'Scopes'")
	}
	if args.Enabled == nil {
		args.Enabled = pulumi.BoolPtr(true)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:insights/v20170401:ActivityLogAlert"),
		},
	})
	opts = append(opts, aliases)
	var resource ActivityLogAlert
	err := ctx.RegisterResource("azure-nextgen:insights/latest:ActivityLogAlert", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetActivityLogAlert gets an existing ActivityLogAlert resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetActivityLogAlert(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ActivityLogAlertState, opts ...pulumi.ResourceOption) (*ActivityLogAlert, error) {
	var resource ActivityLogAlert
	err := ctx.ReadResource("azure-nextgen:insights/latest:ActivityLogAlert", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ActivityLogAlert resources.
type activityLogAlertState struct {
	// The actions that will activate when the condition is met.
	Actions *ActivityLogAlertActionListResponse `pulumi:"actions"`
	// The condition that will cause this alert to activate.
	Condition *ActivityLogAlertAllOfConditionResponse `pulumi:"condition"`
	// A description of this activity log alert.
	Description *string `pulumi:"description"`
	// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
	Enabled *bool `pulumi:"enabled"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
	Scopes []string `pulumi:"scopes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type ActivityLogAlertState struct {
	// The actions that will activate when the condition is met.
	Actions ActivityLogAlertActionListResponsePtrInput
	// The condition that will cause this alert to activate.
	Condition ActivityLogAlertAllOfConditionResponsePtrInput
	// A description of this activity log alert.
	Description pulumi.StringPtrInput
	// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (ActivityLogAlertState) ElementType() reflect.Type {
	return reflect.TypeOf((*activityLogAlertState)(nil)).Elem()
}

type activityLogAlertArgs struct {
	// The actions that will activate when the condition is met.
	Actions ActivityLogAlertActionList `pulumi:"actions"`
	// The name of the activity log alert.
	ActivityLogAlertName string `pulumi:"activityLogAlertName"`
	// The condition that will cause this alert to activate.
	Condition ActivityLogAlertAllOfCondition `pulumi:"condition"`
	// A description of this activity log alert.
	Description *string `pulumi:"description"`
	// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
	Enabled *bool `pulumi:"enabled"`
	// Resource location
	Location string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
	Scopes []string `pulumi:"scopes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ActivityLogAlert resource.
type ActivityLogAlertArgs struct {
	// The actions that will activate when the condition is met.
	Actions ActivityLogAlertActionListInput
	// The name of the activity log alert.
	ActivityLogAlertName pulumi.StringInput
	// The condition that will cause this alert to activate.
	Condition ActivityLogAlertAllOfConditionInput
	// A description of this activity log alert.
	Description pulumi.StringPtrInput
	// Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
	Enabled pulumi.BoolPtrInput
	// Resource location
	Location pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
	Scopes pulumi.StringArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (ActivityLogAlertArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*activityLogAlertArgs)(nil)).Elem()
}

type ActivityLogAlertInput interface {
	pulumi.Input

	ToActivityLogAlertOutput() ActivityLogAlertOutput
	ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput
}

func (*ActivityLogAlert) ElementType() reflect.Type {
	return reflect.TypeOf((*ActivityLogAlert)(nil))
}

func (i *ActivityLogAlert) ToActivityLogAlertOutput() ActivityLogAlertOutput {
	return i.ToActivityLogAlertOutputWithContext(context.Background())
}

func (i *ActivityLogAlert) ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ActivityLogAlertOutput)
}

type ActivityLogAlertOutput struct {
	*pulumi.OutputState
}

func (ActivityLogAlertOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ActivityLogAlert)(nil))
}

func (o ActivityLogAlertOutput) ToActivityLogAlertOutput() ActivityLogAlertOutput {
	return o
}

func (o ActivityLogAlertOutput) ToActivityLogAlertOutputWithContext(ctx context.Context) ActivityLogAlertOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ActivityLogAlertOutput{})
}
