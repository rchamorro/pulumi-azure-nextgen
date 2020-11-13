// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listWebAppPublishingCredentialsSlot(args: ListWebAppPublishingCredentialsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppPublishingCredentialsSlotResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/latest:listWebAppPublishingCredentialsSlot", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface ListWebAppPublishingCredentialsSlotArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will get the publishing credentials for the production slot.
     */
    readonly slot: string;
}

/**
 * User credentials used for publishing activity.
 */
export interface ListWebAppPublishingCredentialsSlotResult {
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Password used for publishing.
     */
    readonly publishingPassword?: string;
    /**
     * Password hash used for publishing.
     */
    readonly publishingPasswordHash?: string;
    /**
     * Password hash salt used for publishing.
     */
    readonly publishingPasswordHashSalt?: string;
    /**
     * Username used for publishing.
     */
    readonly publishingUserName: string;
    /**
     * Url of SCM site.
     */
    readonly scmUri?: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
