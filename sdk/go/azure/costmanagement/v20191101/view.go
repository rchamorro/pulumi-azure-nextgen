// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// States and configurations of Cost Analysis.
type View struct {
	pulumi.CustomResourceState

	// Show costs accumulated over time.
	Accumulated pulumi.StringPtrOutput `pulumi:"accumulated"`
	// Chart type of the main view in Cost Analysis. Required.
	Chart pulumi.StringPtrOutput `pulumi:"chart"`
	// Date the user created this view.
	CreatedOn pulumi.StringOutput `pulumi:"createdOn"`
	// Selected currency.
	Currency pulumi.StringOutput `pulumi:"currency"`
	// Has definition for data in this report config.
	DataSet ReportConfigDatasetResponsePtrOutput `pulumi:"dataSet"`
	// Selected date range for viewing cost in.
	DateRange pulumi.StringOutput `pulumi:"dateRange"`
	// User input name of the view. Required.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrOutput `pulumi:"eTag"`
	// Include monetary commitment
	IncludeMonetaryCommitment pulumi.BoolOutput `pulumi:"includeMonetaryCommitment"`
	// List of KPIs to show in Cost Analysis UI.
	Kpis KpiPropertiesResponseArrayOutput `pulumi:"kpis"`
	// Metric to use when displaying costs.
	Metric pulumi.StringPtrOutput `pulumi:"metric"`
	// Date when the user last modified this view.
	ModifiedOn pulumi.StringOutput `pulumi:"modifiedOn"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots PivotPropertiesResponseArrayOutput `pulumi:"pivots"`
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// Has time period for pulling data for the report.
	TimePeriod ReportConfigTimePeriodResponsePtrOutput `pulumi:"timePeriod"`
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe pulumi.StringOutput `pulumi:"timeframe"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewView registers a new resource with the given unique name, arguments, and options.
func NewView(ctx *pulumi.Context,
	name string, args *ViewArgs, opts ...pulumi.ResourceOption) (*View, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Timeframe == nil {
		return nil, errors.New("invalid value for required argument 'Timeframe'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.ViewName == nil {
		return nil, errors.New("invalid value for required argument 'ViewName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:costmanagement/latest:View"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20190401preview:View"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20200601:View"),
		},
	})
	opts = append(opts, aliases)
	var resource View
	err := ctx.RegisterResource("azure-nextgen:costmanagement/v20191101:View", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetView gets an existing View resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetView(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ViewState, opts ...pulumi.ResourceOption) (*View, error) {
	var resource View
	err := ctx.ReadResource("azure-nextgen:costmanagement/v20191101:View", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering View resources.
type viewState struct {
	// Show costs accumulated over time.
	Accumulated *string `pulumi:"accumulated"`
	// Chart type of the main view in Cost Analysis. Required.
	Chart *string `pulumi:"chart"`
	// Date the user created this view.
	CreatedOn *string `pulumi:"createdOn"`
	// Selected currency.
	Currency *string `pulumi:"currency"`
	// Has definition for data in this report config.
	DataSet *ReportConfigDatasetResponse `pulumi:"dataSet"`
	// Selected date range for viewing cost in.
	DateRange *string `pulumi:"dateRange"`
	// User input name of the view. Required.
	DisplayName *string `pulumi:"displayName"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag *string `pulumi:"eTag"`
	// Include monetary commitment
	IncludeMonetaryCommitment *bool `pulumi:"includeMonetaryCommitment"`
	// List of KPIs to show in Cost Analysis UI.
	Kpis []KpiPropertiesResponse `pulumi:"kpis"`
	// Metric to use when displaying costs.
	Metric *string `pulumi:"metric"`
	// Date when the user last modified this view.
	ModifiedOn *string `pulumi:"modifiedOn"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots []PivotPropertiesResponse `pulumi:"pivots"`
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope *string `pulumi:"scope"`
	// Has time period for pulling data for the report.
	TimePeriod *ReportConfigTimePeriodResponse `pulumi:"timePeriod"`
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe *string `pulumi:"timeframe"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ViewState struct {
	// Show costs accumulated over time.
	Accumulated pulumi.StringPtrInput
	// Chart type of the main view in Cost Analysis. Required.
	Chart pulumi.StringPtrInput
	// Date the user created this view.
	CreatedOn pulumi.StringPtrInput
	// Selected currency.
	Currency pulumi.StringPtrInput
	// Has definition for data in this report config.
	DataSet ReportConfigDatasetResponsePtrInput
	// Selected date range for viewing cost in.
	DateRange pulumi.StringPtrInput
	// User input name of the view. Required.
	DisplayName pulumi.StringPtrInput
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrInput
	// Include monetary commitment
	IncludeMonetaryCommitment pulumi.BoolPtrInput
	// List of KPIs to show in Cost Analysis UI.
	Kpis KpiPropertiesResponseArrayInput
	// Metric to use when displaying costs.
	Metric pulumi.StringPtrInput
	// Date when the user last modified this view.
	ModifiedOn pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots PivotPropertiesResponseArrayInput
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope pulumi.StringPtrInput
	// Has time period for pulling data for the report.
	TimePeriod ReportConfigTimePeriodResponsePtrInput
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ViewState) ElementType() reflect.Type {
	return reflect.TypeOf((*viewState)(nil)).Elem()
}

type viewArgs struct {
	// Show costs accumulated over time.
	Accumulated *string `pulumi:"accumulated"`
	// Chart type of the main view in Cost Analysis. Required.
	Chart *string `pulumi:"chart"`
	// Has definition for data in this report config.
	DataSet *ReportConfigDataset `pulumi:"dataSet"`
	// User input name of the view. Required.
	DisplayName *string `pulumi:"displayName"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag *string `pulumi:"eTag"`
	// List of KPIs to show in Cost Analysis UI.
	Kpis []KpiProperties `pulumi:"kpis"`
	// Metric to use when displaying costs.
	Metric *string `pulumi:"metric"`
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots []PivotProperties `pulumi:"pivots"`
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope *string `pulumi:"scope"`
	// Has time period for pulling data for the report.
	TimePeriod *ReportConfigTimePeriod `pulumi:"timePeriod"`
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe string `pulumi:"timeframe"`
	// The type of the report. Usage represents actual usage, forecast represents forecasted data and UsageAndForecast represents both usage and forecasted data. Actual usage and forecasted data can be differentiated based on dates.
	Type string `pulumi:"type"`
	// View name
	ViewName string `pulumi:"viewName"`
}

// The set of arguments for constructing a View resource.
type ViewArgs struct {
	// Show costs accumulated over time.
	Accumulated pulumi.StringPtrInput
	// Chart type of the main view in Cost Analysis. Required.
	Chart pulumi.StringPtrInput
	// Has definition for data in this report config.
	DataSet ReportConfigDatasetPtrInput
	// User input name of the view. Required.
	DisplayName pulumi.StringPtrInput
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag pulumi.StringPtrInput
	// List of KPIs to show in Cost Analysis UI.
	Kpis KpiPropertiesArrayInput
	// Metric to use when displaying costs.
	Metric pulumi.StringPtrInput
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots PivotPropertiesArrayInput
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope pulumi.StringPtrInput
	// Has time period for pulling data for the report.
	TimePeriod ReportConfigTimePeriodPtrInput
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe pulumi.StringInput
	// The type of the report. Usage represents actual usage, forecast represents forecasted data and UsageAndForecast represents both usage and forecasted data. Actual usage and forecasted data can be differentiated based on dates.
	Type pulumi.StringInput
	// View name
	ViewName pulumi.StringInput
}

func (ViewArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*viewArgs)(nil)).Elem()
}

type ViewInput interface {
	pulumi.Input

	ToViewOutput() ViewOutput
	ToViewOutputWithContext(ctx context.Context) ViewOutput
}

func (*View) ElementType() reflect.Type {
	return reflect.TypeOf((*View)(nil))
}

func (i *View) ToViewOutput() ViewOutput {
	return i.ToViewOutputWithContext(context.Background())
}

func (i *View) ToViewOutputWithContext(ctx context.Context) ViewOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ViewOutput)
}

type ViewOutput struct {
	*pulumi.OutputState
}

func (ViewOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*View)(nil))
}

func (o ViewOutput) ToViewOutput() ViewOutput {
	return o
}

func (o ViewOutput) ToViewOutputWithContext(ctx context.Context) ViewOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ViewOutput{})
}
