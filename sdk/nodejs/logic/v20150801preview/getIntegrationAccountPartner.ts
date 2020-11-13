// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getIntegrationAccountPartner(args: GetIntegrationAccountPartnerArgs, opts?: pulumi.InvokeOptions): Promise<GetIntegrationAccountPartnerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:logic/v20150801preview:getIntegrationAccountPartner", {
        "integrationAccountName": args.integrationAccountName,
        "partnerName": args.partnerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetIntegrationAccountPartnerArgs {
    /**
     * The integration account name.
     */
    readonly integrationAccountName: string;
    /**
     * The integration account partner name.
     */
    readonly partnerName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

export interface GetIntegrationAccountPartnerResult {
    /**
     * The changed time.
     */
    readonly changedTime: string;
    /**
     * The partner content.
     */
    readonly content?: outputs.logic.v20150801preview.PartnerContentResponse;
    /**
     * The created time.
     */
    readonly createdTime: string;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The metadata.
     */
    readonly metadata?: any;
    /**
     * The resource name.
     */
    readonly name?: string;
    /**
     * The partner type.
     */
    readonly partnerType?: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type?: string;
}
