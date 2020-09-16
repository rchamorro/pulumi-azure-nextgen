// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200101

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Action for alert rule.
type AlertRuleAction struct {
	pulumi.CustomResourceState

	// Etag of the action.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}.
	LogicAppResourceId pulumi.StringOutput `pulumi:"logicAppResourceId"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// The name of the logic app's workflow.
	WorkflowId pulumi.StringPtrOutput `pulumi:"workflowId"`
}

// NewAlertRuleAction registers a new resource with the given unique name, arguments, and options.
func NewAlertRuleAction(ctx *pulumi.Context,
	name string, args *AlertRuleActionArgs, opts ...pulumi.ResourceOption) (*AlertRuleAction, error) {
	if args == nil || args.ActionId == nil {
		return nil, errors.New("missing required argument 'ActionId'")
	}
	if args == nil || args.LogicAppResourceId == nil {
		return nil, errors.New("missing required argument 'LogicAppResourceId'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.RuleId == nil {
		return nil, errors.New("missing required argument 'RuleId'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &AlertRuleActionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/latest:AlertRuleAction"),
		},
	})
	opts = append(opts, aliases)
	var resource AlertRuleAction
	err := ctx.RegisterResource("azure-nextgen:operationalinsights/v20200101:AlertRuleAction", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlertRuleAction gets an existing AlertRuleAction resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlertRuleAction(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlertRuleActionState, opts ...pulumi.ResourceOption) (*AlertRuleAction, error) {
	var resource AlertRuleAction
	err := ctx.ReadResource("azure-nextgen:operationalinsights/v20200101:AlertRuleAction", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AlertRuleAction resources.
type alertRuleActionState struct {
	// Etag of the action.
	Etag *string `pulumi:"etag"`
	// Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}.
	LogicAppResourceId *string `pulumi:"logicAppResourceId"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// Azure resource type
	Type *string `pulumi:"type"`
	// The name of the logic app's workflow.
	WorkflowId *string `pulumi:"workflowId"`
}

type AlertRuleActionState struct {
	// Etag of the action.
	Etag pulumi.StringPtrInput
	// Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}.
	LogicAppResourceId pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
	// The name of the logic app's workflow.
	WorkflowId pulumi.StringPtrInput
}

func (AlertRuleActionState) ElementType() reflect.Type {
	return reflect.TypeOf((*alertRuleActionState)(nil)).Elem()
}

type alertRuleActionArgs struct {
	// Action ID
	ActionId string `pulumi:"actionId"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}.
	LogicAppResourceId string `pulumi:"logicAppResourceId"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Alert rule ID
	RuleId string `pulumi:"ruleId"`
	// Logic App Callback URL for this specific workflow.
	TriggerUri *string `pulumi:"triggerUri"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a AlertRuleAction resource.
type AlertRuleActionArgs struct {
	// Action ID
	ActionId pulumi.StringInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// Logic App Resource Id, /subscriptions/{my-subscription}/resourceGroups/{my-resource-group}/providers/Microsoft.Logic/workflows/{my-workflow-id}.
	LogicAppResourceId pulumi.StringInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Alert rule ID
	RuleId pulumi.StringInput
	// Logic App Callback URL for this specific workflow.
	TriggerUri pulumi.StringPtrInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (AlertRuleActionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alertRuleActionArgs)(nil)).Elem()
}