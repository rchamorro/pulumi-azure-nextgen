// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190401

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Private link service resource.
type PrivateLinkService struct {
	pulumi.CustomResourceState

	// The alias of the private link service.
	Alias pulumi.StringOutput `pulumi:"alias"`
	// The auto-approval list of the private link service.
	AutoApproval PrivateLinkServicePropertiesResponseAutoApprovalPtrOutput `pulumi:"autoApproval"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// The list of Fqdn.
	Fqdns pulumi.StringArrayOutput `pulumi:"fqdns"`
	// An array of references to the private link service IP configuration.
	IpConfigurations PrivateLinkServiceIpConfigurationResponseArrayOutput `pulumi:"ipConfigurations"`
	// An array of references to the load balancer IP configurations.
	LoadBalancerFrontendIpConfigurations FrontendIPConfigurationResponseArrayOutput `pulumi:"loadBalancerFrontendIpConfigurations"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets an array of references to the network interfaces created for this private link service.
	NetworkInterfaces NetworkInterfaceResponseArrayOutput `pulumi:"networkInterfaces"`
	// An array of list about connections to the private endpoint.
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayOutput `pulumi:"privateEndpointConnections"`
	// The provisioning state of the private link service.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The visibility list of the private link service.
	Visibility PrivateLinkServicePropertiesResponseVisibilityPtrOutput `pulumi:"visibility"`
}

// NewPrivateLinkService registers a new resource with the given unique name, arguments, and options.
func NewPrivateLinkService(ctx *pulumi.Context,
	name string, args *PrivateLinkServiceArgs, opts ...pulumi.ResourceOption) (*PrivateLinkService, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil {
		args = &PrivateLinkServiceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190801:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:PrivateLinkService"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200701:PrivateLinkService"),
		},
	})
	opts = append(opts, aliases)
	var resource PrivateLinkService
	err := ctx.RegisterResource("azure-nextgen:network/v20190401:PrivateLinkService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPrivateLinkService gets an existing PrivateLinkService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPrivateLinkService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PrivateLinkServiceState, opts ...pulumi.ResourceOption) (*PrivateLinkService, error) {
	var resource PrivateLinkService
	err := ctx.ReadResource("azure-nextgen:network/v20190401:PrivateLinkService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PrivateLinkService resources.
type privateLinkServiceState struct {
	// The alias of the private link service.
	Alias *string `pulumi:"alias"`
	// The auto-approval list of the private link service.
	AutoApproval *PrivateLinkServicePropertiesResponseAutoApproval `pulumi:"autoApproval"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The list of Fqdn.
	Fqdns []string `pulumi:"fqdns"`
	// An array of references to the private link service IP configuration.
	IpConfigurations []PrivateLinkServiceIpConfigurationResponse `pulumi:"ipConfigurations"`
	// An array of references to the load balancer IP configurations.
	LoadBalancerFrontendIpConfigurations []FrontendIPConfigurationResponse `pulumi:"loadBalancerFrontendIpConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Gets an array of references to the network interfaces created for this private link service.
	NetworkInterfaces []NetworkInterfaceResponse `pulumi:"networkInterfaces"`
	// An array of list about connections to the private endpoint.
	PrivateEndpointConnections []PrivateEndpointConnectionResponse `pulumi:"privateEndpointConnections"`
	// The provisioning state of the private link service.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The visibility list of the private link service.
	Visibility *PrivateLinkServicePropertiesResponseVisibility `pulumi:"visibility"`
}

type PrivateLinkServiceState struct {
	// The alias of the private link service.
	Alias pulumi.StringPtrInput
	// The auto-approval list of the private link service.
	AutoApproval PrivateLinkServicePropertiesResponseAutoApprovalPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The list of Fqdn.
	Fqdns pulumi.StringArrayInput
	// An array of references to the private link service IP configuration.
	IpConfigurations PrivateLinkServiceIpConfigurationResponseArrayInput
	// An array of references to the load balancer IP configurations.
	LoadBalancerFrontendIpConfigurations FrontendIPConfigurationResponseArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Gets an array of references to the network interfaces created for this private link service.
	NetworkInterfaces NetworkInterfaceResponseArrayInput
	// An array of list about connections to the private endpoint.
	PrivateEndpointConnections PrivateEndpointConnectionResponseArrayInput
	// The provisioning state of the private link service.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The visibility list of the private link service.
	Visibility PrivateLinkServicePropertiesResponseVisibilityPtrInput
}

func (PrivateLinkServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*privateLinkServiceState)(nil)).Elem()
}

type privateLinkServiceArgs struct {
	// The auto-approval list of the private link service.
	AutoApproval *PrivateLinkServicePropertiesAutoApproval `pulumi:"autoApproval"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// The list of Fqdn.
	Fqdns []string `pulumi:"fqdns"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// An array of references to the private link service IP configuration.
	IpConfigurations []PrivateLinkServiceIpConfiguration `pulumi:"ipConfigurations"`
	// An array of references to the load balancer IP configurations.
	LoadBalancerFrontendIpConfigurations []FrontendIPConfiguration `pulumi:"loadBalancerFrontendIpConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// An array of list about connections to the private endpoint.
	PrivateEndpointConnections []PrivateEndpointConnection `pulumi:"privateEndpointConnections"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the private link service.
	ServiceName string `pulumi:"serviceName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The visibility list of the private link service.
	Visibility *PrivateLinkServicePropertiesVisibility `pulumi:"visibility"`
}

// The set of arguments for constructing a PrivateLinkService resource.
type PrivateLinkServiceArgs struct {
	// The auto-approval list of the private link service.
	AutoApproval PrivateLinkServicePropertiesAutoApprovalPtrInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// The list of Fqdn.
	Fqdns pulumi.StringArrayInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// An array of references to the private link service IP configuration.
	IpConfigurations PrivateLinkServiceIpConfigurationArrayInput
	// An array of references to the load balancer IP configurations.
	LoadBalancerFrontendIpConfigurations FrontendIPConfigurationArrayInput
	// Resource location.
	Location pulumi.StringPtrInput
	// An array of list about connections to the private endpoint.
	PrivateEndpointConnections PrivateEndpointConnectionArrayInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the private link service.
	ServiceName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The visibility list of the private link service.
	Visibility PrivateLinkServicePropertiesVisibilityPtrInput
}

func (PrivateLinkServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*privateLinkServiceArgs)(nil)).Elem()
}
