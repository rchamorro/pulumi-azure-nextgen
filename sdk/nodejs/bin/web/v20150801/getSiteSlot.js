"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getSiteSlot(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:web/v20150801:getSiteSlot", {
        "name": args.name,
        "propertiesToInclude": args.propertiesToInclude,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}
exports.getSiteSlot = getSiteSlot;
//# sourceMappingURL=getSiteSlot.js.map