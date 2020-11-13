// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A budget resource.
type Budget struct {
	pulumi.CustomResourceState

	// The total amount of cost to track with the budget
	Amount pulumi.Float64Output `pulumi:"amount"`
	// The category of the budget, whether the budget tracks cost or usage.
	Category pulumi.StringOutput `pulumi:"category"`
	// The current amount of cost which is being tracked for a budget.
	CurrentSpend CurrentSpendResponseOutput `pulumi:"currentSpend"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrOutput `pulumi:"eTag"`
	// May be used to filter budgets by resource group, resource, or meter.
	Filters FiltersResponsePtrOutput `pulumi:"filters"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Dictionary of notifications associated with the budget. Budget can have up to five notifications.
	Notifications NotificationResponseMapOutput `pulumi:"notifications"`
	// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
	TimeGrain pulumi.StringOutput `pulumi:"timeGrain"`
	// Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
	TimePeriod BudgetTimePeriodResponseOutput `pulumi:"timePeriod"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBudget registers a new resource with the given unique name, arguments, and options.
func NewBudget(ctx *pulumi.Context,
	name string, args *BudgetArgs, opts ...pulumi.ResourceOption) (*Budget, error) {
	if args == nil || args.Amount == nil {
		return nil, errors.New("missing required argument 'Amount'")
	}
	if args == nil || args.BudgetName == nil {
		return nil, errors.New("missing required argument 'BudgetName'")
	}
	if args == nil || args.Category == nil {
		return nil, errors.New("missing required argument 'Category'")
	}
	if args == nil || args.TimeGrain == nil {
		return nil, errors.New("missing required argument 'TimeGrain'")
	}
	if args == nil || args.TimePeriod == nil {
		return nil, errors.New("missing required argument 'TimePeriod'")
	}
	if args == nil {
		args = &BudgetArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:consumption/v20171230preview:Budget"),
		},
		{
			Type: pulumi.String("azure-nextgen:consumption/v20180131:Budget"),
		},
		{
			Type: pulumi.String("azure-nextgen:consumption/v20180331:Budget"),
		},
		{
			Type: pulumi.String("azure-nextgen:consumption/v20180630:Budget"),
		},
		{
			Type: pulumi.String("azure-nextgen:consumption/v20180831:Budget"),
		},
	})
	opts = append(opts, aliases)
	var resource Budget
	err := ctx.RegisterResource("azure-nextgen:consumption/v20181001:Budget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBudget gets an existing Budget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBudget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BudgetState, opts ...pulumi.ResourceOption) (*Budget, error) {
	var resource Budget
	err := ctx.ReadResource("azure-nextgen:consumption/v20181001:Budget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Budget resources.
type budgetState struct {
	// The total amount of cost to track with the budget
	Amount *float64 `pulumi:"amount"`
	// The category of the budget, whether the budget tracks cost or usage.
	Category *string `pulumi:"category"`
	// The current amount of cost which is being tracked for a budget.
	CurrentSpend *CurrentSpendResponse `pulumi:"currentSpend"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag *string `pulumi:"eTag"`
	// May be used to filter budgets by resource group, resource, or meter.
	Filters *FiltersResponse `pulumi:"filters"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Dictionary of notifications associated with the budget. Budget can have up to five notifications.
	Notifications map[string]NotificationResponse `pulumi:"notifications"`
	// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
	TimeGrain *string `pulumi:"timeGrain"`
	// Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
	TimePeriod *BudgetTimePeriodResponse `pulumi:"timePeriod"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type BudgetState struct {
	// The total amount of cost to track with the budget
	Amount pulumi.Float64PtrInput
	// The category of the budget, whether the budget tracks cost or usage.
	Category pulumi.StringPtrInput
	// The current amount of cost which is being tracked for a budget.
	CurrentSpend CurrentSpendResponsePtrInput
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrInput
	// May be used to filter budgets by resource group, resource, or meter.
	Filters FiltersResponsePtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Dictionary of notifications associated with the budget. Budget can have up to five notifications.
	Notifications NotificationResponseMapInput
	// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
	TimeGrain pulumi.StringPtrInput
	// Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
	TimePeriod BudgetTimePeriodResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (BudgetState) ElementType() reflect.Type {
	return reflect.TypeOf((*budgetState)(nil)).Elem()
}

type budgetArgs struct {
	// The total amount of cost to track with the budget
	Amount float64 `pulumi:"amount"`
	// Budget Name.
	BudgetName string `pulumi:"budgetName"`
	// The category of the budget, whether the budget tracks cost or usage.
	Category string `pulumi:"category"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag *string `pulumi:"eTag"`
	// May be used to filter budgets by resource group, resource, or meter.
	Filters *Filters `pulumi:"filters"`
	// Dictionary of notifications associated with the budget. Budget can have up to five notifications.
	Notifications map[string]Notification `pulumi:"notifications"`
	// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
	TimeGrain string `pulumi:"timeGrain"`
	// Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
	TimePeriod BudgetTimePeriod `pulumi:"timePeriod"`
}

// The set of arguments for constructing a Budget resource.
type BudgetArgs struct {
	// The total amount of cost to track with the budget
	Amount pulumi.Float64Input
	// Budget Name.
	BudgetName pulumi.StringInput
	// The category of the budget, whether the budget tracks cost or usage.
	Category pulumi.StringInput
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrInput
	// May be used to filter budgets by resource group, resource, or meter.
	Filters FiltersPtrInput
	// Dictionary of notifications associated with the budget. Budget can have up to five notifications.
	Notifications NotificationMapInput
	// The time covered by a budget. Tracking of the amount will be reset based on the time grain.
	TimeGrain pulumi.StringInput
	// Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
	TimePeriod BudgetTimePeriodInput
}

func (BudgetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*budgetArgs)(nil)).Elem()
}

type BudgetInput interface {
	pulumi.Input

	ToBudgetOutput() BudgetOutput
	ToBudgetOutputWithContext(ctx context.Context) BudgetOutput
}

func (Budget) ElementType() reflect.Type {
	return reflect.TypeOf((*Budget)(nil)).Elem()
}

func (i Budget) ToBudgetOutput() BudgetOutput {
	return i.ToBudgetOutputWithContext(context.Background())
}

func (i Budget) ToBudgetOutputWithContext(ctx context.Context) BudgetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetOutput)
}

type BudgetOutput struct {
	*pulumi.OutputState
}

func (BudgetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetOutput)(nil)).Elem()
}

func (o BudgetOutput) ToBudgetOutput() BudgetOutput {
	return o
}

func (o BudgetOutput) ToBudgetOutputWithContext(ctx context.Context) BudgetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BudgetOutput{})
}
