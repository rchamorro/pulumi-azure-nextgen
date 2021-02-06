// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200202preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A managed database resource.
type ManagedDatabase struct {
	pulumi.CustomResourceState

	// Whether to auto complete restore of this managed database.
	AutoCompleteRestore pulumi.BoolPtrOutput `pulumi:"autoCompleteRestore"`
	// Collation of the metadata catalog.
	CatalogCollation pulumi.StringPtrOutput `pulumi:"catalogCollation"`
	// Collation of the managed database.
	Collation pulumi.StringPtrOutput `pulumi:"collation"`
	// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
	CreateMode pulumi.StringPtrOutput `pulumi:"createMode"`
	// Creation date of the database.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// Geo paired region.
	DefaultSecondaryLocation pulumi.StringOutput `pulumi:"defaultSecondaryLocation"`
	// Earliest restore point in time for point in time restore.
	EarliestRestorePoint pulumi.StringOutput `pulumi:"earliestRestorePoint"`
	// Instance Failover Group resource identifier that this managed database belongs to.
	FailoverGroupId pulumi.StringOutput `pulumi:"failoverGroupId"`
	// Last backup file name for restore of this managed database.
	LastBackupName pulumi.StringPtrOutput `pulumi:"lastBackupName"`
	// Resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the Long Term Retention backup to be used for restore of this managed database.
	LongTermRetentionBackupResourceId pulumi.StringPtrOutput `pulumi:"longTermRetentionBackupResourceId"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The resource identifier of the recoverable database associated with create operation of this database.
	RecoverableDatabaseId pulumi.StringPtrOutput `pulumi:"recoverableDatabaseId"`
	// The restorable dropped database resource id to restore when creating this database.
	RestorableDroppedDatabaseId pulumi.StringPtrOutput `pulumi:"restorableDroppedDatabaseId"`
	// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrOutput `pulumi:"restorePointInTime"`
	// The resource identifier of the source database associated with create operation of this database.
	SourceDatabaseId pulumi.StringPtrOutput `pulumi:"sourceDatabaseId"`
	// Status of the database.
	Status pulumi.StringOutput `pulumi:"status"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
	StorageContainerSasToken pulumi.StringPtrOutput `pulumi:"storageContainerSasToken"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
	StorageContainerUri pulumi.StringPtrOutput `pulumi:"storageContainerUri"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewManagedDatabase registers a new resource with the given unique name, arguments, and options.
func NewManagedDatabase(ctx *pulumi.Context,
	name string, args *ManagedDatabaseArgs, opts ...pulumi.ResourceOption) (*ManagedDatabase, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatabaseName == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseName'")
	}
	if args.ManagedInstanceName == nil {
		return nil, errors.New("invalid value for required argument 'ManagedInstanceName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:sql/v20170301preview:ManagedDatabase"),
		},
		{
			Type: pulumi.String("azure-nextgen:sql/v20180601preview:ManagedDatabase"),
		},
		{
			Type: pulumi.String("azure-nextgen:sql/v20190601preview:ManagedDatabase"),
		},
		{
			Type: pulumi.String("azure-nextgen:sql/v20200801preview:ManagedDatabase"),
		},
	})
	opts = append(opts, aliases)
	var resource ManagedDatabase
	err := ctx.RegisterResource("azure-nextgen:sql/v20200202preview:ManagedDatabase", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedDatabase gets an existing ManagedDatabase resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedDatabaseState, opts ...pulumi.ResourceOption) (*ManagedDatabase, error) {
	var resource ManagedDatabase
	err := ctx.ReadResource("azure-nextgen:sql/v20200202preview:ManagedDatabase", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedDatabase resources.
type managedDatabaseState struct {
	// Whether to auto complete restore of this managed database.
	AutoCompleteRestore *bool `pulumi:"autoCompleteRestore"`
	// Collation of the metadata catalog.
	CatalogCollation *string `pulumi:"catalogCollation"`
	// Collation of the managed database.
	Collation *string `pulumi:"collation"`
	// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
	CreateMode *string `pulumi:"createMode"`
	// Creation date of the database.
	CreationDate *string `pulumi:"creationDate"`
	// Geo paired region.
	DefaultSecondaryLocation *string `pulumi:"defaultSecondaryLocation"`
	// Earliest restore point in time for point in time restore.
	EarliestRestorePoint *string `pulumi:"earliestRestorePoint"`
	// Instance Failover Group resource identifier that this managed database belongs to.
	FailoverGroupId *string `pulumi:"failoverGroupId"`
	// Last backup file name for restore of this managed database.
	LastBackupName *string `pulumi:"lastBackupName"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the Long Term Retention backup to be used for restore of this managed database.
	LongTermRetentionBackupResourceId *string `pulumi:"longTermRetentionBackupResourceId"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The resource identifier of the recoverable database associated with create operation of this database.
	RecoverableDatabaseId *string `pulumi:"recoverableDatabaseId"`
	// The restorable dropped database resource id to restore when creating this database.
	RestorableDroppedDatabaseId *string `pulumi:"restorableDroppedDatabaseId"`
	// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime *string `pulumi:"restorePointInTime"`
	// The resource identifier of the source database associated with create operation of this database.
	SourceDatabaseId *string `pulumi:"sourceDatabaseId"`
	// Status of the database.
	Status *string `pulumi:"status"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
	StorageContainerSasToken *string `pulumi:"storageContainerSasToken"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
	StorageContainerUri *string `pulumi:"storageContainerUri"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ManagedDatabaseState struct {
	// Whether to auto complete restore of this managed database.
	AutoCompleteRestore pulumi.BoolPtrInput
	// Collation of the metadata catalog.
	CatalogCollation pulumi.StringPtrInput
	// Collation of the managed database.
	Collation pulumi.StringPtrInput
	// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
	CreateMode pulumi.StringPtrInput
	// Creation date of the database.
	CreationDate pulumi.StringPtrInput
	// Geo paired region.
	DefaultSecondaryLocation pulumi.StringPtrInput
	// Earliest restore point in time for point in time restore.
	EarliestRestorePoint pulumi.StringPtrInput
	// Instance Failover Group resource identifier that this managed database belongs to.
	FailoverGroupId pulumi.StringPtrInput
	// Last backup file name for restore of this managed database.
	LastBackupName pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the Long Term Retention backup to be used for restore of this managed database.
	LongTermRetentionBackupResourceId pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The resource identifier of the recoverable database associated with create operation of this database.
	RecoverableDatabaseId pulumi.StringPtrInput
	// The restorable dropped database resource id to restore when creating this database.
	RestorableDroppedDatabaseId pulumi.StringPtrInput
	// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrInput
	// The resource identifier of the source database associated with create operation of this database.
	SourceDatabaseId pulumi.StringPtrInput
	// Status of the database.
	Status pulumi.StringPtrInput
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
	StorageContainerSasToken pulumi.StringPtrInput
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
	StorageContainerUri pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ManagedDatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedDatabaseState)(nil)).Elem()
}

type managedDatabaseArgs struct {
	// Whether to auto complete restore of this managed database.
	AutoCompleteRestore *bool `pulumi:"autoCompleteRestore"`
	// Collation of the metadata catalog.
	CatalogCollation *string `pulumi:"catalogCollation"`
	// Collation of the managed database.
	Collation *string `pulumi:"collation"`
	// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
	CreateMode *string `pulumi:"createMode"`
	// The name of the database.
	DatabaseName string `pulumi:"databaseName"`
	// Last backup file name for restore of this managed database.
	LastBackupName *string `pulumi:"lastBackupName"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the Long Term Retention backup to be used for restore of this managed database.
	LongTermRetentionBackupResourceId *string `pulumi:"longTermRetentionBackupResourceId"`
	// The name of the managed instance.
	ManagedInstanceName string `pulumi:"managedInstanceName"`
	// The resource identifier of the recoverable database associated with create operation of this database.
	RecoverableDatabaseId *string `pulumi:"recoverableDatabaseId"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The restorable dropped database resource id to restore when creating this database.
	RestorableDroppedDatabaseId *string `pulumi:"restorableDroppedDatabaseId"`
	// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime *string `pulumi:"restorePointInTime"`
	// The resource identifier of the source database associated with create operation of this database.
	SourceDatabaseId *string `pulumi:"sourceDatabaseId"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
	StorageContainerSasToken *string `pulumi:"storageContainerSasToken"`
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
	StorageContainerUri *string `pulumi:"storageContainerUri"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ManagedDatabase resource.
type ManagedDatabaseArgs struct {
	// Whether to auto complete restore of this managed database.
	AutoCompleteRestore pulumi.BoolPtrInput
	// Collation of the metadata catalog.
	CatalogCollation pulumi.StringPtrInput
	// Collation of the managed database.
	Collation pulumi.StringPtrInput
	// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
	CreateMode pulumi.StringPtrInput
	// The name of the database.
	DatabaseName pulumi.StringInput
	// Last backup file name for restore of this managed database.
	LastBackupName pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the Long Term Retention backup to be used for restore of this managed database.
	LongTermRetentionBackupResourceId pulumi.StringPtrInput
	// The name of the managed instance.
	ManagedInstanceName pulumi.StringInput
	// The resource identifier of the recoverable database associated with create operation of this database.
	RecoverableDatabaseId pulumi.StringPtrInput
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName pulumi.StringInput
	// The restorable dropped database resource id to restore when creating this database.
	RestorableDroppedDatabaseId pulumi.StringPtrInput
	// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrInput
	// The resource identifier of the source database associated with create operation of this database.
	SourceDatabaseId pulumi.StringPtrInput
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
	StorageContainerSasToken pulumi.StringPtrInput
	// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
	StorageContainerUri pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ManagedDatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedDatabaseArgs)(nil)).Elem()
}

type ManagedDatabaseInput interface {
	pulumi.Input

	ToManagedDatabaseOutput() ManagedDatabaseOutput
	ToManagedDatabaseOutputWithContext(ctx context.Context) ManagedDatabaseOutput
}

func (*ManagedDatabase) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedDatabase)(nil))
}

func (i *ManagedDatabase) ToManagedDatabaseOutput() ManagedDatabaseOutput {
	return i.ToManagedDatabaseOutputWithContext(context.Background())
}

func (i *ManagedDatabase) ToManagedDatabaseOutputWithContext(ctx context.Context) ManagedDatabaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabaseOutput)
}

type ManagedDatabaseOutput struct {
	*pulumi.OutputState
}

func (ManagedDatabaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedDatabase)(nil))
}

func (o ManagedDatabaseOutput) ToManagedDatabaseOutput() ManagedDatabaseOutput {
	return o
}

func (o ManagedDatabaseOutput) ToManagedDatabaseOutputWithContext(ctx context.Context) ManagedDatabaseOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ManagedDatabaseOutput{})
}
