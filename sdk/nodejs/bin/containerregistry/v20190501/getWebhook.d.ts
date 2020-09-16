import * as pulumi from "@pulumi/pulumi";
export declare function getWebhook(args: GetWebhookArgs, opts?: pulumi.InvokeOptions): Promise<GetWebhookResult>;
export interface GetWebhookArgs {
    /**
     * The name of the container registry.
     */
    readonly registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the webhook.
     */
    readonly webhookName: string;
}
/**
 * An object that represents a webhook for a container registry.
 */
export interface GetWebhookResult {
    /**
     * The list of actions that trigger the webhook to post notifications.
     */
    readonly actions: string[];
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The provisioning state of the webhook at the time the operation was called.
     */
    readonly provisioningState: string;
    /**
     * The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events.
     */
    readonly scope?: string;
    /**
     * The status of the webhook at the time the operation was called.
     */
    readonly status?: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The type of the resource.
     */
    readonly type: string;
}