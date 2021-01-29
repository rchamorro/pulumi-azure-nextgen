// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListStorageAccountSAS(ctx *pulumi.Context, args *ListStorageAccountSASArgs, opts ...pulumi.InvokeOption) (*ListStorageAccountSASResult, error) {
	var rv ListStorageAccountSASResult
	err := ctx.Invoke("azure-nextgen:storage/v20160501:listStorageAccountSAS", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListStorageAccountSASArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// An IP address or a range of IP addresses from which to accept requests.
	IPAddressOrRange *string `pulumi:"iPAddressOrRange"`
	// The key to sign the account SAS token with.
	KeyToSign *string `pulumi:"keyToSign"`
	// The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
	Permissions string `pulumi:"permissions"`
	// The protocol permitted for a request made with the account SAS.
	Protocols *string `pulumi:"protocols"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files.
	ResourceTypes string `pulumi:"resourceTypes"`
	// The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f).
	Services string `pulumi:"services"`
	// The time at which the shared access signature becomes invalid.
	SharedAccessExpiryTime string `pulumi:"sharedAccessExpiryTime"`
	// The time at which the SAS becomes valid.
	SharedAccessStartTime *string `pulumi:"sharedAccessStartTime"`
}

// The List SAS credentials operation response.
type ListStorageAccountSASResult struct {
	// List SAS credentials of storage account.
	AccountSasToken string `pulumi:"accountSasToken"`
}
