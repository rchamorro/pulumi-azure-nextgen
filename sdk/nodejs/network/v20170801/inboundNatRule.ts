// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Inbound NAT rule of the load balancer.
 */
export class InboundNatRule extends pulumi.CustomResource {
    /**
     * Get an existing InboundNatRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): InboundNatRule {
        return new InboundNatRule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20170801:InboundNatRule';

    /**
     * Returns true if the given object is an instance of InboundNatRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InboundNatRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InboundNatRule.__pulumiType;
    }

    /**
     * A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP.
     */
    public /*out*/ readonly backendIPConfiguration!: pulumi.Output<outputs.network.v20170801.NetworkInterfaceIPConfigurationResponse>;
    /**
     * The port used for the internal endpoint. Acceptable values range from 1 to 65535.
     */
    public readonly backendPort!: pulumi.Output<number | undefined>;
    /**
     * Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
     */
    public readonly enableFloatingIP!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * A reference to frontend IP addresses.
     */
    public readonly frontendIPConfiguration!: pulumi.Output<outputs.network.v20170801.SubResourceResponse | undefined>;
    /**
     * The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
     */
    public readonly frontendPort!: pulumi.Output<number | undefined>;
    /**
     * The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
     */
    public readonly idleTimeoutInMinutes!: pulumi.Output<number | undefined>;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'
     */
    public readonly protocol!: pulumi.Output<string | undefined>;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;

    /**
     * Create a InboundNatRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InboundNatRuleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.inboundNatRuleName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'inboundNatRuleName'");
            }
            if ((!args || args.loadBalancerName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'loadBalancerName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["backendPort"] = args ? args.backendPort : undefined;
            inputs["enableFloatingIP"] = args ? args.enableFloatingIP : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["frontendIPConfiguration"] = args ? args.frontendIPConfiguration : undefined;
            inputs["frontendPort"] = args ? args.frontendPort : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["idleTimeoutInMinutes"] = args ? args.idleTimeoutInMinutes : undefined;
            inputs["inboundNatRuleName"] = args ? args.inboundNatRuleName : undefined;
            inputs["loadBalancerName"] = args ? args.loadBalancerName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["protocol"] = args ? args.protocol : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["backendIPConfiguration"] = undefined /*out*/;
        } else {
            inputs["backendIPConfiguration"] = undefined /*out*/;
            inputs["backendPort"] = undefined /*out*/;
            inputs["enableFloatingIP"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["frontendIPConfiguration"] = undefined /*out*/;
            inputs["frontendPort"] = undefined /*out*/;
            inputs["idleTimeoutInMinutes"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["protocol"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:InboundNatRule" }, { type: "azure-nextgen:network/v20170601:InboundNatRule" }, { type: "azure-nextgen:network/v20170901:InboundNatRule" }, { type: "azure-nextgen:network/v20171001:InboundNatRule" }, { type: "azure-nextgen:network/v20171101:InboundNatRule" }, { type: "azure-nextgen:network/v20180101:InboundNatRule" }, { type: "azure-nextgen:network/v20180201:InboundNatRule" }, { type: "azure-nextgen:network/v20180401:InboundNatRule" }, { type: "azure-nextgen:network/v20180601:InboundNatRule" }, { type: "azure-nextgen:network/v20180701:InboundNatRule" }, { type: "azure-nextgen:network/v20180801:InboundNatRule" }, { type: "azure-nextgen:network/v20181001:InboundNatRule" }, { type: "azure-nextgen:network/v20181101:InboundNatRule" }, { type: "azure-nextgen:network/v20181201:InboundNatRule" }, { type: "azure-nextgen:network/v20190201:InboundNatRule" }, { type: "azure-nextgen:network/v20190401:InboundNatRule" }, { type: "azure-nextgen:network/v20190601:InboundNatRule" }, { type: "azure-nextgen:network/v20190701:InboundNatRule" }, { type: "azure-nextgen:network/v20190801:InboundNatRule" }, { type: "azure-nextgen:network/v20190901:InboundNatRule" }, { type: "azure-nextgen:network/v20191101:InboundNatRule" }, { type: "azure-nextgen:network/v20191201:InboundNatRule" }, { type: "azure-nextgen:network/v20200301:InboundNatRule" }, { type: "azure-nextgen:network/v20200401:InboundNatRule" }, { type: "azure-nextgen:network/v20200501:InboundNatRule" }, { type: "azure-nextgen:network/v20200601:InboundNatRule" }, { type: "azure-nextgen:network/v20200701:InboundNatRule" }, { type: "azure-nextgen:network/v20200801:InboundNatRule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(InboundNatRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a InboundNatRule resource.
 */
export interface InboundNatRuleArgs {
    /**
     * The port used for the internal endpoint. Acceptable values range from 1 to 65535.
     */
    readonly backendPort?: pulumi.Input<number>;
    /**
     * Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
     */
    readonly enableFloatingIP?: pulumi.Input<boolean>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * A reference to frontend IP addresses.
     */
    readonly frontendIPConfiguration?: pulumi.Input<inputs.network.v20170801.SubResource>;
    /**
     * The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534.
     */
    readonly frontendPort?: pulumi.Input<number>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * The name of the inbound nat rule.
     */
    readonly inboundNatRuleName: pulumi.Input<string>;
    /**
     * The name of the load balancer.
     */
    readonly loadBalancerName: pulumi.Input<string>;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'
     */
    readonly protocol?: pulumi.Input<string | enums.network.v20170801.TransportProtocol>;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
