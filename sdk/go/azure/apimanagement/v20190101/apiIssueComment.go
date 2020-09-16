// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190101

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Issue Comment Contract details.
type ApiIssueComment struct {
	pulumi.CustomResourceState

	// Date and time when the comment was created.
	CreatedDate pulumi.StringPtrOutput `pulumi:"createdDate"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Comment text.
	Text pulumi.StringOutput `pulumi:"text"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// A resource identifier for the user who left the comment.
	UserId pulumi.StringOutput `pulumi:"userId"`
}

// NewApiIssueComment registers a new resource with the given unique name, arguments, and options.
func NewApiIssueComment(ctx *pulumi.Context,
	name string, args *ApiIssueCommentArgs, opts ...pulumi.ResourceOption) (*ApiIssueComment, error) {
	if args == nil || args.ApiId == nil {
		return nil, errors.New("missing required argument 'ApiId'")
	}
	if args == nil || args.CommentId == nil {
		return nil, errors.New("missing required argument 'CommentId'")
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
	if args == nil || args.Text == nil {
		return nil, errors.New("missing required argument 'Text'")
	}
	if args == nil || args.UserId == nil {
		return nil, errors.New("missing required argument 'UserId'")
	}
	if args == nil {
		args = &ApiIssueCommentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:ApiIssueComment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20170301:ApiIssueComment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180101:ApiIssueComment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20180601preview:ApiIssueComment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201:ApiIssueComment"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201preview:ApiIssueComment"),
		},
	})
	opts = append(opts, aliases)
	var resource ApiIssueComment
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20190101:ApiIssueComment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiIssueComment gets an existing ApiIssueComment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiIssueComment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiIssueCommentState, opts ...pulumi.ResourceOption) (*ApiIssueComment, error) {
	var resource ApiIssueComment
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20190101:ApiIssueComment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiIssueComment resources.
type apiIssueCommentState struct {
	// Date and time when the comment was created.
	CreatedDate *string `pulumi:"createdDate"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Comment text.
	Text *string `pulumi:"text"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
	// A resource identifier for the user who left the comment.
	UserId *string `pulumi:"userId"`
}

type ApiIssueCommentState struct {
	// Date and time when the comment was created.
	CreatedDate pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Comment text.
	Text pulumi.StringPtrInput
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
	// A resource identifier for the user who left the comment.
	UserId pulumi.StringPtrInput
}

func (ApiIssueCommentState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiIssueCommentState)(nil)).Elem()
}

type apiIssueCommentArgs struct {
	// API identifier. Must be unique in the current API Management service instance.
	ApiId string `pulumi:"apiId"`
	// Comment identifier within an Issue. Must be unique in the current Issue.
	CommentId string `pulumi:"commentId"`
	// Date and time when the comment was created.
	CreatedDate *string `pulumi:"createdDate"`
	// Issue identifier. Must be unique in the current API Management service instance.
	IssueId string `pulumi:"issueId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
	// Comment text.
	Text string `pulumi:"text"`
	// A resource identifier for the user who left the comment.
	UserId string `pulumi:"userId"`
}

// The set of arguments for constructing a ApiIssueComment resource.
type ApiIssueCommentArgs struct {
	// API identifier. Must be unique in the current API Management service instance.
	ApiId pulumi.StringInput
	// Comment identifier within an Issue. Must be unique in the current Issue.
	CommentId pulumi.StringInput
	// Date and time when the comment was created.
	CreatedDate pulumi.StringPtrInput
	// Issue identifier. Must be unique in the current API Management service instance.
	IssueId pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
	// Comment text.
	Text pulumi.StringInput
	// A resource identifier for the user who left the comment.
	UserId pulumi.StringInput
}

func (ApiIssueCommentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiIssueCommentArgs)(nil)).Elem()
}