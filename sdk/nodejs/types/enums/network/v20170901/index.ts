// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const Access = {
    Allow: "Allow",
    Deny: "Deny",
} as const;

/**
 * The access type of the rule. Valid values are: 'Allow', 'Deny'
 */
export type Access = (typeof Access)[keyof typeof Access];

export const ApplicationGatewayCookieBasedAffinity = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Cookie based affinity.
 */
export type ApplicationGatewayCookieBasedAffinity = (typeof ApplicationGatewayCookieBasedAffinity)[keyof typeof ApplicationGatewayCookieBasedAffinity];

export const ApplicationGatewayFirewallMode = {
    Detection: "Detection",
    Prevention: "Prevention",
} as const;

/**
 * Web application firewall mode.
 */
export type ApplicationGatewayFirewallMode = (typeof ApplicationGatewayFirewallMode)[keyof typeof ApplicationGatewayFirewallMode];

export const ApplicationGatewayProtocol = {
    Http: "Http",
    Https: "Https",
} as const;

/**
 * Protocol.
 */
export type ApplicationGatewayProtocol = (typeof ApplicationGatewayProtocol)[keyof typeof ApplicationGatewayProtocol];

export const ApplicationGatewayRedirectType = {
    Permanent: "Permanent",
    Found: "Found",
    SeeOther: "SeeOther",
    Temporary: "Temporary",
} as const;

/**
 * Supported http redirection types - Permanent, Temporary, Found, SeeOther.
 */
export type ApplicationGatewayRedirectType = (typeof ApplicationGatewayRedirectType)[keyof typeof ApplicationGatewayRedirectType];

export const ApplicationGatewayRequestRoutingRuleType = {
    Basic: "Basic",
    PathBasedRouting: "PathBasedRouting",
} as const;

/**
 * Rule type.
 */
export type ApplicationGatewayRequestRoutingRuleType = (typeof ApplicationGatewayRequestRoutingRuleType)[keyof typeof ApplicationGatewayRequestRoutingRuleType];

export const ApplicationGatewaySkuName = {
    Standard_Small: "Standard_Small",
    Standard_Medium: "Standard_Medium",
    Standard_Large: "Standard_Large",
    WAF_Medium: "WAF_Medium",
    WAF_Large: "WAF_Large",
} as const;

/**
 * Name of an application gateway SKU.
 */
export type ApplicationGatewaySkuName = (typeof ApplicationGatewaySkuName)[keyof typeof ApplicationGatewaySkuName];

export const ApplicationGatewaySslCipherSuite = {
    TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384: "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384",
    TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256: "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256",
    TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA: "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA",
    TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA: "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA",
    TLS_DHE_RSA_WITH_AES_256_GCM_SHA384: "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384",
    TLS_DHE_RSA_WITH_AES_128_GCM_SHA256: "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256",
    TLS_DHE_RSA_WITH_AES_256_CBC_SHA: "TLS_DHE_RSA_WITH_AES_256_CBC_SHA",
    TLS_DHE_RSA_WITH_AES_128_CBC_SHA: "TLS_DHE_RSA_WITH_AES_128_CBC_SHA",
    TLS_RSA_WITH_AES_256_GCM_SHA384: "TLS_RSA_WITH_AES_256_GCM_SHA384",
    TLS_RSA_WITH_AES_128_GCM_SHA256: "TLS_RSA_WITH_AES_128_GCM_SHA256",
    TLS_RSA_WITH_AES_256_CBC_SHA256: "TLS_RSA_WITH_AES_256_CBC_SHA256",
    TLS_RSA_WITH_AES_128_CBC_SHA256: "TLS_RSA_WITH_AES_128_CBC_SHA256",
    TLS_RSA_WITH_AES_256_CBC_SHA: "TLS_RSA_WITH_AES_256_CBC_SHA",
    TLS_RSA_WITH_AES_128_CBC_SHA: "TLS_RSA_WITH_AES_128_CBC_SHA",
    TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384: "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384",
    TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256: "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256",
    TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384: "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384",
    TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256: "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256",
    TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA: "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA",
    TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA: "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA",
    TLS_DHE_DSS_WITH_AES_256_CBC_SHA256: "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256",
    TLS_DHE_DSS_WITH_AES_128_CBC_SHA256: "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256",
    TLS_DHE_DSS_WITH_AES_256_CBC_SHA: "TLS_DHE_DSS_WITH_AES_256_CBC_SHA",
    TLS_DHE_DSS_WITH_AES_128_CBC_SHA: "TLS_DHE_DSS_WITH_AES_128_CBC_SHA",
    TLS_RSA_WITH_3DES_EDE_CBC_SHA: "TLS_RSA_WITH_3DES_EDE_CBC_SHA",
    TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA: "TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA",
    TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256: "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256",
    TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384: "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384",
} as const;

