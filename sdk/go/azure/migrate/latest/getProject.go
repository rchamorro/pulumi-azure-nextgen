// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupProject(ctx *pulumi.Context, args *LookupProjectArgs, opts ...pulumi.InvokeOption) (*LookupProjectResult, error) {
	var rv LookupProjectResult
	err := ctx.Invoke("azure-nextgen:migrate/latest:getProject", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupProjectArgs struct {
	// Name of the Azure Migrate project.
	ProjectName string `pulumi:"projectName"`
	// Name of the Azure Resource Group that project is part of.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Azure Migrate Project.
type LookupProjectResult struct {
	// For optimistic concurrency control.
	ETag *string `pulumi:"eTag"`
	// Azure location in which project is created.
	Location *string `pulumi:"location"`
	// Name of the project.
	Name string `pulumi:"name"`
	// Properties of the project.
	Properties ProjectPropertiesResponse `pulumi:"properties"`
	// Tags provided by Azure Tagging service.
	Tags interface{} `pulumi:"tags"`
	// Type of the object = [Microsoft.Migrate/assessmentProjects].
	Type string `pulumi:"type"`
}
