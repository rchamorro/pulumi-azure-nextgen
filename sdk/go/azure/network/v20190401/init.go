// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190401

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-nextgen/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-nextgen:network/v20190401:ApplicationGateway":
		r, err = NewApplicationGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ApplicationSecurityGroup":
		r, err = NewApplicationSecurityGroup(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:AzureFirewall":
		r, err = NewAzureFirewall(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:BastionHost":
		r, err = NewBastionHost(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ConnectionMonitor":
		r, err = NewConnectionMonitor(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:DdosCustomPolicy":
		r, err = NewDdosCustomPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:DdosProtectionPlan":
		r, err = NewDdosProtectionPlan(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteCircuit":
		r, err = NewExpressRouteCircuit(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteCircuitAuthorization":
		r, err = NewExpressRouteCircuitAuthorization(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteCircuitConnection":
		r, err = NewExpressRouteCircuitConnection(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteCircuitPeering":
		r, err = NewExpressRouteCircuitPeering(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteConnection":
		r, err = NewExpressRouteConnection(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteCrossConnectionPeering":
		r, err = NewExpressRouteCrossConnectionPeering(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRouteGateway":
		r, err = NewExpressRouteGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ExpressRoutePort":
		r, err = NewExpressRoutePort(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:FrontDoor":
		r, err = NewFrontDoor(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:InboundNatRule":
		r, err = NewInboundNatRule(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:LoadBalancer":
		r, err = NewLoadBalancer(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:LocalNetworkGateway":
		r, err = NewLocalNetworkGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NatGateway":
		r, err = NewNatGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NetworkInterface":
		r, err = NewNetworkInterface(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NetworkInterfaceTapConfiguration":
		r, err = NewNetworkInterfaceTapConfiguration(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NetworkProfile":
		r, err = NewNetworkProfile(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NetworkSecurityGroup":
		r, err = NewNetworkSecurityGroup(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:NetworkWatcher":
		r, err = NewNetworkWatcher(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:P2sVpnGateway":
		r, err = NewP2sVpnGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:P2sVpnServerConfiguration":
		r, err = NewP2sVpnServerConfiguration(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:PacketCapture":
		r, err = NewPacketCapture(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:PrivateEndpoint":
		r, err = NewPrivateEndpoint(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:PrivateLinkService":
		r, err = NewPrivateLinkService(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:PublicIPAddress":
		r, err = NewPublicIPAddress(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:PublicIPPrefix":
		r, err = NewPublicIPPrefix(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:Route":
		r, err = NewRoute(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:RouteFilter":
		r, err = NewRouteFilter(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:RouteFilterRule":
		r, err = NewRouteFilterRule(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:RouteTable":
		r, err = NewRouteTable(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:SecurityRule":
		r, err = NewSecurityRule(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ServiceEndpointPolicy":
		r, err = NewServiceEndpointPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:ServiceEndpointPolicyDefinition":
		r, err = NewServiceEndpointPolicyDefinition(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:Subnet":
		r, err = NewSubnet(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualHub":
		r, err = NewVirtualHub(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualNetwork":
		r, err = NewVirtualNetwork(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualNetworkGateway":
		r, err = NewVirtualNetworkGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualNetworkGatewayConnection":
		r, err = NewVirtualNetworkGatewayConnection(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualNetworkPeering":
		r, err = NewVirtualNetworkPeering(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualNetworkTap":
		r, err = NewVirtualNetworkTap(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VirtualWan":
		r, err = NewVirtualWan(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VpnConnection":
		r, err = NewVpnConnection(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VpnGateway":
		r, err = NewVpnGateway(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:VpnSite":
		r, err = NewVpnSite(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:network/v20190401:WebApplicationFirewallPolicy":
		r, err = NewWebApplicationFirewallPolicy(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"azure-nextgen",
		"network/v20190401",
		&module{version},
	)
}