/**
 * Ssl cipher suites enums.
 */
export type ApplicationGatewaySslCipherSuite = (typeof ApplicationGatewaySslCipherSuite)[keyof typeof ApplicationGatewaySslCipherSuite];

export const ApplicationGatewaySslPolicyName = {
    AppGwSslPolicy20150501: "AppGwSslPolicy20150501",
    AppGwSslPolicy20170401: "AppGwSslPolicy20170401",
    AppGwSslPolicy20170401S: "AppGwSslPolicy20170401S",
} as const;

/**
 * Name of Ssl predefined policy
 */
export type ApplicationGatewaySslPolicyName = (typeof ApplicationGatewaySslPolicyName)[keyof typeof ApplicationGatewaySslPolicyName];

export const ApplicationGatewaySslPolicyType = {
    Predefined: "Predefined",
    Custom: "Custom",
} as const;

/**
 * Type of Ssl Policy
 */
export type ApplicationGatewaySslPolicyType = (typeof ApplicationGatewaySslPolicyType)[keyof typeof ApplicationGatewaySslPolicyType];

export const ApplicationGatewaySslProtocol = {
    TLSv1_0: "TLSv1_0",
    TLSv1_1: "TLSv1_1",
    TLSv1_2: "TLSv1_2",
} as const;

/**
 * Minimum version of Ssl protocol to be supported on application gateway.
 */
export type ApplicationGatewaySslProtocol = (typeof ApplicationGatewaySslProtocol)[keyof typeof ApplicationGatewaySslProtocol];

export const ApplicationGatewayTier = {
    Standard: "Standard",
    WAF: "WAF",
} as const;

/**
 * Tier of an application gateway.
 */
export type ApplicationGatewayTier = (typeof ApplicationGatewayTier)[keyof typeof ApplicationGatewayTier];

export const AuthorizationUseStatus = {
    Available: "Available",
    InUse: "InUse",
} as const;

/**
 * AuthorizationUseStatus. Possible values are: 'Available' and 'InUse'.
 */
export type AuthorizationUseStatus = (typeof AuthorizationUseStatus)[keyof typeof AuthorizationUseStatus];

export const DhGroup = {
    None: "None",
    DHGroup1: "DHGroup1",
    DHGroup2: "DHGroup2",
    DHGroup14: "DHGroup14",
    DHGroup2048: "DHGroup2048",
    ECP256: "ECP256",
    ECP384: "ECP384",
    DHGroup24: "DHGroup24",
} as const;

/**
 * The DH Groups used in IKE Phase 1 for initial SA.
 */
export type DhGroup = (typeof DhGroup)[keyof typeof DhGroup];

export const ExpressRouteCircuitPeeringAdvertisedPublicPrefixState = {
    NotConfigured: "NotConfigured",
    Configuring: "Configuring",
    Configured: "Configured",
    ValidationNeeded: "ValidationNeeded",
} as const;

/**
 * AdvertisedPublicPrefixState of the Peering resource. Possible values are 'NotConfigured', 'Configuring', 'Configured', and 'ValidationNeeded'.
 */
