// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150615

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// ExpressRouteCircuit resource
type ExpressRouteCircuit struct {
	pulumi.CustomResourceState

	// The list of authorizations.
	Authorizations ExpressRouteCircuitAuthorizationResponseArrayOutput `pulumi:"authorizations"`
	// The CircuitProvisioningState state of the resource.
	CircuitProvisioningState pulumi.StringPtrOutput `pulumi:"circuitProvisioningState"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The list of peerings.
	Peerings ExpressRouteCircuitPeeringResponseArrayOutput `pulumi:"peerings"`
	// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// The ServiceKey.
	ServiceKey pulumi.StringPtrOutput `pulumi:"serviceKey"`
	// The ServiceProviderNotes.
	ServiceProviderNotes pulumi.StringPtrOutput `pulumi:"serviceProviderNotes"`
	// The ServiceProviderProperties.
	ServiceProviderProperties ExpressRouteCircuitServiceProviderPropertiesResponsePtrOutput `pulumi:"serviceProviderProperties"`
	// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
	ServiceProviderProvisioningState pulumi.StringPtrOutput `pulumi:"serviceProviderProvisioningState"`
	// The SKU.
	Sku ExpressRouteCircuitSkuResponsePtrOutput `pulumi:"sku"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewExpressRouteCircuit registers a new resource with the given unique name, arguments, and options.
func NewExpressRouteCircuit(ctx *pulumi.Context,
	name string, args *ExpressRouteCircuitArgs, opts ...pulumi.ResourceOption) (*ExpressRouteCircuit, error) {
	if args == nil || args.CircuitName == nil {
		return nil, errors.New("missing required argument 'CircuitName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ExpressRouteCircuitArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:ExpressRouteCircuit"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:ExpressRouteCircuit"),
		},
	})
	opts = append(opts, aliases)
	var resource ExpressRouteCircuit
	err := ctx.RegisterResource("azure-nextgen:network/v20150615:ExpressRouteCircuit", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExpressRouteCircuit gets an existing ExpressRouteCircuit resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExpressRouteCircuit(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExpressRouteCircuitState, opts ...pulumi.ResourceOption) (*ExpressRouteCircuit, error) {
	var resource ExpressRouteCircuit
	err := ctx.ReadResource("azure-nextgen:network/v20150615:ExpressRouteCircuit", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ExpressRouteCircuit resources.
type expressRouteCircuitState struct {
	// The list of authorizations.
	Authorizations []ExpressRouteCircuitAuthorizationResponse `pulumi:"authorizations"`
	// The CircuitProvisioningState state of the resource.
	CircuitProvisioningState *string `pulumi:"circuitProvisioningState"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The list of peerings.
	Peerings []ExpressRouteCircuitPeeringResponse `pulumi:"peerings"`
	// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The ServiceKey.
	ServiceKey *string `pulumi:"serviceKey"`
	// The ServiceProviderNotes.
	ServiceProviderNotes *string `pulumi:"serviceProviderNotes"`
	// The ServiceProviderProperties.
	ServiceProviderProperties *ExpressRouteCircuitServiceProviderPropertiesResponse `pulumi:"serviceProviderProperties"`
	// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
	ServiceProviderProvisioningState *string `pulumi:"serviceProviderProvisioningState"`
	// The SKU.
	Sku *ExpressRouteCircuitSkuResponse `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ExpressRouteCircuitState struct {
	// The list of authorizations.
	Authorizations ExpressRouteCircuitAuthorizationResponseArrayInput
	// The CircuitProvisioningState state of the resource.
	CircuitProvisioningState pulumi.StringPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The list of peerings.
	Peerings ExpressRouteCircuitPeeringResponseArrayInput
	// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The ServiceKey.
	ServiceKey pulumi.StringPtrInput
	// The ServiceProviderNotes.
	ServiceProviderNotes pulumi.StringPtrInput
	// The ServiceProviderProperties.
	ServiceProviderProperties ExpressRouteCircuitServiceProviderPropertiesResponsePtrInput
	// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
	ServiceProviderProvisioningState pulumi.StringPtrInput
	// The SKU.
	Sku ExpressRouteCircuitSkuResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ExpressRouteCircuitState) ElementType() reflect.Type {
	return reflect.TypeOf((*expressRouteCircuitState)(nil)).Elem()
}

type expressRouteCircuitArgs struct {
	// The list of authorizations.
	Authorizations []ExpressRouteCircuitAuthorizationType `pulumi:"authorizations"`
	// The name of the circuit.
	CircuitName string `pulumi:"circuitName"`
	// The CircuitProvisioningState state of the resource.
	CircuitProvisioningState *string `pulumi:"circuitProvisioningState"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource Identifier.
	Id *string `pulumi:"id"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The list of peerings.
	Peerings []ExpressRouteCircuitPeeringType `pulumi:"peerings"`
	// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The ServiceKey.
	ServiceKey *string `pulumi:"serviceKey"`
	// The ServiceProviderNotes.
	ServiceProviderNotes *string `pulumi:"serviceProviderNotes"`
	// The ServiceProviderProperties.
	ServiceProviderProperties *ExpressRouteCircuitServiceProviderProperties `pulumi:"serviceProviderProperties"`
	// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
	ServiceProviderProvisioningState *string `pulumi:"serviceProviderProvisioningState"`
	// The SKU.
	Sku *ExpressRouteCircuitSku `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ExpressRouteCircuit resource.
type ExpressRouteCircuitArgs struct {
	// The list of authorizations.
	Authorizations ExpressRouteCircuitAuthorizationTypeArrayInput
	// The name of the circuit.
	CircuitName pulumi.StringInput
	// The CircuitProvisioningState state of the resource.
	CircuitProvisioningState pulumi.StringPtrInput
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource Identifier.
	Id pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The list of peerings.
	Peerings ExpressRouteCircuitPeeringTypeArrayInput
	// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The ServiceKey.
	ServiceKey pulumi.StringPtrInput
	// The ServiceProviderNotes.
	ServiceProviderNotes pulumi.StringPtrInput
	// The ServiceProviderProperties.
	ServiceProviderProperties ExpressRouteCircuitServiceProviderPropertiesPtrInput
	// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
	ServiceProviderProvisioningState pulumi.StringPtrInput
	// The SKU.
	Sku ExpressRouteCircuitSkuPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ExpressRouteCircuitArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*expressRouteCircuitArgs)(nil)).Elem()
}
