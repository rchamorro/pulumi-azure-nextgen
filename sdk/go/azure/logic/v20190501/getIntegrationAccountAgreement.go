// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupIntegrationAccountAgreement(ctx *pulumi.Context, args *LookupIntegrationAccountAgreementArgs, opts ...pulumi.InvokeOption) (*LookupIntegrationAccountAgreementResult, error) {
	var rv LookupIntegrationAccountAgreementResult
	err := ctx.Invoke("azure-nextgen:logic/v20190501:getIntegrationAccountAgreement", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIntegrationAccountAgreementArgs struct {
	// The integration account agreement name.
	AgreementName string `pulumi:"agreementName"`
	// The integration account name.
	IntegrationAccountName string `pulumi:"integrationAccountName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The integration account agreement.
type LookupIntegrationAccountAgreementResult struct {
	// The agreement type.
	AgreementType string `pulumi:"agreementType"`
	// The changed time.
	ChangedTime string `pulumi:"changedTime"`
	// The agreement content.
	Content AgreementContentResponse `pulumi:"content"`
	// The created time.
	CreatedTime string `pulumi:"createdTime"`
	// The business identity of the guest partner.
	GuestIdentity BusinessIdentityResponse `pulumi:"guestIdentity"`
	// The integration account partner that is set as guest partner for this agreement.
	GuestPartner string `pulumi:"guestPartner"`
	// The business identity of the host partner.
	HostIdentity BusinessIdentityResponse `pulumi:"hostIdentity"`
	// The integration account partner that is set as host partner for this agreement.
	HostPartner string `pulumi:"hostPartner"`
	// The resource location.
	Location *string `pulumi:"location"`
	// The metadata.
	Metadata interface{} `pulumi:"metadata"`
	// Gets the resource name.
	Name string `pulumi:"name"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Gets the resource type.
	Type string `pulumi:"type"`
}
