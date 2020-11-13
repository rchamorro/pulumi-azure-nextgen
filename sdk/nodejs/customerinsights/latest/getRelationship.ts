// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRelationship(args: GetRelationshipArgs, opts?: pulumi.InvokeOptions): Promise<GetRelationshipResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:customerinsights/latest:getRelationship", {
        "hubName": args.hubName,
        "relationshipName": args.relationshipName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetRelationshipArgs {
    /**
     * The name of the hub.
     */
    readonly hubName: string;
    /**
     * The name of the relationship.
     */
    readonly relationshipName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * The relationship resource format.
 */
export interface GetRelationshipResult {
    /**
     * The Relationship Cardinality.
     */
    readonly cardinality?: string;
    /**
     * Localized descriptions for the Relationship.
     */
    readonly description?: {[key: string]: string};
    /**
     * Localized display name for the Relationship.
     */
    readonly displayName?: {[key: string]: string};
    /**
     * The expiry date time in UTC.
     */
    readonly expiryDateTimeUtc?: string;
    /**
     * The properties of the Relationship.
     */
    readonly fields?: outputs.customerinsights.latest.PropertyDefinitionResponse[];
    /**
     * Optional property to be used to map fields in profile to their strong ids in related profile.
     */
    readonly lookupMappings?: outputs.customerinsights.latest.RelationshipTypeMappingResponse[];
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Profile type.
     */
    readonly profileType: string;
    /**
     * Provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Related profile being referenced.
     */
    readonly relatedProfileType: string;
    /**
     * The relationship guid id.
     */
    readonly relationshipGuidId: string;
    /**
     * The Relationship name.
     */
    readonly relationshipName: string;
    /**
     * The hub name.
     */
    readonly tenantId: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
