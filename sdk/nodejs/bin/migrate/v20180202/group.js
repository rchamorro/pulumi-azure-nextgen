"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * A group created in a Migration project.
 */
class Group extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.groupName === undefined) {
                throw new Error("Missing required property 'groupName'");
            }
            if (!args || args.machines === undefined) {
                throw new Error("Missing required property 'machines'");
            }
            if (!args || args.projectName === undefined) {
                throw new Error("Missing required property 'projectName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["eTag"] = args ? args.eTag : undefined;
            inputs["groupName"] = args ? args.groupName : undefined;
            inputs["machines"] = args ? args.machines : undefined;
            inputs["projectName"] = args ? args.projectName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["assessments"] = undefined /*out*/;
            inputs["createdTimestamp"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["updatedTimestamp"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Group.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing Group resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new Group(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of Group.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Group.__pulumiType;
    }
}
exports.Group = Group;
/** @internal */
Group.__pulumiType = 'azurerm:migrate/v20180202:Group';
//# sourceMappingURL=group.js.map