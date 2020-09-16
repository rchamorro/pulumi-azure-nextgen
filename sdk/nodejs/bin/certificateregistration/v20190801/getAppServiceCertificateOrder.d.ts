import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getAppServiceCertificateOrder(args: GetAppServiceCertificateOrderArgs, opts?: pulumi.InvokeOptions): Promise<GetAppServiceCertificateOrderResult>;
export interface GetAppServiceCertificateOrderArgs {
    /**
     * Name of the certificate order..
     */
    readonly certificateOrderName: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}
/**
 * SSL certificate purchase order.
 */
export interface GetAppServiceCertificateOrderResult {
    /**
     * Reasons why App Service Certificate is not renewable at the current moment.
     */
    readonly appServiceCertificateNotRenewableReasons: string[];
    /**
     * <code>true</code> if the certificate should be automatically renewed when it expires; otherwise, <code>false</code>.
     */
    readonly autoRenew?: boolean;
    /**
     * State of the Key Vault secret.
     */
    readonly certificates?: {
        [key: string]: outputs.certificateregistration.v20190801.AppServiceCertificateResponse;
    };
    /**
     * Last CSR that was created for this order.
     */
    readonly csr?: string;
    /**
     * Certificate distinguished name.
     */
    readonly distinguishedName?: string;
    /**
     * Domain verification token.
     */
    readonly domainVerificationToken: string;
    /**
     * Certificate expiration time.
     */
    readonly expirationTime: string;
    /**
     * Intermediate certificate.
     */
    readonly intermediate: outputs.certificateregistration.v20190801.CertificateDetailsResponse;
    /**
     * <code>true</code> if private key is external; otherwise, <code>false</code>.
     */
    readonly isPrivateKeyExternal: boolean;
    /**
     * Certificate key size.
     */
    readonly keySize?: number;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Certificate last issuance time.
     */
    readonly lastCertificateIssuanceTime: string;
    /**
     * Resource Location.
     */
    readonly location: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Time stamp when the certificate would be auto renewed next
     */
    readonly nextAutoRenewalTimeStamp: string;
    /**
     * Certificate product type.
     */
    readonly productType: string;
    /**
     * Status of certificate order.
     */
    readonly provisioningState: string;
    /**
     * Root certificate.
     */
    readonly root: outputs.certificateregistration.v20190801.CertificateDetailsResponse;
    /**
     * Current serial number of the certificate.
     */
    readonly serialNumber: string;
    /**
     * Signed certificate.
     */
    readonly signedCertificate: outputs.certificateregistration.v20190801.CertificateDetailsResponse;
    /**
     * Current order status.
     */
    readonly status: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Duration in years (must be between 1 and 3).
     */
    readonly validityInYears?: number;
}