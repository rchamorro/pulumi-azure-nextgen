// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Information about a domain.
 */
export class Domain extends pulumi.CustomResource {
    /**
     * Get an existing Domain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Domain {
        return new Domain(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:domainregistration/v20180201:Domain';

    /**
     * Returns true if the given object is an instance of Domain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Domain {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Domain.__pulumiType;
    }

    public readonly authCode!: pulumi.Output<string | undefined>;
    /**
     * <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
     */
    public readonly autoRenew!: pulumi.Output<boolean | undefined>;
    /**
     * Legal agreement consent.
     */
    public readonly consent!: pulumi.Output<outputs.domainregistration.v20180201.DomainPurchaseConsentResponse>;
    /**
     * Administrative contact.
     */
    public readonly contactAdmin!: pulumi.Output<outputs.domainregistration.v20180201.ContactResponse>;
    /**
     * Billing contact.
     */
    public readonly contactBilling!: pulumi.Output<outputs.domainregistration.v20180201.ContactResponse>;
    /**
     * Registrant contact.
     */
    public readonly contactRegistrant!: pulumi.Output<outputs.domainregistration.v20180201.ContactResponse>;
    /**
     * Technical contact.
     */
    public readonly contactTech!: pulumi.Output<outputs.domainregistration.v20180201.ContactResponse>;
    /**
     * Domain creation timestamp.
     */
    public /*out*/ readonly createdTime!: pulumi.Output<string>;
    /**
     * Current DNS type
     */
    public readonly dnsType!: pulumi.Output<string | undefined>;
    /**
     * Azure DNS Zone to use
     */
    public readonly dnsZoneId!: pulumi.Output<string | undefined>;
    /**
     * Reasons why domain is not renewable.
     */
    public /*out*/ readonly domainNotRenewableReasons!: pulumi.Output<string[]>;
    /**
     * Domain expiration timestamp.
     */
    public /*out*/ readonly expirationTime!: pulumi.Output<string>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Timestamp when the domain was renewed last time.
     */
    public /*out*/ readonly lastRenewedTime!: pulumi.Output<string>;
    /**
     * Resource Location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * All hostnames derived from the domain and assigned to Azure resources.
     */
    public /*out*/ readonly managedHostNames!: pulumi.Output<outputs.domainregistration.v20180201.HostNameResponse[]>;
    /**
     * Resource Name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Name servers.
     */
    public /*out*/ readonly nameServers!: pulumi.Output<string[]>;
    /**
     * <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
     */
    public readonly privacy!: pulumi.Output<boolean | undefined>;
    /**
     * Domain provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * <code>true</code> if Azure can assign this domain to App Service apps; otherwise, <code>false</code>. This value will be <code>true</code> if domain registration status is active and 
     *  it is hosted on name servers Azure has programmatic access to.
     */
    public /*out*/ readonly readyForDnsRecordManagement!: pulumi.Output<boolean>;
    /**
     * Domain registration status.
     */
    public /*out*/ readonly registrationStatus!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Target DNS type (would be used for migration)
     */
    public readonly targetDnsType!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Domain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.consent === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'consent'");
            }
            if ((!args || args.contactAdmin === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'contactAdmin'");
            }
            if ((!args || args.contactBilling === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'contactBilling'");
            }
            if ((!args || args.contactRegistrant === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'contactRegistrant'");
            }
            if ((!args || args.contactTech === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'contactTech'");
            }
            if ((!args || args.domainName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'domainName'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["authCode"] = args ? args.authCode : undefined;
            inputs["autoRenew"] = (args ? args.autoRenew : undefined) || true;
            inputs["consent"] = args ? args.consent : undefined;
            inputs["contactAdmin"] = args ? args.contactAdmin : undefined;
            inputs["contactBilling"] = args ? args.contactBilling : undefined;
            inputs["contactRegistrant"] = args ? args.contactRegistrant : undefined;
            inputs["contactTech"] = args ? args.contactTech : undefined;
            inputs["dnsType"] = args ? args.dnsType : undefined;
            inputs["dnsZoneId"] = args ? args.dnsZoneId : undefined;
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["privacy"] = args ? args.privacy : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetDnsType"] = args ? args.targetDnsType : undefined;
            inputs["createdTime"] = undefined /*out*/;
            inputs["domainNotRenewableReasons"] = undefined /*out*/;
            inputs["expirationTime"] = undefined /*out*/;
            inputs["lastRenewedTime"] = undefined /*out*/;
            inputs["managedHostNames"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nameServers"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["readyForDnsRecordManagement"] = undefined /*out*/;
            inputs["registrationStatus"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["authCode"] = undefined /*out*/;
            inputs["autoRenew"] = undefined /*out*/;
            inputs["consent"] = undefined /*out*/;
            inputs["contactAdmin"] = undefined /*out*/;
            inputs["contactBilling"] = undefined /*out*/;
            inputs["contactRegistrant"] = undefined /*out*/;
            inputs["contactTech"] = undefined /*out*/;
            inputs["createdTime"] = undefined /*out*/;
            inputs["dnsType"] = undefined /*out*/;
            inputs["dnsZoneId"] = undefined /*out*/;
            inputs["domainNotRenewableReasons"] = undefined /*out*/;
            inputs["expirationTime"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["lastRenewedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["managedHostNames"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nameServers"] = undefined /*out*/;
            inputs["privacy"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["readyForDnsRecordManagement"] = undefined /*out*/;
            inputs["registrationStatus"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetDnsType"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:domainregistration/latest:Domain" }, { type: "azure-nextgen:domainregistration/v20150401:Domain" }, { type: "azure-nextgen:domainregistration/v20150801:Domain" }, { type: "azure-nextgen:domainregistration/v20190801:Domain" }, { type: "azure-nextgen:domainregistration/v20200601:Domain" }, { type: "azure-nextgen:domainregistration/v20200901:Domain" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Domain.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Domain resource.
 */
export interface DomainArgs {
    readonly authCode?: pulumi.Input<string>;
    /**
     * <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
     */
    readonly autoRenew?: pulumi.Input<boolean>;
    /**
     * Legal agreement consent.
     */
    readonly consent: pulumi.Input<inputs.domainregistration.v20180201.DomainPurchaseConsent>;
    /**
     * Administrative contact.
     */
    readonly contactAdmin: pulumi.Input<inputs.domainregistration.v20180201.Contact>;
    /**
     * Billing contact.
     */
    readonly contactBilling: pulumi.Input<inputs.domainregistration.v20180201.Contact>;
    /**
     * Registrant contact.
     */
    readonly contactRegistrant: pulumi.Input<inputs.domainregistration.v20180201.Contact>;
    /**
     * Technical contact.
     */
    readonly contactTech: pulumi.Input<inputs.domainregistration.v20180201.Contact>;
    /**
     * Current DNS type
     */
    readonly dnsType?: pulumi.Input<enums.domainregistration.v20180201.DnsType>;
    /**
     * Azure DNS Zone to use
     */
    readonly dnsZoneId?: pulumi.Input<string>;
    /**
     * Name of the domain.
     */
    readonly domainName: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
     */
    readonly privacy?: pulumi.Input<boolean>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Target DNS type (would be used for migration)
     */
    readonly targetDnsType?: pulumi.Input<enums.domainregistration.v20180201.DnsType>;
}
