// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getCertificate(args: GetCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetCertificateResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:appplatform/v20200701:getCertificate", {
        "certificateName": args.certificateName,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetCertificateArgs {
    /**
     * The name of the certificate resource.
     */
    readonly certificateName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Service resource.
     */
    readonly serviceName: string;
}

/**
 * Certificate resource payload.
 */
export interface GetCertificateResult {
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * Properties of the certificate resource payload.
     */
    readonly properties: outputs.appplatform.v20200701.CertificatePropertiesResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}
