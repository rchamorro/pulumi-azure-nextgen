// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupSavedSearch(ctx *pulumi.Context, args *LookupSavedSearchArgs, opts ...pulumi.InvokeOption) (*LookupSavedSearchResult, error) {
	var rv LookupSavedSearchResult
	err := ctx.Invoke("azure-nextgen:operationalinsights/v20200801:getSavedSearch", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSavedSearchArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The id of the saved search.
	SavedSearchId string `pulumi:"savedSearchId"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// Value object for saved search results.
type LookupSavedSearchResult struct {
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
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The query expression for the saved search.
	Query string `pulumi:"query"`
	// The tags attached to the saved search.
	Tags []TagResponse `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
	// The version number of the query language. The current version is 2 and is the default.
	Version *float64 `pulumi:"version"`
}