export type ExpressRouteCircuitPeeringAdvertisedPublicPrefixState = (typeof ExpressRouteCircuitPeeringAdvertisedPublicPrefixState)[keyof typeof ExpressRouteCircuitPeeringAdvertisedPublicPrefixState];

export const ExpressRouteCircuitPeeringState = {
    Disabled: "Disabled",
    Enabled: "Enabled",
} as const;

/**
 * The state of peering. Possible values are: 'Disabled' and 'Enabled'
 */
export type ExpressRouteCircuitPeeringState = (typeof ExpressRouteCircuitPeeringState)[keyof typeof ExpressRouteCircuitPeeringState];

export const ExpressRouteCircuitPeeringType = {
    AzurePublicPeering: "AzurePublicPeering",
    AzurePrivatePeering: "AzurePrivatePeering",
    MicrosoftPeering: "MicrosoftPeering",
} as const;

/**
 * The PeeringType. Possible values are: 'AzurePublicPeering', 'AzurePrivatePeering', and 'MicrosoftPeering'.
 */
export type ExpressRouteCircuitPeeringType = (typeof ExpressRouteCircuitPeeringType)[keyof typeof ExpressRouteCircuitPeeringType];

export const ExpressRouteCircuitSkuFamily = {
    UnlimitedData: "UnlimitedData",
    MeteredData: "MeteredData",
} as const;

/**
 * The family of the SKU. Possible values are: 'UnlimitedData' and 'MeteredData'.
 */
export type ExpressRouteCircuitSkuFamily = (typeof ExpressRouteCircuitSkuFamily)[keyof typeof ExpressRouteCircuitSkuFamily];

export const ExpressRouteCircuitSkuTier = {
    Standard: "Standard",
    Premium: "Premium",
} as const;

/**
 * The tier of the SKU. Possible values are 'Standard' and 'Premium'.
 */
export type ExpressRouteCircuitSkuTier = (typeof ExpressRouteCircuitSkuTier)[keyof typeof ExpressRouteCircuitSkuTier];

export const IPAllocationMethod = {
    Static: "Static",
    Dynamic: "Dynamic",
} as const;

/**
 * The private IP allocation method. Possible values are: 'Static' and 'Dynamic'.
 */
export type IPAllocationMethod = (typeof IPAllocationMethod)[keyof typeof IPAllocationMethod];

export const IPVersion = {
    IPv4: "IPv4",
    IPv6: "IPv6",
} as const;

/**
 * The public IP address version. Possible values are: 'IPv4' and 'IPv6'.
 */
export type IPVersion = (typeof IPVersion)[keyof typeof IPVersion];

export const IkeEncryption = {
    DES: "DES",
    DES3: "DES3",
    AES128: "AES128",
    AES192: "AES192",
    AES256: "AES256",
} as const;

/**
 * The IKE encryption algorithm (IKE phase 2).
 */
export type IkeEncryption = (typeof IkeEncryption)[keyof typeof IkeEncryption];

export const IkeIntegrity = {
    MD5: "MD5",
    SHA1: "SHA1",
    SHA256: "SHA256",
    SHA384: "SHA384",
} as const;

/**
 * The IKE integrity algorithm (IKE phase 2).
 */
export type IkeIntegrity = (typeof IkeIntegrity)[keyof typeof IkeIntegrity];

export const IpsecEncryption = {
    None: "None",
    DES: "DES",
    DES3: "DES3",
    AES128: "AES128",
    AES192: "AES192",
    AES256: "AES256",
    GCMAES128: "GCMAES128",
    GCMAES192: "GCMAES192",
    GCMAES256: "GCMAES256",
} as const;

/**
 * The IPSec encryption algorithm (IKE phase 1).
 */
export type IpsecEncryption = (typeof IpsecEncryption)[keyof typeof IpsecEncryption];

export const IpsecIntegrity = {
    MD5: "MD5",
    SHA1: "SHA1",
    SHA256: "SHA256",
    GCMAES128: "GCMAES128",
    GCMAES192: "GCMAES192",
    GCMAES256: "GCMAES256",
} as const;

