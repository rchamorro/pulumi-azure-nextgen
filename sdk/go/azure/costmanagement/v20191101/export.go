// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A export resource.
type Export struct {
	pulumi.CustomResourceState

	// Has definition for the export.
	Definition QueryDefinitionResponseOutput `pulumi:"definition"`
	// Has delivery information for the export.
	DeliveryInfo ExportDeliveryInfoResponseOutput `pulumi:"deliveryInfo"`
	// The format of the export being delivered.
	Format pulumi.StringPtrOutput `pulumi:"format"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Has schedule information for the export.
	Schedule ExportScheduleResponsePtrOutput `pulumi:"schedule"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewExport registers a new resource with the given unique name, arguments, and options.
func NewExport(ctx *pulumi.Context,
	name string, args *ExportArgs, opts ...pulumi.ResourceOption) (*Export, error) {
	if args == nil || args.Definition == nil {
		return nil, errors.New("missing required argument 'Definition'")
	}
	if args == nil || args.DeliveryInfo == nil {
		return nil, errors.New("missing required argument 'DeliveryInfo'")
	}
	if args == nil || args.ExportName == nil {
		return nil, errors.New("missing required argument 'ExportName'")
	}
	if args == nil || args.Scope == nil {
		return nil, errors.New("missing required argument 'Scope'")
	}
	if args == nil {
		args = &ExportArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:costmanagement/latest:Export"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20190101:Export"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20190901:Export"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20191001:Export"),
		},
		{
			Type: pulumi.String("azure-nextgen:costmanagement/v20200601:Export"),
		},
	})
	opts = append(opts, aliases)
	var resource Export
	err := ctx.RegisterResource("azure-nextgen:costmanagement/v20191101:Export", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExport gets an existing Export resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExport(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExportState, opts ...pulumi.ResourceOption) (*Export, error) {
	var resource Export
	err := ctx.ReadResource("azure-nextgen:costmanagement/v20191101:Export", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Export resources.
type exportState struct {
	// Has definition for the export.
	Definition *QueryDefinitionResponse `pulumi:"definition"`
	// Has delivery information for the export.
	DeliveryInfo *ExportDeliveryInfoResponse `pulumi:"deliveryInfo"`
	// The format of the export being delivered.
	Format *string `pulumi:"format"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Has schedule information for the export.
	Schedule *ExportScheduleResponse `pulumi:"schedule"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ExportState struct {
	// Has definition for the export.
	Definition QueryDefinitionResponsePtrInput
	// Has delivery information for the export.
	DeliveryInfo ExportDeliveryInfoResponsePtrInput
	// The format of the export being delivered.
	Format pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Has schedule information for the export.
	Schedule ExportScheduleResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ExportState) ElementType() reflect.Type {
	return reflect.TypeOf((*exportState)(nil)).Elem()
}

type exportArgs struct {
	// Has definition for the export.
	Definition QueryDefinition `pulumi:"definition"`
	// Has delivery information for the export.
	DeliveryInfo ExportDeliveryInfo `pulumi:"deliveryInfo"`
	// Export Name.
	ExportName string `pulumi:"exportName"`
	// The format of the export being delivered.
	Format *string `pulumi:"format"`
	// Has schedule information for the export.
	Schedule *ExportSchedule `pulumi:"schedule"`
	// The scope associated with query and export operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners.
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a Export resource.
type ExportArgs struct {
	// Has definition for the export.
	Definition QueryDefinitionInput
	// Has delivery information for the export.
	DeliveryInfo ExportDeliveryInfoInput
	// Export Name.
	ExportName pulumi.StringInput
	// The format of the export being delivered.
	Format pulumi.StringPtrInput
	// Has schedule information for the export.
	Schedule ExportSchedulePtrInput
	// The scope associated with query and export operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners.
	Scope pulumi.StringInput
}

func (ExportArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*exportArgs)(nil)).Elem()
}

type ExportInput interface {
	pulumi.Input

	ToExportOutput() ExportOutput
	ToExportOutputWithContext(ctx context.Context) ExportOutput
}

func (Export) ElementType() reflect.Type {
	return reflect.TypeOf((*Export)(nil)).Elem()
}

func (i Export) ToExportOutput() ExportOutput {
	return i.ToExportOutputWithContext(context.Background())
}

func (i Export) ToExportOutputWithContext(ctx context.Context) ExportOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExportOutput)
}

type ExportOutput struct {
	*pulumi.OutputState
}

func (ExportOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExportOutput)(nil)).Elem()
}

func (o ExportOutput) ToExportOutput() ExportOutput {
	return o
}

func (o ExportOutput) ToExportOutputWithContext(ctx context.Context) ExportOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ExportOutput{})
}
