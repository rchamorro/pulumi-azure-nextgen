// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getShareSubscription(args: GetShareSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetShareSubscriptionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datashare/latest:getShareSubscription", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "shareSubscriptionName": args.shareSubscriptionName,
    }, opts);
}

export interface GetShareSubscriptionArgs {
    /**
     * The name of the share account.
     */
    readonly accountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the shareSubscription.
     */
    readonly shareSubscriptionName: string;
}

/**
 * A share subscription data transfer object.
 */
export interface GetShareSubscriptionResult {
    /**
     * Time at which the share subscription was created.
     */
    readonly createdAt: string;
    /**
     * The expiration date of the share subscription.
     */
    readonly expirationDate?: string;
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * The invitation id.
     */
    readonly invitationId: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Email of the provider who created the resource
     */
    readonly providerEmail: string;
    /**
     * Name of the provider who created the resource
     */
    readonly providerName: string;
    /**
     * Tenant name of the provider who created the resource
     */
    readonly providerTenantName: string;
    /**
     * Provisioning state of the share subscription
     */
    readonly provisioningState: string;
    /**
     * Description of share
     */
    readonly shareDescription: string;
    /**
     * Kind of share
     */
    readonly shareKind: string;
    /**
     * Name of the share
     */
    readonly shareName: string;
    /**
     * Gets the current status of share subscription.
     */
    readonly shareSubscriptionStatus: string;
    /**
     * Terms of a share
     */
    readonly shareTerms: string;
    /**
     * Source share location.
     */
    readonly sourceShareLocation: string;
    /**
     * System Data of the Azure resource.
     */
    readonly systemData: outputs.datashare.latest.ProxyDtoResponseSystemData;
    /**
     * Type of the azure resource
     */
    readonly type: string;
    /**
     * Email of the user who created the resource
     */
    readonly userEmail: string;
    /**
     * Name of the user who created the resource
     */
    readonly userName: string;
}
