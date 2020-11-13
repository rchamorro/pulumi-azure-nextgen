// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDomainService(args: GetDomainServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:aad/latest:getDomainService", {
        "domainServiceName": args.domainServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDomainServiceArgs {
    /**
     * The name of the domain service.
     */
    readonly domainServiceName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * Domain service.
 */
export interface GetDomainServiceResult {
    /**
     * Deployment Id
     */
    readonly deploymentId: string;
    /**
     * Domain Configuration Type
     */
    readonly domainConfigurationType?: string;
    /**
     * The name of the Azure domain that the user would like to deploy Domain Services to.
     */
    readonly domainName?: string;
    /**
     * DomainSecurity Settings
     */
    readonly domainSecuritySettings?: outputs.aad.latest.DomainSecuritySettingsResponse;
    /**
     * Resource etag
     */
    readonly etag?: string;
    /**
     * Enabled or Disabled flag to turn on Group-based filtered sync
     */
    readonly filteredSync?: string;
    /**
     * Secure LDAP Settings
     */
    readonly ldapsSettings?: outputs.aad.latest.LdapsSettingsResponse;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Notification Settings
     */
    readonly notificationSettings?: outputs.aad.latest.NotificationSettingsResponse;
    /**
     * the current deployment or provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * List of ReplicaSets
     */
    readonly replicaSets?: outputs.aad.latest.ReplicaSetResponse[];
    /**
     * Resource Forest Settings
     */
    readonly resourceForestSettings?: outputs.aad.latest.ResourceForestSettingsResponse;
    /**
     * Sku Type
     */
    readonly sku?: string;
    /**
     * SyncOwner ReplicaSet Id
     */
    readonly syncOwner: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure Active Directory Tenant Id
     */
    readonly tenantId: string;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Data Model Version
     */
    readonly version: number;
}
