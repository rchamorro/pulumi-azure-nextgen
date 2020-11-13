// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Description of a Namespace AuthorizationRules.
type NamespaceAuthorizationRule struct {
	pulumi.CustomResourceState

	// A string that describes the claim type
	ClaimType pulumi.StringOutput `pulumi:"claimType"`
	// A string that describes the claim value
	ClaimValue pulumi.StringOutput `pulumi:"claimValue"`
	// The created time for this rule
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// A string that describes the authorization rule.
	KeyName pulumi.StringOutput `pulumi:"keyName"`
	// Resource location
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The last modified time for this rule
	ModifiedTime pulumi.StringOutput `pulumi:"modifiedTime"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey pulumi.StringOutput `pulumi:"primaryKey"`
	// The revision number for the rule
	Revision pulumi.IntOutput `pulumi:"revision"`
	// The rights associated with the rule.
	Rights pulumi.StringArrayOutput `pulumi:"rights"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey pulumi.StringOutput `pulumi:"secondaryKey"`
	// The sku of the created namespace
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewNamespaceAuthorizationRule registers a new resource with the given unique name, arguments, and options.
func NewNamespaceAuthorizationRule(ctx *pulumi.Context,
	name string, args *NamespaceAuthorizationRuleArgs, opts ...pulumi.ResourceOption) (*NamespaceAuthorizationRule, error) {
	if args == nil || args.AuthorizationRuleName == nil {
		return nil, errors.New("missing required argument 'AuthorizationRuleName'")
	}
	if args == nil || args.NamespaceName == nil {
		return nil, errors.New("missing required argument 'NamespaceName'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &NamespaceAuthorizationRuleArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:notificationhubs/latest:NamespaceAuthorizationRule"),
		},
		{
			Type: pulumi.String("azure-nextgen:notificationhubs/v20160301:NamespaceAuthorizationRule"),
		},
	})
	opts = append(opts, aliases)
	var resource NamespaceAuthorizationRule
	err := ctx.RegisterResource("azure-nextgen:notificationhubs/v20170401:NamespaceAuthorizationRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNamespaceAuthorizationRule gets an existing NamespaceAuthorizationRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNamespaceAuthorizationRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NamespaceAuthorizationRuleState, opts ...pulumi.ResourceOption) (*NamespaceAuthorizationRule, error) {
	var resource NamespaceAuthorizationRule
	err := ctx.ReadResource("azure-nextgen:notificationhubs/v20170401:NamespaceAuthorizationRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NamespaceAuthorizationRule resources.
type namespaceAuthorizationRuleState struct {
	// A string that describes the claim type
	ClaimType *string `pulumi:"claimType"`
	// A string that describes the claim value
	ClaimValue *string `pulumi:"claimValue"`
	// The created time for this rule
	CreatedTime *string `pulumi:"createdTime"`
	// A string that describes the authorization rule.
	KeyName *string `pulumi:"keyName"`
	// Resource location
	Location *string `pulumi:"location"`
	// The last modified time for this rule
	ModifiedTime *string `pulumi:"modifiedTime"`
	// Resource name
	Name *string `pulumi:"name"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey *string `pulumi:"primaryKey"`
	// The revision number for the rule
	Revision *int `pulumi:"revision"`
	// The rights associated with the rule.
	Rights []string `pulumi:"rights"`
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey *string `pulumi:"secondaryKey"`
	// The sku of the created namespace
	Sku *SkuResponse `pulumi:"sku"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type NamespaceAuthorizationRuleState struct {
	// A string that describes the claim type
	ClaimType pulumi.StringPtrInput
	// A string that describes the claim value
	ClaimValue pulumi.StringPtrInput
	// The created time for this rule
	CreatedTime pulumi.StringPtrInput
	// A string that describes the authorization rule.
	KeyName pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// The last modified time for this rule
	ModifiedTime pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	PrimaryKey pulumi.StringPtrInput
	// The revision number for the rule
	Revision pulumi.IntPtrInput
	// The rights associated with the rule.
	Rights pulumi.StringArrayInput
	// A base64-encoded 256-bit primary key for signing and validating the SAS token.
	SecondaryKey pulumi.StringPtrInput
	// The sku of the created namespace
	Sku SkuResponsePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (NamespaceAuthorizationRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*namespaceAuthorizationRuleState)(nil)).Elem()
}

type namespaceAuthorizationRuleArgs struct {
	// Authorization Rule Name.
	AuthorizationRuleName string `pulumi:"authorizationRuleName"`
	// The namespace name.
	NamespaceName string `pulumi:"namespaceName"`
	// Properties of the Namespace AuthorizationRules.
	Properties SharedAccessAuthorizationRuleProperties `pulumi:"properties"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a NamespaceAuthorizationRule resource.
type NamespaceAuthorizationRuleArgs struct {
	// Authorization Rule Name.
	AuthorizationRuleName pulumi.StringInput
	// The namespace name.
	NamespaceName pulumi.StringInput
	// Properties of the Namespace AuthorizationRules.
	Properties SharedAccessAuthorizationRulePropertiesInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (NamespaceAuthorizationRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*namespaceAuthorizationRuleArgs)(nil)).Elem()
}

type NamespaceAuthorizationRuleInput interface {
	pulumi.Input

	ToNamespaceAuthorizationRuleOutput() NamespaceAuthorizationRuleOutput
	ToNamespaceAuthorizationRuleOutputWithContext(ctx context.Context) NamespaceAuthorizationRuleOutput
}

func (NamespaceAuthorizationRule) ElementType() reflect.Type {
	return reflect.TypeOf((*NamespaceAuthorizationRule)(nil)).Elem()
}

func (i NamespaceAuthorizationRule) ToNamespaceAuthorizationRuleOutput() NamespaceAuthorizationRuleOutput {
	return i.ToNamespaceAuthorizationRuleOutputWithContext(context.Background())
}

func (i NamespaceAuthorizationRule) ToNamespaceAuthorizationRuleOutputWithContext(ctx context.Context) NamespaceAuthorizationRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NamespaceAuthorizationRuleOutput)
}

type NamespaceAuthorizationRuleOutput struct {
	*pulumi.OutputState
}

func (NamespaceAuthorizationRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NamespaceAuthorizationRuleOutput)(nil)).Elem()
}

func (o NamespaceAuthorizationRuleOutput) ToNamespaceAuthorizationRuleOutput() NamespaceAuthorizationRuleOutput {
	return o
}

func (o NamespaceAuthorizationRuleOutput) ToNamespaceAuthorizationRuleOutputWithContext(ctx context.Context) NamespaceAuthorizationRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NamespaceAuthorizationRuleOutput{})
}
