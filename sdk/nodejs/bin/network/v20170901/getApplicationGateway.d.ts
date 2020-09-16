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
 * Application gateway resource
 */
export interface GetApplicationGatewayResult {
    /**
     * Authentication certificates of the application gateway resource.
     */
    readonly authenticationCertificates?: outputs.network.v20170901.ApplicationGatewayAuthenticationCertificateResponse[];
    /**
     * Backend address pool of the application gateway resource.
     */
    readonly backendAddressPools?: outputs.network.v20170901.ApplicationGatewayBackendAddressPoolResponse[];
    /**
     * Backend http settings of the application gateway resource.
     */
    readonly backendHttpSettingsCollection?: outputs.network.v20170901.ApplicationGatewayBackendHttpSettingsResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * Frontend IP addresses of the application gateway resource.
     */
    readonly frontendIPConfigurations?: outputs.network.v20170901.ApplicationGatewayFrontendIPConfigurationResponse[];
    /**
     * Frontend ports of the application gateway resource.
     */
    readonly frontendPorts?: outputs.network.v20170901.ApplicationGatewayFrontendPortResponse[];
    /**
     * Subnets of application the gateway resource.
     */
    readonly gatewayIPConfigurations?: outputs.network.v20170901.ApplicationGatewayIPConfigurationResponse[];
    /**
     * Http listeners of the application gateway resource.
     */
    readonly httpListeners?: outputs.network.v20170901.ApplicationGatewayHttpListenerResponse[];
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
    readonly probes?: outputs.network.v20170901.ApplicationGatewayProbeResponse[];
    /**
     * Provisioning state of the application gateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: string;
    /**
     * Redirect configurations of the application gateway resource.
     */
    readonly redirectConfigurations?: outputs.network.v20170901.ApplicationGatewayRedirectConfigurationResponse[];
    /**
     * Request routing rules of the application gateway resource.
     */
    readonly requestRoutingRules?: outputs.network.v20170901.ApplicationGatewayRequestRoutingRuleResponse[];
    /**
     * Resource GUID property of the application gateway resource.
     */
    readonly resourceGuid?: string;
    /**
     * SKU of the application gateway resource.
     */
    readonly sku?: outputs.network.v20170901.ApplicationGatewaySkuResponse;
    /**
     * SSL certificates of the application gateway resource.
     */
    readonly sslCertificates?: outputs.network.v20170901.ApplicationGatewaySslCertificateResponse[];
    /**
     * SSL policy of the application gateway resource.
     */
    readonly sslPolicy?: outputs.network.v20170901.ApplicationGatewaySslPolicyResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * URL path map of the application gateway resource.
     */
    readonly urlPathMaps?: outputs.network.v20170901.ApplicationGatewayUrlPathMapResponse[];
    /**
     * Web application firewall configuration.
     */
    readonly webApplicationFirewallConfiguration?: outputs.network.v20170901.ApplicationGatewayWebApplicationFirewallConfigurationResponse;
}