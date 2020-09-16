import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getRecordSet(args: GetRecordSetArgs, opts?: pulumi.InvokeOptions): Promise<GetRecordSetResult>;
export interface GetRecordSetArgs {
    /**
     * The type of DNS record in this record set.
     */
    readonly recordType: string;
    /**
     * The name of the record set, relative to the name of the zone.
     */
    readonly relativeRecordSetName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the DNS zone (without a terminating dot).
     */
    readonly zoneName: string;
}
/**
 * Describes a DNS record set (a collection of DNS records with the same name and type).
 */
export interface GetRecordSetResult {
    /**
     * The list of A records in the record set.
     */
    readonly aRecords?: outputs.network.v20171001.ARecordResponse[];
    /**
     * The list of AAAA records in the record set.
     */
    readonly aaaaRecords?: outputs.network.v20171001.AaaaRecordResponse[];
    /**
     * The list of CAA records in the record set.
     */
    readonly caaRecords?: outputs.network.v20171001.CaaRecordResponse[];
    /**
     * The CNAME record in the  record set.
     */
    readonly cnameRecord?: outputs.network.v20171001.CnameRecordResponse;
    /**
     * The etag of the record set.
     */
    readonly etag?: string;
    /**
     * Fully qualified domain name of the record set.
     */
    readonly fqdn: string;
    /**
     * The metadata attached to the record set.
     */
    readonly metadata?: {
        [key: string]: string;
    };
    /**
     * The list of MX records in the record set.
     */
    readonly mxRecords?: outputs.network.v20171001.MxRecordResponse[];
    /**
     * The name of the record set.
     */
    readonly name: string;
    /**
     * The list of NS records in the record set.
     */
    readonly nsRecords?: outputs.network.v20171001.NsRecordResponse[];
    /**
     * The list of PTR records in the record set.
     */
    readonly ptrRecords?: outputs.network.v20171001.PtrRecordResponse[];
    /**
     * The SOA record in the record set.
     */
    readonly soaRecord?: outputs.network.v20171001.SoaRecordResponse;
    /**
     * The list of SRV records in the record set.
     */
    readonly srvRecords?: outputs.network.v20171001.SrvRecordResponse[];
    /**
     * The TTL (time-to-live) of the records in the record set.
     */
    readonly ttl?: number;
    /**
     * The list of TXT records in the record set.
     */
    readonly txtRecords?: outputs.network.v20171001.TxtRecordResponse[];
    /**
     * The type of the record set.
     */
    readonly type: string;
}