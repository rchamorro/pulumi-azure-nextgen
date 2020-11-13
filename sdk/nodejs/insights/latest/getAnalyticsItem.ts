// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAnalyticsItem(args: GetAnalyticsItemArgs, opts?: pulumi.InvokeOptions): Promise<GetAnalyticsItemResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:insights/latest:getAnalyticsItem", {
        "id": args.id,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
        "scopePath": args.scopePath,
    }, opts);
}

export interface GetAnalyticsItemArgs {
    /**
     * The Id of a specific item defined in the Application Insights component
     */
    readonly id?: string;
    /**
     * The name of a specific item defined in the Application Insights component
     */
    readonly name?: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Application Insights component resource.
     */
    readonly resourceName: string;
    /**
     * Enum indicating if this item definition is owned by a specific user or is shared between all users with access to the Application Insights component.
     */
    readonly scopePath: string;
}

/**
 * Properties that define an Analytics item that is associated to an Application Insights component.
 */
export interface GetAnalyticsItemResult {
    /**
     * The content of this item
     */
    readonly content?: string;
    /**
     * The user-defined name of the item.
     */
    readonly name?: string;
    /**
     * A set of properties that can be defined in the context of a specific item type. Each type may have its own properties.
     */
    readonly properties: outputs.insights.latest.ApplicationInsightsComponentAnalyticsItemPropertiesResponse;
    /**
     * Enum indicating if this item definition is owned by a specific user or is shared between all users with access to the Application Insights component.
     */
    readonly scope?: string;
    /**
     * Date and time in UTC when this item was created.
     */
    readonly timeCreated: string;
    /**
     * Date and time in UTC of the last modification that was made to this item.
     */
    readonly timeModified: string;
    /**
     * Enum indicating the type of the Analytics item.
     */
    readonly type?: string;
    /**
     * This instance's version of the data model. This can change as new features are added.
     */
    readonly version: string;
}
