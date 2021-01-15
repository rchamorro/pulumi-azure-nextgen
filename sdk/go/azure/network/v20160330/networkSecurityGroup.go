// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160330

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// NetworkSecurityGroup resource
type NetworkSecurityGroup struct {
	pulumi.CustomResourceState

	// Gets or sets Default security rules of network security group
	DefaultSecurityRules SecurityRuleResponseArrayOutput `pulumi:"defaultSecurityRules"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets collection of references to Network Interfaces
	NetworkInterfaces NetworkInterfaceResponseArrayOutput `pulumi:"networkInterfaces"`
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Gets or sets resource GUID property of the network security group resource
	ResourceGuid pulumi.StringPtrOutput `pulumi:"resourceGuid"`
	// Gets or sets Security rules of network security group
	SecurityRules SecurityRuleResponseArrayOutput `pulumi:"securityRules"`
	// Gets collection of references to subnets
	Subnets SubnetResponseArrayOutput `pulumi:"subnets"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNetworkSecurityGroup registers a new resource with the given unique name, arguments, and options.
func NewNetworkSecurityGroup(ctx *pulumi.Context,
	name string, args *NetworkSecurityGroupArgs, opts ...pulumi.ResourceOption) (*NetworkSecurityGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkSecurityGroupName == nil {
		return nil, errors.New("invalid value for required argument 'NetworkSecurityGroupName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:NetworkSecurityGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:NetworkSecurityGroup"),
		},
	})
	opts = append(opts, aliases)
	var resource NetworkSecurityGroup
	err := ctx.RegisterResource("azure-nextgen:network/v20160330:NetworkSecurityGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkSecurityGroup gets an existing NetworkSecurityGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkSecurityGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkSecurityGroupState, opts ...pulumi.ResourceOption) (*NetworkSecurityGroup, error) {
	var resource NetworkSecurityGroup
	err := ctx.ReadResource("azure-nextgen:network/v20160330:NetworkSecurityGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkSecurityGroup resources.
type networkSecurityGroupState struct {
	// Gets or sets Default security rules of network security group
	DefaultSecurityRules []SecurityRuleResponse `pulumi:"defaultSecurityRules"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag *string `pulumi:"etag"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Gets collection of references to Network Interfaces
	NetworkInterfaces []NetworkInterfaceResponse `pulumi:"networkInterfaces"`
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets or sets resource GUID property of the network security group resource
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Gets or sets Security rules of network security group
	SecurityRules []SecurityRuleResponse `pulumi:"securityRules"`
	// Gets collection of references to subnets
	Subnets []SubnetResponse `pulumi:"subnets"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type NetworkSecurityGroupState struct {
	// Gets or sets Default security rules of network security group
	DefaultSecurityRules SecurityRuleResponseArrayInput
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Gets collection of references to Network Interfaces
	NetworkInterfaces NetworkInterfaceResponseArrayInput
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrInput
	// Gets or sets resource GUID property of the network security group resource
	ResourceGuid pulumi.StringPtrInput
	// Gets or sets Security rules of network security group
	SecurityRules SecurityRuleResponseArrayInput
	// Gets collection of references to subnets
	Subnets SubnetResponseArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (NetworkSecurityGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkSecurityGroupState)(nil)).Elem()
}

type networkSecurityGroupArgs struct {
	// Gets or sets Default security rules of network security group
	DefaultSecurityRules []SecurityRuleType `pulumi:"defaultSecurityRules"`
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag *string `pulumi:"etag"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Resource location
	Location *string `pulumi:"location"`
	// Gets collection of references to Network Interfaces
	NetworkInterfaces []NetworkInterfaceType `pulumi:"networkInterfaces"`
	// The name of the network security group.
	NetworkSecurityGroupName string `pulumi:"networkSecurityGroupName"`
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets resource GUID property of the network security group resource
	ResourceGuid *string `pulumi:"resourceGuid"`
	// Gets or sets Security rules of network security group
	SecurityRules []SecurityRuleType `pulumi:"securityRules"`
	// Gets collection of references to subnets
	Subnets []SubnetType `pulumi:"subnets"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NetworkSecurityGroup resource.
type NetworkSecurityGroupArgs struct {
	// Gets or sets Default security rules of network security group
	DefaultSecurityRules SecurityRuleTypeArrayInput
	// Gets a unique read-only string that changes whenever the resource is updated
	Etag pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Gets collection of references to Network Interfaces
	NetworkInterfaces NetworkInterfaceTypeArrayInput
	// The name of the network security group.
	NetworkSecurityGroupName pulumi.StringInput
	// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Gets or sets resource GUID property of the network security group resource
	ResourceGuid pulumi.StringPtrInput
	// Gets or sets Security rules of network security group
	SecurityRules SecurityRuleTypeArrayInput
	// Gets collection of references to subnets
	Subnets SubnetTypeArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (NetworkSecurityGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkSecurityGroupArgs)(nil)).Elem()
}

type NetworkSecurityGroupInput interface {
	pulumi.Input

	ToNetworkSecurityGroupOutput() NetworkSecurityGroupOutput
	ToNetworkSecurityGroupOutputWithContext(ctx context.Context) NetworkSecurityGroupOutput
}

func (*NetworkSecurityGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkSecurityGroup)(nil))
}

func (i *NetworkSecurityGroup) ToNetworkSecurityGroupOutput() NetworkSecurityGroupOutput {
	return i.ToNetworkSecurityGroupOutputWithContext(context.Background())
}

func (i *NetworkSecurityGroup) ToNetworkSecurityGroupOutputWithContext(ctx context.Context) NetworkSecurityGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkSecurityGroupOutput)
}

type NetworkSecurityGroupOutput struct {
	*pulumi.OutputState
}

func (NetworkSecurityGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkSecurityGroup)(nil))
}

func (o NetworkSecurityGroupOutput) ToNetworkSecurityGroupOutput() NetworkSecurityGroupOutput {
	return o
}

func (o NetworkSecurityGroupOutput) ToNetworkSecurityGroupOutputWithContext(ctx context.Context) NetworkSecurityGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NetworkSecurityGroupOutput{})
}
