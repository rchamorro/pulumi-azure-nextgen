import * as pulumi from "@pulumi/pulumi";
export declare function getManagerExtendedInfo(args: GetManagerExtendedInfoArgs, opts?: pulumi.InvokeOptions): Promise<GetManagerExtendedInfoResult>;
export interface GetManagerExtendedInfoArgs {
    /**
     * The manager name
     */
    readonly managerName: string;
    /**
     * The resource group name
     */
    readonly resourceGroupName: string;
}
/**
 * The extended info of the manager.
 */
export interface GetManagerExtendedInfoResult {
    /**
     * Represents the encryption algorithm used to encrypt the other keys. None - if EncryptionKey is saved in plain text format. AlgorithmName - if encryption is used
     */
    readonly algorithm: string;
    /**
     * Represents the CEK of the resource
     */
    readonly encryptionKey?: string;
    /**
     * Represents the Cert thumbprint that was used to encrypt the CEK
     */
    readonly encryptionKeyThumbprint?: string;
    /**
     * ETag of the Resource
     */
    readonly etag?: string;
    /**
     * Represents the CIK of the resource
     */
    readonly integrityKey: string;
    /**
     * The name.
     */
    readonly name: string;
    /**
     * Represents the portal thumbprint which can be used optionally to encrypt the entire data before storing it.
     */
    readonly portalCertificateThumbprint?: string;
    /**
     * The type.
     */
    readonly type: string;
    /**
     * Represents the version of the ExtendedInfo object being persisted
     */
    readonly version?: string;
}