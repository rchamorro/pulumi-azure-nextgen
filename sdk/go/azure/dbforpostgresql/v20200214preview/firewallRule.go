// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200214preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a server firewall rule.
type FirewallRule struct {
	pulumi.CustomResourceState

	// The end IP address of the server firewall rule. Must be IPv4 format.
	EndIpAddress pulumi.StringOutput `pulumi:"endIpAddress"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The start IP address of the server firewall rule. Must be IPv4 format.
	StartIpAddress pulumi.StringOutput `pulumi:"startIpAddress"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewFirewallRule registers a new resource with the given unique name, arguments, and options.
func NewFirewallRule(ctx *pulumi.Context,
	name string, args *FirewallRuleArgs, opts ...pulumi.ResourceOption) (*FirewallRule, error) {
	if args == nil || args.EndIpAddress == nil {
		return nil, errors.New("missing required argument 'EndIpAddress'")
	}
	if args == nil || args.FirewallRuleName == nil {
		return nil, errors.New("missing required argument 'FirewallRuleName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil || args.StartIpAddress == nil {
		return nil, errors.New("missing required argument 'StartIpAddress'")
	}
	if args == nil {
		args = &FirewallRuleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:dbforpostgresql/v20200214privatepreview:FirewallRule"),
		},
	})
	opts = append(opts, aliases)
	var resource FirewallRule
	err := ctx.RegisterResource("azure-nextgen:dbforpostgresql/v20200214preview:FirewallRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFirewallRule gets an existing FirewallRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFirewallRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FirewallRuleState, opts ...pulumi.ResourceOption) (*FirewallRule, error) {
	var resource FirewallRule
	err := ctx.ReadResource("azure-nextgen:dbforpostgresql/v20200214preview:FirewallRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FirewallRule resources.
type firewallRuleState struct {
	// The end IP address of the server firewall rule. Must be IPv4 format.
	EndIpAddress *string `pulumi:"endIpAddress"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The start IP address of the server firewall rule. Must be IPv4 format.
	StartIpAddress *string `pulumi:"startIpAddress"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type FirewallRuleState struct {
	// The end IP address of the server firewall rule. Must be IPv4 format.
	EndIpAddress pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The start IP address of the server firewall rule. Must be IPv4 format.
	StartIpAddress pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (FirewallRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*firewallRuleState)(nil)).Elem()
}

type firewallRuleArgs struct {
	// The end IP address of the server firewall rule. Must be IPv4 format.
	EndIpAddress string `pulumi:"endIpAddress"`
	// The name of the server firewall rule.
	FirewallRuleName string `pulumi:"firewallRuleName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
	// The start IP address of the server firewall rule. Must be IPv4 format.
	StartIpAddress string `pulumi:"startIpAddress"`
}

// The set of arguments for constructing a FirewallRule resource.
type FirewallRuleArgs struct {
	// The end IP address of the server firewall rule. Must be IPv4 format.
	EndIpAddress pulumi.StringInput
	// The name of the server firewall rule.
	FirewallRuleName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
	// The start IP address of the server firewall rule. Must be IPv4 format.
	StartIpAddress pulumi.StringInput
}

func (FirewallRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*firewallRuleArgs)(nil)).Elem()
}

type FirewallRuleInput interface {
	pulumi.Input

	ToFirewallRuleOutput() FirewallRuleOutput
	ToFirewallRuleOutputWithContext(ctx context.Context) FirewallRuleOutput
}

func (FirewallRule) ElementType() reflect.Type {
	return reflect.TypeOf((*FirewallRule)(nil)).Elem()
}

func (i FirewallRule) ToFirewallRuleOutput() FirewallRuleOutput {
	return i.ToFirewallRuleOutputWithContext(context.Background())
}

func (i FirewallRule) ToFirewallRuleOutputWithContext(ctx context.Context) FirewallRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FirewallRuleOutput)
}

type FirewallRuleOutput struct {
	*pulumi.OutputState
}

func (FirewallRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*FirewallRuleOutput)(nil)).Elem()
}

func (o FirewallRuleOutput) ToFirewallRuleOutput() FirewallRuleOutput {
	return o
}

func (o FirewallRuleOutput) ToFirewallRuleOutputWithContext(ctx context.Context) FirewallRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(FirewallRuleOutput{})
}
