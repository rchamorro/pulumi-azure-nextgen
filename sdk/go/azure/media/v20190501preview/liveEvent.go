// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190501preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The Live Event.
type LiveEvent struct {
	pulumi.CustomResourceState

	// The exact time the Live Event was created.
	Created pulumi.StringOutput `pulumi:"created"`
	// The Live Event access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesResponsePtrOutput `pulumi:"crossSiteAccessPolicies"`
	// The Live Event description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The Live Event encoding.
	Encoding LiveEventEncodingResponsePtrOutput `pulumi:"encoding"`
	// The Live Event input.
	Input LiveEventInputResponseOutput `pulumi:"input"`
	// The exact time the Live Event was last modified.
	LastModified pulumi.StringOutput `pulumi:"lastModified"`
	// The Azure Region of the resource.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The Live Event preview.
	Preview LiveEventPreviewResponsePtrOutput `pulumi:"preview"`
	// The provisioning state of the Live Event.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource state of the Live Event.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// The options to use for the LiveEvent.  This value is specified at creation time and cannot be updated.
	StreamOptions pulumi.StringArrayOutput `pulumi:"streamOptions"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The Live Event transcription.
	Transcriptions LiveEventTranscriptionResponseArrayOutput `pulumi:"transcriptions"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// Specifies whether to use a vanity url with the Live Event.  This value is specified at creation time and cannot be updated.
	VanityUrl pulumi.BoolPtrOutput `pulumi:"vanityUrl"`
}

