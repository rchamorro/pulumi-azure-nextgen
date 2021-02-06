// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200804preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The health alert resource.
type HealthAlert struct {
	pulumi.CustomResourceState

	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions HealthAlertActionResponseArrayOutput `pulumi:"actions"`
	// defines the specific alert criteria information.
	Criteria HealthAlertCriteriaResponseOutput `pulumi:"criteria"`
	// the description of the health alert that will be included in the alert email.
	Description pulumi.StringOutput `pulumi:"description"`
	// the flag that indicates whether the health alert is enabled.
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Last time the rule was updated in ISO8601 format.
	LastUpdatedTime pulumi.StringOutput `pulumi:"lastUpdatedTime"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// the list of resource id's that this health alert is scoped to.
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewHealthAlert registers a new resource with the given unique name, arguments, and options.
func NewHealthAlert(ctx *pulumi.Context,
	name string, args *HealthAlertArgs, opts ...pulumi.ResourceOption) (*HealthAlert, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Criteria == nil {
		return nil, errors.New("invalid value for required argument 'Criteria'")
	}
	if args.Description == nil {
		return nil, errors.New("invalid value for required argument 'Description'")
	}
	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.RuleName == nil {
		return nil, errors.New("invalid value for required argument 'RuleName'")
	}
	var resource HealthAlert
	err := ctx.RegisterResource("azure-nextgen:alertsmanagement/v20200804preview:HealthAlert", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHealthAlert gets an existing HealthAlert resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHealthAlert(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HealthAlertState, opts ...pulumi.ResourceOption) (*HealthAlert, error) {
	var resource HealthAlert
	err := ctx.ReadResource("azure-nextgen:alertsmanagement/v20200804preview:HealthAlert", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HealthAlert resources.
type healthAlertState struct {
	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions []HealthAlertActionResponse `pulumi:"actions"`
	// defines the specific alert criteria information.
	Criteria *HealthAlertCriteriaResponse `pulumi:"criteria"`
	// the description of the health alert that will be included in the alert email.
	Description *string `pulumi:"description"`
	// the flag that indicates whether the health alert is enabled.
	Enabled *bool `pulumi:"enabled"`
	// Last time the rule was updated in ISO8601 format.
	LastUpdatedTime *string `pulumi:"lastUpdatedTime"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// the list of resource id's that this health alert is scoped to.
	Scopes []string `pulumi:"scopes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type HealthAlertState struct {
	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions HealthAlertActionResponseArrayInput
	// defines the specific alert criteria information.
	Criteria HealthAlertCriteriaResponsePtrInput
	// the description of the health alert that will be included in the alert email.
	Description pulumi.StringPtrInput
	// the flag that indicates whether the health alert is enabled.
	Enabled pulumi.BoolPtrInput
	// Last time the rule was updated in ISO8601 format.
	LastUpdatedTime pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// the list of resource id's that this health alert is scoped to.
	Scopes pulumi.StringArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (HealthAlertState) ElementType() reflect.Type {
	return reflect.TypeOf((*healthAlertState)(nil)).Elem()
}

type healthAlertArgs struct {
	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions []HealthAlertAction `pulumi:"actions"`
	// defines the specific alert criteria information.
	Criteria HealthAlertCriteria `pulumi:"criteria"`
	// the description of the health alert that will be included in the alert email.
	Description string `pulumi:"description"`
	// the flag that indicates whether the health alert is enabled.
	Enabled bool `pulumi:"enabled"`
	// Resource location
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the rule.
	RuleName string `pulumi:"ruleName"`
	// the list of resource id's that this health alert is scoped to.
	Scopes []string `pulumi:"scopes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a HealthAlert resource.
type HealthAlertArgs struct {
	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions HealthAlertActionArrayInput
	// defines the specific alert criteria information.
	Criteria HealthAlertCriteriaInput
	// the description of the health alert that will be included in the alert email.
	Description pulumi.StringInput
	// the flag that indicates whether the health alert is enabled.
	Enabled pulumi.BoolInput
	// Resource location
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the rule.
	RuleName pulumi.StringInput
	// the list of resource id's that this health alert is scoped to.
	Scopes pulumi.StringArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (HealthAlertArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*healthAlertArgs)(nil)).Elem()
}

type HealthAlertInput interface {
	pulumi.Input

	ToHealthAlertOutput() HealthAlertOutput
	ToHealthAlertOutputWithContext(ctx context.Context) HealthAlertOutput
}

func (*HealthAlert) ElementType() reflect.Type {
	return reflect.TypeOf((*HealthAlert)(nil))
}

func (i *HealthAlert) ToHealthAlertOutput() HealthAlertOutput {
	return i.ToHealthAlertOutputWithContext(context.Background())
}

func (i *HealthAlert) ToHealthAlertOutputWithContext(ctx context.Context) HealthAlertOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HealthAlertOutput)
}

type HealthAlertOutput struct {
	*pulumi.OutputState
}

func (HealthAlertOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*HealthAlert)(nil))
}

func (o HealthAlertOutput) ToHealthAlertOutput() HealthAlertOutput {
	return o
}

func (o HealthAlertOutput) ToHealthAlertOutputWithContext(ctx context.Context) HealthAlertOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(HealthAlertOutput{})
}
