// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAzureFirewall(args: GetAzureFirewallArgs, opts?: pulumi.InvokeOptions): Promise<GetAzureFirewallResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200301:getAzureFirewall", {
        "azureFirewallName": args.azureFirewallName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAzureFirewallArgs {
    /**
     * The name of the Azure Firewall.
     */
    readonly azureFirewallName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Azure Firewall resource.
 */
export interface GetAzureFirewallResult {
    /**
     * The additional properties used to further config this azure firewall.
     */
    readonly additionalProperties?: {[key: string]: string};
    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    readonly applicationRuleCollections?: outputs.network.v20200301.AzureFirewallApplicationRuleCollectionResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The firewallPolicy associated with this azure firewall.
     */
    readonly firewallPolicy?: outputs.network.v20200301.SubResourceResponse;
    /**
     * IP addresses associated with AzureFirewall.
     */
    readonly hubIpAddresses: outputs.network.v20200301.HubIPAddressesResponse;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    readonly ipConfigurations?: outputs.network.v20200301.AzureFirewallIPConfigurationResponse[];
    /**
     * IpGroups associated with AzureFirewall.
     */
    readonly ipGroups: outputs.network.v20200301.AzureFirewallIpGroupsResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * IP configuration of the Azure Firewall used for management traffic.
     */
    readonly managementIpConfiguration?: outputs.network.v20200301.AzureFirewallIPConfigurationResponse;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    readonly natRuleCollections?: outputs.network.v20200301.AzureFirewallNatRuleCollectionResponse[];
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    readonly networkRuleCollections?: outputs.network.v20200301.AzureFirewallNetworkRuleCollectionResponse[];
    /**
     * The provisioning state of the Azure firewall resource.
     */
    readonly provisioningState: string;
    /**
     * The Azure Firewall Resource SKU.
     */
    readonly sku?: outputs.network.v20200301.AzureFirewallSkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The operation mode for Threat Intelligence.
     */
    readonly threatIntelMode?: string;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The virtualHub to which the firewall belongs.
     */
    readonly virtualHub?: outputs.network.v20200301.SubResourceResponse;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    readonly zones?: string[];
}
