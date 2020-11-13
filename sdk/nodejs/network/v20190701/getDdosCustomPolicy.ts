// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDdosCustomPolicy(args: GetDdosCustomPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetDdosCustomPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190701:getDdosCustomPolicy", {
        "ddosCustomPolicyName": args.ddosCustomPolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDdosCustomPolicyArgs {
    /**
     * The name of the DDoS custom policy.
     */
    readonly ddosCustomPolicyName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A DDoS custom policy in a resource group.
 */
export interface GetDdosCustomPolicyResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The protocol-specific DDoS policy customization parameters.
     */
    readonly protocolCustomSettings?: outputs.network.v20190701.ProtocolCustomSettingsFormatResponse[];
    /**
     * The provisioning state of the DDoS custom policy resource.
     */
    readonly provisioningState: string;
    /**
     * The list of public IPs associated with the DDoS custom policy resource. This list is read-only.
     */
    readonly publicIPAddresses: outputs.network.v20190701.SubResourceResponse[];
    /**
     * The resource GUID property of the DDoS custom policy resource. It uniquely identifies the resource, even if the user changes its name or migrate the resource across subscriptions or resource groups.
     */
    readonly resourceGuid: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
