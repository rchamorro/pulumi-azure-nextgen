import * as pulumi from "@pulumi/pulumi";
export declare function getShareSubscription(args: GetShareSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetShareSubscriptionResult>;
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