"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getGalleryApplication(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:compute/v20191201:getGalleryApplication", {
        "galleryApplicationName": args.galleryApplicationName,
        "galleryName": args.galleryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}
exports.getGalleryApplication = getGalleryApplication;
//# sourceMappingURL=getGalleryApplication.js.map