// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getBudget(args: GetBudgetArgs, opts?: pulumi.InvokeOptions): Promise<GetBudgetResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:consumption/v20190101:getBudget", {
        "budgetName": args.budgetName,
        "scope": args.scope,
    }, opts);
}

export interface GetBudgetArgs {
    /**
     * Budget Name.
     */
    readonly budgetName: string;
    /**
     * The scope associated with budget operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope.
     */
    readonly scope: string;
}

/**
 * A budget resource.
 */
export interface GetBudgetResult {
    /**
     * The total amount of cost to track with the budget
     */
    readonly amount: number;
    /**
     * The category of the budget, whether the budget tracks cost or usage.
     */
    readonly category: string;
    /**
     * The current amount of cost which is being tracked for a budget.
     */
    readonly currentSpend: outputs.consumption.v20190101.CurrentSpendResponse;
    /**
     * eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
     */
    readonly eTag?: string;
    /**
     * May be used to filter budgets by resource group, resource, or meter.
     */
    readonly filters?: outputs.consumption.v20190101.FiltersResponse;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Dictionary of notifications associated with the budget. Budget can have up to five notifications.
     */
    readonly notifications?: {[key: string]: outputs.consumption.v20190101.NotificationResponse};
    /**
     * The time covered by a budget. Tracking of the amount will be reset based on the time grain.
     */
    readonly timeGrain: string;
    /**
     * Has start and end date of the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than three months. Past start date should  be selected within the timegrain period. There are no restrictions on the end date.
     */
    readonly timePeriod: outputs.consumption.v20190101.BudgetTimePeriodResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}
