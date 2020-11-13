// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Server communication link.
type ServerCommunicationLink struct {
	pulumi.CustomResourceState

	// Communication link kind.  This property is used for Azure Portal metadata.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Communication link location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the partner server.
	PartnerServer pulumi.StringOutput `pulumi:"partnerServer"`
	// The state.
	State pulumi.StringOutput `pulumi:"state"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewServerCommunicationLink registers a new resource with the given unique name, arguments, and options.
func NewServerCommunicationLink(ctx *pulumi.Context,
	name string, args *ServerCommunicationLinkArgs, opts ...pulumi.ResourceOption) (*ServerCommunicationLink, error) {
	if args == nil || args.CommunicationLinkName == nil {
		return nil, errors.New("missing required argument 'CommunicationLinkName'")
	}
	if args == nil || args.PartnerServer == nil {
		return nil, errors.New("missing required argument 'PartnerServer'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil {
		args = &ServerCommunicationLinkArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:sql/v20140401:ServerCommunicationLink"),
		},
	})
	opts = append(opts, aliases)
	var resource ServerCommunicationLink
	err := ctx.RegisterResource("azure-nextgen:sql/latest:ServerCommunicationLink", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerCommunicationLink gets an existing ServerCommunicationLink resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerCommunicationLink(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerCommunicationLinkState, opts ...pulumi.ResourceOption) (*ServerCommunicationLink, error) {
	var resource ServerCommunicationLink
	err := ctx.ReadResource("azure-nextgen:sql/latest:ServerCommunicationLink", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerCommunicationLink resources.
type serverCommunicationLinkState struct {
	// Communication link kind.  This property is used for Azure Portal metadata.
	Kind *string `pulumi:"kind"`
	// Communication link location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The name of the partner server.
	PartnerServer *string `pulumi:"partnerServer"`
	// The state.
	State *string `pulumi:"state"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ServerCommunicationLinkState struct {
	// Communication link kind.  This property is used for Azure Portal metadata.
	Kind pulumi.StringPtrInput
	// Communication link location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The name of the partner server.
	PartnerServer pulumi.StringPtrInput
	// The state.
	State pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ServerCommunicationLinkState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverCommunicationLinkState)(nil)).Elem()
}

type serverCommunicationLinkArgs struct {
	// The name of the server communication link.
	CommunicationLinkName string `pulumi:"communicationLinkName"`
	// The name of the partner server.
	PartnerServer string `pulumi:"partnerServer"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
}

// The set of arguments for constructing a ServerCommunicationLink resource.
type ServerCommunicationLinkArgs struct {
	// The name of the server communication link.
	CommunicationLinkName pulumi.StringInput
	// The name of the partner server.
	PartnerServer pulumi.StringInput
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
}

func (ServerCommunicationLinkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverCommunicationLinkArgs)(nil)).Elem()
}

type ServerCommunicationLinkInput interface {
	pulumi.Input

	ToServerCommunicationLinkOutput() ServerCommunicationLinkOutput
	ToServerCommunicationLinkOutputWithContext(ctx context.Context) ServerCommunicationLinkOutput
}

func (ServerCommunicationLink) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerCommunicationLink)(nil)).Elem()
}

func (i ServerCommunicationLink) ToServerCommunicationLinkOutput() ServerCommunicationLinkOutput {
	return i.ToServerCommunicationLinkOutputWithContext(context.Background())
}

func (i ServerCommunicationLink) ToServerCommunicationLinkOutputWithContext(ctx context.Context) ServerCommunicationLinkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerCommunicationLinkOutput)
}

type ServerCommunicationLinkOutput struct {
	*pulumi.OutputState
}

func (ServerCommunicationLinkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerCommunicationLinkOutput)(nil)).Elem()
}

func (o ServerCommunicationLinkOutput) ToServerCommunicationLinkOutput() ServerCommunicationLinkOutput {
	return o
}

func (o ServerCommunicationLinkOutput) ToServerCommunicationLinkOutputWithContext(ctx context.Context) ServerCommunicationLinkOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServerCommunicationLinkOutput{})
}
