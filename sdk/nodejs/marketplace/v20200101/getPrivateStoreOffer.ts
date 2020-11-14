// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getPrivateStoreOffer(args: GetPrivateStoreOfferArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateStoreOfferResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:marketplace/v20200101:getPrivateStoreOffer", {
        "offerId": args.offerId,
        "privateStoreId": args.privateStoreId,
    }, opts);
}

export interface GetPrivateStoreOfferArgs {
    /**
     * The offer ID to update or delete
     */
    readonly offerId: string;
    /**
     * The store ID - must use the tenant ID
     */
    readonly privateStoreId: string;
}

/**
 * The privateStore offer data structure.
 */
export interface GetPrivateStoreOfferResult {
    /**
     * Private store offer creation date
     */
    readonly createdAt: string;
    /**
     * Identifier for purposes of race condition
     */
    readonly eTag?: string;
    /**
     * Icon File Uris
     */
    readonly iconFileUris?: outputs.marketplace.v20200101.OfferPropertiesResponseIconFileUris;
    /**
     * Private store offer modification date
     */
    readonly modifiedAt: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * It will be displayed prominently in the marketplace
     */
    readonly offerDisplayName: string;
    /**
     * Offer plans
     */
    readonly plans?: outputs.marketplace.v20200101.PlanResponse[];
    /**
     * Private store unique id
     */
    readonly privateStoreId: string;
    /**
     * Publisher name that will be displayed prominently in the marketplace
     */
    readonly publisherDisplayName: string;
    /**
     * Plan ids limitation for this offer
     */
    readonly specificPlanIdsLimitation?: string[];
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * Offers unique id
     */
    readonly uniqueOfferId: string;
    /**
     * Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated.
     */
    readonly updateSuppressedDueIdempotence?: boolean;
}
