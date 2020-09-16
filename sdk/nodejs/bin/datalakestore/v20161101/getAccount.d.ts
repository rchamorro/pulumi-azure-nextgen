import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getAccount(args: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult>;
export interface GetAccountArgs {
    /**
     * The name of the Data Lake Store account.
     */
    readonly accountName: string;
    /**
     * The name of the Azure resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Data Lake Store account information.
 */
export interface GetAccountResult {
    /**
     * The unique identifier associated with this Data Lake Store account.
     */
    readonly accountId: string;
    /**
     * The account creation time.
     */
    readonly creationTime: string;
    /**
     * The commitment tier in use for the current month.
     */
    readonly currentTier: string;
    /**
     * The default owner group for all new folders and files created in the Data Lake Store account.
     */
    readonly defaultGroup: string;
    /**
     * The Key Vault encryption configuration.
     */
    readonly encryptionConfig: outputs.datalakestore.v20161101.EncryptionConfigResponse;
    /**
     * The current state of encryption provisioning for this Data Lake Store account.
     */
    readonly encryptionProvisioningState: string;
    /**
     * The current state of encryption for this Data Lake Store account.
     */
    readonly encryptionState: string;
    /**
     * The full CName endpoint for this account.
     */
    readonly endpoint: string;
    /**
     * The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
     */
    readonly firewallAllowAzureIps: string;
    /**
     * The list of firewall rules associated with this Data Lake Store account.
     */
    readonly firewallRules: outputs.datalakestore.v20161101.FirewallRuleResponse[];
    /**
     * The current state of the IP address firewall for this Data Lake Store account.
     */
    readonly firewallState: string;
    /**
     * The Key Vault encryption identity, if any.
     */
    readonly identity: outputs.datalakestore.v20161101.EncryptionIdentityResponse;
    /**
     * The account last modified time.
     */
    readonly lastModifiedTime: string;
    /**
     * The resource location.
     */
    readonly location: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The commitment tier to use for next month.
     */
    readonly newTier: string;
    /**
     * The provisioning status of the Data Lake Store account.
     */
    readonly provisioningState: string;
    /**
     * The state of the Data Lake Store account.
     */
    readonly state: string;
    /**
     * The resource tags.
     */
    readonly tags: {
        [key: string]: string;
    };
    /**
     * The current state of the trusted identity provider feature for this Data Lake Store account.
     */
    readonly trustedIdProviderState: string;
    /**
     * The list of trusted identity providers associated with this Data Lake Store account.
     */
    readonly trustedIdProviders: outputs.datalakestore.v20161101.TrustedIdProviderResponse[];
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * The list of virtual network rules associated with this Data Lake Store account.
     */
    readonly virtualNetworkRules: outputs.datalakestore.v20161101.VirtualNetworkRuleResponse[];
}