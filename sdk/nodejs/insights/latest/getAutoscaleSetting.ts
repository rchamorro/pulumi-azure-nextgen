// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAutoscaleSetting(args: GetAutoscaleSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetAutoscaleSettingResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:insights/latest:getAutoscaleSetting", {
        "autoscaleSettingName": args.autoscaleSettingName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAutoscaleSettingArgs {
    /**
     * The autoscale setting name.
     */
    readonly autoscaleSettingName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * The autoscale setting resource.
 */
export interface GetAutoscaleSettingResult {
    /**
     * the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is 'true'.
     */
    readonly enabled?: boolean;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * the collection of notifications.
     */
    readonly notifications?: outputs.insights.latest.AutoscaleNotificationResponse[];
    /**
     * the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified.
     */
    readonly profiles: outputs.insights.latest.AutoscaleProfileResponse[];
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * the resource identifier of the resource that the autoscale setting should be added to.
     */
    readonly targetResourceUri?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}
