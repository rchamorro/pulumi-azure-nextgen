// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190101preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a relation between two resources
type BookmarkRelation struct {
	pulumi.CustomResourceState

	// Etag of the azure resource
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource ID of the related resource
	RelatedResourceId pulumi.StringOutput `pulumi:"relatedResourceId"`
	// The resource kind of the related resource
	RelatedResourceKind pulumi.StringOutput `pulumi:"relatedResourceKind"`
	// The name of the related resource
	RelatedResourceName pulumi.StringOutput `pulumi:"relatedResourceName"`
	// The resource type of the related resource
	RelatedResourceType pulumi.StringOutput `pulumi:"relatedResourceType"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBookmarkRelation registers a new resource with the given unique name, arguments, and options.
func NewBookmarkRelation(ctx *pulumi.Context,
	name string, args *BookmarkRelationArgs, opts ...pulumi.ResourceOption) (*BookmarkRelation, error) {
	if args == nil || args.BookmarkId == nil {
		return nil, errors.New("missing required argument 'BookmarkId'")
	}
	if args == nil || args.OperationalInsightsResourceProvider == nil {
		return nil, errors.New("missing required argument 'OperationalInsightsResourceProvider'")
	}
	if args == nil || args.RelatedResourceId == nil {
		return nil, errors.New("missing required argument 'RelatedResourceId'")
	}
	if args == nil || args.RelationName == nil {
		return nil, errors.New("missing required argument 'RelationName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &BookmarkRelationArgs{}
	}
	var resource BookmarkRelation
	err := ctx.RegisterResource("azure-nextgen:securityinsights/v20190101preview:BookmarkRelation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBookmarkRelation gets an existing BookmarkRelation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBookmarkRelation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BookmarkRelationState, opts ...pulumi.ResourceOption) (*BookmarkRelation, error) {
	var resource BookmarkRelation
	err := ctx.ReadResource("azure-nextgen:securityinsights/v20190101preview:BookmarkRelation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BookmarkRelation resources.
type bookmarkRelationState struct {
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// The resource ID of the related resource
	RelatedResourceId *string `pulumi:"relatedResourceId"`
	// The resource kind of the related resource
	RelatedResourceKind *string `pulumi:"relatedResourceKind"`
	// The name of the related resource
	RelatedResourceName *string `pulumi:"relatedResourceName"`
	// The resource type of the related resource
	RelatedResourceType *string `pulumi:"relatedResourceType"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type BookmarkRelationState struct {
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// The resource ID of the related resource
	RelatedResourceId pulumi.StringPtrInput
	// The resource kind of the related resource
	RelatedResourceKind pulumi.StringPtrInput
	// The name of the related resource
	RelatedResourceName pulumi.StringPtrInput
	// The resource type of the related resource
	RelatedResourceType pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (BookmarkRelationState) ElementType() reflect.Type {
	return reflect.TypeOf((*bookmarkRelationState)(nil)).Elem()
}

type bookmarkRelationArgs struct {
	// Bookmark ID
	BookmarkId string `pulumi:"bookmarkId"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
	OperationalInsightsResourceProvider string `pulumi:"operationalInsightsResourceProvider"`
	// The resource ID of the related resource
	RelatedResourceId string `pulumi:"relatedResourceId"`
	// Relation Name
	RelationName string `pulumi:"relationName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a BookmarkRelation resource.
type BookmarkRelationArgs struct {
	// Bookmark ID
	BookmarkId pulumi.StringInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// The namespace of workspaces resource provider- Microsoft.OperationalInsights.
	OperationalInsightsResourceProvider pulumi.StringInput
	// The resource ID of the related resource
	RelatedResourceId pulumi.StringInput
	// Relation Name
	RelationName pulumi.StringInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (BookmarkRelationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bookmarkRelationArgs)(nil)).Elem()
}

type BookmarkRelationInput interface {
	pulumi.Input

	ToBookmarkRelationOutput() BookmarkRelationOutput
	ToBookmarkRelationOutputWithContext(ctx context.Context) BookmarkRelationOutput
}

func (BookmarkRelation) ElementType() reflect.Type {
	return reflect.TypeOf((*BookmarkRelation)(nil)).Elem()
}

func (i BookmarkRelation) ToBookmarkRelationOutput() BookmarkRelationOutput {
	return i.ToBookmarkRelationOutputWithContext(context.Background())
}

func (i BookmarkRelation) ToBookmarkRelationOutputWithContext(ctx context.Context) BookmarkRelationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BookmarkRelationOutput)
}

type BookmarkRelationOutput struct {
	*pulumi.OutputState
}

func (BookmarkRelationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BookmarkRelationOutput)(nil)).Elem()
}

func (o BookmarkRelationOutput) ToBookmarkRelationOutput() BookmarkRelationOutput {
	return o
}

func (o BookmarkRelationOutput) ToBookmarkRelationOutputWithContext(ctx context.Context) BookmarkRelationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BookmarkRelationOutput{})
}
