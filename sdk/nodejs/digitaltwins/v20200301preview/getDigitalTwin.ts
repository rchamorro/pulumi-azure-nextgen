// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDigitalTwin(args: GetDigitalTwinArgs, opts?: pulumi.InvokeOptions): Promise<GetDigitalTwinResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:digitaltwins/v20200301preview:getDigitalTwin", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetDigitalTwinArgs {
    /**
     * The name of the resource group that contains the DigitalTwinsInstance.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the DigitalTwinsInstance.
     */
    readonly resourceName: string;
}

/**
 * The description of the DigitalTwins service.
 */
export interface GetDigitalTwinResult {
    /**
     * Time when DigitalTwinsInstance was created.
     */
    readonly createdTime: string;
    /**
     * Api endpoint to work with DigitalTwinsInstance.
     */
    readonly hostName: string;
    /**
     * Time when DigitalTwinsInstance was created.
     */
    readonly lastUpdatedTime: string;
    /**
     * The resource location.
     */
    readonly location: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The provisioning state.
     */
    readonly provisioningState: string;
    /**
     * This property is reserved for future use, and will be ignored/omitted
     */
    readonly sku?: outputs.digitaltwins.v20200301preview.DigitalTwinsSkuInfoResponse;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
}