/**
 * The IPSec integrity algorithm (IKE phase 1).
 */
export type IpsecIntegrity = (typeof IpsecIntegrity)[keyof typeof IpsecIntegrity];

export const LoadBalancerSkuName = {
    Basic: "Basic",
    Standard: "Standard",
} as const;

/**
 * Name of a load balancer SKU.
 */
export type LoadBalancerSkuName = (typeof LoadBalancerSkuName)[keyof typeof LoadBalancerSkuName];

export const LoadDistribution = {
    Default: "Default",
    SourceIP: "SourceIP",
    SourceIPProtocol: "SourceIPProtocol",
} as const;

/**
 * The load distribution policy for this rule. Possible values are 'Default', 'SourceIP', and 'SourceIPProtocol'.
 */
export type LoadDistribution = (typeof LoadDistribution)[keyof typeof LoadDistribution];

export const PcProtocol = {
    TCP: "TCP",
    UDP: "UDP",
    Any: "Any",
} as const;

/**
 * Protocol to be filtered on.
 */
export type PcProtocol = (typeof PcProtocol)[keyof typeof PcProtocol];

export const PfsGroup = {
    None: "None",
    PFS1: "PFS1",
    PFS2: "PFS2",
    PFS2048: "PFS2048",
    ECP256: "ECP256",
    ECP384: "ECP384",
    PFS24: "PFS24",
} as const;

/**
 * The DH Groups used in IKE Phase 2 for new child SA.
 */
export type PfsGroup = (typeof PfsGroup)[keyof typeof PfsGroup];

export const ProbeProtocol = {
    Http: "Http",
    Tcp: "Tcp",
} as const;

/**
 * The protocol of the end point. Possible values are: 'Http' or 'Tcp'. If 'Tcp' is specified, a received ACK is required for the probe to be successful. If 'Http' is specified, a 200 OK response from the specifies URI is required for the probe to be successful.
 */
export type ProbeProtocol = (typeof ProbeProtocol)[keyof typeof ProbeProtocol];

export const PublicIPAddressSkuName = {
    Basic: "Basic",
    Standard: "Standard",
} as const;

/**
 * Name of a public IP address SKU.
 */
export type PublicIPAddressSkuName = (typeof PublicIPAddressSkuName)[keyof typeof PublicIPAddressSkuName];

export const RouteFilterRuleType = {
    Community: "Community",
} as const;

/**
 * The rule type of the rule. Valid value is: 'Community'
 */
export type RouteFilterRuleType = (typeof RouteFilterRuleType)[keyof typeof RouteFilterRuleType];

export const RouteNextHopType = {
    VirtualNetworkGateway: "VirtualNetworkGateway",
    VnetLocal: "VnetLocal",
    Internet: "Internet",
    VirtualAppliance: "VirtualAppliance",
    None: "None",
} as const;

/**
 * The type of Azure hop the packet should be sent to. Possible values are: 'VirtualNetworkGateway', 'VnetLocal', 'Internet', 'VirtualAppliance', and 'None'
 */
export type RouteNextHopType = (typeof RouteNextHopType)[keyof typeof RouteNextHopType];

export const SecurityRuleAccess = {
    Allow: "Allow",
    Deny: "Deny",
} as const;

/**
 * The network traffic is allowed or denied. Possible values are: 'Allow' and 'Deny'.
 */
export type SecurityRuleAccess = (typeof SecurityRuleAccess)[keyof typeof SecurityRuleAccess];

export const SecurityRuleDirection = {
    Inbound: "Inbound",
    Outbound: "Outbound",
} as const;

/**
 * The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are: 'Inbound' and 'Outbound'.
 */
export type SecurityRuleDirection = (typeof SecurityRuleDirection)[keyof typeof SecurityRuleDirection];

export const SecurityRuleProtocol = {
    Tcp: "Tcp",
    Udp: "Udp",
    Asterisk: "*",
} as const;

/**
 * Network protocol this rule applies to. Possible values are 'Tcp', 'Udp', and '*'.
 */
