// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPublicIPPrefix(args: GetPublicIPPrefixArgs, opts?: pulumi.InvokeOptions): Promise<GetPublicIPPrefixResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getPublicIPPrefix", {
        "expand": args.expand,
        "publicIpPrefixName": args.publicIpPrefixName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPublicIPPrefixArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the public IP prefix.
     */
    readonly publicIpPrefixName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Public IP prefix resource.
 */
export interface GetPublicIPPrefixResult {
    /**
     * The customIpPrefix that this prefix is associated with.
     */
    readonly customIPPrefix?: outputs.network.v20200701.SubResourceResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The extended location of the public ip address.
     */
    readonly extendedLocation?: outputs.network.v20200701.ExtendedLocationResponse;
    /**
     * The allocated Prefix.
     */
    readonly ipPrefix: string;
    /**
     * The list of tags associated with the public IP prefix.
     */
    readonly ipTags?: outputs.network.v20200701.IpTagResponse[];
    /**
     * The reference to load balancer frontend IP configuration associated with the public IP prefix.
     */
    readonly loadBalancerFrontendIpConfiguration: outputs.network.v20200701.SubResourceResponse;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The Length of the Public IP Prefix.
     */
    readonly prefixLength?: number;
    /**
     * The provisioning state of the public IP prefix resource.
     */
    readonly provisioningState: string;
    /**
     * The public IP address version.
     */
    readonly publicIPAddressVersion?: string;
    /**
     * The list of all referenced PublicIPAddresses.
     */
    readonly publicIPAddresses: outputs.network.v20200701.ReferencedPublicIpAddressResponse[];
    /**
     * The resource GUID property of the public IP prefix resource.
     */
    readonly resourceGuid: string;
    /**
     * The public IP prefix SKU.
     */
    readonly sku?: outputs.network.v20200701.PublicIPPrefixSkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones?: string[];
}
