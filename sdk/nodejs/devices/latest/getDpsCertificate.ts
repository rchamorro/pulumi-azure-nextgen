// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDpsCertificate(args: GetDpsCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetDpsCertificateResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devices/latest:getDpsCertificate", {
        "certificateName": args.certificateName,
        "provisioningServiceName": args.provisioningServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDpsCertificateArgs {
    /**
     * Name of the certificate to retrieve.
     */
    readonly certificateName: string;
    /**
     * Name of the provisioning service the certificate is associated with.
     */
    readonly provisioningServiceName: string;
    /**
     * Resource group identifier.
     */
    readonly resourceGroupName: string;
}

/**
 * The X509 Certificate.
 */
export interface GetDpsCertificateResult {
    /**
     * The entity tag.
     */
    readonly etag: string;
    /**
     * The name of the certificate.
     */
    readonly name: string;
    /**
     * properties of a certificate
     */
    readonly properties: outputs.devices.latest.CertificatePropertiesResponse;
    /**
     * The resource type.
     */
    readonly type: string;
}
