"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * The IpGroups resource information.
 */
class IpGroup extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.ipGroupsName === undefined) {
                throw new Error("Missing required property 'ipGroupsName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["ipAddresses"] = args ? args.ipAddresses : undefined;
            inputs["ipGroupsName"] = args ? args.ipGroupsName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["firewalls"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:network/v20190901:IpGroup" }, { type: "azurerm:network/v20191201:IpGroup" }, { type: "azurerm:network/v20200301:IpGroup" }, { type: "azurerm:network/v20200401:IpGroup" }, { type: "azurerm:network/v20200501:IpGroup" }, { type: "azurerm:network/v20200601:IpGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(IpGroup.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing IpGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new IpGroup(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of IpGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IpGroup.__pulumiType;
    }
}
exports.IpGroup = IpGroup;
/** @internal */
IpGroup.__pulumiType = 'azurerm:network/v20191101:IpGroup';
//# sourceMappingURL=ipGroup.js.map