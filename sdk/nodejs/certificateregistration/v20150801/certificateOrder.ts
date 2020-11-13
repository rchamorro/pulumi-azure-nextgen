// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Certificate purchase order
 */
export class CertificateOrder extends pulumi.CustomResource {
    /**
     * Get an existing CertificateOrder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CertificateOrder {
        return new CertificateOrder(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:certificateregistration/v20150801:CertificateOrder';

    /**
     * Returns true if the given object is an instance of CertificateOrder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CertificateOrder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CertificateOrder.__pulumiType;
    }

    /**
     * Auto renew
     */
    public readonly autoRenew!: pulumi.Output<boolean | undefined>;
    /**
     * State of the Key Vault secret
     */
    public readonly certificates!: pulumi.Output<{[key: string]: outputs.certificateregistration.v20150801.CertificateOrderCertificateResponse} | undefined>;
    /**
     * Last CSR that was created for this order
     */
    public readonly csr!: pulumi.Output<string | undefined>;
    /**
     * Certificate distinguished name
     */
    public readonly distinguishedName!: pulumi.Output<string | undefined>;
    /**
     * Domain Verification Token
     */
    public readonly domainVerificationToken!: pulumi.Output<string | undefined>;
    /**
     * Certificate expiration time
     */
    public readonly expirationTime!: pulumi.Output<string | undefined>;
    /**
     * Intermediate certificate
     */
    public readonly intermediate!: pulumi.Output<outputs.certificateregistration.v20150801.CertificateDetailsResponse | undefined>;
    /**
     * Certificate Key Size
     */
    public readonly keySize!: pulumi.Output<number | undefined>;
    /**
     * Kind of resource
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Certificate last issuance time
     */
    public readonly lastCertificateIssuanceTime!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Certificate product type
     */
    public readonly productType!: pulumi.Output<string | undefined>;
    /**
     * Status of certificate order
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Root certificate
     */
    public readonly root!: pulumi.Output<outputs.certificateregistration.v20150801.CertificateDetailsResponse | undefined>;
    /**
     * Current serial number of the certificate
     */
    public readonly serialNumber!: pulumi.Output<string | undefined>;
    /**
     * Signed certificate
     */
    public readonly signedCertificate!: pulumi.Output<outputs.certificateregistration.v20150801.CertificateDetailsResponse | undefined>;
    /**
     * Current order status
     */
    public readonly status!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Duration in years (must be between 1 and 3)
     */
    public readonly validityInYears!: pulumi.Output<number | undefined>;

    /**
     * Create a CertificateOrder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CertificateOrderArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["autoRenew"] = args ? args.autoRenew : undefined;
            inputs["certificates"] = args ? args.certificates : undefined;
            inputs["csr"] = args ? args.csr : undefined;
            inputs["distinguishedName"] = args ? args.distinguishedName : undefined;
            inputs["domainVerificationToken"] = args ? args.domainVerificationToken : undefined;
            inputs["expirationTime"] = args ? args.expirationTime : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["intermediate"] = args ? args.intermediate : undefined;
            inputs["keySize"] = args ? args.keySize : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["lastCertificateIssuanceTime"] = args ? args.lastCertificateIssuanceTime : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["productType"] = args ? args.productType : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["root"] = args ? args.root : undefined;
            inputs["serialNumber"] = args ? args.serialNumber : undefined;
            inputs["signedCertificate"] = args ? args.signedCertificate : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["validityInYears"] = args ? args.validityInYears : undefined;
        } else {
            inputs["autoRenew"] = undefined /*out*/;
            inputs["certificates"] = undefined /*out*/;
            inputs["csr"] = undefined /*out*/;
            inputs["distinguishedName"] = undefined /*out*/;
            inputs["domainVerificationToken"] = undefined /*out*/;
            inputs["expirationTime"] = undefined /*out*/;
            inputs["intermediate"] = undefined /*out*/;
            inputs["keySize"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["lastCertificateIssuanceTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["productType"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["root"] = undefined /*out*/;
            inputs["serialNumber"] = undefined /*out*/;
            inputs["signedCertificate"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["validityInYears"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:certificateregistration/latest:CertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20180201:CertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20190801:CertificateOrder" }, { type: "azure-nextgen:certificateregistration/v20200601:CertificateOrder" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(CertificateOrder.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CertificateOrder resource.
 */
export interface CertificateOrderArgs {
    /**
     * Auto renew
     */
    readonly autoRenew?: pulumi.Input<boolean>;
    /**
     * State of the Key Vault secret
     */
    readonly certificates?: pulumi.Input<{[key: string]: pulumi.Input<inputs.certificateregistration.v20150801.CertificateOrderCertificate>}>;
    /**
     * Last CSR that was created for this order
     */
    readonly csr?: pulumi.Input<string>;
    /**
     * Certificate distinguished name
     */
    readonly distinguishedName?: pulumi.Input<string>;
    /**
     * Domain Verification Token
     */
    readonly domainVerificationToken?: pulumi.Input<string>;
    /**
     * Certificate expiration time
     */
    readonly expirationTime?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Intermediate certificate
     */
    readonly intermediate?: pulumi.Input<inputs.certificateregistration.v20150801.CertificateDetails>;
    /**
     * Certificate Key Size
     */
    readonly keySize?: pulumi.Input<number>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Certificate last issuance time
     */
    readonly lastCertificateIssuanceTime?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Input<string>;
    /**
     * Certificate product type
     */
    readonly productType?: pulumi.Input<string>;
    /**
     * Status of certificate order
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Azure resource group name
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Root certificate
     */
    readonly root?: pulumi.Input<inputs.certificateregistration.v20150801.CertificateDetails>;
    /**
     * Current serial number of the certificate
     */
    readonly serialNumber?: pulumi.Input<string>;
    /**
     * Signed certificate
     */
    readonly signedCertificate?: pulumi.Input<inputs.certificateregistration.v20150801.CertificateDetails>;
    /**
     * Current order status
     */
    readonly status?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Duration in years (must be between 1 and 3)
     */
    readonly validityInYears?: pulumi.Input<number>;
}
