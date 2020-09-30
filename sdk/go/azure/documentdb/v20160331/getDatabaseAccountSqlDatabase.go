// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160331

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDatabaseAccountSqlDatabase(ctx *pulumi.Context, args *LookupDatabaseAccountSqlDatabaseArgs, opts ...pulumi.InvokeOption) (*LookupDatabaseAccountSqlDatabaseResult, error) {
	var rv LookupDatabaseAccountSqlDatabaseResult
	err := ctx.Invoke("azure-nextgen:documentdb/v20160331:getDatabaseAccountSqlDatabase", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDatabaseAccountSqlDatabaseArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// Cosmos DB database name.
	DatabaseName string `pulumi:"databaseName"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// An Azure Cosmos DB SQL database.
type LookupDatabaseAccountSqlDatabaseResult struct {
	// A system generated property that specified the addressable path of the collections resource.
	Colls *string `pulumi:"colls"`
	// A system generated property representing the resource etag required for optimistic concurrency control.
	Etag *string `pulumi:"etag"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the database account.
	Name string `pulumi:"name"`
	// A system generated property. A unique identifier.
	Rid *string `pulumi:"rid"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// A system generated property that denotes the last updated timestamp of the resource.
	Ts interface{} `pulumi:"ts"`
	// The type of Azure resource.
	Type string `pulumi:"type"`
	// A system generated property that specifies the addressable path of the users resource.
	Users *string `pulumi:"users"`
}
