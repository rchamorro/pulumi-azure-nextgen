// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Value object for saved search results.
type SavedSearch struct {
	pulumi.CustomResourceState

	// The category of the saved search. This helps the user to find a saved search faster.
	Category pulumi.StringOutput `pulumi:"category"`
	// Saved search display name.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// The ETag of the saved search.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The function alias if query serves as a function.
	FunctionAlias pulumi.StringPtrOutput `pulumi:"functionAlias"`
	// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
	FunctionParameters pulumi.StringPtrOutput `pulumi:"functionParameters"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The query expression for the saved search.
	Query pulumi.StringOutput `pulumi:"query"`
	// The tags attached to the saved search.
	Tags TagResponseArrayOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The version number of the query language. The current version is 2 and is the default.
	Version pulumi.IntPtrOutput `pulumi:"version"`
}

// NewSavedSearch registers a new resource with the given unique name, arguments, and options.
func NewSavedSearch(ctx *pulumi.Context,
	name string, args *SavedSearchArgs, opts ...pulumi.ResourceOption) (*SavedSearch, error) {
	if args == nil || args.Category == nil {
		return nil, errors.New("missing required argument 'Category'")
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
	if args == nil || args.SavedSearchId == nil {
		return nil, errors.New("missing required argument 'SavedSearchId'")
	}
	if args == nil || args.WorkspaceName == nil {
		return nil, errors.New("missing required argument 'WorkspaceName'")
	}
	if args == nil {
		args = &SavedSearchArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/latest:SavedSearch"),
		},
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/v20150320:SavedSearch"),
		},
		{
			Type: pulumi.String("azure-nextgen:operationalinsights/v20200801:SavedSearch"),
		},
	})
	opts = append(opts, aliases)
	var resource SavedSearch
	err := ctx.RegisterResource("azure-nextgen:operationalinsights/v20200301preview:SavedSearch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSavedSearch gets an existing SavedSearch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSavedSearch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SavedSearchState, opts ...pulumi.ResourceOption) (*SavedSearch, error) {
	var resource SavedSearch
	err := ctx.ReadResource("azure-nextgen:operationalinsights/v20200301preview:SavedSearch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SavedSearch resources.
type savedSearchState struct {
	// The category of the saved search. This helps the user to find a saved search faster.
	Category *string `pulumi:"category"`
	// Saved search display name.
	DisplayName *string `pulumi:"displayName"`
	// The ETag of the saved search.
	Etag *string `pulumi:"etag"`
	// The function alias if query serves as a function.
	FunctionAlias *string `pulumi:"functionAlias"`
	// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
	FunctionParameters *string `pulumi:"functionParameters"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The query expression for the saved search.
	Query *string `pulumi:"query"`
	// The tags attached to the saved search.
	Tags []TagResponse `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// The version number of the query language. The current version is 2 and is the default.
	Version *int `pulumi:"version"`
}

type SavedSearchState struct {
	// The category of the saved search. This helps the user to find a saved search faster.
	Category pulumi.StringPtrInput
	// Saved search display name.
	DisplayName pulumi.StringPtrInput
	// The ETag of the saved search.
	Etag pulumi.StringPtrInput
	// The function alias if query serves as a function.
	FunctionAlias pulumi.StringPtrInput
	// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
	FunctionParameters pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The query expression for the saved search.
	Query pulumi.StringPtrInput
	// The tags attached to the saved search.
	Tags TagResponseArrayInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// The version number of the query language. The current version is 2 and is the default.
	Version pulumi.IntPtrInput
}

func (SavedSearchState) ElementType() reflect.Type {
	return reflect.TypeOf((*savedSearchState)(nil)).Elem()
}

type savedSearchArgs struct {
	// The category of the saved search. This helps the user to find a saved search faster.
	Category string `pulumi:"category"`
	// Saved search display name.
	DisplayName string `pulumi:"displayName"`
	// The ETag of the saved search.
	Etag *string `pulumi:"etag"`
	// The function alias if query serves as a function.
	FunctionAlias *string `pulumi:"functionAlias"`
	// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
	FunctionParameters *string `pulumi:"functionParameters"`
	// The query expression for the saved search.
	Query string `pulumi:"query"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The id of the saved search.
	SavedSearchId string `pulumi:"savedSearchId"`
	// The tags attached to the saved search.
	Tags []Tag `pulumi:"tags"`
	// The version number of the query language. The current version is 2 and is the default.
	Version *int `pulumi:"version"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a SavedSearch resource.
type SavedSearchArgs struct {
	// The category of the saved search. This helps the user to find a saved search faster.
	Category pulumi.StringInput
	// Saved search display name.
	DisplayName pulumi.StringInput
	// The ETag of the saved search.
	Etag pulumi.StringPtrInput
	// The function alias if query serves as a function.
	FunctionAlias pulumi.StringPtrInput
	// The optional function parameters if query serves as a function. Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'. For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
	FunctionParameters pulumi.StringPtrInput
	// The query expression for the saved search.
	Query pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The id of the saved search.
	SavedSearchId pulumi.StringInput
	// The tags attached to the saved search.
	Tags TagArrayInput
	// The version number of the query language. The current version is 2 and is the default.
	Version pulumi.IntPtrInput
	// The name of the workspace.
	WorkspaceName pulumi.StringInput
}

func (SavedSearchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*savedSearchArgs)(nil)).Elem()
}

type SavedSearchInput interface {
	pulumi.Input

	ToSavedSearchOutput() SavedSearchOutput
	ToSavedSearchOutputWithContext(ctx context.Context) SavedSearchOutput
}

func (SavedSearch) ElementType() reflect.Type {
	return reflect.TypeOf((*SavedSearch)(nil)).Elem()
}

func (i SavedSearch) ToSavedSearchOutput() SavedSearchOutput {
	return i.ToSavedSearchOutputWithContext(context.Background())
}

func (i SavedSearch) ToSavedSearchOutputWithContext(ctx context.Context) SavedSearchOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SavedSearchOutput)
}

type SavedSearchOutput struct {
	*pulumi.OutputState
}

func (SavedSearchOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SavedSearchOutput)(nil)).Elem()
}

func (o SavedSearchOutput) ToSavedSearchOutput() SavedSearchOutput {
	return o
}

func (o SavedSearchOutput) ToSavedSearchOutputWithContext(ctx context.Context) SavedSearchOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SavedSearchOutput{})
}
