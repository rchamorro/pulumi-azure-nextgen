// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200930

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// disk encryption set resource.
type DiskEncryptionSet struct {
	pulumi.CustomResourceState

	// The key vault key which is currently used by this disk encryption set.
	ActiveKey KeyForDiskEncryptionSetResponsePtrOutput `pulumi:"activeKey"`
	// The type of key used to encrypt the data of the disk.
	EncryptionType pulumi.StringPtrOutput `pulumi:"encryptionType"`
	// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
	Identity EncryptionSetIdentityResponsePtrOutput `pulumi:"identity"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation.
	PreviousKeys KeyForDiskEncryptionSetResponseArrayOutput `pulumi:"previousKeys"`
	// The disk encryption set provisioning state.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDiskEncryptionSet registers a new resource with the given unique name, arguments, and options.
func NewDiskEncryptionSet(ctx *pulumi.Context,
	name string, args *DiskEncryptionSetArgs, opts ...pulumi.ResourceOption) (*DiskEncryptionSet, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DiskEncryptionSetName == nil {
		return nil, errors.New("invalid value for required argument 'DiskEncryptionSetName'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:DiskEncryptionSet"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190701:DiskEncryptionSet"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191101:DiskEncryptionSet"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200501:DiskEncryptionSet"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200630:DiskEncryptionSet"),
		},
	})
	opts = append(opts, aliases)
	var resource DiskEncryptionSet
	err := ctx.RegisterResource("azure-nextgen:compute/v20200930:DiskEncryptionSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDiskEncryptionSet gets an existing DiskEncryptionSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDiskEncryptionSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DiskEncryptionSetState, opts ...pulumi.ResourceOption) (*DiskEncryptionSet, error) {
	var resource DiskEncryptionSet
	err := ctx.ReadResource("azure-nextgen:compute/v20200930:DiskEncryptionSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DiskEncryptionSet resources.
type diskEncryptionSetState struct {
	// The key vault key which is currently used by this disk encryption set.
	ActiveKey *KeyForDiskEncryptionSetResponse `pulumi:"activeKey"`
	// The type of key used to encrypt the data of the disk.
	EncryptionType *string `pulumi:"encryptionType"`
	// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
	Identity *EncryptionSetIdentityResponse `pulumi:"identity"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation.
	PreviousKeys []KeyForDiskEncryptionSetResponse `pulumi:"previousKeys"`
	// The disk encryption set provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type DiskEncryptionSetState struct {
	// The key vault key which is currently used by this disk encryption set.
	ActiveKey KeyForDiskEncryptionSetResponsePtrInput
	// The type of key used to encrypt the data of the disk.
	EncryptionType pulumi.StringPtrInput
	// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
	Identity EncryptionSetIdentityResponsePtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation.
	PreviousKeys KeyForDiskEncryptionSetResponseArrayInput
	// The disk encryption set provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (DiskEncryptionSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*diskEncryptionSetState)(nil)).Elem()
}

type diskEncryptionSetArgs struct {
	// The key vault key which is currently used by this disk encryption set.
	ActiveKey *KeyForDiskEncryptionSet `pulumi:"activeKey"`
	// The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
	DiskEncryptionSetName string `pulumi:"diskEncryptionSetName"`
	// The type of key used to encrypt the data of the disk.
	EncryptionType *string `pulumi:"encryptionType"`
	// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
	Identity *EncryptionSetIdentity `pulumi:"identity"`
	// Resource location
	Location string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DiskEncryptionSet resource.
type DiskEncryptionSetArgs struct {
	// The key vault key which is currently used by this disk encryption set.
	ActiveKey KeyForDiskEncryptionSetPtrInput
	// The name of the disk encryption set that is being created. The name can't be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
	DiskEncryptionSetName pulumi.StringInput
	// The type of key used to encrypt the data of the disk.
	EncryptionType pulumi.StringPtrInput
	// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
	Identity EncryptionSetIdentityPtrInput
	// Resource location
	Location pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (DiskEncryptionSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*diskEncryptionSetArgs)(nil)).Elem()
}

type DiskEncryptionSetInput interface {
	pulumi.Input

	ToDiskEncryptionSetOutput() DiskEncryptionSetOutput
	ToDiskEncryptionSetOutputWithContext(ctx context.Context) DiskEncryptionSetOutput
}

func (*DiskEncryptionSet) ElementType() reflect.Type {
	return reflect.TypeOf((*DiskEncryptionSet)(nil))
}

func (i *DiskEncryptionSet) ToDiskEncryptionSetOutput() DiskEncryptionSetOutput {
	return i.ToDiskEncryptionSetOutputWithContext(context.Background())
}

func (i *DiskEncryptionSet) ToDiskEncryptionSetOutputWithContext(ctx context.Context) DiskEncryptionSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DiskEncryptionSetOutput)
}

type DiskEncryptionSetOutput struct {
	*pulumi.OutputState
}

func (DiskEncryptionSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DiskEncryptionSet)(nil))
}

func (o DiskEncryptionSetOutput) ToDiskEncryptionSetOutput() DiskEncryptionSetOutput {
	return o
}

func (o DiskEncryptionSetOutput) ToDiskEncryptionSetOutputWithContext(ctx context.Context) DiskEncryptionSetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DiskEncryptionSetOutput{})
}
