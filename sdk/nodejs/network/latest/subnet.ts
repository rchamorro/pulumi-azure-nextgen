// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Subnet in a virtual network resource.
 */
export class Subnet extends pulumi.CustomResource {
    /**
     * Get an existing Subnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Subnet {
        return new Subnet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/latest:Subnet';

    /**
     * Returns true if the given object is an instance of Subnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Subnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Subnet.__pulumiType;
    }

    /**
     * The address prefix for the subnet.
     */
    public readonly addressPrefix!: pulumi.Output<string | undefined>;
    /**
     * List of address prefixes for the subnet.
     */
    public readonly addressPrefixes!: pulumi.Output<string[] | undefined>;
    /**
     * An array of references to the delegations on the subnet.
     */
    public readonly delegations!: pulumi.Output<outputs.network.latest.DelegationResponse[] | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Array of IpAllocation which reference this subnet.
     */
    public readonly ipAllocations!: pulumi.Output<outputs.network.latest.SubResourceResponse[] | undefined>;
    /**
     * Array of IP configuration profiles which reference this subnet.
     */
    public /*out*/ readonly ipConfigurationProfiles!: pulumi.Output<outputs.network.latest.IPConfigurationProfileResponse[]>;
    /**
     * An array of references to the network interface IP configurations using subnet.
     */
    public /*out*/ readonly ipConfigurations!: pulumi.Output<outputs.network.latest.IPConfigurationResponse[]>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Nat gateway associated with this subnet.
     */
    public readonly natGateway!: pulumi.Output<outputs.network.latest.SubResourceResponse | undefined>;
    /**
     * The reference to the NetworkSecurityGroup resource.
     */
    public readonly networkSecurityGroup!: pulumi.Output<outputs.network.latest.NetworkSecurityGroupResponse | undefined>;
    /**
     * Enable or Disable apply network policies on private end point in the subnet.
     */
    public readonly privateEndpointNetworkPolicies!: pulumi.Output<string | undefined>;
    /**
     * An array of references to private endpoints.
     */
    public /*out*/ readonly privateEndpoints!: pulumi.Output<outputs.network.latest.PrivateEndpointResponse[]>;
    /**
     * Enable or Disable apply network policies on private link service in the subnet.
     */
    public readonly privateLinkServiceNetworkPolicies!: pulumi.Output<string | undefined>;
    /**
     * The provisioning state of the subnet resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties.
     */
    public /*out*/ readonly purpose!: pulumi.Output<string>;
    /**
     * An array of references to the external resources using subnet.
     */
    public /*out*/ readonly resourceNavigationLinks!: pulumi.Output<outputs.network.latest.ResourceNavigationLinkResponse[]>;
    /**
     * The reference to the RouteTable resource.
     */
    public readonly routeTable!: pulumi.Output<outputs.network.latest.RouteTableResponse | undefined>;
    /**
     * An array of references to services injecting into this subnet.
     */
    public /*out*/ readonly serviceAssociationLinks!: pulumi.Output<outputs.network.latest.ServiceAssociationLinkResponse[]>;
    /**
     * An array of service endpoint policies.
     */
    public readonly serviceEndpointPolicies!: pulumi.Output<outputs.network.latest.ServiceEndpointPolicyResponse[] | undefined>;
    /**
     * An array of service endpoints.
     */
    public readonly serviceEndpoints!: pulumi.Output<outputs.network.latest.ServiceEndpointPropertiesFormatResponse[] | undefined>;

