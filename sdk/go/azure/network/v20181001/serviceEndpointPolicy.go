// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181001

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Service End point policy resource.
type ServiceEndpointPolicy struct {
	pulumi.CustomResourceState

	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The resource GUID property of the service endpoint policy resource.
	ResourceGuid pulumi.StringOutput `pulumi:"resourceGuid"`
	// A collection of service endpoint policy definitions of the service endpoint policy.
	ServiceEndpointPolicyDefinitions ServiceEndpointPolicyDefinitionResponseArrayOutput `pulumi:"serviceEndpointPolicyDefinitions"`
	// A collection of references to subnets.
	Subnets SubnetResponseArrayOutput `pulumi:"subnets"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewServiceEndpointPolicy registers a new resource with the given unique name, arguments, and options.
func NewServiceEndpointPolicy(ctx *pulumi.Context,
	name string, args *ServiceEndpointPolicyArgs, opts ...pulumi.ResourceOption) (*ServiceEndpointPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.ServiceEndpointPolicyName == nil {
		return nil, errors.New("invalid value for required argument 'ServiceEndpointPolicyName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:ServiceEndpointPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:ServiceEndpointPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource ServiceEndpointPolicy
	err := ctx.RegisterResource("azure-nextgen:network/v20181001:ServiceEndpointPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceEndpointPolicy gets an existing ServiceEndpointPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceEndpointPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceEndpointPolicyState, opts ...pulumi.ResourceOption) (*ServiceEndpointPolicy, error) {
	var resource ServiceEndpointPolicy
	err := ctx.ReadResource("azure-nextgen:network/v20181001:ServiceEndpointPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceEndpointPolicy resources.
type serviceEndpointPolicyState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The resource GUID property of the service endpoint policy resource.
	ResourceGuid *string `pulumi:"resourceGuid"`
	// A collection of service endpoint policy definitions of the service endpoint policy.
	ServiceEndpointPolicyDefinitions []ServiceEndpointPolicyDefinitionResponse `pulumi:"serviceEndpointPolicyDefinitions"`
	// A collection of references to subnets.
	Subnets []SubnetResponse `pulumi:"subnets"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ServiceEndpointPolicyState struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The resource GUID property of the service endpoint policy resource.
	ResourceGuid pulumi.StringPtrInput
	// A collection of service endpoint policy definitions of the service endpoint policy.
	ServiceEndpointPolicyDefinitions ServiceEndpointPolicyDefinitionResponseArrayInput
	// A collection of references to subnets.
	Subnets SubnetResponseArrayInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ServiceEndpointPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceEndpointPolicyState)(nil)).Elem()
}

type serviceEndpointPolicyArgs struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A collection of service endpoint policy definitions of the service endpoint policy.
	ServiceEndpointPolicyDefinitions []ServiceEndpointPolicyDefinitionType `pulumi:"serviceEndpointPolicyDefinitions"`
	// The name of the service endpoint policy.
	ServiceEndpointPolicyName string `pulumi:"serviceEndpointPolicyName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ServiceEndpointPolicy resource.
type ServiceEndpointPolicyArgs struct {
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// A collection of service endpoint policy definitions of the service endpoint policy.
	ServiceEndpointPolicyDefinitions ServiceEndpointPolicyDefinitionTypeArrayInput
	// The name of the service endpoint policy.
	ServiceEndpointPolicyName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ServiceEndpointPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceEndpointPolicyArgs)(nil)).Elem()
}

type ServiceEndpointPolicyInput interface {
	pulumi.Input

	ToServiceEndpointPolicyOutput() ServiceEndpointPolicyOutput
	ToServiceEndpointPolicyOutputWithContext(ctx context.Context) ServiceEndpointPolicyOutput
}

func (*ServiceEndpointPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpointPolicy)(nil))
}

func (i *ServiceEndpointPolicy) ToServiceEndpointPolicyOutput() ServiceEndpointPolicyOutput {
	return i.ToServiceEndpointPolicyOutputWithContext(context.Background())
}

func (i *ServiceEndpointPolicy) ToServiceEndpointPolicyOutputWithContext(ctx context.Context) ServiceEndpointPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceEndpointPolicyOutput)
}

type ServiceEndpointPolicyOutput struct {
	*pulumi.OutputState
}

func (ServiceEndpointPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpointPolicy)(nil))
}

func (o ServiceEndpointPolicyOutput) ToServiceEndpointPolicyOutput() ServiceEndpointPolicyOutput {
	return o
}

func (o ServiceEndpointPolicyOutput) ToServiceEndpointPolicyOutputWithContext(ctx context.Context) ServiceEndpointPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServiceEndpointPolicyOutput{})
}
