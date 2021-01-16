// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupUser(ctx *pulumi.Context, args *LookupUserArgs, opts ...pulumi.InvokeOption) (*LookupUserResult, error) {
	var rv LookupUserResult
	err := ctx.Invoke("azure-nextgen:databoxedge/v20200901:getUser", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupUserArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The user name.
	Name string `pulumi:"name"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Represents a user who has access to one or more shares on the Data Box Edge/Gateway device.
type LookupUserResult struct {
	// The password details.
	EncryptedPassword *AsymmetricEncryptedSecretResponse `pulumi:"encryptedPassword"`
	// The path ID that uniquely identifies the object.
	Id string `pulumi:"id"`
	// The object name.
	Name string `pulumi:"name"`
	// List of shares that the user has rights on. This field should not be specified during user creation.
	ShareAccessRights []ShareAccessRightResponse `pulumi:"shareAccessRights"`
	// User in DataBoxEdge Resource
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The hierarchical type of the object.
	Type string `pulumi:"type"`
	// Type of the user.
	UserType *string `pulumi:"userType"`
}
