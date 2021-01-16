// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// VpnGatewayNatRule Resource.
// Latest API Version: 2020-08-01.
type NatRule struct {
	pulumi.CustomResourceState

	// List of egress VpnSiteLinkConnections.
	EgressVpnSiteLinkConnections SubResourceResponseArrayOutput `pulumi:"egressVpnSiteLinkConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The private IP address external mapping for NAT.
	ExternalMappings VpnNatRuleMappingResponseArrayOutput `pulumi:"externalMappings"`
	// List of ingress VpnSiteLinkConnections.
	IngressVpnSiteLinkConnections SubResourceResponseArrayOutput `pulumi:"ingressVpnSiteLinkConnections"`
	// The private IP address internal mapping for NAT.
	InternalMappings VpnNatRuleMappingResponseArrayOutput `pulumi:"internalMappings"`
	// The IP Configuration ID this NAT rule applies to.
	IpConfigurationId pulumi.StringPtrOutput `pulumi:"ipConfigurationId"`
	// The Source NAT direction of a VPN NAT.
	Mode pulumi.StringPtrOutput `pulumi:"mode"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The provisioning state of the NAT Rule resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNatRule registers a new resource with the given unique name, arguments, and options.
func NewNatRule(ctx *pulumi.Context,
	name string, args *NatRuleArgs, opts ...pulumi.ResourceOption) (*NatRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GatewayName == nil {
		return nil, errors.New("invalid value for required argument 'GatewayName'")
	}
	if args.NatRuleName == nil {
		return nil, errors.New("invalid value for required argument 'NatRuleName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/v20200801:NatRule"),
		},
	})
	opts = append(opts, aliases)
	var resource NatRule
	err := ctx.RegisterResource("azure-nextgen:network/latest:NatRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNatRule gets an existing NatRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNatRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NatRuleState, opts ...pulumi.ResourceOption) (*NatRule, error) {
	var resource NatRule
	err := ctx.ReadResource("azure-nextgen:network/latest:NatRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NatRule resources.
type natRuleState struct {
	// List of egress VpnSiteLinkConnections.
	EgressVpnSiteLinkConnections []SubResourceResponse `pulumi:"egressVpnSiteLinkConnections"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The private IP address external mapping for NAT.
	ExternalMappings []VpnNatRuleMappingResponse `pulumi:"externalMappings"`
	// List of ingress VpnSiteLinkConnections.
	IngressVpnSiteLinkConnections []SubResourceResponse `pulumi:"ingressVpnSiteLinkConnections"`
	// The private IP address internal mapping for NAT.
	InternalMappings []VpnNatRuleMappingResponse `pulumi:"internalMappings"`
	// The IP Configuration ID this NAT rule applies to.
	IpConfigurationId *string `pulumi:"ipConfigurationId"`
	// The Source NAT direction of a VPN NAT.
	Mode *string `pulumi:"mode"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The provisioning state of the NAT Rule resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type NatRuleState struct {
	// List of egress VpnSiteLinkConnections.
	EgressVpnSiteLinkConnections SubResourceResponseArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The private IP address external mapping for NAT.
	ExternalMappings VpnNatRuleMappingResponseArrayInput
	// List of ingress VpnSiteLinkConnections.
	IngressVpnSiteLinkConnections SubResourceResponseArrayInput
	// The private IP address internal mapping for NAT.
	InternalMappings VpnNatRuleMappingResponseArrayInput
	// The IP Configuration ID this NAT rule applies to.
	IpConfigurationId pulumi.StringPtrInput
	// The Source NAT direction of a VPN NAT.
	Mode pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The provisioning state of the NAT Rule resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (NatRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*natRuleState)(nil)).Elem()
}

type natRuleArgs struct {
	// The private IP address external mapping for NAT.
	ExternalMappings []VpnNatRuleMapping `pulumi:"externalMappings"`
	// The name of the gateway.
	GatewayName string `pulumi:"gatewayName"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The private IP address internal mapping for NAT.
	InternalMappings []VpnNatRuleMapping `pulumi:"internalMappings"`
	// The IP Configuration ID this NAT rule applies to.
	IpConfigurationId *string `pulumi:"ipConfigurationId"`
	// The Source NAT direction of a VPN NAT.
	Mode *string `pulumi:"mode"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The name of the nat rule.
	NatRuleName string `pulumi:"natRuleName"`
	// The resource group name of the VpnGateway.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The type of NAT rule for VPN NAT.
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a NatRule resource.
type NatRuleArgs struct {
	// The private IP address external mapping for NAT.
	ExternalMappings VpnNatRuleMappingArrayInput
	// The name of the gateway.
	GatewayName pulumi.StringInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The private IP address internal mapping for NAT.
	InternalMappings VpnNatRuleMappingArrayInput
	// The IP Configuration ID this NAT rule applies to.
	IpConfigurationId pulumi.StringPtrInput
	// The Source NAT direction of a VPN NAT.
	Mode pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The name of the nat rule.
	NatRuleName pulumi.StringInput
	// The resource group name of the VpnGateway.
	ResourceGroupName pulumi.StringInput
	// The type of NAT rule for VPN NAT.
	Type pulumi.StringPtrInput
}

func (NatRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*natRuleArgs)(nil)).Elem()
}

type NatRuleInput interface {
	pulumi.Input

	ToNatRuleOutput() NatRuleOutput
	ToNatRuleOutputWithContext(ctx context.Context) NatRuleOutput
}

func (*NatRule) ElementType() reflect.Type {
	return reflect.TypeOf((*NatRule)(nil))
}

func (i *NatRule) ToNatRuleOutput() NatRuleOutput {
	return i.ToNatRuleOutputWithContext(context.Background())
}

func (i *NatRule) ToNatRuleOutputWithContext(ctx context.Context) NatRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NatRuleOutput)
}

type NatRuleOutput struct {
	*pulumi.OutputState
}

func (NatRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NatRule)(nil))
}

func (o NatRuleOutput) ToNatRuleOutput() NatRuleOutput {
	return o
}

func (o NatRuleOutput) ToNatRuleOutputWithContext(ctx context.Context) NatRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NatRuleOutput{})
}
