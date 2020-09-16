// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Migrate Project REST Resource.
type MigrateProject struct {
	pulumi.CustomResourceState

	// Gets or sets the eTag for concurrency control.
	ETag pulumi.StringPtrOutput `pulumi:"eTag"`
	// Gets or sets the Azure location in which migrate project is created.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Gets the name of the migrate project.
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the nested properties.
	Properties MigrateProjectPropertiesResponseOutput `pulumi:"properties"`
	// Gets or sets the tags.
	Tags MigrateProjectResponseTagsPtrOutput `pulumi:"tags"`
	// Handled by resource provider. Type = Microsoft.Migrate/MigrateProject.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewMigrateProject registers a new resource with the given unique name, arguments, and options.
func NewMigrateProject(ctx *pulumi.Context,
	name string, args *MigrateProjectArgs, opts ...pulumi.ResourceOption) (*MigrateProject, error) {
	if args == nil || args.MigrateProjectName == nil {
		return nil, errors.New("missing required argument 'MigrateProjectName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &MigrateProjectArgs{}
	}
	var resource MigrateProject
	err := ctx.RegisterResource("azure-nextgen:migrate/v20180901preview:MigrateProject", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMigrateProject gets an existing MigrateProject resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMigrateProject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MigrateProjectState, opts ...pulumi.ResourceOption) (*MigrateProject, error) {
	var resource MigrateProject
	err := ctx.ReadResource("azure-nextgen:migrate/v20180901preview:MigrateProject", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MigrateProject resources.
type migrateProjectState struct {
	// Gets or sets the eTag for concurrency control.
	ETag *string `pulumi:"eTag"`
	// Gets or sets the Azure location in which migrate project is created.
	Location *string `pulumi:"location"`
	// Gets the name of the migrate project.
	Name *string `pulumi:"name"`
	// Gets or sets the nested properties.
	Properties *MigrateProjectPropertiesResponse `pulumi:"properties"`
	// Gets or sets the tags.
	Tags *MigrateProjectResponseTags `pulumi:"tags"`
	// Handled by resource provider. Type = Microsoft.Migrate/MigrateProject.
	Type *string `pulumi:"type"`
}

type MigrateProjectState struct {
	// Gets or sets the eTag for concurrency control.
	ETag pulumi.StringPtrInput
	// Gets or sets the Azure location in which migrate project is created.
	Location pulumi.StringPtrInput
	// Gets the name of the migrate project.
	Name pulumi.StringPtrInput
	// Gets or sets the nested properties.
	Properties MigrateProjectPropertiesResponsePtrInput
	// Gets or sets the tags.
	Tags MigrateProjectResponseTagsPtrInput
	// Handled by resource provider. Type = Microsoft.Migrate/MigrateProject.
	Type pulumi.StringPtrInput
}

func (MigrateProjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*migrateProjectState)(nil)).Elem()
}

type migrateProjectArgs struct {
	// Gets or sets the eTag for concurrency control.
	ETag *string `pulumi:"eTag"`
	// Gets or sets the Azure location in which migrate project is created.
	Location *string `pulumi:"location"`
	// Name of the Azure Migrate project.
	MigrateProjectName string `pulumi:"migrateProjectName"`
	// Gets or sets the nested properties.
	Properties *MigrateProjectProperties `pulumi:"properties"`
	// Name of the Azure Resource Group that migrate project is part of.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets the tags.
	Tags *MigrateProjectTags `pulumi:"tags"`
}

// The set of arguments for constructing a MigrateProject resource.
type MigrateProjectArgs struct {
	// Gets or sets the eTag for concurrency control.
	ETag pulumi.StringPtrInput
	// Gets or sets the Azure location in which migrate project is created.
	Location pulumi.StringPtrInput
	// Name of the Azure Migrate project.
	MigrateProjectName pulumi.StringInput
	// Gets or sets the nested properties.
	Properties MigrateProjectPropertiesPtrInput
	// Name of the Azure Resource Group that migrate project is part of.
	ResourceGroupName pulumi.StringInput
	// Gets or sets the tags.
	Tags MigrateProjectTagsPtrInput
}

func (MigrateProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*migrateProjectArgs)(nil)).Elem()
}