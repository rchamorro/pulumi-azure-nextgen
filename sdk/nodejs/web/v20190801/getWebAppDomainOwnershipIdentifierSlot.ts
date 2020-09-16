// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getWebAppDomainOwnershipIdentifierSlot(args: GetWebAppDomainOwnershipIdentifierSlotArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppDomainOwnershipIdentifierSlotResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20190801:getWebAppDomainOwnershipIdentifierSlot", {
        "domainOwnershipIdentifierName": args.domainOwnershipIdentifierName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface GetWebAppDomainOwnershipIdentifierSlotArgs {
    /**
     * Name of domain ownership identifier.
     */
    readonly domainOwnershipIdentifierName: string;
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will delete the binding for the production slot.
     */
    readonly slot: string;
}

/**
 * A domain specific resource identifier.
 */
export interface GetWebAppDomainOwnershipIdentifierSlotResult {
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * String representation of the identity.
     */
    readonly value?: string;
}