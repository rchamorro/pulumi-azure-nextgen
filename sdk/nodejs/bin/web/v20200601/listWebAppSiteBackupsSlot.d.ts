import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function listWebAppSiteBackupsSlot(args: ListWebAppSiteBackupsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppSiteBackupsSlotResult>;
export interface ListWebAppSiteBackupsSlotArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will get backups of the production slot.
     */
    readonly slot: string;
}
/**
 * Collection of backup items.
 */
export interface ListWebAppSiteBackupsSlotResult {
    /**
     * Link to next page of resources.
     */
    readonly nextLink: string;
    /**
     * Collection of resources.
     */
    readonly value: outputs.web.v20200601.BackupItemResponse[];
}