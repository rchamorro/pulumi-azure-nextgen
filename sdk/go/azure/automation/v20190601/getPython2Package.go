// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupPython2Package(ctx *pulumi.Context, args *LookupPython2PackageArgs, opts ...pulumi.InvokeOption) (*LookupPython2PackageResult, error) {
	var rv LookupPython2PackageResult
	err := ctx.Invoke("azure-nextgen:automation/v20190601:getPython2Package", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPython2PackageArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// The python package name.
	PackageName string `pulumi:"packageName"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Definition of the module type.
type LookupPython2PackageResult struct {
	// Gets or sets the activity count of the module.
	ActivityCount *int `pulumi:"activityCount"`
	// Gets or sets the contentLink of the module.
	ContentLink *ContentLinkResponse `pulumi:"contentLink"`
	// Gets or sets the creation time.
	CreationTime *string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the error info of the module.
	Error *ModuleErrorInfoResponse `pulumi:"error"`
	// Gets or sets the etag of the resource.
	Etag *string `pulumi:"etag"`
	// Fully qualified resource Id for the resource
	Id string `pulumi:"id"`
	// Gets or sets type of module, if its composite or not.
	IsComposite *bool `pulumi:"isComposite"`
	// Gets or sets the isGlobal flag of the module.
	IsGlobal *bool `pulumi:"isGlobal"`
	// Gets or sets the last modified time.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Gets or sets the provisioning state of the module.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets the size in bytes of the module.
	SizeInBytes *float64 `pulumi:"sizeInBytes"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type string `pulumi:"type"`
	// Gets or sets the version of the module.
	Version *string `pulumi:"version"`
}
