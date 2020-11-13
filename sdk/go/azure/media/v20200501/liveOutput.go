// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The Live Output.
type LiveOutput struct {
	pulumi.CustomResourceState

	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength pulumi.StringOutput `pulumi:"archiveWindowLength"`
	// The asset that the live output will write to.
	AssetName pulumi.StringOutput `pulumi:"assetName"`
	// The creation time the live output.
	Created pulumi.StringOutput `pulumi:"created"`
	// The description of the live output.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls HlsResponsePtrOutput `pulumi:"hls"`
	// The time the live output was last modified.
	LastModified pulumi.StringOutput `pulumi:"lastModified"`
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName pulumi.StringPtrOutput `pulumi:"manifestName"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime pulumi.IntPtrOutput `pulumi:"outputSnapTime"`
	// The provisioning state of the live output.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource state of the live output.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewLiveOutput registers a new resource with the given unique name, arguments, and options.
func NewLiveOutput(ctx *pulumi.Context,
	name string, args *LiveOutputArgs, opts ...pulumi.ResourceOption) (*LiveOutput, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ArchiveWindowLength == nil {
		return nil, errors.New("missing required argument 'ArchiveWindowLength'")
	}
	if args == nil || args.AssetName == nil {
		return nil, errors.New("missing required argument 'AssetName'")
	}
	if args == nil || args.LiveEventName == nil {
		return nil, errors.New("missing required argument 'LiveEventName'")
	}
	if args == nil || args.LiveOutputName == nil {
		return nil, errors.New("missing required argument 'LiveOutputName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &LiveOutputArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/latest:LiveOutput"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180330preview:LiveOutput"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180601preview:LiveOutput"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180701:LiveOutput"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20190501preview:LiveOutput"),
		},
	})
	opts = append(opts, aliases)
	var resource LiveOutput
	err := ctx.RegisterResource("azure-nextgen:media/v20200501:LiveOutput", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLiveOutput gets an existing LiveOutput resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLiveOutput(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LiveOutputState, opts ...pulumi.ResourceOption) (*LiveOutput, error) {
	var resource LiveOutput
	err := ctx.ReadResource("azure-nextgen:media/v20200501:LiveOutput", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LiveOutput resources.
type liveOutputState struct {
	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength *string `pulumi:"archiveWindowLength"`
	// The asset that the live output will write to.
	AssetName *string `pulumi:"assetName"`
	// The creation time the live output.
	Created *string `pulumi:"created"`
	// The description of the live output.
	Description *string `pulumi:"description"`
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls *HlsResponse `pulumi:"hls"`
	// The time the live output was last modified.
	LastModified *string `pulumi:"lastModified"`
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName *string `pulumi:"manifestName"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime *int `pulumi:"outputSnapTime"`
	// The provisioning state of the live output.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource state of the live output.
	ResourceState *string `pulumi:"resourceState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type LiveOutputState struct {
	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength pulumi.StringPtrInput
	// The asset that the live output will write to.
	AssetName pulumi.StringPtrInput
	// The creation time the live output.
	Created pulumi.StringPtrInput
	// The description of the live output.
	Description pulumi.StringPtrInput
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls HlsResponsePtrInput
	// The time the live output was last modified.
	LastModified pulumi.StringPtrInput
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime pulumi.IntPtrInput
	// The provisioning state of the live output.
	ProvisioningState pulumi.StringPtrInput
	// The resource state of the live output.
	ResourceState pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (LiveOutputState) ElementType() reflect.Type {
	return reflect.TypeOf((*liveOutputState)(nil)).Elem()
}

type liveOutputArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength string `pulumi:"archiveWindowLength"`
	// The asset that the live output will write to.
	AssetName string `pulumi:"assetName"`
	// The description of the live output.
	Description *string `pulumi:"description"`
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls *Hls `pulumi:"hls"`
	// The name of the live event, maximum length is 32.
	LiveEventName string `pulumi:"liveEventName"`
	// The name of the live output.
	LiveOutputName string `pulumi:"liveOutputName"`
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName *string `pulumi:"manifestName"`
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime *int `pulumi:"outputSnapTime"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a LiveOutput resource.
type LiveOutputArgs struct {
	// The Media Services account name.
	AccountName pulumi.StringInput
	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength pulumi.StringInput
	// The asset that the live output will write to.
	AssetName pulumi.StringInput
	// The description of the live output.
	Description pulumi.StringPtrInput
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls HlsPtrInput
	// The name of the live event, maximum length is 32.
	LiveEventName pulumi.StringInput
	// The name of the live output.
	LiveOutputName pulumi.StringInput
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName pulumi.StringPtrInput
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime pulumi.IntPtrInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
}

func (LiveOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*liveOutputArgs)(nil)).Elem()
}

type LiveOutputInput interface {
	pulumi.Input

	ToLiveOutputOutput() LiveOutputOutput
	ToLiveOutputOutputWithContext(ctx context.Context) LiveOutputOutput
}

func (LiveOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveOutput)(nil)).Elem()
}

func (i LiveOutput) ToLiveOutputOutput() LiveOutputOutput {
	return i.ToLiveOutputOutputWithContext(context.Background())
}

func (i LiveOutput) ToLiveOutputOutputWithContext(ctx context.Context) LiveOutputOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LiveOutputOutput)
}

type LiveOutputOutput struct {
	*pulumi.OutputState
}

func (LiveOutputOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LiveOutputOutput)(nil)).Elem()
}

func (o LiveOutputOutput) ToLiveOutputOutput() LiveOutputOutput {
	return o
}

func (o LiveOutputOutput) ToLiveOutputOutputWithContext(ctx context.Context) LiveOutputOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LiveOutputOutput{})
}
