// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVpnServerConfiguration(args: GetVpnServerConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnServerConfigurationResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200401:getVpnServerConfiguration", {
        "resourceGroupName": args.resourceGroupName,
        "vpnServerConfigurationName": args.vpnServerConfigurationName,
    }, opts);
}

export interface GetVpnServerConfigurationArgs {
    /**
     * The resource group name of the VpnServerConfiguration.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VpnServerConfiguration being retrieved.
     */
    readonly vpnServerConfigurationName: string;
}

/**
 * VpnServerConfiguration Resource.
 */
export interface GetVpnServerConfigurationResult {
    /**
     * The set of aad vpn authentication parameters.
     */
    readonly aadAuthenticationParameters?: outputs.network.v20200401.AadAuthenticationParametersResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * List of references to P2SVpnGateways.
     */
    readonly p2SVpnGateways: outputs.network.v20200401.P2SVpnGatewayResponse[];
    /**
     * The provisioning state of the VpnServerConfiguration resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * Radius client root certificate of VpnServerConfiguration.
     */
    readonly radiusClientRootCertificates?: outputs.network.v20200401.VpnServerConfigRadiusClientRootCertificateResponse[];
    /**
     * The radius server address property of the VpnServerConfiguration resource for point to site client connection.
     */
    readonly radiusServerAddress?: string;
    /**
     * Radius Server root certificate of VpnServerConfiguration.
     */
    readonly radiusServerRootCertificates?: outputs.network.v20200401.VpnServerConfigRadiusServerRootCertificateResponse[];
    /**
     * The radius secret property of the VpnServerConfiguration resource for point to site client connection.
     */
    readonly radiusServerSecret?: string;
    /**
     * Multiple Radius Server configuration for VpnServerConfiguration.
     */
    readonly radiusServers?: outputs.network.v20200401.RadiusServerResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * VPN authentication types for the VpnServerConfiguration.
     */
    readonly vpnAuthenticationTypes?: string[];
    /**
     * VpnClientIpsecPolicies for VpnServerConfiguration.
     */
    readonly vpnClientIpsecPolicies?: outputs.network.v20200401.IpsecPolicyResponse[];
    /**
     * VPN client revoked certificate of VpnServerConfiguration.
     */
    readonly vpnClientRevokedCertificates?: outputs.network.v20200401.VpnServerConfigVpnClientRevokedCertificateResponse[];
    /**
     * VPN client root certificate of VpnServerConfiguration.
     */
    readonly vpnClientRootCertificates?: outputs.network.v20200401.VpnServerConfigVpnClientRootCertificateResponse[];
    /**
     * VPN protocols for the VpnServerConfiguration.
     */
    readonly vpnProtocols?: string[];
}
