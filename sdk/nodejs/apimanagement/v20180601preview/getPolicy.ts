// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getPolicy(args: GetPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20180601preview:getPolicy", {
        "policyId": args.policyId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetPolicyArgs {
    /**
     * The identifier of the Policy.
     */
    readonly policyId: string;
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
 * Policy Contract details.
 */
export interface GetPolicyResult {
    /**
     * Format of the policyContent.
     */
    readonly contentFormat?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Json escaped Xml Encoded contents of the Policy.
     */
    readonly policyContent: string;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
}
