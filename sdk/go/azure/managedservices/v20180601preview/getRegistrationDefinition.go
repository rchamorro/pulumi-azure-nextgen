// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupRegistrationDefinition(ctx *pulumi.Context, args *LookupRegistrationDefinitionArgs, opts ...pulumi.InvokeOption) (*LookupRegistrationDefinitionResult, error) {
	var rv LookupRegistrationDefinitionResult
	err := ctx.Invoke("azure-nextgen:managedservices/v20180601preview:getRegistrationDefinition", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupRegistrationDefinitionArgs struct {
	// Guid of the registration definition.
	RegistrationDefinitionId string `pulumi:"registrationDefinitionId"`
	// Scope of the resource.
	Scope string `pulumi:"scope"`
}

// Registration definition.
type LookupRegistrationDefinitionResult struct {
	// Name of the registration definition.
	Name string `pulumi:"name"`
	// Plan details for the managed services.
	Plan *PlanResponse `pulumi:"plan"`
	// Properties of a registration definition.
	Properties RegistrationDefinitionPropertiesResponse `pulumi:"properties"`
	// Type of the resource.
	Type string `pulumi:"type"`
}