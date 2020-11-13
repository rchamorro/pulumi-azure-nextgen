// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getCustomerSubscription(args: GetCustomerSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetCustomerSubscriptionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:azurestack/v20170601:getCustomerSubscription", {
        "customerSubscriptionName": args.customerSubscriptionName,
        "registrationName": args.registrationName,
        "resourceGroup": args.resourceGroup,
    }, opts);
}

export interface GetCustomerSubscriptionArgs {
    /**
     * Name of the product.
     */
    readonly customerSubscriptionName: string;
    /**
     * Name of the Azure Stack registration.
     */
    readonly registrationName: string;
    /**
     * Name of the resource group.
     */
    readonly resourceGroup: string;
}

/**
 * Customer subscription.
 */
export interface GetCustomerSubscriptionResult {
    /**
     * The entity tag used for optimistic concurrency when modifying the resource.
     */
    readonly etag?: string;
    /**
     * Name of the resource.
     */
    readonly name: string;
    /**
     * Tenant Id.
     */
    readonly tenantId?: string;
    /**
     * Type of Resource.
     */
    readonly type: string;
}
