"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getSynchronizationSetting(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:datashare/v20191101:getSynchronizationSetting", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
        "synchronizationSettingName": args.synchronizationSettingName,
    }, opts);
}
exports.getSynchronizationSetting = getSynchronizationSetting;
//# sourceMappingURL=getSynchronizationSetting.js.map