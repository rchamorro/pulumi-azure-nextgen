"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * Defines web application firewall policy.
 */
class WebApplicationFirewallPolicy extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.policyName === undefined) {
                throw new Error("Missing required property 'policyName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customRules"] = args ? args.customRules : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["policyName"] = args ? args.policyName : undefined;
            inputs["policySettings"] = args ? args.policySettings : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["applicationGateways"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:network/v20181201:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20190201:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20190401:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20190701:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20190801:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20190901:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20191101:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20191201:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20200301:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20200401:WebApplicationFirewallPolicy" }, { type: "azurerm:network/v20200601:WebApplicationFirewallPolicy" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebApplicationFirewallPolicy.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing WebApplicationFirewallPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new WebApplicationFirewallPolicy(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of WebApplicationFirewallPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebApplicationFirewallPolicy.__pulumiType;
    }
}
exports.WebApplicationFirewallPolicy = WebApplicationFirewallPolicy;
/** @internal */
WebApplicationFirewallPolicy.__pulumiType = 'azurerm:network/v20190601:WebApplicationFirewallPolicy';
//# sourceMappingURL=webApplicationFirewallPolicy.js.map