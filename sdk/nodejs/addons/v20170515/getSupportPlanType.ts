// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getSupportPlanType(args: GetSupportPlanTypeArgs, opts?: pulumi.InvokeOptions): Promise<GetSupportPlanTypeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:addons/v20170515:getSupportPlanType", {
        "planTypeName": args.planTypeName,
        "providerName": args.providerName,
    }, opts);
}

export interface GetSupportPlanTypeArgs {
    /**
     * The Canonical support plan type.
     */
    readonly planTypeName: string;
    /**
     * The support plan type. For now the only valid type is "canonical".
     */
    readonly providerName: string;
}

/**
 * The status of the Canonical support plan.
 */
export interface GetSupportPlanTypeResult {
    /**
     * The name of the Canonical support plan, i.e. "essential", "standard" or "advanced".
     */
    readonly name: string;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState?: string;
    /**
     * Microsoft.Addons/supportProvider
     */
    readonly type: string;
}