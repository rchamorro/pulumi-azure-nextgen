// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getExposureControlFeatureValue(args: GetExposureControlFeatureValueArgs, opts?: pulumi.InvokeOptions): Promise<GetExposureControlFeatureValueResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datafactory/v20180601:getExposureControlFeatureValue", {
        "featureName": args.featureName,
        "featureType": args.featureType,
        "locationId": args.locationId,
    }, opts);
}

export interface GetExposureControlFeatureValueArgs {
    /**
     * The feature name.
     */
    readonly featureName?: string;
    /**
     * The feature type.
     */
    readonly featureType?: string;
    /**
     * The location identifier.
     */
    readonly locationId: string;
}

/**
 * The exposure control response.
 */
export interface GetExposureControlFeatureValueResult {
    /**
     * The feature name.
     */
    readonly featureName: string;
    /**
     * The feature value.
     */
    readonly value: string;
}
