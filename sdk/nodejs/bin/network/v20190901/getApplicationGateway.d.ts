import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getApplicationGateway(args: GetApplicationGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationGatewayResult>;
export interface GetApplicationGatewayArgs {
    /**
     * The name of the application gateway.
     */
    readonly applicationGatewayName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Application gateway resource.
 */
export interface GetApplicationGatewayResult {
    /**
     * Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly authenticationCertificates?: outputs.network.v20190901.ApplicationGatewayAuthenticationCertificateResponse[];
    /**
     * Autoscale Configuration.
     */
    readonly autoscaleConfiguration?: outputs.network.v20190901.ApplicationGatewayAutoscaleConfigurationResponse;
    /**
     * Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly backendAddressPools?: outputs.network.v20190901.ApplicationGatewayBackendAddressPoolResponse[];
    /**
     * Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly backendHttpSettingsCollection?: outputs.network.v20190901.ApplicationGatewayBackendHttpSettingsResponse[];
    /**
     * Custom error configurations of the application gateway resource.
     */
    readonly customErrorConfigurations?: outputs.network.v20190901.ApplicationGatewayCustomErrorResponse[];
    /**
     * Whether FIPS is enabled on the application gateway resource.
     */
    readonly enableFips?: boolean;
    /**
     * Whether HTTP2 is enabled on the application gateway resource.
     */
    readonly enableHttp2?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Reference of the FirewallPolicy resource.
     */
    readonly firewallPolicy?: outputs.network.v20190901.SubResourceResponse;
    /**
     * Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly frontendIPConfigurations?: outputs.network.v20190901.ApplicationGatewayFrontendIPConfigurationResponse[];
    /**
     * Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly frontendPorts?: outputs.network.v20190901.ApplicationGatewayFrontendPortResponse[];
    /**
     * Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly gatewayIPConfigurations?: outputs.network.v20190901.ApplicationGatewayIPConfigurationResponse[];
    /**
     * Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly httpListeners?: outputs.network.v20190901.ApplicationGatewayHttpListenerResponse[];
    /**
     * The identity of the application gateway, if configured.
     */
    readonly identity?: outputs.network.v20190901.ManagedServiceIdentityResponse;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Operational state of the application gateway resource.
     */
    readonly operationalState: string;
    /**
     * Probes of the application gateway resource.
     */
    readonly probes?: outputs.network.v20190901.ApplicationGatewayProbeResponse[];
    /**
     * The provisioning state of the application gateway resource.
     */
    readonly provisioningState: string;
    /**
     * Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly redirectConfigurations?: outputs.network.v20190901.ApplicationGatewayRedirectConfigurationResponse[];
    /**
     * Request routing rules of the application gateway resource.
     */
    readonly requestRoutingRules?: outputs.network.v20190901.ApplicationGatewayRequestRoutingRuleResponse[];
    /**
     * The resource GUID property of the application gateway resource.
     */
    readonly resourceGuid: string;
    /**
     * Rewrite rules for the application gateway resource.
     */
    readonly rewriteRuleSets?: outputs.network.v20190901.ApplicationGatewayRewriteRuleSetResponse[];
    /**
     * SKU of the application gateway resource.
     */
    readonly sku?: outputs.network.v20190901.ApplicationGatewaySkuResponse;
    /**
     * SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly sslCertificates?: outputs.network.v20190901.ApplicationGatewaySslCertificateResponse[];
    /**
     * SSL policy of the application gateway resource.
     */
    readonly sslPolicy?: outputs.network.v20190901.ApplicationGatewaySslPolicyResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly trustedRootCertificates?: outputs.network.v20190901.ApplicationGatewayTrustedRootCertificateResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly urlPathMaps?: outputs.network.v20190901.ApplicationGatewayUrlPathMapResponse[];
    /**
     * Web application firewall configuration.
     */
    readonly webApplicationFirewallConfiguration?: outputs.network.v20190901.ApplicationGatewayWebApplicationFirewallConfigurationResponse;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    readonly zones?: string[];
}