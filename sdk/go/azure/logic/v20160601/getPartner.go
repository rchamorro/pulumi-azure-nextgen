// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPartner(ctx *pulumi.Context, args *LookupPartnerArgs, opts ...pulumi.InvokeOption) (*LookupPartnerResult, error) {
	var rv LookupPartnerResult
	err := ctx.Invoke("azure-nextgen:logic/v20160601:getPartner", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPartnerArgs struct {
	// The integration account name.
	IntegrationAccountName string `pulumi:"integrationAccountName"`
	// The integration account partner name.
	PartnerName string `pulumi:"partnerName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The integration account partner.
type LookupPartnerResult struct {
	// The changed time.
	ChangedTime string `pulumi:"changedTime"`
	// The partner content.
	Content PartnerContentResponse `pulumi:"content"`
	// The created time.
	CreatedTime string `pulumi:"createdTime"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The metadata.
	Metadata interface{} `pulumi:"metadata"`
	// Gets the resource name.
	Name string `pulumi:"name"`
	// The partner type.
	PartnerType string `pulumi:"partnerType"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type string `pulumi:"type"`
}
