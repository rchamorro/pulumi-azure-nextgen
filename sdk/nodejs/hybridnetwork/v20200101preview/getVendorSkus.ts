// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVendorSkus(args: GetVendorSkusArgs, opts?: pulumi.InvokeOptions): Promise<GetVendorSkusResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:hybridnetwork/v20200101preview:getVendorSkus", {
        "skuName": args.skuName,
        "vendorName": args.vendorName,
    }, opts);
}

export interface GetVendorSkusArgs {
    /**
     * The name of the sku.
     */
    readonly skuName: string;
    /**
     * The name of vendor.
     */
    readonly vendorName: string;
}

/**
 * Sku sub resource.
 */
export interface GetVendorSkusResult {
    /**
     * Sku deployment mode.
     */
    readonly deploymentMode?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The parameters for the managed application to be supplied by vendor.
     */
    readonly managedApplicationParameters?: any;
    /**
     * The template for the managed application deployment.
     */
    readonly managedApplicationTemplate?: any;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Indicates if the vendor sku is in preview mode.
     */
    readonly preview?: boolean;
    /**
     * The provisioning state of the vendor sku sub resource.
     */
    readonly provisioningState: string;
    /**
     * Sku type.
     */
    readonly skuType?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The template definition of the virtual network function.
     */
    readonly virtualNetworkFunctionTemplate?: outputs.hybridnetwork.v20200101preview.VirtualNetworkFunctionTemplateResponse;
}
