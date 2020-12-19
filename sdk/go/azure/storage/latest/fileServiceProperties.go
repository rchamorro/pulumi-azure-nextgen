// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The properties of File services in storage account.
// Latest API Version: 2019-06-01.
type FileServiceProperties struct {
	pulumi.CustomResourceState

	// Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service.
	Cors CorsRulesResponsePtrOutput `pulumi:"cors"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The file service properties for share soft delete.
	ShareDeleteRetentionPolicy DeleteRetentionPolicyResponsePtrOutput `pulumi:"shareDeleteRetentionPolicy"`
	// Sku name and tier.
	Sku SkuResponseOutput `pulumi:"sku"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewFileServiceProperties registers a new resource with the given unique name, arguments, and options.
func NewFileServiceProperties(ctx *pulumi.Context,
	name string, args *FileServicePropertiesArgs, opts ...pulumi.ResourceOption) (*FileServiceProperties, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.FileServicesName == nil {
		return nil, errors.New("invalid value for required argument 'FileServicesName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/v20190401:FileServiceProperties"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190601:FileServiceProperties"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20200801preview:FileServiceProperties"),
		},
	})
	opts = append(opts, aliases)
	var resource FileServiceProperties
	err := ctx.RegisterResource("azure-nextgen:storage/latest:FileServiceProperties", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFileServiceProperties gets an existing FileServiceProperties resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFileServiceProperties(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FileServicePropertiesState, opts ...pulumi.ResourceOption) (*FileServiceProperties, error) {
	var resource FileServiceProperties
	err := ctx.ReadResource("azure-nextgen:storage/latest:FileServiceProperties", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FileServiceProperties resources.
type fileServicePropertiesState struct {
	// Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service.
	Cors *CorsRulesResponse `pulumi:"cors"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The file service properties for share soft delete.
	ShareDeleteRetentionPolicy *DeleteRetentionPolicyResponse `pulumi:"shareDeleteRetentionPolicy"`
	// Sku name and tier.
	Sku *SkuResponse `pulumi:"sku"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type FileServicePropertiesState struct {
	// Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service.
	Cors CorsRulesResponsePtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The file service properties for share soft delete.
	ShareDeleteRetentionPolicy DeleteRetentionPolicyResponsePtrInput
	// Sku name and tier.
	Sku SkuResponsePtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (FileServicePropertiesState) ElementType() reflect.Type {
	return reflect.TypeOf((*fileServicePropertiesState)(nil)).Elem()
}

type fileServicePropertiesArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service.
	Cors *CorsRules `pulumi:"cors"`
	// The name of the file Service within the specified storage account. File Service Name must be "default"
	FileServicesName string `pulumi:"fileServicesName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The file service properties for share soft delete.
	ShareDeleteRetentionPolicy *DeleteRetentionPolicy `pulumi:"shareDeleteRetentionPolicy"`
}

// The set of arguments for constructing a FileServiceProperties resource.
type FileServicePropertiesArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service.
	Cors CorsRulesPtrInput
	// The name of the file Service within the specified storage account. File Service Name must be "default"
	FileServicesName pulumi.StringInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The file service properties for share soft delete.
	ShareDeleteRetentionPolicy DeleteRetentionPolicyPtrInput
}

func (FileServicePropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fileServicePropertiesArgs)(nil)).Elem()
}

type FileServicePropertiesInput interface {
	pulumi.Input

	ToFileServicePropertiesOutput() FileServicePropertiesOutput
	ToFileServicePropertiesOutputWithContext(ctx context.Context) FileServicePropertiesOutput
}

func (*FileServiceProperties) ElementType() reflect.Type {
	return reflect.TypeOf((*FileServiceProperties)(nil))
}

func (i *FileServiceProperties) ToFileServicePropertiesOutput() FileServicePropertiesOutput {
	return i.ToFileServicePropertiesOutputWithContext(context.Background())
}

func (i *FileServiceProperties) ToFileServicePropertiesOutputWithContext(ctx context.Context) FileServicePropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FileServicePropertiesOutput)
}

type FileServicePropertiesOutput struct {
	*pulumi.OutputState
}

func (FileServicePropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FileServiceProperties)(nil))
}

func (o FileServicePropertiesOutput) ToFileServicePropertiesOutput() FileServicePropertiesOutput {
	return o
}

func (o FileServicePropertiesOutput) ToFileServicePropertiesOutputWithContext(ctx context.Context) FileServicePropertiesOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FileServicePropertiesOutput{})
}
