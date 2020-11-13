// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Issue Attachment Contract details.
type ApiIssueAttachment struct {
	pulumi.CustomResourceState

	// An HTTP link or Base64-encoded binary data.
	Content pulumi.StringOutput `pulumi:"content"`
	// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
	ContentFormat pulumi.StringOutput `pulumi:"contentFormat"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Filename by which the binary data will be saved.
	Title pulumi.StringOutput `pulumi:"title"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewApiIssueAttachment registers a new resource with the given unique name, arguments, and options.
func NewApiIssueAttachment(ctx *pulumi.Context,
	name string, args *ApiIssueAttachmentArgs, opts ...pulumi.ResourceOption) (*ApiIssueAttachment, error) {
	if args == nil || args.ApiId == nil {
		return nil, errors.New("missing required argument 'ApiId'")
	}
	if args == nil || args.AttachmentId == nil {
		return nil, errors.New("missing required argument 'AttachmentId'")
	}
	if args == nil || args.Content == nil {
		return nil, errors.New("missing required argument 'Content'")
	}
	if args == nil || args.ContentFormat == nil {
		return nil, errors.New("missing required argument 'ContentFormat'")
	}
	if args == nil || args.IssueId == nil {
		return nil, errors.New("missing required argument 'IssueId'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil {
		args = &ApiIssueAttachmentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20170301:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180101:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20190101:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201preview:ApiIssueAttachment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20200601preview:ApiIssueAttachment"),
		},
	})
	opts = append(opts, aliases)
	var resource ApiIssueAttachment
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20180601preview:ApiIssueAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiIssueAttachment gets an existing ApiIssueAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiIssueAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiIssueAttachmentState, opts ...pulumi.ResourceOption) (*ApiIssueAttachment, error) {
	var resource ApiIssueAttachment
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20180601preview:ApiIssueAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiIssueAttachment resources.
type apiIssueAttachmentState struct {
	// An HTTP link or Base64-encoded binary data.
	Content *string `pulumi:"content"`
	// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
	ContentFormat *string `pulumi:"contentFormat"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Filename by which the binary data will be saved.
	Title *string `pulumi:"title"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
}

type ApiIssueAttachmentState struct {
	// An HTTP link or Base64-encoded binary data.
	Content pulumi.StringPtrInput
	// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
	ContentFormat pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Filename by which the binary data will be saved.
	Title pulumi.StringPtrInput
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
}

func (ApiIssueAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiIssueAttachmentState)(nil)).Elem()
}

type apiIssueAttachmentArgs struct {
	// API identifier. Must be unique in the current API Management service instance.
	ApiId string `pulumi:"apiId"`
	// Attachment identifier within an Issue. Must be unique in the current Issue.
	AttachmentId string `pulumi:"attachmentId"`
	// An HTTP link or Base64-encoded binary data.
	Content string `pulumi:"content"`
	// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
	ContentFormat string `pulumi:"contentFormat"`
	// Issue identifier. Must be unique in the current API Management service instance.
	IssueId string `pulumi:"issueId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
	// Filename by which the binary data will be saved.
	Title string `pulumi:"title"`
}

// The set of arguments for constructing a ApiIssueAttachment resource.
type ApiIssueAttachmentArgs struct {
	// API identifier. Must be unique in the current API Management service instance.
	ApiId pulumi.StringInput
	// Attachment identifier within an Issue. Must be unique in the current Issue.
	AttachmentId pulumi.StringInput
	// An HTTP link or Base64-encoded binary data.
	Content pulumi.StringInput
	// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
	ContentFormat pulumi.StringInput
	// Issue identifier. Must be unique in the current API Management service instance.
	IssueId pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
	// Filename by which the binary data will be saved.
	Title pulumi.StringInput
}

func (ApiIssueAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiIssueAttachmentArgs)(nil)).Elem()
}

type ApiIssueAttachmentInput interface {
	pulumi.Input

	ToApiIssueAttachmentOutput() ApiIssueAttachmentOutput
	ToApiIssueAttachmentOutputWithContext(ctx context.Context) ApiIssueAttachmentOutput
}

func (ApiIssueAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiIssueAttachment)(nil)).Elem()
}

func (i ApiIssueAttachment) ToApiIssueAttachmentOutput() ApiIssueAttachmentOutput {
	return i.ToApiIssueAttachmentOutputWithContext(context.Background())
}

func (i ApiIssueAttachment) ToApiIssueAttachmentOutputWithContext(ctx context.Context) ApiIssueAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiIssueAttachmentOutput)
}

type ApiIssueAttachmentOutput struct {
	*pulumi.OutputState
}

func (ApiIssueAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiIssueAttachmentOutput)(nil)).Elem()
}

func (o ApiIssueAttachmentOutput) ToApiIssueAttachmentOutput() ApiIssueAttachmentOutput {
	return o
}

func (o ApiIssueAttachmentOutput) ToApiIssueAttachmentOutputWithContext(ctx context.Context) ApiIssueAttachmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ApiIssueAttachmentOutput{})
}
