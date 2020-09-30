// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Data store.
type DataStore struct {
	pulumi.CustomResourceState

	// List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
	CustomerSecrets CustomerSecretResponseArrayOutput `pulumi:"customerSecrets"`
	// The arm id of the data store type.
	DataStoreTypeId pulumi.StringOutput `pulumi:"dataStoreTypeId"`
	// A generic json used differently by each data source type.
	ExtendedProperties pulumi.AnyOutput `pulumi:"extendedProperties"`
	// Name of the object.
	Name pulumi.StringOutput `pulumi:"name"`
	// Arm Id for the manager resource to which the data source is associated. This is optional.
	RepositoryId pulumi.StringPtrOutput `pulumi:"repositoryId"`
	// State of the data source.
	State pulumi.StringOutput `pulumi:"state"`
	// Type of the object.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDataStore registers a new resource with the given unique name, arguments, and options.
func NewDataStore(ctx *pulumi.Context,
	name string, args *DataStoreArgs, opts ...pulumi.ResourceOption) (*DataStore, error) {
	if args == nil || args.DataManagerName == nil {
		return nil, errors.New("missing required argument 'DataManagerName'")
	}
	if args == nil || args.DataStoreName == nil {
		return nil, errors.New("missing required argument 'DataStoreName'")
	}
	if args == nil || args.DataStoreTypeId == nil {
		return nil, errors.New("missing required argument 'DataStoreTypeId'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.State == nil {
		return nil, errors.New("missing required argument 'State'")
	}
	if args == nil {
		args = &DataStoreArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:hybriddata/latest:DataStore"),
		},
		{
			Type: pulumi.String("azure-nextgen:hybriddata/v20160601:DataStore"),
		},
	})
	opts = append(opts, aliases)
	var resource DataStore
	err := ctx.RegisterResource("azure-nextgen:hybriddata/v20190601:DataStore", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataStore gets an existing DataStore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataStore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataStoreState, opts ...pulumi.ResourceOption) (*DataStore, error) {
	var resource DataStore
	err := ctx.ReadResource("azure-nextgen:hybriddata/v20190601:DataStore", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataStore resources.
type dataStoreState struct {
	// List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
	CustomerSecrets []CustomerSecretResponse `pulumi:"customerSecrets"`
	// The arm id of the data store type.
	DataStoreTypeId *string `pulumi:"dataStoreTypeId"`
	// A generic json used differently by each data source type.
	ExtendedProperties interface{} `pulumi:"extendedProperties"`
	// Name of the object.
	Name *string `pulumi:"name"`
	// Arm Id for the manager resource to which the data source is associated. This is optional.
	RepositoryId *string `pulumi:"repositoryId"`
	// State of the data source.
	State *string `pulumi:"state"`
	// Type of the object.
	Type *string `pulumi:"type"`
}

type DataStoreState struct {
	// List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
	CustomerSecrets CustomerSecretResponseArrayInput
	// The arm id of the data store type.
	DataStoreTypeId pulumi.StringPtrInput
	// A generic json used differently by each data source type.
	ExtendedProperties pulumi.Input
	// Name of the object.
	Name pulumi.StringPtrInput
	// Arm Id for the manager resource to which the data source is associated. This is optional.
	RepositoryId pulumi.StringPtrInput
	// State of the data source.
	State pulumi.StringPtrInput
	// Type of the object.
	Type pulumi.StringPtrInput
}

func (DataStoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataStoreState)(nil)).Elem()
}

type dataStoreArgs struct {
	// List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
	CustomerSecrets []CustomerSecret `pulumi:"customerSecrets"`
	// The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
	DataManagerName string `pulumi:"dataManagerName"`
	// The data store/repository name to be created or updated.
	DataStoreName string `pulumi:"dataStoreName"`
	// The arm id of the data store type.
	DataStoreTypeId string `pulumi:"dataStoreTypeId"`
	// A generic json used differently by each data source type.
	ExtendedProperties interface{} `pulumi:"extendedProperties"`
	// Arm Id for the manager resource to which the data source is associated. This is optional.
	RepositoryId *string `pulumi:"repositoryId"`
	// The Resource Group Name
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// State of the data source.
	State string `pulumi:"state"`
}

// The set of arguments for constructing a DataStore resource.
type DataStoreArgs struct {
	// List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
	CustomerSecrets CustomerSecretArrayInput
	// The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
	DataManagerName pulumi.StringInput
	// The data store/repository name to be created or updated.
	DataStoreName pulumi.StringInput
	// The arm id of the data store type.
	DataStoreTypeId pulumi.StringInput
	// A generic json used differently by each data source type.
	ExtendedProperties pulumi.Input
	// Arm Id for the manager resource to which the data source is associated. This is optional.
	RepositoryId pulumi.StringPtrInput
	// The Resource Group Name
	ResourceGroupName pulumi.StringInput
	// State of the data source.
	State pulumi.StringInput
}

func (DataStoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataStoreArgs)(nil)).Elem()
}
