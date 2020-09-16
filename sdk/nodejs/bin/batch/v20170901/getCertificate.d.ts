import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getCertificate(args: GetCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetCertificateResult>;
export interface GetCertificateArgs {
    /**
     * The name of the Batch account.
     */
    readonly accountName: string;
    /**
     * The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5.
     */
    readonly certificateName: string;
    /**
     * The name of the resource group that contains the Batch account.
     */
    readonly resourceGroupName: string;
}
/**
 * Contains information about a certificate.
 */
export interface GetCertificateResult {
    /**
     * This is only returned when the certificate provisioningState is 'Failed'.
     */
    readonly deleteCertificateError: outputs.batch.v20170901.DeleteCertificateErrorResponse;
    /**
     * The ETag of the resource, used for concurrency statements.
     */
    readonly etag: string;
    /**
     * The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx.
     */
    readonly format?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The previous provisioned state of the resource
     */
    readonly previousProvisioningState: string;
    readonly previousProvisioningStateTransitionTime: string;
    /**
     * Values are:
     *
     *  Succeeded - The certificate is available for use in pools.
     *  Deleting - The user has requested that the certificate be deleted, but the delete operation has not yet completed. You may not reference the certificate when creating or updating pools.
     *  Failed - The user requested that the certificate be deleted, but there are pools that still have references to the certificate, or it is still installed on one or more compute nodes. (The latter can occur if the certificate has been removed from the pool, but the node has not yet restarted. Nodes refresh their certificates only when they restart.) You may use the cancel certificate delete operation to cancel the delete, or the delete certificate operation to retry the delete.
     */
    readonly provisioningState: string;
    readonly provisioningStateTransitionTime: string;
    /**
     * The public key of the certificate.
     */
    readonly publicData: string;
    /**
     * This must match the thumbprint from the name.
     */
    readonly thumbprint?: string;
    /**
     * This must match the first portion of the certificate name. Currently required to be 'SHA1'.
     */
    readonly thumbprintAlgorithm?: string;
    /**
     * The type of the resource.
     */
    readonly type: string;
}