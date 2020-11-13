// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDatabasePrincipalAssignment(args: GetDatabasePrincipalAssignmentArgs, opts?: pulumi.InvokeOptions): Promise<GetDatabasePrincipalAssignmentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:kusto/v20200215:getDatabasePrincipalAssignment", {
        "clusterName": args.clusterName,
        "databaseName": args.databaseName,
        "principalAssignmentName": args.principalAssignmentName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDatabasePrincipalAssignmentArgs {
    /**
     * The name of the Kusto cluster.
     */
    readonly clusterName: string;
    /**
     * The name of the database in the Kusto cluster.
     */
    readonly databaseName: string;
    /**
     * The name of the Kusto principalAssignment.
     */
    readonly principalAssignmentName: string;
    /**
     * The name of the resource group containing the Kusto cluster.
     */
    readonly resourceGroupName: string;
}

/**
 * Class representing a database principal assignment.
 */
export interface GetDatabasePrincipalAssignmentResult {
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
     */
    readonly principalId: string;
    /**
     * The principal name
     */
    readonly principalName: string;
    /**
     * Principal type.
     */
    readonly principalType: string;
    /**
     * The provisioned state of the resource.
     */
    readonly provisioningState: string;
    /**
     * Database principal role.
     */
    readonly role: string;
    /**
     * The tenant id of the principal
     */
    readonly tenantId?: string;
    /**
     * The tenant name of the principal
     */
    readonly tenantName: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
