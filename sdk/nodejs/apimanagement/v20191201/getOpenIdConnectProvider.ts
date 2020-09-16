// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getOpenIdConnectProvider(args: GetOpenIdConnectProviderArgs, opts?: pulumi.InvokeOptions): Promise<GetOpenIdConnectProviderResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20191201:getOpenIdConnectProvider", {
        "opid": args.opid,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetOpenIdConnectProviderArgs {
    /**
     * Identifier of the OpenID Connect Provider.
     */
    readonly opid: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
}

/**
 * OpenId Connect Provider details.
 */
export interface GetOpenIdConnectProviderResult {
    /**
     * Client ID of developer console which is the client application.
     */
    readonly clientId: string;
    /**
     * Client Secret of developer console which is the client application.
     */
    readonly clientSecret?: string;
    /**
     * User-friendly description of OpenID Connect Provider.
     */
    readonly description?: string;
    /**
     * User-friendly OpenID Connect Provider name.
     */
    readonly displayName: string;
    /**
     * Metadata endpoint URI.
     */
    readonly metadataEndpoint: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
}