// NewLiveEvent registers a new resource with the given unique name, arguments, and options.
func NewLiveEvent(ctx *pulumi.Context,
	name string, args *LiveEventArgs, opts ...pulumi.ResourceOption) (*LiveEvent, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.Input == nil {
		return nil, errors.New("missing required argument 'Input'")
	}
	if args == nil || args.LiveEventName == nil {
		return nil, errors.New("missing required argument 'LiveEventName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &LiveEventArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/latest:LiveEvent"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180330preview:LiveEvent"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180601preview:LiveEvent"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180701:LiveEvent"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20200501:LiveEvent"),
		},
	})
	opts = append(opts, aliases)
	var resource LiveEvent
	err := ctx.RegisterResource("azure-nextgen:media/v20190501preview:LiveEvent", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLiveEvent gets an existing LiveEvent resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLiveEvent(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LiveEventState, opts ...pulumi.ResourceOption) (*LiveEvent, error) {
	var resource LiveEvent
	err := ctx.ReadResource("azure-nextgen:media/v20190501preview:LiveEvent", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LiveEvent resources.
type liveEventState struct {
	// The exact time the Live Event was created.
	Created *string `pulumi:"created"`
	// The Live Event access policies.
	CrossSiteAccessPolicies *CrossSiteAccessPoliciesResponse `pulumi:"crossSiteAccessPolicies"`
	// The Live Event description.
	Description *string `pulumi:"description"`
	// The Live Event encoding.
	Encoding *LiveEventEncodingResponse `pulumi:"encoding"`
	// The Live Event input.
	Input *LiveEventInputResponse `pulumi:"input"`
	// The exact time the Live Event was last modified.
	LastModified *string `pulumi:"lastModified"`
	// The Azure Region of the resource.
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The Live Event preview.
	Preview *LiveEventPreviewResponse `pulumi:"preview"`
	// The provisioning state of the Live Event.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource state of the Live Event.
	ResourceState *string `pulumi:"resourceState"`
	// The options to use for the LiveEvent.  This value is specified at creation time and cannot be updated.
	StreamOptions []string `pulumi:"streamOptions"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Live Event transcription.
	Transcriptions []LiveEventTranscriptionResponse `pulumi:"transcriptions"`
	// The type of the resource.
	Type *string `pulumi:"type"`
	// Specifies whether to use a vanity url with the Live Event.  This value is specified at creation time and cannot be updated.
	VanityUrl *bool `pulumi:"vanityUrl"`
}

type LiveEventState struct {
	// The exact time the Live Event was created.
	Created pulumi.StringPtrInput
	// The Live Event access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesResponsePtrInput
	// The Live Event description.
	Description pulumi.StringPtrInput
	// The Live Event encoding.
	Encoding LiveEventEncodingResponsePtrInput
	// The Live Event input.
	Input LiveEventInputResponsePtrInput
	// The exact time the Live Event was last modified.
	LastModified pulumi.StringPtrInput
	// The Azure Region of the resource.
	Location pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The Live Event preview.
	Preview LiveEventPreviewResponsePtrInput
	// The provisioning state of the Live Event.
	ProvisioningState pulumi.StringPtrInput
	// The resource state of the Live Event.
	ResourceState pulumi.StringPtrInput
	// The options to use for the LiveEvent.  This value is specified at creation time and cannot be updated.
	StreamOptions pulumi.StringArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The Live Event transcription.
	Transcriptions LiveEventTranscriptionResponseArrayInput
	// The type of the resource.
	Type pulumi.StringPtrInput
	// Specifies whether to use a vanity url with the Live Event.  This value is specified at creation time and cannot be updated.
	VanityUrl pulumi.BoolPtrInput
}

func (LiveEventState) ElementType() reflect.Type {
	return reflect.TypeOf((*liveEventState)(nil)).Elem()
}

type liveEventArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The flag indicates if the resource should be automatically started on creation.
	AutoStart *bool `pulumi:"autoStart"`
	// The Live Event access policies.
	CrossSiteAccessPolicies *CrossSiteAccessPolicies `pulumi:"crossSiteAccessPolicies"`
	// The Live Event description.
	Description *string `pulumi:"description"`
	// The Live Event encoding.
	Encoding *LiveEventEncoding `pulumi:"encoding"`
	// The Live Event input.
	Input LiveEventInput `pulumi:"input"`
	// The name of the Live Event.
	LiveEventName string `pulumi:"liveEventName"`
	// The Azure Region of the resource.
	Location *string `pulumi:"location"`
	// The Live Event preview.
	Preview *LiveEventPreview `pulumi:"preview"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The options to use for the LiveEvent.  This value is specified at creation time and cannot be updated.
	StreamOptions []string `pulumi:"streamOptions"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Live Event transcription.
	Transcriptions []LiveEventTranscription `pulumi:"transcriptions"`
	// Specifies whether to use a vanity url with the Live Event.  This value is specified at creation time and cannot be updated.
	VanityUrl *bool `pulumi:"vanityUrl"`
}

// The set of arguments for constructing a LiveEvent resource.
type LiveEventArgs struct {
	// The Media Services account name.
	AccountName pulumi.StringInput
	// The flag indicates if the resource should be automatically started on creation.
	AutoStart pulumi.BoolPtrInput
	// The Live Event access policies.
	CrossSiteAccessPolicies CrossSiteAccessPoliciesPtrInput
	// The Live Event description.
	Description pulumi.StringPtrInput
	// The Live Event encoding.
	Encoding LiveEventEncodingPtrInput
	// The Live Event input.
	Input LiveEventInputInput
	// The name of the Live Event.
	LiveEventName pulumi.StringInput
	// The Azure Region of the resource.
	Location pulumi.StringPtrInput
	// The Live Event preview.
	Preview LiveEventPreviewPtrInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The options to use for the LiveEvent.  This value is specified at creation time and cannot be updated.
	StreamOptions pulumi.StringArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The Live Event transcription.
	Transcriptions LiveEventTranscriptionArrayInput
	// Specifies whether to use a vanity url with the Live Event.  This value is specified at creation time and cannot be updated.
	VanityUrl pulumi.BoolPtrInput
}

func (LiveEventArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*liveEventArgs)(nil)).Elem()
}

type LiveEventInput interface {
	pulumi.Input

	ToLiveEventOutput() LiveEventOutput
	ToLiveEventOutputWithContext(ctx context.Context) LiveEventOutput
}

func (LiveEvent) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEvent)(nil)).Elem()
}

func (i LiveEvent) ToLiveEventOutput() LiveEventOutput {
	return i.ToLiveEventOutputWithContext(context.Background())
}

func (i LiveEvent) ToLiveEventOutputWithContext(ctx context.Context) LiveEventOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LiveEventOutput)
}

type LiveEventOutput struct {
	*pulumi.OutputState
}

func (LiveEventOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveEventOutput)(nil)).Elem()
}

func (o LiveEventOutput) ToLiveEventOutput() LiveEventOutput {
	return o
}

func (o LiveEventOutput) ToLiveEventOutputWithContext(ctx context.Context) LiveEventOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LiveEventOutput{})
}
