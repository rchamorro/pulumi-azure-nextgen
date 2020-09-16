"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
 */
class CustomDomain extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.customDomainName === undefined) {
                throw new Error("Missing required property 'customDomainName'");
            }
            if (!args || args.endpointName === undefined) {
                throw new Error("Missing required property 'endpointName'");
            }
            if (!args || args.hostName === undefined) {
                throw new Error("Missing required property 'hostName'");
            }
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customDomainName"] = args ? args.customDomainName : undefined;
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["customHttpsProvisioningState"] = undefined /*out*/;
            inputs["customHttpsProvisioningSubstate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["validationData"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:cdn/v20150601:CustomDomain" }, { type: "azurerm:cdn/v20160402:CustomDomain" }, { type: "azurerm:cdn/v20161002:CustomDomain" }, { type: "azurerm:cdn/v20170402:CustomDomain" }, { type: "azurerm:cdn/v20171012:CustomDomain" }, { type: "azurerm:cdn/v20190415:CustomDomain" }, { type: "azurerm:cdn/v20190615:CustomDomain" }, { type: "azurerm:cdn/v20191231:CustomDomain" }, { type: "azurerm:cdn/v20200415:CustomDomain" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(CustomDomain.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing CustomDomain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new CustomDomain(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of CustomDomain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomDomain.__pulumiType;
    }
}
exports.CustomDomain = CustomDomain;
/** @internal */
CustomDomain.__pulumiType = 'azurerm:cdn/v20200331:CustomDomain';
//# sourceMappingURL=customDomain.js.map