export type SecurityRuleProtocol = (typeof SecurityRuleProtocol)[keyof typeof SecurityRuleProtocol];

export const ServiceProviderProvisioningState = {
    NotProvisioned: "NotProvisioned",
    Provisioning: "Provisioning",
    Provisioned: "Provisioned",
    Deprovisioning: "Deprovisioning",
} as const;

/**
 * The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
 */
export type ServiceProviderProvisioningState = (typeof ServiceProviderProvisioningState)[keyof typeof ServiceProviderProvisioningState];

export const TransportProtocol = {
    Udp: "Udp",
    Tcp: "Tcp",
    All: "All",
} as const;

/**
 * The transport protocol for the endpoint. Possible values are 'Udp' or 'Tcp' or 'All.'
 */
export type TransportProtocol = (typeof TransportProtocol)[keyof typeof TransportProtocol];

export const VirtualNetworkGatewayConnectionType = {
    IPsec: "IPsec",
    Vnet2Vnet: "Vnet2Vnet",
    ExpressRoute: "ExpressRoute",
    VPNClient: "VPNClient",
} as const;

/**
 * Gateway connection type. Possible values are: 'IPsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
 */
export type VirtualNetworkGatewayConnectionType = (typeof VirtualNetworkGatewayConnectionType)[keyof typeof VirtualNetworkGatewayConnectionType];

export const VirtualNetworkGatewaySkuName = {
    Basic: "Basic",
    HighPerformance: "HighPerformance",
    Standard: "Standard",
    UltraPerformance: "UltraPerformance",
    VpnGw1: "VpnGw1",
    VpnGw2: "VpnGw2",
    VpnGw3: "VpnGw3",
} as const;

/**
 * Gateway SKU name.
 */
export type VirtualNetworkGatewaySkuName = (typeof VirtualNetworkGatewaySkuName)[keyof typeof VirtualNetworkGatewaySkuName];

export const VirtualNetworkGatewaySkuTier = {
    Basic: "Basic",
    HighPerformance: "HighPerformance",
    Standard: "Standard",
    UltraPerformance: "UltraPerformance",
    VpnGw1: "VpnGw1",
    VpnGw2: "VpnGw2",
    VpnGw3: "VpnGw3",
} as const;

/**
 * Gateway SKU tier.
 */
export type VirtualNetworkGatewaySkuTier = (typeof VirtualNetworkGatewaySkuTier)[keyof typeof VirtualNetworkGatewaySkuTier];

export const VirtualNetworkGatewayType = {
    Vpn: "Vpn",
    ExpressRoute: "ExpressRoute",
} as const;

/**
 * The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
 */
export type VirtualNetworkGatewayType = (typeof VirtualNetworkGatewayType)[keyof typeof VirtualNetworkGatewayType];

export const VirtualNetworkPeeringState = {
    Initiated: "Initiated",
    Connected: "Connected",
    Disconnected: "Disconnected",
} as const;

/**
 * The status of the virtual network peering. Possible values are 'Initiated', 'Connected', and 'Disconnected'.
 */
export type VirtualNetworkPeeringState = (typeof VirtualNetworkPeeringState)[keyof typeof VirtualNetworkPeeringState];

export const VpnClientProtocol = {
    IkeV2: "IkeV2",
    SSTP: "SSTP",
} as const;

/**
 * VPN client protocol enabled for the virtual network gateway.
 */
export type VpnClientProtocol = (typeof VpnClientProtocol)[keyof typeof VpnClientProtocol];

export const VpnType = {
    PolicyBased: "PolicyBased",
    RouteBased: "RouteBased",
} as const;

/**
 * The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
 */
export type VpnType = (typeof VpnType)[keyof typeof VpnType];

export const ZoneType = {
    Public: "Public",
    Private: "Private",
} as const;

/**
 * The type of this DNS zone (Public or Private).
 */
export type ZoneType = (typeof ZoneType)[keyof typeof ZoneType];
