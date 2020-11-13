// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160901preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about appliance definition.
type ApplianceDefinition struct {
	pulumi.CustomResourceState

	// The collection of appliance artifacts. The portal will use the files specified as artifacts to construct the user experience of creating an appliance from an appliance definition.
	Artifacts ApplianceArtifactResponseArrayOutput `pulumi:"artifacts"`
	// The appliance provider authorizations.
	Authorizations ApplianceProviderAuthorizationResponseArrayOutput `pulumi:"authorizations"`
	// The appliance definition description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The appliance definition display name.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The identity of the resource.
	Identity IdentityResponsePtrOutput `pulumi:"identity"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The appliance lock level.
	LockLevel pulumi.StringOutput `pulumi:"lockLevel"`
	// ID of the resource that manages this resource.
	ManagedBy pulumi.StringPtrOutput `pulumi:"managedBy"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The appliance definition package file Uri.
	PackageFileUri pulumi.StringOutput `pulumi:"packageFileUri"`
	// The SKU of the resource.
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewApplianceDefinition registers a new resource with the given unique name, arguments, and options.
func NewApplianceDefinition(ctx *pulumi.Context,
	name string, args *ApplianceDefinitionArgs, opts ...pulumi.ResourceOption) (*ApplianceDefinition, error) {
	if args == nil || args.ApplianceDefinitionName == nil {
		return nil, errors.New("missing required argument 'ApplianceDefinitionName'")
	}
	if args == nil || args.Authorizations == nil {
		return nil, errors.New("missing required argument 'Authorizations'")
	}
	if args == nil || args.LockLevel == nil {
		return nil, errors.New("missing required argument 'LockLevel'")
	}
	if args == nil || args.PackageFileUri == nil {
		return nil, errors.New("missing required argument 'PackageFileUri'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ApplianceDefinitionArgs{}
	}
	var resource ApplianceDefinition
	err := ctx.RegisterResource("azure-nextgen:solutions/v20160901preview:ApplianceDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplianceDefinition gets an existing ApplianceDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplianceDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplianceDefinitionState, opts ...pulumi.ResourceOption) (*ApplianceDefinition, error) {
	var resource ApplianceDefinition
	err := ctx.ReadResource("azure-nextgen:solutions/v20160901preview:ApplianceDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApplianceDefinition resources.
type applianceDefinitionState struct {
	// The collection of appliance artifacts. The portal will use the files specified as artifacts to construct the user experience of creating an appliance from an appliance definition.
	Artifacts []ApplianceArtifactResponse `pulumi:"artifacts"`
	// The appliance provider authorizations.
	Authorizations []ApplianceProviderAuthorizationResponse `pulumi:"authorizations"`
	// The appliance definition description.
	Description *string `pulumi:"description"`
	// The appliance definition display name.
	DisplayName *string `pulumi:"displayName"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// Resource location
	Location *string `pulumi:"location"`
	// The appliance lock level.
	LockLevel *string `pulumi:"lockLevel"`
	// ID of the resource that manages this resource.
	ManagedBy *string `pulumi:"managedBy"`
	// Resource name
	Name *string `pulumi:"name"`
	// The appliance definition package file Uri.
	PackageFileUri *string `pulumi:"packageFileUri"`
	// The SKU of the resource.
	Sku *SkuResponse `pulumi:"sku"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type ApplianceDefinitionState struct {
	// The collection of appliance artifacts. The portal will use the files specified as artifacts to construct the user experience of creating an appliance from an appliance definition.
	Artifacts ApplianceArtifactResponseArrayInput
	// The appliance provider authorizations.
	Authorizations ApplianceProviderAuthorizationResponseArrayInput
	// The appliance definition description.
	Description pulumi.StringPtrInput
	// The appliance definition display name.
	DisplayName pulumi.StringPtrInput
	// The identity of the resource.
	Identity IdentityResponsePtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// The appliance lock level.
	LockLevel pulumi.StringPtrInput
	// ID of the resource that manages this resource.
	ManagedBy pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// The appliance definition package file Uri.
	PackageFileUri pulumi.StringPtrInput
	// The SKU of the resource.
	Sku SkuResponsePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (ApplianceDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*applianceDefinitionState)(nil)).Elem()
}

type applianceDefinitionArgs struct {
	// The name of the appliance definition.
	ApplianceDefinitionName string `pulumi:"applianceDefinitionName"`
	// The collection of appliance artifacts. The portal will use the files specified as artifacts to construct the user experience of creating an appliance from an appliance definition.
	Artifacts []ApplianceArtifact `pulumi:"artifacts"`
	// The appliance provider authorizations.
	Authorizations []ApplianceProviderAuthorization `pulumi:"authorizations"`
	// The appliance definition description.
	Description *string `pulumi:"description"`
	// The appliance definition display name.
	DisplayName *string `pulumi:"displayName"`
	// The identity of the resource.
	Identity *Identity `pulumi:"identity"`
	// Resource location
	Location *string `pulumi:"location"`
	// The appliance lock level.
	LockLevel string `pulumi:"lockLevel"`
	// ID of the resource that manages this resource.
	ManagedBy *string `pulumi:"managedBy"`
	// The appliance definition package file Uri.
	PackageFileUri string `pulumi:"packageFileUri"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The SKU of the resource.
	Sku *Sku `pulumi:"sku"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ApplianceDefinition resource.
type ApplianceDefinitionArgs struct {
	// The name of the appliance definition.
	ApplianceDefinitionName pulumi.StringInput
	// The collection of appliance artifacts. The portal will use the files specified as artifacts to construct the user experience of creating an appliance from an appliance definition.
	Artifacts ApplianceArtifactArrayInput
	// The appliance provider authorizations.
	Authorizations ApplianceProviderAuthorizationArrayInput
	// The appliance definition description.
	Description pulumi.StringPtrInput
	// The appliance definition display name.
	DisplayName pulumi.StringPtrInput
	// The identity of the resource.
	Identity IdentityPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// The appliance lock level.
	LockLevel pulumi.StringInput
	// ID of the resource that manages this resource.
	ManagedBy pulumi.StringPtrInput
	// The appliance definition package file Uri.
	PackageFileUri pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The SKU of the resource.
	Sku SkuPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (ApplianceDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applianceDefinitionArgs)(nil)).Elem()
}

type ApplianceDefinitionInput interface {
	pulumi.Input

	ToApplianceDefinitionOutput() ApplianceDefinitionOutput
	ToApplianceDefinitionOutputWithContext(ctx context.Context) ApplianceDefinitionOutput
}

func (ApplianceDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplianceDefinition)(nil)).Elem()
}

func (i ApplianceDefinition) ToApplianceDefinitionOutput() ApplianceDefinitionOutput {
	return i.ToApplianceDefinitionOutputWithContext(context.Background())
}

func (i ApplianceDefinition) ToApplianceDefinitionOutputWithContext(ctx context.Context) ApplianceDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplianceDefinitionOutput)
}

type ApplianceDefinitionOutput struct {
	*pulumi.OutputState
}

func (ApplianceDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplianceDefinitionOutput)(nil)).Elem()
}

func (o ApplianceDefinitionOutput) ToApplianceDefinitionOutput() ApplianceDefinitionOutput {
	return o
}

func (o ApplianceDefinitionOutput) ToApplianceDefinitionOutputWithContext(ctx context.Context) ApplianceDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ApplianceDefinitionOutput{})
}
