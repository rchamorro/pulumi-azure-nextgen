// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAccountFilter(args: GetAccountFilterArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountFilterResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20180701:getAccountFilter", {
        "accountName": args.accountName,
        "filterName": args.filterName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAccountFilterArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The Account Filter name
     */
    readonly filterName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * An Account Filter.
 */
export interface GetAccountFilterResult {
    /**
     * The first quality.
     */
    readonly firstQuality?: outputs.media.v20180701.FirstQualityResponse;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The presentation time range.
     */
    readonly presentationTimeRange?: outputs.media.v20180701.PresentationTimeRangeResponse;
    /**
     * The tracks selection conditions.
     */
    readonly tracks?: outputs.media.v20180701.FilterTrackSelectionResponse[];
    /**
     * The type of the resource.
     */
    readonly type: string;
}
