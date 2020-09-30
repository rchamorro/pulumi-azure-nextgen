// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getIntegrationAccountAgreement(args: GetIntegrationAccountAgreementArgs, opts?: pulumi.InvokeOptions): Promise<GetIntegrationAccountAgreementResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:logic/v20180701preview:getIntegrationAccountAgreement", {
        "agreementName": args.agreementName,
        "integrationAccountName": args.integrationAccountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetIntegrationAccountAgreementArgs {
    /**
     * The integration account agreement name.
     */
    readonly agreementName: string;
    /**
     * The integration account name.
     */
    readonly integrationAccountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * The integration account agreement.
 */
export interface GetIntegrationAccountAgreementResult {
    /**
     * The agreement type.
     */
    readonly agreementType: string;
    /**
     * The changed time.
     */
    readonly changedTime: string;
    /**
     * The agreement content.
     */
    readonly content: outputs.logic.v20180701preview.AgreementContentResponse;
    /**
     * The created time.
     */
    readonly createdTime: string;
    /**
     * The business identity of the guest partner.
     */
    readonly guestIdentity: outputs.logic.v20180701preview.BusinessIdentityResponse;
    /**
     * The integration account partner that is set as guest partner for this agreement.
     */
    readonly guestPartner: string;
    /**
     * The business identity of the host partner.
     */
    readonly hostIdentity: outputs.logic.v20180701preview.BusinessIdentityResponse;
    /**
     * The integration account partner that is set as host partner for this agreement.
     */
    readonly hostPartner: string;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The metadata.
     */
    readonly metadata?: any;
    /**
     * Gets the resource name.
     */
    readonly name: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Gets the resource type.
     */
    readonly type: string;
}
