// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const ProvisionState = {
    Accepted: "Accepted",
    Creating: "Creating",
    Updating: "Updating",
    Deleting: "Deleting",
    Succeeded: "Succeeded",
    Failed: "Failed",
    Canceled: "Canceled",
    Deleted: "Deleted",
    NotSpecified: "NotSpecified",
} as const;

/**
 * Provision states for confluent RP
 */
export type ProvisionState = (typeof ProvisionState)[keyof typeof ProvisionState];

export const SaaSOfferStatus = {
    Started: "Started",
    PendingFulfillmentStart: "PendingFulfillmentStart",
    InProgress: "InProgress",
    Subscribed: "Subscribed",
    Suspended: "Suspended",
    Reinstated: "Reinstated",
    Succeeded: "Succeeded",
    Failed: "Failed",
    Unsubscribed: "Unsubscribed",
    Updating: "Updating",
} as const;

/**
 * SaaS Offer Status
 */
export type SaaSOfferStatus = (typeof SaaSOfferStatus)[keyof typeof SaaSOfferStatus];
