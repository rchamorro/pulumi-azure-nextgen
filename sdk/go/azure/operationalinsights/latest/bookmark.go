// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a bookmark in Azure Security Insights.
type Bookmark struct {
	pulumi.CustomResourceState

	// The time the bookmark was created
	Created pulumi.StringPtrOutput `pulumi:"created"`
	// Describes a user that created the bookmark
	CreatedBy UserInfoResponsePtrOutput `pulumi:"createdBy"`
	// The display name of the bookmark
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Etag of the azure resource
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Describes an incident that relates to bookmark
	IncidentInfo IncidentInfoResponsePtrOutput `pulumi:"incidentInfo"`
	// List of labels relevant to this bookmark
	Labels pulumi.StringArrayOutput `pulumi:"labels"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The notes of the bookmark
	Notes pulumi.StringPtrOutput `pulumi:"notes"`
	// The query of the bookmark.
	Query pulumi.StringOutput `pulumi:"query"`
	// The query result of the bookmark.
	QueryResult pulumi.StringPtrOutput `pulumi:"queryResult"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// The last time the bookmark was updated
	Updated pulumi.StringPtrOutput `pulumi:"updated"`
	// Describes a user that updated the bookmark
	UpdatedBy UserInfoResponsePtrOutput `pulumi:"updatedBy"`
}

// NewBookmark registers a new resource with the given unique name, arguments, and options.
func NewBookmark(ctx *pulumi.Context,
	name string, args *BookmarkArgs, opts ...pulumi.ResourceOption) (*Bookmark, error) {
	if args == nil || args.BookmarkId == nil {
		return nil, errors.New("missing required argument 'BookmarkId'")
	}
	if args == nil || args.DisplayName == nil {
		return nil, errors.New("missing required argument 'DisplayName'")
	}
	if args == nil || args.Query == nil {
		return nil, errors.New("missing required argument 'Query'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &BookmarkArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/v20200101:Bookmark"),
		},
	})
	opts = append(opts, aliases)
	var resource Bookmark
	err := ctx.RegisterResource("azure-nextgen:operationalinsights/latest:Bookmark", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBookmark gets an existing Bookmark resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBookmark(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BookmarkState, opts ...pulumi.ResourceOption) (*Bookmark, error) {
	var resource Bookmark
	err := ctx.ReadResource("azure-nextgen:operationalinsights/latest:Bookmark", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Bookmark resources.
type bookmarkState struct {
	// The time the bookmark was created
	Created *string `pulumi:"created"`
	// Describes a user that created the bookmark
	CreatedBy *UserInfoResponse `pulumi:"createdBy"`
	// The display name of the bookmark
	DisplayName *string `pulumi:"displayName"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// Describes an incident that relates to bookmark
	IncidentInfo *IncidentInfoResponse `pulumi:"incidentInfo"`
	// List of labels relevant to this bookmark
	Labels []string `pulumi:"labels"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// The notes of the bookmark
	Notes *string `pulumi:"notes"`
	// The query of the bookmark.
	Query *string `pulumi:"query"`
	// The query result of the bookmark.
	QueryResult *string `pulumi:"queryResult"`
	// Azure resource type
	Type *string `pulumi:"type"`
	// The last time the bookmark was updated
	Updated *string `pulumi:"updated"`
	// Describes a user that updated the bookmark
	UpdatedBy *UserInfoResponse `pulumi:"updatedBy"`
}

type BookmarkState struct {
	// The time the bookmark was created
	Created pulumi.StringPtrInput
	// Describes a user that created the bookmark
	CreatedBy UserInfoResponsePtrInput
	// The display name of the bookmark
	DisplayName pulumi.StringPtrInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// Describes an incident that relates to bookmark
	IncidentInfo IncidentInfoResponsePtrInput
	// List of labels relevant to this bookmark
	Labels pulumi.StringArrayInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// The notes of the bookmark
	Notes pulumi.StringPtrInput
	// The query of the bookmark.
	Query pulumi.StringPtrInput
	// The query result of the bookmark.
	QueryResult pulumi.StringPtrInput
	// Azure resource type
	Type pulumi.StringPtrInput
	// The last time the bookmark was updated
	Updated pulumi.StringPtrInput
	// Describes a user that updated the bookmark
	UpdatedBy UserInfoResponsePtrInput
}

func (BookmarkState) ElementType() reflect.Type {
	return reflect.TypeOf((*bookmarkState)(nil)).Elem()
}

type bookmarkArgs struct {
	// Bookmark ID
	BookmarkId string `pulumi:"bookmarkId"`
	// The time the bookmark was created
	Created *string `pulumi:"created"`
	// Describes a user that created the bookmark
	CreatedBy *UserInfo `pulumi:"createdBy"`
	// The display name of the bookmark
	DisplayName string `pulumi:"displayName"`
	// Etag of the azure resource
	Etag *string `pulumi:"etag"`
	// Describes an incident that relates to bookmark
	IncidentInfo *IncidentInfo `pulumi:"incidentInfo"`
	// List of labels relevant to this bookmark
	Labels []string `pulumi:"labels"`
	// The notes of the bookmark
	Notes *string `pulumi:"notes"`
	// The query of the bookmark.
	Query string `pulumi:"query"`
	// The query result of the bookmark.
	QueryResult *string `pulumi:"queryResult"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The last time the bookmark was updated
	Updated *string `pulumi:"updated"`
	// Describes a user that updated the bookmark
	UpdatedBy *UserInfo `pulumi:"updatedBy"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a Bookmark resource.
type BookmarkArgs struct {
	// Bookmark ID
	BookmarkId pulumi.StringInput
	// The time the bookmark was created
	Created pulumi.StringPtrInput
	// Describes a user that created the bookmark
	CreatedBy UserInfoPtrInput
	// The display name of the bookmark
	DisplayName pulumi.StringInput
	// Etag of the azure resource
	Etag pulumi.StringPtrInput
	// Describes an incident that relates to bookmark
	IncidentInfo IncidentInfoPtrInput
	// List of labels relevant to this bookmark
	Labels pulumi.StringArrayInput
	// The notes of the bookmark
	Notes pulumi.StringPtrInput
	// The query of the bookmark.
	Query pulumi.StringInput
	// The query result of the bookmark.
	QueryResult pulumi.StringPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The last time the bookmark was updated
	Updated pulumi.StringPtrInput
	// Describes a user that updated the bookmark
	UpdatedBy UserInfoPtrInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (BookmarkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bookmarkArgs)(nil)).Elem()
}