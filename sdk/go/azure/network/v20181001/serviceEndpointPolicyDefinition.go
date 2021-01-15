// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Service Endpoint policy definitions.
type ServiceEndpointPolicyDefinition struct {
	pulumi.CustomResourceState

	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The provisioning state of the service end point policy definition. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// service endpoint name.
	Service pulumi.StringPtrOutput `pulumi:"service"`
	// A list of service resources.
	ServiceResources pulumi.StringArrayOutput `pulumi:"serviceResources"`
}

// NewServiceEndpointPolicyDefinition registers a new resource with the given unique name, arguments, and options.
func NewServiceEndpointPolicyDefinition(ctx *pulumi.Context,
	name string, args *ServiceEndpointPolicyDefinitionArgs, opts ...pulumi.ResourceOption) (*ServiceEndpointPolicyDefinition, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServiceEndpointPolicyDefinitionName == nil {
		return nil, errors.New("invalid value for required argument 'ServiceEndpointPolicyDefinitionName'")
	}
	if args.ServiceEndpointPolicyName == nil {
		return nil, errors.New("invalid value for required argument 'ServiceEndpointPolicyName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:ServiceEndpointPolicyDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:ServiceEndpointPolicyDefinition"),
		},
	})
	opts = append(opts, aliases)
	var resource ServiceEndpointPolicyDefinition
	err := ctx.RegisterResource("azure-nextgen:network/v20181001:ServiceEndpointPolicyDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceEndpointPolicyDefinition gets an existing ServiceEndpointPolicyDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceEndpointPolicyDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceEndpointPolicyDefinitionState, opts ...pulumi.ResourceOption) (*ServiceEndpointPolicyDefinition, error) {
	var resource ServiceEndpointPolicyDefinition
	err := ctx.ReadResource("azure-nextgen:network/v20181001:ServiceEndpointPolicyDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceEndpointPolicyDefinition resources.
type serviceEndpointPolicyDefinitionState struct {
	// A description for this rule. Restricted to 140 chars.
	Description *string `pulumi:"description"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the service end point policy definition. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// service endpoint name.
	Service *string `pulumi:"service"`
	// A list of service resources.
	ServiceResources []string `pulumi:"serviceResources"`
}

type ServiceEndpointPolicyDefinitionState struct {
	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the service end point policy definition. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// service endpoint name.
	Service pulumi.StringPtrInput
	// A list of service resources.
	ServiceResources pulumi.StringArrayInput
}

func (ServiceEndpointPolicyDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceEndpointPolicyDefinitionState)(nil)).Elem()
}

type serviceEndpointPolicyDefinitionArgs struct {
	// A description for this rule. Restricted to 140 chars.
	Description *string `pulumi:"description"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// service endpoint name.
	Service *string `pulumi:"service"`
	// The name of the service endpoint policy definition name.
	ServiceEndpointPolicyDefinitionName string `pulumi:"serviceEndpointPolicyDefinitionName"`
	// The name of the service endpoint policy.
	ServiceEndpointPolicyName string `pulumi:"serviceEndpointPolicyName"`
	// A list of service resources.
	ServiceResources []string `pulumi:"serviceResources"`
}

// The set of arguments for constructing a ServiceEndpointPolicyDefinition resource.
type ServiceEndpointPolicyDefinitionArgs struct {
	// A description for this rule. Restricted to 140 chars.
	Description pulumi.StringPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// service endpoint name.
	Service pulumi.StringPtrInput
	// The name of the service endpoint policy definition name.
	ServiceEndpointPolicyDefinitionName pulumi.StringInput
	// The name of the service endpoint policy.
	ServiceEndpointPolicyName pulumi.StringInput
	// A list of service resources.
	ServiceResources pulumi.StringArrayInput
}

func (ServiceEndpointPolicyDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceEndpointPolicyDefinitionArgs)(nil)).Elem()
}

type ServiceEndpointPolicyDefinitionInput interface {
	pulumi.Input

	ToServiceEndpointPolicyDefinitionOutput() ServiceEndpointPolicyDefinitionOutput
	ToServiceEndpointPolicyDefinitionOutputWithContext(ctx context.Context) ServiceEndpointPolicyDefinitionOutput
}

func (*ServiceEndpointPolicyDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpointPolicyDefinition)(nil))
}

func (i *ServiceEndpointPolicyDefinition) ToServiceEndpointPolicyDefinitionOutput() ServiceEndpointPolicyDefinitionOutput {
	return i.ToServiceEndpointPolicyDefinitionOutputWithContext(context.Background())
}

func (i *ServiceEndpointPolicyDefinition) ToServiceEndpointPolicyDefinitionOutputWithContext(ctx context.Context) ServiceEndpointPolicyDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceEndpointPolicyDefinitionOutput)
}

type ServiceEndpointPolicyDefinitionOutput struct {
	*pulumi.OutputState
}

func (ServiceEndpointPolicyDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpointPolicyDefinition)(nil))
}

func (o ServiceEndpointPolicyDefinitionOutput) ToServiceEndpointPolicyDefinitionOutput() ServiceEndpointPolicyDefinitionOutput {
	return o
}

func (o ServiceEndpointPolicyDefinitionOutput) ToServiceEndpointPolicyDefinitionOutputWithContext(ctx context.Context) ServiceEndpointPolicyDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceEndpointPolicyDefinitionOutput{})
}
