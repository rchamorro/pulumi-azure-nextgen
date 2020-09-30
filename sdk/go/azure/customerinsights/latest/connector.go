// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The connector resource format.
type Connector struct {
	pulumi.CustomResourceState

	// ID of the connector.
	ConnectorId pulumi.IntOutput `pulumi:"connectorId"`
	// Name of the connector.
	ConnectorName pulumi.StringPtrOutput `pulumi:"connectorName"`
	// The connector properties.
	ConnectorProperties pulumi.MapOutput `pulumi:"connectorProperties"`
	// Type of connector.
	ConnectorType pulumi.StringOutput `pulumi:"connectorType"`
	// The created time.
	Created pulumi.StringOutput `pulumi:"created"`
	// Description of the connector.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Display name of the connector.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// If this is an internal connector.
	IsInternal pulumi.BoolPtrOutput `pulumi:"isInternal"`
	// The last modified time.
	LastModified pulumi.StringOutput `pulumi:"lastModified"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// State of connector.
	State pulumi.StringOutput `pulumi:"state"`
	// The hub name.
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewConnector registers a new resource with the given unique name, arguments, and options.
func NewConnector(ctx *pulumi.Context,
	name string, args *ConnectorArgs, opts ...pulumi.ResourceOption) (*Connector, error) {
	if args == nil || args.ConnectorName == nil {
		return nil, errors.New("missing required argument 'ConnectorName'")
	}
	if args == nil || args.ConnectorProperties == nil {
		return nil, errors.New("missing required argument 'ConnectorProperties'")
	}
	if args == nil || args.ConnectorType == nil {
		return nil, errors.New("missing required argument 'ConnectorType'")
	}
	if args == nil || args.HubName == nil {
		return nil, errors.New("missing required argument 'HubName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ConnectorArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:customerinsights/v20170101:Connector"),
		},
		{
			Type: pulumi.String("azure-nextgen:customerinsights/v20170426:Connector"),
		},
	})
	opts = append(opts, aliases)
	var resource Connector
	err := ctx.RegisterResource("azure-nextgen:customerinsights/latest:Connector", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnector gets an existing Connector resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnector(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectorState, opts ...pulumi.ResourceOption) (*Connector, error) {
	var resource Connector
	err := ctx.ReadResource("azure-nextgen:customerinsights/latest:Connector", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Connector resources.
type connectorState struct {
	// ID of the connector.
	ConnectorId *int `pulumi:"connectorId"`
	// Name of the connector.
	ConnectorName *string `pulumi:"connectorName"`
	// The connector properties.
	ConnectorProperties map[string]interface{} `pulumi:"connectorProperties"`
	// Type of connector.
	ConnectorType *string `pulumi:"connectorType"`
	// The created time.
	Created *string `pulumi:"created"`
	// Description of the connector.
	Description *string `pulumi:"description"`
	// Display name of the connector.
	DisplayName *string `pulumi:"displayName"`
	// If this is an internal connector.
	IsInternal *bool `pulumi:"isInternal"`
	// The last modified time.
	LastModified *string `pulumi:"lastModified"`
	// Resource name.
	Name *string `pulumi:"name"`
	// State of connector.
	State *string `pulumi:"state"`
	// The hub name.
	TenantId *string `pulumi:"tenantId"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ConnectorState struct {
	// ID of the connector.
	ConnectorId pulumi.IntPtrInput
	// Name of the connector.
	ConnectorName pulumi.StringPtrInput
	// The connector properties.
	ConnectorProperties pulumi.MapInput
	// Type of connector.
	ConnectorType pulumi.StringPtrInput
	// The created time.
	Created pulumi.StringPtrInput
	// Description of the connector.
	Description pulumi.StringPtrInput
	// Display name of the connector.
	DisplayName pulumi.StringPtrInput
	// If this is an internal connector.
	IsInternal pulumi.BoolPtrInput
	// The last modified time.
	LastModified pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// State of connector.
	State pulumi.StringPtrInput
	// The hub name.
	TenantId pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ConnectorState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectorState)(nil)).Elem()
}

type connectorArgs struct {
	// Name of the connector.
	ConnectorName string `pulumi:"connectorName"`
	// The connector properties.
	ConnectorProperties map[string]interface{} `pulumi:"connectorProperties"`
	// Type of connector.
	ConnectorType string `pulumi:"connectorType"`
	// Description of the connector.
	Description *string `pulumi:"description"`
	// Display name of the connector.
	DisplayName *string `pulumi:"displayName"`
	// The name of the hub.
	HubName string `pulumi:"hubName"`
	// If this is an internal connector.
	IsInternal *bool `pulumi:"isInternal"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a Connector resource.
type ConnectorArgs struct {
	// Name of the connector.
	ConnectorName pulumi.StringInput
	// The connector properties.
	ConnectorProperties pulumi.MapInput
	// Type of connector.
	ConnectorType pulumi.StringInput
	// Description of the connector.
	Description pulumi.StringPtrInput
	// Display name of the connector.
	DisplayName pulumi.StringPtrInput
	// The name of the hub.
	HubName pulumi.StringInput
	// If this is an internal connector.
	IsInternal pulumi.BoolPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
}

func (ConnectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectorArgs)(nil)).Elem()
}
