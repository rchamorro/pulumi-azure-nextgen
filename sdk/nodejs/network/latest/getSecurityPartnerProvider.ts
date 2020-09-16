// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getSecurityPartnerProvider(args: GetSecurityPartnerProviderArgs, opts?: pulumi.InvokeOptions): Promise<GetSecurityPartnerProviderResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getSecurityPartnerProvider", {
        "resourceGroupName": args.resourceGroupName,
        "securityPartnerProviderName": args.securityPartnerProviderName,
    }, opts);
}

export interface GetSecurityPartnerProviderArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Security Partner Provider.
     */
    readonly securityPartnerProviderName: string;
}

/**
 * Security Partner Provider resource.
 */
export interface GetSecurityPartnerProviderResult {
    /**
     * The connection status with the Security Partner Provider.
     */
    readonly connectionStatus: string;
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
     * The provisioning state of the Security Partner Provider resource.
     */
    readonly provisioningState: string;
    /**
     * The security provider name.
     */
    readonly securityProviderName?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The virtualHub to which the Security Partner Provider belongs.
     */
    readonly virtualHub?: outputs.network.latest.SubResourceResponse;
}