    /**
     * Create a Subnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubnetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.subnetName === undefined) {
                throw new Error("Missing required property 'subnetName'");
            }
            if (!args || args.virtualNetworkName === undefined) {
                throw new Error("Missing required property 'virtualNetworkName'");
            }
            inputs["addressPrefix"] = args ? args.addressPrefix : undefined;
            inputs["addressPrefixes"] = args ? args.addressPrefixes : undefined;
            inputs["delegations"] = args ? args.delegations : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipAllocations"] = args ? args.ipAllocations : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["natGateway"] = args ? args.natGateway : undefined;
            inputs["networkSecurityGroup"] = args ? args.networkSecurityGroup : undefined;
            inputs["privateEndpointNetworkPolicies"] = args ? args.privateEndpointNetworkPolicies : undefined;
            inputs["privateLinkServiceNetworkPolicies"] = args ? args.privateLinkServiceNetworkPolicies : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routeTable"] = args ? args.routeTable : undefined;
            inputs["serviceEndpointPolicies"] = args ? args.serviceEndpointPolicies : undefined;
            inputs["serviceEndpoints"] = args ? args.serviceEndpoints : undefined;
            inputs["subnetName"] = args ? args.subnetName : undefined;
            inputs["virtualNetworkName"] = args ? args.virtualNetworkName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["ipConfigurationProfiles"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["privateEndpoints"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["purpose"] = undefined /*out*/;
            inputs["resourceNavigationLinks"] = undefined /*out*/;
            inputs["serviceAssociationLinks"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["addressPrefixes"] = undefined /*out*/;
            inputs["delegations"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["ipAllocations"] = undefined /*out*/;
            inputs["ipConfigurationProfiles"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["natGateway"] = undefined /*out*/;
            inputs["networkSecurityGroup"] = undefined /*out*/;
            inputs["privateEndpointNetworkPolicies"] = undefined /*out*/;
            inputs["privateEndpoints"] = undefined /*out*/;
            inputs["privateLinkServiceNetworkPolicies"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["purpose"] = undefined /*out*/;
            inputs["resourceNavigationLinks"] = undefined /*out*/;
            inputs["routeTable"] = undefined /*out*/;
            inputs["serviceAssociationLinks"] = undefined /*out*/;
            inputs["serviceEndpointPolicies"] = undefined /*out*/;
            inputs["serviceEndpoints"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/v20150501preview:Subnet" }, { type: "azure-nextgen:network/v20150615:Subnet" }, { type: "azure-nextgen:network/v20160330:Subnet" }, { type: "azure-nextgen:network/v20160601:Subnet" }, { type: "azure-nextgen:network/v20160901:Subnet" }, { type: "azure-nextgen:network/v20161201:Subnet" }, { type: "azure-nextgen:network/v20170301:Subnet" }, { type: "azure-nextgen:network/v20170601:Subnet" }, { type: "azure-nextgen:network/v20170801:Subnet" }, { type: "azure-nextgen:network/v20170901:Subnet" }, { type: "azure-nextgen:network/v20171001:Subnet" }, { type: "azure-nextgen:network/v20171101:Subnet" }, { type: "azure-nextgen:network/v20180101:Subnet" }, { type: "azure-nextgen:network/v20180201:Subnet" }, { type: "azure-nextgen:network/v20180401:Subnet" }, { type: "azure-nextgen:network/v20180601:Subnet" }, { type: "azure-nextgen:network/v20180701:Subnet" }, { type: "azure-nextgen:network/v20180801:Subnet" }, { type: "azure-nextgen:network/v20181001:Subnet" }, { type: "azure-nextgen:network/v20181101:Subnet" }, { type: "azure-nextgen:network/v20181201:Subnet" }, { type: "azure-nextgen:network/v20190201:Subnet" }, { type: "azure-nextgen:network/v20190401:Subnet" }, { type: "azure-nextgen:network/v20190601:Subnet" }, { type: "azure-nextgen:network/v20190701:Subnet" }, { type: "azure-nextgen:network/v20190801:Subnet" }, { type: "azure-nextgen:network/v20190901:Subnet" }, { type: "azure-nextgen:network/v20191101:Subnet" }, { type: "azure-nextgen:network/v20191201:Subnet" }, { type: "azure-nextgen:network/v20200301:Subnet" }, { type: "azure-nextgen:network/v20200401:Subnet" }, { type: "azure-nextgen:network/v20200501:Subnet" }, { type: "azure-nextgen:network/v20200601:Subnet" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Subnet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Subnet resource.
 */
export interface SubnetArgs {
    /**
     * The address prefix for the subnet.
     */
    readonly addressPrefix?: pulumi.Input<string>;
    /**
     * List of address prefixes for the subnet.
     */
    readonly addressPrefixes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An array of references to the delegations on the subnet.
     */
    readonly delegations?: pulumi.Input<pulumi.Input<inputs.network.latest.Delegation>[]>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Array of IpAllocation which reference this subnet.
     */
    readonly ipAllocations?: pulumi.Input<pulumi.Input<inputs.network.latest.SubResource>[]>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Nat gateway associated with this subnet.
     */
    readonly natGateway?: pulumi.Input<inputs.network.latest.SubResource>;
    /**
     * The reference to the NetworkSecurityGroup resource.
     */
    readonly networkSecurityGroup?: pulumi.Input<inputs.network.latest.NetworkSecurityGroup>;
    /**
     * Enable or Disable apply network policies on private end point in the subnet.
     */
    readonly privateEndpointNetworkPolicies?: pulumi.Input<string>;
    /**
     * Enable or Disable apply network policies on private link service in the subnet.
     */
    readonly privateLinkServiceNetworkPolicies?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The reference to the RouteTable resource.
     */
    readonly routeTable?: pulumi.Input<inputs.network.latest.RouteTable>;
    /**
     * An array of service endpoint policies.
     */
    readonly serviceEndpointPolicies?: pulumi.Input<pulumi.Input<inputs.network.latest.ServiceEndpointPolicy>[]>;
    /**
     * An array of service endpoints.
     */
    readonly serviceEndpoints?: pulumi.Input<pulumi.Input<inputs.network.latest.ServiceEndpointPropertiesFormat>[]>;
    /**
     * The name of the subnet.
     */
    readonly subnetName: pulumi.Input<string>;
    /**
     * The name of the virtual network.
     */
    readonly virtualNetworkName: pulumi.Input<string>;
}