// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Application gateway resource.
 */
export class ApplicationGateway extends pulumi.CustomResource {
    /**
     * Get an existing ApplicationGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApplicationGateway {
        return new ApplicationGateway(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190401:ApplicationGateway';

    /**
     * Returns true if the given object is an instance of ApplicationGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApplicationGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApplicationGateway.__pulumiType;
    }

    /**
     * Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly authenticationCertificates!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayAuthenticationCertificateResponse[] | undefined>;
    /**
     * Autoscale Configuration.
     */
    public readonly autoscaleConfiguration!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayAutoscaleConfigurationResponse | undefined>;
    /**
     * Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly backendAddressPools!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayBackendAddressPoolResponse[] | undefined>;
    /**
     * Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly backendHttpSettingsCollection!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayBackendHttpSettingsResponse[] | undefined>;
    /**
     * Custom error configurations of the application gateway resource.
     */
    public readonly customErrorConfigurations!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayCustomErrorResponse[] | undefined>;
    /**
     * Whether FIPS is enabled on the application gateway resource.
     */
    public readonly enableFips!: pulumi.Output<boolean | undefined>;
    /**
     * Whether HTTP2 is enabled on the application gateway resource.
     */
    public readonly enableHttp2!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Reference of the FirewallPolicy resource.
     */
    public readonly firewallPolicy!: pulumi.Output<outputs.network.v20190401.SubResourceResponse | undefined>;
    /**
     * Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly frontendIPConfigurations!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayFrontendIPConfigurationResponse[] | undefined>;
    /**
     * Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly frontendPorts!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayFrontendPortResponse[] | undefined>;
    /**
     * Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly gatewayIPConfigurations!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayIPConfigurationResponse[] | undefined>;
    /**
     * Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly httpListeners!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayHttpListenerResponse[] | undefined>;
    /**
     * The identity of the application gateway, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.network.v20190401.ManagedServiceIdentityResponse | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Operational state of the application gateway resource.
     */
    public /*out*/ readonly operationalState!: pulumi.Output<string>;
    /**
     * Probes of the application gateway resource.
     */
    public readonly probes!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayProbeResponse[] | undefined>;
    /**
     * Provisioning state of the application gateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly redirectConfigurations!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayRedirectConfigurationResponse[] | undefined>;
    /**
     * Request routing rules of the application gateway resource.
     */
    public readonly requestRoutingRules!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayRequestRoutingRuleResponse[] | undefined>;
    /**
     * Resource GUID property of the application gateway resource.
     */
    public readonly resourceGuid!: pulumi.Output<string | undefined>;
    /**
     * Rewrite rules for the application gateway resource.
     */
    public readonly rewriteRuleSets!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayRewriteRuleSetResponse[] | undefined>;
    /**
     * SKU of the application gateway resource.
     */
    public readonly sku!: pulumi.Output<outputs.network.v20190401.ApplicationGatewaySkuResponse | undefined>;
    /**
     * SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly sslCertificates!: pulumi.Output<outputs.network.v20190401.ApplicationGatewaySslCertificateResponse[] | undefined>;
    /**
     * SSL policy of the application gateway resource.
     */
    public readonly sslPolicy!: pulumi.Output<outputs.network.v20190401.ApplicationGatewaySslPolicyResponse | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly trustedRootCertificates!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayTrustedRootCertificateResponse[] | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    public readonly urlPathMaps!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayUrlPathMapResponse[] | undefined>;
    /**
     * Web application firewall configuration.
     */
    public readonly webApplicationFirewallConfiguration!: pulumi.Output<outputs.network.v20190401.ApplicationGatewayWebApplicationFirewallConfigurationResponse | undefined>;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a ApplicationGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplicationGatewayArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.applicationGatewayName === undefined) {
                throw new Error("Missing required property 'applicationGatewayName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["applicationGatewayName"] = args ? args.applicationGatewayName : undefined;
            inputs["authenticationCertificates"] = args ? args.authenticationCertificates : undefined;
            inputs["autoscaleConfiguration"] = args ? args.autoscaleConfiguration : undefined;
            inputs["backendAddressPools"] = args ? args.backendAddressPools : undefined;
            inputs["backendHttpSettingsCollection"] = args ? args.backendHttpSettingsCollection : undefined;
            inputs["customErrorConfigurations"] = args ? args.customErrorConfigurations : undefined;
            inputs["enableFips"] = args ? args.enableFips : undefined;
            inputs["enableHttp2"] = args ? args.enableHttp2 : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["firewallPolicy"] = args ? args.firewallPolicy : undefined;
            inputs["frontendIPConfigurations"] = args ? args.frontendIPConfigurations : undefined;
            inputs["frontendPorts"] = args ? args.frontendPorts : undefined;
            inputs["gatewayIPConfigurations"] = args ? args.gatewayIPConfigurations : undefined;
            inputs["httpListeners"] = args ? args.httpListeners : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["probes"] = args ? args.probes : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["redirectConfigurations"] = args ? args.redirectConfigurations : undefined;
            inputs["requestRoutingRules"] = args ? args.requestRoutingRules : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceGuid"] = args ? args.resourceGuid : undefined;
            inputs["rewriteRuleSets"] = args ? args.rewriteRuleSets : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["sslCertificates"] = args ? args.sslCertificates : undefined;
            inputs["sslPolicy"] = args ? args.sslPolicy : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["trustedRootCertificates"] = args ? args.trustedRootCertificates : undefined;
            inputs["urlPathMaps"] = args ? args.urlPathMaps : undefined;
            inputs["webApplicationFirewallConfiguration"] = args ? args.webApplicationFirewallConfiguration : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["operationalState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["authenticationCertificates"] = undefined /*out*/;
            inputs["autoscaleConfiguration"] = undefined /*out*/;
            inputs["backendAddressPools"] = undefined /*out*/;
            inputs["backendHttpSettingsCollection"] = undefined /*out*/;
            inputs["customErrorConfigurations"] = undefined /*out*/;
            inputs["enableFips"] = undefined /*out*/;
            inputs["enableHttp2"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["firewallPolicy"] = undefined /*out*/;
            inputs["frontendIPConfigurations"] = undefined /*out*/;
            inputs["frontendPorts"] = undefined /*out*/;
            inputs["gatewayIPConfigurations"] = undefined /*out*/;
            inputs["httpListeners"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["operationalState"] = undefined /*out*/;
            inputs["probes"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["redirectConfigurations"] = undefined /*out*/;
            inputs["requestRoutingRules"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["rewriteRuleSets"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["sslCertificates"] = undefined /*out*/;
            inputs["sslPolicy"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["trustedRootCertificates"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["urlPathMaps"] = undefined /*out*/;
            inputs["webApplicationFirewallConfiguration"] = undefined /*out*/;
            inputs["zones"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ApplicationGateway" }, { type: "azure-nextgen:network/v20150501preview:ApplicationGateway" }, { type: "azure-nextgen:network/v20150615:ApplicationGateway" }, { type: "azure-nextgen:network/v20160330:ApplicationGateway" }, { type: "azure-nextgen:network/v20160601:ApplicationGateway" }, { type: "azure-nextgen:network/v20160901:ApplicationGateway" }, { type: "azure-nextgen:network/v20161201:ApplicationGateway" }, { type: "azure-nextgen:network/v20170301:ApplicationGateway" }, { type: "azure-nextgen:network/v20170601:ApplicationGateway" }, { type: "azure-nextgen:network/v20170801:ApplicationGateway" }, { type: "azure-nextgen:network/v20170901:ApplicationGateway" }, { type: "azure-nextgen:network/v20171001:ApplicationGateway" }, { type: "azure-nextgen:network/v20171101:ApplicationGateway" }, { type: "azure-nextgen:network/v20180101:ApplicationGateway" }, { type: "azure-nextgen:network/v20180201:ApplicationGateway" }, { type: "azure-nextgen:network/v20180401:ApplicationGateway" }, { type: "azure-nextgen:network/v20180601:ApplicationGateway" }, { type: "azure-nextgen:network/v20180701:ApplicationGateway" }, { type: "azure-nextgen:network/v20180801:ApplicationGateway" }, { type: "azure-nextgen:network/v20181001:ApplicationGateway" }, { type: "azure-nextgen:network/v20181101:ApplicationGateway" }, { type: "azure-nextgen:network/v20181201:ApplicationGateway" }, { type: "azure-nextgen:network/v20190201:ApplicationGateway" }, { type: "azure-nextgen:network/v20190601:ApplicationGateway" }, { type: "azure-nextgen:network/v20190701:ApplicationGateway" }, { type: "azure-nextgen:network/v20190801:ApplicationGateway" }, { type: "azure-nextgen:network/v20190901:ApplicationGateway" }, { type: "azure-nextgen:network/v20191101:ApplicationGateway" }, { type: "azure-nextgen:network/v20191201:ApplicationGateway" }, { type: "azure-nextgen:network/v20200301:ApplicationGateway" }, { type: "azure-nextgen:network/v20200401:ApplicationGateway" }, { type: "azure-nextgen:network/v20200501:ApplicationGateway" }, { type: "azure-nextgen:network/v20200601:ApplicationGateway" }, { type: "azure-nextgen:network/v20200701:ApplicationGateway" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ApplicationGateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApplicationGateway resource.
 */
export interface ApplicationGatewayArgs {
    /**
     * The name of the application gateway.
     */
    readonly applicationGatewayName: pulumi.Input<string>;
    /**
     * Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly authenticationCertificates?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayAuthenticationCertificate>[]>;
    /**
     * Autoscale Configuration.
     */
    readonly autoscaleConfiguration?: pulumi.Input<inputs.network.v20190401.ApplicationGatewayAutoscaleConfiguration>;
    /**
     * Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly backendAddressPools?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayBackendAddressPool>[]>;
    /**
     * Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly backendHttpSettingsCollection?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayBackendHttpSettings>[]>;
    /**
     * Custom error configurations of the application gateway resource.
     */
    readonly customErrorConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayCustomError>[]>;
    /**
     * Whether FIPS is enabled on the application gateway resource.
     */
    readonly enableFips?: pulumi.Input<boolean>;
    /**
     * Whether HTTP2 is enabled on the application gateway resource.
     */
    readonly enableHttp2?: pulumi.Input<boolean>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Reference of the FirewallPolicy resource.
     */
    readonly firewallPolicy?: pulumi.Input<inputs.network.v20190401.SubResource>;
    /**
     * Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly frontendIPConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayFrontendIPConfiguration>[]>;
    /**
     * Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly frontendPorts?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayFrontendPort>[]>;
    /**
     * Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly gatewayIPConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayIPConfiguration>[]>;
    /**
     * Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly httpListeners?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayHttpListener>[]>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The identity of the application gateway, if configured.
     */
    readonly identity?: pulumi.Input<inputs.network.v20190401.ManagedServiceIdentity>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Probes of the application gateway resource.
     */
    readonly probes?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayProbe>[]>;
    /**
     * Provisioning state of the application gateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly redirectConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayRedirectConfiguration>[]>;
    /**
     * Request routing rules of the application gateway resource.
     */
    readonly requestRoutingRules?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayRequestRoutingRule>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource GUID property of the application gateway resource.
     */
    readonly resourceGuid?: pulumi.Input<string>;
    /**
     * Rewrite rules for the application gateway resource.
     */
    readonly rewriteRuleSets?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayRewriteRuleSet>[]>;
    /**
     * SKU of the application gateway resource.
     */
    readonly sku?: pulumi.Input<inputs.network.v20190401.ApplicationGatewaySku>;
    /**
     * SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly sslCertificates?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewaySslCertificate>[]>;
    /**
     * SSL policy of the application gateway resource.
     */
    readonly sslPolicy?: pulumi.Input<inputs.network.v20190401.ApplicationGatewaySslPolicy>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly trustedRootCertificates?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayTrustedRootCertificate>[]>;
    /**
     * URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
     */
    readonly urlPathMaps?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ApplicationGatewayUrlPathMap>[]>;
    /**
     * Web application firewall configuration.
     */
    readonly webApplicationFirewallConfiguration?: pulumi.Input<inputs.network.v20190401.ApplicationGatewayWebApplicationFirewallConfiguration>;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}
