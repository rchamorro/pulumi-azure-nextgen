// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The link resource format.
type Link struct {
	pulumi.CustomResourceState

	// Localized descriptions for the Link.
	Description pulumi.StringMapOutput `pulumi:"description"`
	// Localized display name for the Link.
	DisplayName pulumi.StringMapOutput `pulumi:"displayName"`
	// The link name.
	LinkName pulumi.StringOutput `pulumi:"linkName"`
	// The set of properties mappings between the source and target Types.
	Mappings TypePropertiesMappingResponseArrayOutput `pulumi:"mappings"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
	OperationType pulumi.StringPtrOutput `pulumi:"operationType"`
	// The properties that represent the participating profile.
	ParticipantPropertyReferences ParticipantPropertyReferenceResponseArrayOutput `pulumi:"participantPropertyReferences"`
	// Provisioning state.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
	ReferenceOnly pulumi.BoolPtrOutput `pulumi:"referenceOnly"`
	// Name of the source Interaction Type.
	SourceInteractionType pulumi.StringOutput `pulumi:"sourceInteractionType"`
	// Name of the target Profile Type.
	TargetProfileType pulumi.StringOutput `pulumi:"targetProfileType"`
	// The hub name.
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewLink registers a new resource with the given unique name, arguments, and options.
func NewLink(ctx *pulumi.Context,
	name string, args *LinkArgs, opts ...pulumi.ResourceOption) (*Link, error) {
	if args == nil || args.HubName == nil {
		return nil, errors.New("missing required argument 'HubName'")
	}
	if args == nil || args.LinkName == nil {
		return nil, errors.New("missing required argument 'LinkName'")
	}
	if args == nil || args.ParticipantPropertyReferences == nil {
		return nil, errors.New("missing required argument 'ParticipantPropertyReferences'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SourceInteractionType == nil {
		return nil, errors.New("missing required argument 'SourceInteractionType'")
	}
	if args == nil || args.TargetProfileType == nil {
		return nil, errors.New("missing required argument 'TargetProfileType'")
	}
	if args == nil {
		args = &LinkArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:customerinsights/latest:Link"),
		},
		{
			Type: pulumi.String("azure-nextgen:customerinsights/v20170426:Link"),
		},
	})
	opts = append(opts, aliases)
	var resource Link
	err := ctx.RegisterResource("azure-nextgen:customerinsights/v20170101:Link", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLink gets an existing Link resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLink(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LinkState, opts ...pulumi.ResourceOption) (*Link, error) {
	var resource Link
	err := ctx.ReadResource("azure-nextgen:customerinsights/v20170101:Link", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Link resources.
type linkState struct {
	// Localized descriptions for the Link.
	Description map[string]string `pulumi:"description"`
	// Localized display name for the Link.
	DisplayName map[string]string `pulumi:"displayName"`
	// The link name.
	LinkName *string `pulumi:"linkName"`
	// The set of properties mappings between the source and target Types.
	Mappings []TypePropertiesMappingResponse `pulumi:"mappings"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
	OperationType *string `pulumi:"operationType"`
	// The properties that represent the participating profile.
	ParticipantPropertyReferences []ParticipantPropertyReferenceResponse `pulumi:"participantPropertyReferences"`
	// Provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
	ReferenceOnly *bool `pulumi:"referenceOnly"`
	// Name of the source Interaction Type.
	SourceInteractionType *string `pulumi:"sourceInteractionType"`
	// Name of the target Profile Type.
	TargetProfileType *string `pulumi:"targetProfileType"`
	// The hub name.
	TenantId *string `pulumi:"tenantId"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type LinkState struct {
	// Localized descriptions for the Link.
	Description pulumi.StringMapInput
	// Localized display name for the Link.
	DisplayName pulumi.StringMapInput
	// The link name.
	LinkName pulumi.StringPtrInput
	// The set of properties mappings between the source and target Types.
	Mappings TypePropertiesMappingResponseArrayInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
	OperationType pulumi.StringPtrInput
	// The properties that represent the participating profile.
	ParticipantPropertyReferences ParticipantPropertyReferenceResponseArrayInput
	// Provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
	ReferenceOnly pulumi.BoolPtrInput
	// Name of the source Interaction Type.
	SourceInteractionType pulumi.StringPtrInput
	// Name of the target Profile Type.
	TargetProfileType pulumi.StringPtrInput
	// The hub name.
	TenantId pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (LinkState) ElementType() reflect.Type {
	return reflect.TypeOf((*linkState)(nil)).Elem()
}

type linkArgs struct {
	// Localized descriptions for the Link.
	Description map[string]string `pulumi:"description"`
	// Localized display name for the Link.
	DisplayName map[string]string `pulumi:"displayName"`
	// The name of the hub.
	HubName string `pulumi:"hubName"`
	// The name of the link.
	LinkName string `pulumi:"linkName"`
	// The set of properties mappings between the source and target Types.
	Mappings []TypePropertiesMapping `pulumi:"mappings"`
	// Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
	OperationType *string `pulumi:"operationType"`
	// The properties that represent the participating profile.
	ParticipantPropertyReferences []ParticipantPropertyReference `pulumi:"participantPropertyReferences"`
	// Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
	ReferenceOnly *bool `pulumi:"referenceOnly"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the source Interaction Type.
	SourceInteractionType string `pulumi:"sourceInteractionType"`
	// Name of the target Profile Type.
	TargetProfileType string `pulumi:"targetProfileType"`
}

// The set of arguments for constructing a Link resource.
type LinkArgs struct {
	// Localized descriptions for the Link.
	Description pulumi.StringMapInput
	// Localized display name for the Link.
	DisplayName pulumi.StringMapInput
	// The name of the hub.
	HubName pulumi.StringInput
	// The name of the link.
	LinkName pulumi.StringInput
	// The set of properties mappings between the source and target Types.
	Mappings TypePropertiesMappingArrayInput
	// Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
	OperationType pulumi.StringPtrInput
	// The properties that represent the participating profile.
	ParticipantPropertyReferences ParticipantPropertyReferenceArrayInput
	// Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
	ReferenceOnly pulumi.BoolPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Name of the source Interaction Type.
	SourceInteractionType pulumi.StringInput
	// Name of the target Profile Type.
	TargetProfileType pulumi.StringInput
}

func (LinkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*linkArgs)(nil)).Elem()
}

type LinkInput interface {
	pulumi.Input

	ToLinkOutput() LinkOutput
	ToLinkOutputWithContext(ctx context.Context) LinkOutput
}

func (Link) ElementType() reflect.Type {
	return reflect.TypeOf((*Link)(nil)).Elem()
}

func (i Link) ToLinkOutput() LinkOutput {
	return i.ToLinkOutputWithContext(context.Background())
}

func (i Link) ToLinkOutputWithContext(ctx context.Context) LinkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LinkOutput)
}

type LinkOutput struct {
	*pulumi.OutputState
}

func (LinkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LinkOutput)(nil)).Elem()
}

func (o LinkOutput) ToLinkOutput() LinkOutput {
	return o
}

func (o LinkOutput) ToLinkOutputWithContext(ctx context.Context) LinkOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LinkOutput{})
}
