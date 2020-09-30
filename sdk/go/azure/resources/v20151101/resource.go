// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20151101

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Resource information.
type Resource struct {
	pulumi.CustomResourceState

	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets the plan of the resource.
	Plan PlanResponsePtrOutput `pulumi:"plan"`
	// Gets or sets the resource properties.
	Properties pulumi.AnyOutput `pulumi:"properties"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewResource registers a new resource with the given unique name, arguments, and options.
func NewResource(ctx *pulumi.Context,
	name string, args *ResourceArgs, opts ...pulumi.ResourceOption) (*Resource, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ParentResourcePath == nil {
		return nil, errors.New("missing required argument 'ParentResourcePath'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ResourceName == nil {
		return nil, errors.New("missing required argument 'ResourceName'")
	}
	if args == nil || args.ResourceProviderNamespace == nil {
		return nil, errors.New("missing required argument 'ResourceProviderNamespace'")
	}
	if args == nil || args.ResourceType == nil {
		return nil, errors.New("missing required argument 'ResourceType'")
	}
	if args == nil {
		args = &ResourceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:resources/latest:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160201:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160701:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20160901:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20170510:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20180201:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20180501:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190301:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190501:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190510:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190701:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20190801:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20191001:Resource"),
		},
		{
			Type: pulumi.String("azure-nextgen:resources/v20200601:Resource"),
		},
	})
	opts = append(opts, aliases)
	var resource Resource
	err := ctx.RegisterResource("azure-nextgen:resources/v20151101:Resource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResource gets an existing Resource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceState, opts ...pulumi.ResourceOption) (*Resource, error) {
	var resource Resource
	err := ctx.ReadResource("azure-nextgen:resources/v20151101:Resource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Resource resources.
type resourceState struct {
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Gets or sets the plan of the resource.
	Plan *PlanResponse `pulumi:"plan"`
	// Gets or sets the resource properties.
	Properties interface{} `pulumi:"properties"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type ResourceState struct {
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Gets or sets the plan of the resource.
	Plan PlanResponsePtrInput
	// Gets or sets the resource properties.
	Properties pulumi.Input
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (ResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceState)(nil)).Elem()
}

type resourceArgs struct {
	// Resource location
	Location string `pulumi:"location"`
	// Resource identity.
	ParentResourcePath string `pulumi:"parentResourcePath"`
	// Gets or sets the plan of the resource.
	Plan *Plan `pulumi:"plan"`
	// Gets or sets the resource properties.
	Properties interface{} `pulumi:"properties"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource identity.
	ResourceName string `pulumi:"resourceName"`
	// Resource identity.
	ResourceProviderNamespace string `pulumi:"resourceProviderNamespace"`
	// Resource identity.
	ResourceType string `pulumi:"resourceType"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Resource resource.
type ResourceArgs struct {
	// Resource location
	Location pulumi.StringInput
	// Resource identity.
	ParentResourcePath pulumi.StringInput
	// Gets or sets the plan of the resource.
	Plan PlanPtrInput
	// Gets or sets the resource properties.
	Properties pulumi.Input
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource identity.
	ResourceName pulumi.StringInput
	// Resource identity.
	ResourceProviderNamespace pulumi.StringInput
	// Resource identity.
	ResourceType pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (ResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceArgs)(nil)).Elem()
}
