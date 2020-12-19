// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Properties of the file share, including Id, resource name, resource type, Etag.
type FileShare struct {
	pulumi.CustomResourceState

	// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
	AccessTier pulumi.StringPtrOutput `pulumi:"accessTier"`
	// Indicates the last modification time for share access tier.
	AccessTierChangeTime pulumi.StringOutput `pulumi:"accessTierChangeTime"`
	// Indicates if there is a pending transition for access tier.
	AccessTierStatus pulumi.StringOutput `pulumi:"accessTierStatus"`
	// Indicates whether the share was deleted.
	Deleted pulumi.BoolOutput `pulumi:"deleted"`
	// The deleted time if the share was deleted.
	DeletedTime pulumi.StringOutput `pulumi:"deletedTime"`
	// The authentication protocol that is used for the file share. Can only be specified when creating a share.
	EnabledProtocols pulumi.StringPtrOutput `pulumi:"enabledProtocols"`
	// Resource Etag.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Returns the date and time the share was last modified.
	LastModifiedTime pulumi.StringOutput `pulumi:"lastModifiedTime"`
	// A name-value pair to associate with the share as metadata.
	Metadata pulumi.StringMapOutput `pulumi:"metadata"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Remaining retention days for share that was soft deleted.
	RemainingRetentionDays pulumi.IntOutput `pulumi:"remainingRetentionDays"`
	// The property is for NFS share only. The default is NoRootSquash.
	RootSquash pulumi.StringPtrOutput `pulumi:"rootSquash"`
	// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
	ShareQuota pulumi.IntPtrOutput `pulumi:"shareQuota"`
	// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
	ShareUsageBytes pulumi.IntOutput `pulumi:"shareUsageBytes"`
	// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
	SnapshotTime pulumi.StringOutput `pulumi:"snapshotTime"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The version of the share.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewFileShare registers a new resource with the given unique name, arguments, and options.
func NewFileShare(ctx *pulumi.Context,
	name string, args *FileShareArgs, opts ...pulumi.ResourceOption) (*FileShare, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ShareName == nil {
		return nil, errors.New("invalid value for required argument 'ShareName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/latest:FileShare"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190401:FileShare"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190601:FileShare"),
		},
	})
	opts = append(opts, aliases)
	var resource FileShare
	err := ctx.RegisterResource("azure-nextgen:storage/v20200801preview:FileShare", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFileShare gets an existing FileShare resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFileShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FileShareState, opts ...pulumi.ResourceOption) (*FileShare, error) {
	var resource FileShare
	err := ctx.ReadResource("azure-nextgen:storage/v20200801preview:FileShare", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FileShare resources.
type fileShareState struct {
	// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
	AccessTier *string `pulumi:"accessTier"`
	// Indicates the last modification time for share access tier.
	AccessTierChangeTime *string `pulumi:"accessTierChangeTime"`
	// Indicates if there is a pending transition for access tier.
	AccessTierStatus *string `pulumi:"accessTierStatus"`
	// Indicates whether the share was deleted.
	Deleted *bool `pulumi:"deleted"`
	// The deleted time if the share was deleted.
	DeletedTime *string `pulumi:"deletedTime"`
	// The authentication protocol that is used for the file share. Can only be specified when creating a share.
	EnabledProtocols *string `pulumi:"enabledProtocols"`
	// Resource Etag.
	Etag *string `pulumi:"etag"`
	// Returns the date and time the share was last modified.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// A name-value pair to associate with the share as metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Remaining retention days for share that was soft deleted.
	RemainingRetentionDays *int `pulumi:"remainingRetentionDays"`
	// The property is for NFS share only. The default is NoRootSquash.
	RootSquash *string `pulumi:"rootSquash"`
	// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
	ShareQuota *int `pulumi:"shareQuota"`
	// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
	ShareUsageBytes *int `pulumi:"shareUsageBytes"`
	// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
	SnapshotTime *string `pulumi:"snapshotTime"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// The version of the share.
	Version *string `pulumi:"version"`
}

type FileShareState struct {
	// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
	AccessTier pulumi.StringPtrInput
	// Indicates the last modification time for share access tier.
	AccessTierChangeTime pulumi.StringPtrInput
	// Indicates if there is a pending transition for access tier.
	AccessTierStatus pulumi.StringPtrInput
	// Indicates whether the share was deleted.
	Deleted pulumi.BoolPtrInput
	// The deleted time if the share was deleted.
	DeletedTime pulumi.StringPtrInput
	// The authentication protocol that is used for the file share. Can only be specified when creating a share.
	EnabledProtocols pulumi.StringPtrInput
	// Resource Etag.
	Etag pulumi.StringPtrInput
	// Returns the date and time the share was last modified.
	LastModifiedTime pulumi.StringPtrInput
	// A name-value pair to associate with the share as metadata.
	Metadata pulumi.StringMapInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Remaining retention days for share that was soft deleted.
	RemainingRetentionDays pulumi.IntPtrInput
	// The property is for NFS share only. The default is NoRootSquash.
	RootSquash pulumi.StringPtrInput
	// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
	ShareQuota pulumi.IntPtrInput
	// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
	ShareUsageBytes pulumi.IntPtrInput
	// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
	SnapshotTime pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// The version of the share.
	Version pulumi.StringPtrInput
}

func (FileShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*fileShareState)(nil)).Elem()
}

type fileShareArgs struct {
	// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
	AccessTier *string `pulumi:"accessTier"`
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// The authentication protocol that is used for the file share. Can only be specified when creating a share.
	EnabledProtocols *string `pulumi:"enabledProtocols"`
	// Optional, used to create a snapshot.
	Expand *string `pulumi:"expand"`
	// A name-value pair to associate with the share as metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The property is for NFS share only. The default is NoRootSquash.
	RootSquash *string `pulumi:"rootSquash"`
	// The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
	ShareName string `pulumi:"shareName"`
	// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
	ShareQuota *int `pulumi:"shareQuota"`
}

// The set of arguments for constructing a FileShare resource.
type FileShareArgs struct {
	// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
	AccessTier pulumi.StringPtrInput
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// The authentication protocol that is used for the file share. Can only be specified when creating a share.
	EnabledProtocols pulumi.StringPtrInput
	// Optional, used to create a snapshot.
	Expand pulumi.StringPtrInput
	// A name-value pair to associate with the share as metadata.
	Metadata pulumi.StringMapInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The property is for NFS share only. The default is NoRootSquash.
	RootSquash pulumi.StringPtrInput
	// The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
	ShareName pulumi.StringInput
	// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
	ShareQuota pulumi.IntPtrInput
}

func (FileShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fileShareArgs)(nil)).Elem()
}

type FileShareInput interface {
	pulumi.Input

	ToFileShareOutput() FileShareOutput
	ToFileShareOutputWithContext(ctx context.Context) FileShareOutput
}

func (*FileShare) ElementType() reflect.Type {
	return reflect.TypeOf((*FileShare)(nil))
}

func (i *FileShare) ToFileShareOutput() FileShareOutput {
	return i.ToFileShareOutputWithContext(context.Background())
}

func (i *FileShare) ToFileShareOutputWithContext(ctx context.Context) FileShareOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FileShareOutput)
}

type FileShareOutput struct {
	*pulumi.OutputState
}

func (FileShareOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FileShare)(nil))
}

func (o FileShareOutput) ToFileShareOutput() FileShareOutput {
	return o
}

func (o FileShareOutput) ToFileShareOutputWithContext(ctx context.Context) FileShareOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FileShareOutput{})
}
