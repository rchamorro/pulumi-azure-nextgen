// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180630

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the runbook type.
type Runbook struct {
	pulumi.CustomResourceState

	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrOutput `pulumi:"creationTime"`
	// Gets or sets the description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Gets or sets the draft runbook properties.
	Draft RunbookDraftResponsePtrOutput `pulumi:"draft"`
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Gets or sets the job count of the runbook.
	JobCount pulumi.IntPtrOutput `pulumi:"jobCount"`
	// Gets or sets the last modified by.
	LastModifiedBy pulumi.StringPtrOutput `pulumi:"lastModifiedBy"`
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrOutput `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets or sets the option to log activity trace of the runbook.
	LogActivityTrace pulumi.IntPtrOutput `pulumi:"logActivityTrace"`
	// Gets or sets progress log option.
	LogProgress pulumi.BoolPtrOutput `pulumi:"logProgress"`
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrOutput `pulumi:"logVerbose"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the runbook output types.
	OutputTypes pulumi.StringArrayOutput `pulumi:"outputTypes"`
	// Gets or sets the runbook parameters.
	Parameters RunbookParameterResponseMapOutput `pulumi:"parameters"`
	// Gets or sets the provisioning state of the runbook.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets the published runbook content link.
	PublishContentLink ContentLinkResponsePtrOutput `pulumi:"publishContentLink"`
	// Gets or sets the type of the runbook.
	RunbookType pulumi.StringPtrOutput `pulumi:"runbookType"`
	// Gets or sets the state of the runbook.
	State pulumi.StringPtrOutput `pulumi:"state"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRunbook registers a new resource with the given unique name, arguments, and options.
func NewRunbook(ctx *pulumi.Context,
	name string, args *RunbookArgs, opts ...pulumi.ResourceOption) (*Runbook, error) {
	if args == nil || args.AutomationAccountName == nil {
		return nil, errors.New("missing required argument 'AutomationAccountName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.RunbookName == nil {
		return nil, errors.New("missing required argument 'RunbookName'")
	}
	if args == nil || args.RunbookType == nil {
		return nil, errors.New("missing required argument 'RunbookType'")
	}
	if args == nil {
		args = &RunbookArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:automation/latest:Runbook"),
		},
		{
			Type: pulumi.String("azure-nextgen:automation/v20151031:Runbook"),
		},
	})
	opts = append(opts, aliases)
	var resource Runbook
	err := ctx.RegisterResource("azure-nextgen:automation/v20180630:Runbook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRunbook gets an existing Runbook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRunbook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RunbookState, opts ...pulumi.ResourceOption) (*Runbook, error) {
	var resource Runbook
	err := ctx.ReadResource("azure-nextgen:automation/v20180630:Runbook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Runbook resources.
type runbookState struct {
	// Gets or sets the creation time.
	CreationTime *string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the draft runbook properties.
	Draft *RunbookDraftResponse `pulumi:"draft"`
	// Gets or sets the etag of the resource.
	Etag *string `pulumi:"etag"`
	// Gets or sets the job count of the runbook.
	JobCount *int `pulumi:"jobCount"`
	// Gets or sets the last modified by.
	LastModifiedBy *string `pulumi:"lastModifiedBy"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// Gets or sets the option to log activity trace of the runbook.
	LogActivityTrace *int `pulumi:"logActivityTrace"`
	// Gets or sets progress log option.
	LogProgress *bool `pulumi:"logProgress"`
	// Gets or sets verbose log option.
	LogVerbose *bool `pulumi:"logVerbose"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Gets or sets the runbook output types.
	OutputTypes []string `pulumi:"outputTypes"`
	// Gets or sets the runbook parameters.
	Parameters map[string]RunbookParameterResponse `pulumi:"parameters"`
	// Gets or sets the provisioning state of the runbook.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets the published runbook content link.
	PublishContentLink *ContentLinkResponse `pulumi:"publishContentLink"`
	// Gets or sets the type of the runbook.
	RunbookType *string `pulumi:"runbookType"`
	// Gets or sets the state of the runbook.
	State *string `pulumi:"state"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type RunbookState struct {
	// Gets or sets the creation time.
	CreationTime pulumi.StringPtrInput
	// Gets or sets the description.
	Description pulumi.StringPtrInput
	// Gets or sets the draft runbook properties.
	Draft RunbookDraftResponsePtrInput
	// Gets or sets the etag of the resource.
	Etag pulumi.StringPtrInput
	// Gets or sets the job count of the runbook.
	JobCount pulumi.IntPtrInput
	// Gets or sets the last modified by.
	LastModifiedBy pulumi.StringPtrInput
	// Gets or sets the last modified time.
	LastModifiedTime pulumi.StringPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// Gets or sets the option to log activity trace of the runbook.
	LogActivityTrace pulumi.IntPtrInput
	// Gets or sets progress log option.
	LogProgress pulumi.BoolPtrInput
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Gets or sets the runbook output types.
	OutputTypes pulumi.StringArrayInput
	// Gets or sets the runbook parameters.
	Parameters RunbookParameterResponseMapInput
	// Gets or sets the provisioning state of the runbook.
	ProvisioningState pulumi.StringPtrInput
	// Gets or sets the published runbook content link.
	PublishContentLink ContentLinkResponsePtrInput
	// Gets or sets the type of the runbook.
	RunbookType pulumi.StringPtrInput
	// Gets or sets the state of the runbook.
	State pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (RunbookState) ElementType() reflect.Type {
	return reflect.TypeOf((*runbookState)(nil)).Elem()
}

type runbookArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Gets or sets the description of the runbook.
	Description *string `pulumi:"description"`
	// Gets or sets the draft runbook properties.
	Draft *RunbookDraft `pulumi:"draft"`
	// Gets or sets the location of the resource.
	Location *string `pulumi:"location"`
	// Gets or sets the activity-level tracing options of the runbook.
	LogActivityTrace *int `pulumi:"logActivityTrace"`
	// Gets or sets progress log option.
	LogProgress *bool `pulumi:"logProgress"`
	// Gets or sets verbose log option.
	LogVerbose *bool `pulumi:"logVerbose"`
	// Gets or sets the name of the resource.
	Name *string `pulumi:"name"`
	// Gets or sets the published runbook content link.
	PublishContentLink *ContentLink `pulumi:"publishContentLink"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The runbook name.
	RunbookName string `pulumi:"runbookName"`
	// Gets or sets the type of the runbook.
	RunbookType string `pulumi:"runbookType"`
	// Gets or sets the tags attached to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Runbook resource.
type RunbookArgs struct {
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// Gets or sets the description of the runbook.
	Description pulumi.StringPtrInput
	// Gets or sets the draft runbook properties.
	Draft RunbookDraftPtrInput
	// Gets or sets the location of the resource.
	Location pulumi.StringPtrInput
	// Gets or sets the activity-level tracing options of the runbook.
	LogActivityTrace pulumi.IntPtrInput
	// Gets or sets progress log option.
	LogProgress pulumi.BoolPtrInput
	// Gets or sets verbose log option.
	LogVerbose pulumi.BoolPtrInput
	// Gets or sets the name of the resource.
	Name pulumi.StringPtrInput
	// Gets or sets the published runbook content link.
	PublishContentLink ContentLinkPtrInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
	// The runbook name.
	RunbookName pulumi.StringInput
	// Gets or sets the type of the runbook.
	RunbookType pulumi.StringInput
	// Gets or sets the tags attached to the resource.
	Tags pulumi.StringMapInput
}

func (RunbookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*runbookArgs)(nil)).Elem()
}

type RunbookInput interface {
	pulumi.Input

	ToRunbookOutput() RunbookOutput
	ToRunbookOutputWithContext(ctx context.Context) RunbookOutput
}

func (Runbook) ElementType() reflect.Type {
	return reflect.TypeOf((*Runbook)(nil)).Elem()
}

func (i Runbook) ToRunbookOutput() RunbookOutput {
	return i.ToRunbookOutputWithContext(context.Background())
}

func (i Runbook) ToRunbookOutputWithContext(ctx context.Context) RunbookOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RunbookOutput)
}

type RunbookOutput struct {
	*pulumi.OutputState
}

func (RunbookOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RunbookOutput)(nil)).Elem()
}

func (o RunbookOutput) ToRunbookOutput() RunbookOutput {
	return o
}

func (o RunbookOutput) ToRunbookOutputWithContext(ctx context.Context) RunbookOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RunbookOutput{})
}
