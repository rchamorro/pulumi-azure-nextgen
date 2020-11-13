// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Account Filter.
type AccountFilter struct {
	pulumi.CustomResourceState

	// The first quality.
	FirstQuality FirstQualityResponsePtrOutput `pulumi:"firstQuality"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The presentation time range.
	PresentationTimeRange PresentationTimeRangeResponsePtrOutput `pulumi:"presentationTimeRange"`
	// The tracks selection conditions.
	Tracks FilterTrackSelectionResponseArrayOutput `pulumi:"tracks"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAccountFilter registers a new resource with the given unique name, arguments, and options.
func NewAccountFilter(ctx *pulumi.Context,
	name string, args *AccountFilterArgs, opts ...pulumi.ResourceOption) (*AccountFilter, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.FilterName == nil {
		return nil, errors.New("missing required argument 'FilterName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &AccountFilterArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/v20180701:AccountFilter"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20200501:AccountFilter"),
		},
	})
	opts = append(opts, aliases)
	var resource AccountFilter
	err := ctx.RegisterResource("azure-nextgen:media/latest:AccountFilter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccountFilter gets an existing AccountFilter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccountFilter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccountFilterState, opts ...pulumi.ResourceOption) (*AccountFilter, error) {
	var resource AccountFilter
	err := ctx.ReadResource("azure-nextgen:media/latest:AccountFilter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AccountFilter resources.
type accountFilterState struct {
	// The first quality.
	FirstQuality *FirstQualityResponse `pulumi:"firstQuality"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The presentation time range.
	PresentationTimeRange *PresentationTimeRangeResponse `pulumi:"presentationTimeRange"`
	// The tracks selection conditions.
	Tracks []FilterTrackSelectionResponse `pulumi:"tracks"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type AccountFilterState struct {
	// The first quality.
	FirstQuality FirstQualityResponsePtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The presentation time range.
	PresentationTimeRange PresentationTimeRangeResponsePtrInput
	// The tracks selection conditions.
	Tracks FilterTrackSelectionResponseArrayInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (AccountFilterState) ElementType() reflect.Type {
	return reflect.TypeOf((*accountFilterState)(nil)).Elem()
}

type accountFilterArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The Account Filter name
	FilterName string `pulumi:"filterName"`
	// The first quality.
	FirstQuality *FirstQuality `pulumi:"firstQuality"`
	// The presentation time range.
	PresentationTimeRange *PresentationTimeRange `pulumi:"presentationTimeRange"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The tracks selection conditions.
	Tracks []FilterTrackSelection `pulumi:"tracks"`
}

// The set of arguments for constructing a AccountFilter resource.
type AccountFilterArgs struct {
	// The Media Services account name.
	AccountName pulumi.StringInput
	// The Account Filter name
	FilterName pulumi.StringInput
	// The first quality.
	FirstQuality FirstQualityPtrInput
	// The presentation time range.
	PresentationTimeRange PresentationTimeRangePtrInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The tracks selection conditions.
	Tracks FilterTrackSelectionArrayInput
}

func (AccountFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accountFilterArgs)(nil)).Elem()
}

type AccountFilterInput interface {
	pulumi.Input

	ToAccountFilterOutput() AccountFilterOutput
	ToAccountFilterOutputWithContext(ctx context.Context) AccountFilterOutput
}

func (AccountFilter) ElementType() reflect.Type {
	return reflect.TypeOf((*AccountFilter)(nil)).Elem()
}

func (i AccountFilter) ToAccountFilterOutput() AccountFilterOutput {
	return i.ToAccountFilterOutputWithContext(context.Background())
}

func (i AccountFilter) ToAccountFilterOutputWithContext(ctx context.Context) AccountFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccountFilterOutput)
}

type AccountFilterOutput struct {
	*pulumi.OutputState
}

func (AccountFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccountFilterOutput)(nil)).Elem()
}

func (o AccountFilterOutput) ToAccountFilterOutput() AccountFilterOutput {
	return o
}

func (o AccountFilterOutput) ToAccountFilterOutputWithContext(ctx context.Context) AccountFilterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AccountFilterOutput{})
}
