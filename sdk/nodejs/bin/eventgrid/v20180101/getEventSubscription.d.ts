import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getEventSubscription(args: GetEventSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetEventSubscriptionResult>;
export interface GetEventSubscriptionArgs {
    /**
     * Name of the event subscription
     */
    readonly eventSubscriptionName: string;
    /**
     * The scope of the event subscription. The scope can be a subscription, or a resource group, or a top level resource belonging to a resource provider namespace, or an EventGrid topic. For example, use '/subscriptions/{subscriptionId}/' for a subscription, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a resource group, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}' for a resource, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}' for an EventGrid topic.
     */
    readonly scope: string;
}
/**
 * Event Subscription
 */
export interface GetEventSubscriptionResult {
    /**
     * Information about the destination where events have to be delivered for the event subscription.
     */
    readonly destination?: outputs.eventgrid.v20180101.EventSubscriptionDestinationResponse;
    /**
     * Information about the filter for the event subscription.
     */
    readonly filter?: outputs.eventgrid.v20180101.EventSubscriptionFilterResponse;
    /**
     * List of user defined labels.
     */
    readonly labels?: string[];
    /**
     * Name of the resource
     */
    readonly name: string;
    /**
     * Provisioning state of the event subscription.
     */
    readonly provisioningState: string;
    /**
     * Name of the topic of the event subscription.
     */
    readonly topic: string;
    /**
     * Type of the resource
     */
    readonly type: string;
}