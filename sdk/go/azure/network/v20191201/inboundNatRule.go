// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Inbound NAT rule of the load balancer.
type InboundNatRule struct {
	pulumi.CustomResourceState

	// A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
	BackendIPConfiguration NetworkInterfaceIPConfigurationResponseOutput `pulumi:"backendIPConfiguration"`
	// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
	BackendPort pulumi.IntPtrOutput `pulumi:"backendPort"`
	// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
	EnableFloatingIP pulumi.BoolPtrOutput `pulumi:"enableFloatingIP"`
	// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
	EnableTcpReset pulumi.BoolPtrOutput `pulumi:"enableTcpReset"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// A reference to frontend IP addresses.
	FrontendIPConfiguration SubResourceResponsePtrOutput `pulumi:"frontendIPConfiguration"`
	// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
	FrontendPort pulumi.IntPtrOutput `pulumi:"frontendPort"`
	// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
	IdleTimeoutInMinutes pulumi.IntPtrOutput `pulumi:"idleTimeoutInMinutes"`
	// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// The reference to the transport protocol used by the load balancing rule.
	Protocol pulumi.StringPtrOutput `pulumi:"protocol"`
	// The provisioning state of the inbound NAT rule resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewInboundNatRule registers a new resource with the given unique name, arguments, and options.
func NewInboundNatRule(ctx *pulumi.Context,
	name string, args *InboundNatRuleArgs, opts ...pulumi.ResourceOption) (*InboundNatRule, error) {
	if args == nil || args.InboundNatRuleName == nil {
		return nil, errors.New("missing required argument 'InboundNatRuleName'")
	}
	if args == nil || args.LoadBalancerName == nil {
		return nil, errors.New("missing required argument 'LoadBalancerName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &InboundNatRuleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:InboundNatRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:InboundNatRule"),
		},
	})
	opts = append(opts, aliases)
	var resource InboundNatRule
	err := ctx.RegisterResource("azure-nextgen:network/v20191201:InboundNatRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInboundNatRule gets an existing InboundNatRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInboundNatRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InboundNatRuleState, opts ...pulumi.ResourceOption) (*InboundNatRule, error) {
	var resource InboundNatRule
	err := ctx.ReadResource("azure-nextgen:network/v20191201:InboundNatRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering InboundNatRule resources.
type inboundNatRuleState struct {
	// A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
	BackendIPConfiguration *NetworkInterfaceIPConfigurationResponse `pulumi:"backendIPConfiguration"`
	// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
	BackendPort *int `pulumi:"backendPort"`
	// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
	EnableFloatingIP *bool `pulumi:"enableFloatingIP"`
	// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
	EnableTcpReset *bool `pulumi:"enableTcpReset"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// A reference to frontend IP addresses.
	FrontendIPConfiguration *SubResourceResponse `pulumi:"frontendIPConfiguration"`
	// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
	FrontendPort *int `pulumi:"frontendPort"`
	// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
	IdleTimeoutInMinutes *int `pulumi:"idleTimeoutInMinutes"`
	// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The reference to the transport protocol used by the load balancing rule.
	Protocol *string `pulumi:"protocol"`
	// The provisioning state of the inbound NAT rule resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Type of the resource.
	Type *string `pulumi:"type"`
}

type InboundNatRuleState struct {
	// A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
	BackendIPConfiguration NetworkInterfaceIPConfigurationResponsePtrInput
	// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
	BackendPort pulumi.IntPtrInput
	// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
	EnableFloatingIP pulumi.BoolPtrInput
	// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
	EnableTcpReset pulumi.BoolPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// A reference to frontend IP addresses.
	FrontendIPConfiguration SubResourceResponsePtrInput
	// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
	FrontendPort pulumi.IntPtrInput
	// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
	IdleTimeoutInMinutes pulumi.IntPtrInput
	// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The reference to the transport protocol used by the load balancing rule.
	Protocol pulumi.StringPtrInput
	// The provisioning state of the inbound NAT rule resource.
	ProvisioningState pulumi.StringPtrInput
	// Type of the resource.
	Type pulumi.StringPtrInput
}

func (InboundNatRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*inboundNatRuleState)(nil)).Elem()
}

type inboundNatRuleArgs struct {
	// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
	BackendPort *int `pulumi:"backendPort"`
	// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
	EnableFloatingIP *bool `pulumi:"enableFloatingIP"`
	// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
	EnableTcpReset *bool `pulumi:"enableTcpReset"`
	// A reference to frontend IP addresses.
	FrontendIPConfiguration *SubResource `pulumi:"frontendIPConfiguration"`
	// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
	FrontendPort *int `pulumi:"frontendPort"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
	IdleTimeoutInMinutes *int `pulumi:"idleTimeoutInMinutes"`
	// The name of the inbound nat rule.
	InboundNatRuleName string `pulumi:"inboundNatRuleName"`
	// The name of the load balancer.
	LoadBalancerName string `pulumi:"loadBalancerName"`
	// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// The reference to the transport protocol used by the load balancing rule.
	Protocol *string `pulumi:"protocol"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a InboundNatRule resource.
type InboundNatRuleArgs struct {
	// The port used for the internal endpoint. Acceptable values range from 1 to 65535.
	BackendPort pulumi.IntPtrInput
	// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
	EnableFloatingIP pulumi.BoolPtrInput
	// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
	EnableTcpReset pulumi.BoolPtrInput
	// A reference to frontend IP addresses.
	FrontendIPConfiguration SubResourcePtrInput
	// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
	FrontendPort pulumi.IntPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
	IdleTimeoutInMinutes pulumi.IntPtrInput
	// The name of the inbound nat rule.
	InboundNatRuleName pulumi.StringInput
	// The name of the load balancer.
	LoadBalancerName pulumi.StringInput
	// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// The reference to the transport protocol used by the load balancing rule.
	Protocol pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (InboundNatRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*inboundNatRuleArgs)(nil)).Elem()
}

type InboundNatRuleInput interface {
	pulumi.Input

	ToInboundNatRuleOutput() InboundNatRuleOutput
	ToInboundNatRuleOutputWithContext(ctx context.Context) InboundNatRuleOutput
}

func (InboundNatRule) ElementType() reflect.Type {
	return reflect.TypeOf((*InboundNatRule)(nil)).Elem()
}

func (i InboundNatRule) ToInboundNatRuleOutput() InboundNatRuleOutput {
	return i.ToInboundNatRuleOutputWithContext(context.Background())
}

func (i InboundNatRule) ToInboundNatRuleOutputWithContext(ctx context.Context) InboundNatRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InboundNatRuleOutput)
}

type InboundNatRuleOutput struct {
	*pulumi.OutputState
}

func (InboundNatRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InboundNatRuleOutput)(nil)).Elem()
}

func (o InboundNatRuleOutput) ToInboundNatRuleOutput() InboundNatRuleOutput {
	return o
}

func (o InboundNatRuleOutput) ToInboundNatRuleOutputWithContext(ctx context.Context) InboundNatRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(InboundNatRuleOutput{})
}
