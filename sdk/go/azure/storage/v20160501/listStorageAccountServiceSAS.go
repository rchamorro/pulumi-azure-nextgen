// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListStorageAccountServiceSAS(ctx *pulumi.Context, args *ListStorageAccountServiceSASArgs, opts ...pulumi.InvokeOption) (*ListStorageAccountServiceSASResult, error) {
	var rv ListStorageAccountServiceSASResult
	err := ctx.Invoke("azure-nextgen:storage/v20160501:listStorageAccountServiceSAS", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListStorageAccountServiceSASArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// The response header override for cache control.
	CacheControl *string `pulumi:"cacheControl"`
	// The canonical path to the signed resource.
	CanonicalizedResource string `pulumi:"canonicalizedResource"`
	// The response header override for content disposition.
	ContentDisposition *string `pulumi:"contentDisposition"`
	// The response header override for content encoding.
	ContentEncoding *string `pulumi:"contentEncoding"`
	// The response header override for content language.
	ContentLanguage *string `pulumi:"contentLanguage"`
	// The response header override for content type.
	ContentType *string `pulumi:"contentType"`
	// An IP address or a range of IP addresses from which to accept requests.
	IPAddressOrRange *string `pulumi:"iPAddressOrRange"`
	// A unique value up to 64 characters in length that correlates to an access policy specified for the container, queue, or table.
	Identifier *string `pulumi:"identifier"`
	// The key to sign the account SAS token with.
	KeyToSign *string `pulumi:"keyToSign"`
	// The end of partition key.
	PartitionKeyEnd *string `pulumi:"partitionKeyEnd"`
	// The start of partition key.
	PartitionKeyStart *string `pulumi:"partitionKeyStart"`
	// The signed permissions for the service SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
	Permissions *string `pulumi:"permissions"`
	// The protocol permitted for a request made with the account SAS.
	Protocols *string `pulumi:"protocols"`
	// The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s).
	Resource string `pulumi:"resource"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The end of row key.
	RowKeyEnd *string `pulumi:"rowKeyEnd"`
	// The start of row key.
	RowKeyStart *string `pulumi:"rowKeyStart"`
	// The time at which the shared access signature becomes invalid.
	SharedAccessExpiryTime *string `pulumi:"sharedAccessExpiryTime"`
	// The time at which the SAS becomes valid.
	SharedAccessStartTime *string `pulumi:"sharedAccessStartTime"`
}

// The List service SAS credentials operation response.
type ListStorageAccountServiceSASResult struct {
	// List service SAS credentials of specific resource.
	ServiceSasToken string `pulumi:"serviceSasToken"`
}
