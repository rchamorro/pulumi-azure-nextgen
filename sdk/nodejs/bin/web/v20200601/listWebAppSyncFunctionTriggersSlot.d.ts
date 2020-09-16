import * as pulumi from "@pulumi/pulumi";
export declare function listWebAppSyncFunctionTriggersSlot(args: ListWebAppSyncFunctionTriggersSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppSyncFunctionTriggersSlotResult>;
export interface ListWebAppSyncFunctionTriggersSlotArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot.
     */
    readonly slot: string;
}
/**
 * Function secrets.
 */
export interface ListWebAppSyncFunctionTriggersSlotResult {
    /**
     * Secret key.
     */
    readonly key?: string;
    /**
     * Trigger URL.
     */
    readonly triggerUrl?: string;
}