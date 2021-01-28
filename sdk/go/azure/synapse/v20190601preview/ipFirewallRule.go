// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// IP firewall rule
type IpFirewallRule struct {
	pulumi.CustomResourceState

	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress pulumi.StringPtrOutput `pulumi:"endIpAddress"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource provisioning state
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress pulumi.StringPtrOutput `pulumi:"startIpAddress"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewIpFirewallRule registers a new resource with the given unique name, arguments, and options.
func NewIpFirewallRule(ctx *pulumi.Context,
	name string, args *IpFirewallRuleArgs, opts ...pulumi.ResourceOption) (*IpFirewallRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.RuleName == nil {
		return nil, errors.New("invalid value for required argument 'RuleName'")
	}
	if args.WorkspaceName == nil {
		return nil, errors.New("invalid value for required argument 'WorkspaceName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:synapse/v20201201:IpFirewallRule"),
		},
	})
	opts = append(opts, aliases)
	var resource IpFirewallRule
	err := ctx.RegisterResource("azure-nextgen:synapse/v20190601preview:IpFirewallRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIpFirewallRule gets an existing IpFirewallRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIpFirewallRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IpFirewallRuleState, opts ...pulumi.ResourceOption) (*IpFirewallRule, error) {
	var resource IpFirewallRule
	err := ctx.ReadResource("azure-nextgen:synapse/v20190601preview:IpFirewallRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IpFirewallRule resources.
type ipFirewallRuleState struct {
	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress *string `pulumi:"endIpAddress"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Resource provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress *string `pulumi:"startIpAddress"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type IpFirewallRuleState struct {
	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Resource provisioning state
	ProvisioningState pulumi.StringPtrInput
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (IpFirewallRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipFirewallRuleState)(nil)).Elem()
}

type ipFirewallRuleArgs struct {
	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress *string `pulumi:"endIpAddress"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The IP firewall rule name
	RuleName string `pulumi:"ruleName"`
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress *string `pulumi:"startIpAddress"`
	// The name of the workspace
	WorkspaceName string `pulumi:"workspaceName"`
}

// The set of arguments for constructing a IpFirewallRule resource.
type IpFirewallRuleArgs struct {
	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The IP firewall rule name
	RuleName pulumi.StringInput
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress pulumi.StringPtrInput
	// The name of the workspace
	WorkspaceName pulumi.StringInput
}

func (IpFirewallRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipFirewallRuleArgs)(nil)).Elem()
}

type IpFirewallRuleInput interface {
	pulumi.Input

	ToIpFirewallRuleOutput() IpFirewallRuleOutput
	ToIpFirewallRuleOutputWithContext(ctx context.Context) IpFirewallRuleOutput
}

func (*IpFirewallRule) ElementType() reflect.Type {
	return reflect.TypeOf((*IpFirewallRule)(nil))
}

func (i *IpFirewallRule) ToIpFirewallRuleOutput() IpFirewallRuleOutput {
	return i.ToIpFirewallRuleOutputWithContext(context.Background())
}

func (i *IpFirewallRule) ToIpFirewallRuleOutputWithContext(ctx context.Context) IpFirewallRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpFirewallRuleOutput)
}

type IpFirewallRuleOutput struct {
	*pulumi.OutputState
}

func (IpFirewallRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IpFirewallRule)(nil))
}

func (o IpFirewallRuleOutput) ToIpFirewallRuleOutput() IpFirewallRuleOutput {
	return o
}

func (o IpFirewallRuleOutput) ToIpFirewallRuleOutputWithContext(ctx context.Context) IpFirewallRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IpFirewallRuleOutput{})
}
