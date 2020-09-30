// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150408

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDatabaseAccountGremlinGraph(ctx *pulumi.Context, args *LookupDatabaseAccountGremlinGraphArgs, opts ...pulumi.InvokeOption) (*LookupDatabaseAccountGremlinGraphResult, error) {
	var rv LookupDatabaseAccountGremlinGraphResult
	err := ctx.Invoke("azure-nextgen:documentdb/v20150408:getDatabaseAccountGremlinGraph", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDatabaseAccountGremlinGraphArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// Cosmos DB database name.
	DatabaseName string `pulumi:"databaseName"`
	// Cosmos DB graph name.
	GraphName string `pulumi:"graphName"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// An Azure Cosmos DB Gremlin graph.
type LookupDatabaseAccountGremlinGraphResult struct {
	// The conflict resolution policy for the graph.
	ConflictResolutionPolicy *ConflictResolutionPolicyResponse `pulumi:"conflictResolutionPolicy"`
	// Default time to live
	DefaultTtl *int `pulumi:"defaultTtl"`
	// A system generated property representing the resource etag required for optimistic concurrency control.
	Etag *string `pulumi:"etag"`
	// The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the graph
	IndexingPolicy *IndexingPolicyResponse `pulumi:"indexingPolicy"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the database account.
	Name string `pulumi:"name"`
	// The configuration of the partition key to be used for partitioning data into multiple partitions
	PartitionKey *ContainerPartitionKeyResponse `pulumi:"partitionKey"`
	// A system generated property. A unique identifier.
	Rid *string `pulumi:"rid"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// A system generated property that denotes the last updated timestamp of the resource.
	Ts interface{} `pulumi:"ts"`
	// The type of Azure resource.
	Type string `pulumi:"type"`
	// The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.
	UniqueKeyPolicy *UniqueKeyPolicyResponse `pulumi:"uniqueKeyPolicy"`
}
