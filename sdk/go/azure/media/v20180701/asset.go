// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180701

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Asset.
type Asset struct {
	pulumi.CustomResourceState

	// The alternate ID of the Asset.
	AlternateId pulumi.StringPtrOutput `pulumi:"alternateId"`
	// The Asset ID.
	AssetId pulumi.StringOutput `pulumi:"assetId"`
	// The name of the asset blob container.
	Container pulumi.StringPtrOutput `pulumi:"container"`
	// The creation date of the Asset.
	Created pulumi.StringOutput `pulumi:"created"`
	// The Asset description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The last modified date of the Asset.
	LastModified pulumi.StringOutput `pulumi:"lastModified"`
	// The name of the resource.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the storage account.
	StorageAccountName pulumi.StringPtrOutput `pulumi:"storageAccountName"`
	// The Asset encryption format. One of None or MediaStorageEncryption.
	StorageEncryptionFormat pulumi.StringOutput `pulumi:"storageEncryptionFormat"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAsset registers a new resource with the given unique name, arguments, and options.
func NewAsset(ctx *pulumi.Context,
	name string, args *AssetArgs, opts ...pulumi.ResourceOption) (*Asset, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.AssetName == nil {
		return nil, errors.New("missing required argument 'AssetName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &AssetArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/latest:Asset"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180330preview:Asset"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180601preview:Asset"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20200501:Asset"),
		},
	})
	opts = append(opts, aliases)
	var resource Asset
	err := ctx.RegisterResource("azure-nextgen:media/v20180701:Asset", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAsset gets an existing Asset resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAsset(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AssetState, opts ...pulumi.ResourceOption) (*Asset, error) {
	var resource Asset
	err := ctx.ReadResource("azure-nextgen:media/v20180701:Asset", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Asset resources.
type assetState struct {
	// The alternate ID of the Asset.
	AlternateId *string `pulumi:"alternateId"`
	// The Asset ID.
	AssetId *string `pulumi:"assetId"`
	// The name of the asset blob container.
	Container *string `pulumi:"container"`
	// The creation date of the Asset.
	Created *string `pulumi:"created"`
	// The Asset description.
	Description *string `pulumi:"description"`
	// The last modified date of the Asset.
	LastModified *string `pulumi:"lastModified"`
	// The name of the resource.
	Name *string `pulumi:"name"`
	// The name of the storage account.
	StorageAccountName *string `pulumi:"storageAccountName"`
	// The Asset encryption format. One of None or MediaStorageEncryption.
	StorageEncryptionFormat *string `pulumi:"storageEncryptionFormat"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type AssetState struct {
	// The alternate ID of the Asset.
	AlternateId pulumi.StringPtrInput
	// The Asset ID.
	AssetId pulumi.StringPtrInput
	// The name of the asset blob container.
	Container pulumi.StringPtrInput
	// The creation date of the Asset.
	Created pulumi.StringPtrInput
	// The Asset description.
	Description pulumi.StringPtrInput
	// The last modified date of the Asset.
	LastModified pulumi.StringPtrInput
	// The name of the resource.
	Name pulumi.StringPtrInput
	// The name of the storage account.
	StorageAccountName pulumi.StringPtrInput
	// The Asset encryption format. One of None or MediaStorageEncryption.
	StorageEncryptionFormat pulumi.StringPtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (AssetState) ElementType() reflect.Type {
	return reflect.TypeOf((*assetState)(nil)).Elem()
}

type assetArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The alternate ID of the Asset.
	AlternateId *string `pulumi:"alternateId"`
	// The Asset name.
	AssetName string `pulumi:"assetName"`
	// The name of the asset blob container.
	Container *string `pulumi:"container"`
	// The Asset description.
	Description *string `pulumi:"description"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the storage account.
	StorageAccountName *string `pulumi:"storageAccountName"`
}

// The set of arguments for constructing a Asset resource.
type AssetArgs struct {
	// The Media Services account name.
	AccountName pulumi.StringInput
	// The alternate ID of the Asset.
	AlternateId pulumi.StringPtrInput
	// The Asset name.
	AssetName pulumi.StringInput
	// The name of the asset blob container.
	Container pulumi.StringPtrInput
	// The Asset description.
	Description pulumi.StringPtrInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The name of the storage account.
	StorageAccountName pulumi.StringPtrInput
}

func (AssetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*assetArgs)(nil)).Elem()
}

type AssetInput interface {
	pulumi.Input

	ToAssetOutput() AssetOutput
	ToAssetOutputWithContext(ctx context.Context) AssetOutput
}

func (Asset) ElementType() reflect.Type {
	return reflect.TypeOf((*Asset)(nil)).Elem()
}

func (i Asset) ToAssetOutput() AssetOutput {
	return i.ToAssetOutputWithContext(context.Background())
}

func (i Asset) ToAssetOutputWithContext(ctx context.Context) AssetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AssetOutput)
}

type AssetOutput struct {
	*pulumi.OutputState
}

func (AssetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AssetOutput)(nil)).Elem()
}

func (o AssetOutput) ToAssetOutput() AssetOutput {
	return o
}

func (o AssetOutput) ToAssetOutputWithContext(ctx context.Context) AssetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AssetOutput{})
}
