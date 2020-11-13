// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getLabAccountRegionalAvailability(args: GetLabAccountRegionalAvailabilityArgs, opts?: pulumi.InvokeOptions): Promise<GetLabAccountRegionalAvailabilityResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:labservices/latest:getLabAccountRegionalAvailability", {
        "labAccountName": args.labAccountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetLabAccountRegionalAvailabilityArgs {
    /**
     * The name of the lab Account.
     */
    readonly labAccountName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * The response model from the GetRegionalAvailability action
 */
export interface GetLabAccountRegionalAvailabilityResult {
    /**
     * Availability information for different size categories per region
     */
    readonly regionalAvailability?: outputs.labservices.latest.RegionalAvailabilityResponse[];
}
