import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getExport(args: GetExportArgs, opts?: pulumi.InvokeOptions): Promise<GetExportResult>;
export interface GetExportArgs {
    /**
     * Export Name.
     */
    readonly exportName: string;
    /**
     * The scope associated with export operations. This includes '/subscriptions/{subscriptionId}' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope.
     */
    readonly scope: string;
}
/**
 * A export resource.
 */
export interface GetExportResult {
    /**
     * Has definition for the export.
     */
    readonly definition: outputs.costmanagement.v20190101.QueryDefinitionResponse;
    /**
     * Has delivery information for the export.
     */
    readonly deliveryInfo: outputs.costmanagement.v20190101.ExportDeliveryInfoResponse;
    /**
     * The format of the export being delivered.
     */
    readonly format?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Has schedule information for the export.
     */
    readonly schedule?: outputs.costmanagement.v20190101.ExportScheduleResponse;
    /**
     * Resource tags.
     */
    readonly tags: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
}