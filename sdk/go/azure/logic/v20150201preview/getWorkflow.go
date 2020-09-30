// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150201preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWorkflow(ctx *pulumi.Context, args *LookupWorkflowArgs, opts ...pulumi.InvokeOption) (*LookupWorkflowResult, error) {
	var rv LookupWorkflowResult
	err := ctx.Invoke("azure-nextgen:logic/v20150201preview:getWorkflow", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWorkflowArgs struct {
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The workflow name.
	WorkflowName string `pulumi:"workflowName"`
}

type LookupWorkflowResult struct {
	// Gets the access endpoint.
	AccessEndpoint string `pulumi:"accessEndpoint"`
	// Gets the changed time.
	ChangedTime string `pulumi:"changedTime"`
	// Gets the created time.
	CreatedTime string `pulumi:"createdTime"`
	// Gets or sets the definition.
	Definition interface{} `pulumi:"definition"`
	// Gets or sets the link to definition.
	DefinitionLink *ContentLinkResponse `pulumi:"definitionLink"`
	// Gets or sets the resource location.
	Location *string `pulumi:"location"`
	// Gets the resource name.
	Name *string `pulumi:"name"`
	// Gets or sets the parameters.
	Parameters map[string]WorkflowParameterResponse `pulumi:"parameters"`
	// Gets or sets the link to parameters.
	ParametersLink *ContentLinkResponse `pulumi:"parametersLink"`
	// Gets the provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// Gets or sets the sku.
	Sku *SkuResponse `pulumi:"sku"`
	// Gets or sets the state.
	State *string `pulumi:"state"`
	// Gets or sets the resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type *string `pulumi:"type"`
	// Gets the version.
	Version string `pulumi:"version"`
}
