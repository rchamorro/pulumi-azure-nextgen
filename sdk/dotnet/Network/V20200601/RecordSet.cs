// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200601
{
    /// <summary>
    /// Describes a DNS record set (a collection of DNS records with the same name and type) in a Private DNS zone.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20200601:RecordSet")]
    public partial class RecordSet : Pulumi.CustomResource
    {
        /// <summary>
        /// The list of A records in the record set.
        /// </summary>
        [Output("aRecords")]
        public Output<ImmutableArray<Outputs.ARecordResponse>> ARecords { get; private set; } = null!;

        /// <summary>
        /// The list of AAAA records in the record set.
        /// </summary>
        [Output("aaaaRecords")]
        public Output<ImmutableArray<Outputs.AaaaRecordResponse>> AaaaRecords { get; private set; } = null!;

        /// <summary>
        /// The CNAME record in the record set.
        /// </summary>
        [Output("cnameRecord")]
        public Output<Outputs.CnameRecordResponse?> CnameRecord { get; private set; } = null!;

        /// <summary>
        /// The ETag of the record set.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Fully qualified domain name of the record set.
        /// </summary>
        [Output("fqdn")]
        public Output<string> Fqdn { get; private set; } = null!;

        /// <summary>
        /// Is the record set auto-registered in the Private DNS zone through a virtual network link?
        /// </summary>
        [Output("isAutoRegistered")]
        public Output<bool> IsAutoRegistered { get; private set; } = null!;

        /// <summary>
        /// The metadata attached to the record set.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The list of MX records in the record set.
        /// </summary>
        [Output("mxRecords")]
        public Output<ImmutableArray<Outputs.MxRecordResponse>> MxRecords { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The list of PTR records in the record set.
        /// </summary>
        [Output("ptrRecords")]
        public Output<ImmutableArray<Outputs.PtrRecordResponse>> PtrRecords { get; private set; } = null!;

        /// <summary>
        /// The SOA record in the record set.
        /// </summary>
        [Output("soaRecord")]
        public Output<Outputs.SoaRecordResponse?> SoaRecord { get; private set; } = null!;

        /// <summary>
        /// The list of SRV records in the record set.
        /// </summary>
        [Output("srvRecords")]
        public Output<ImmutableArray<Outputs.SrvRecordResponse>> SrvRecords { get; private set; } = null!;

        /// <summary>
        /// The TTL (time-to-live) of the records in the record set.
        /// </summary>
        [Output("ttl")]
        public Output<double?> Ttl { get; private set; } = null!;

        /// <summary>
        /// The list of TXT records in the record set.
        /// </summary>
        [Output("txtRecords")]
        public Output<ImmutableArray<Outputs.TxtRecordResponse>> TxtRecords { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a RecordSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RecordSet(string name, RecordSetArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200601:RecordSet", name, args ?? new RecordSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RecordSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200601:RecordSet", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:RecordSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180901:RecordSet"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200101:RecordSet"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RecordSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RecordSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RecordSet(name, id, options);
        }
    }

    public sealed class RecordSetArgs : Pulumi.ResourceArgs
    {
        [Input("aRecords")]
        private InputList<Inputs.ARecordArgs>? _aRecords;

        /// <summary>
        /// The list of A records in the record set.
        /// </summary>
        public InputList<Inputs.ARecordArgs> ARecords
        {
            get => _aRecords ?? (_aRecords = new InputList<Inputs.ARecordArgs>());
            set => _aRecords = value;
        }

        [Input("aaaaRecords")]
        private InputList<Inputs.AaaaRecordArgs>? _aaaaRecords;

        /// <summary>
        /// The list of AAAA records in the record set.
        /// </summary>
        public InputList<Inputs.AaaaRecordArgs> AaaaRecords
        {
            get => _aaaaRecords ?? (_aaaaRecords = new InputList<Inputs.AaaaRecordArgs>());
            set => _aaaaRecords = value;
        }

        /// <summary>
        /// The CNAME record in the record set.
        /// </summary>
        [Input("cnameRecord")]
        public Input<Inputs.CnameRecordArgs>? CnameRecord { get; set; }

        /// <summary>
        /// The ETag of the record set.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// The metadata attached to the record set.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("mxRecords")]
        private InputList<Inputs.MxRecordArgs>? _mxRecords;

        /// <summary>
        /// The list of MX records in the record set.
        /// </summary>
        public InputList<Inputs.MxRecordArgs> MxRecords
        {
            get => _mxRecords ?? (_mxRecords = new InputList<Inputs.MxRecordArgs>());
            set => _mxRecords = value;
        }

        /// <summary>
        /// The name of the Private DNS zone (without a terminating dot).
        /// </summary>
        [Input("privateZoneName", required: true)]
        public Input<string> PrivateZoneName { get; set; } = null!;

        [Input("ptrRecords")]
        private InputList<Inputs.PtrRecordArgs>? _ptrRecords;

        /// <summary>
        /// The list of PTR records in the record set.
        /// </summary>
        public InputList<Inputs.PtrRecordArgs> PtrRecords
        {
            get => _ptrRecords ?? (_ptrRecords = new InputList<Inputs.PtrRecordArgs>());
            set => _ptrRecords = value;
        }

        /// <summary>
        /// The type of DNS record in this record set. Record sets of type SOA can be updated but not created (they are created when the Private DNS zone is created).
        /// </summary>
        [Input("recordType", required: true)]
        public Input<string> RecordType { get; set; } = null!;

        /// <summary>
        /// The name of the record set, relative to the name of the zone.
        /// </summary>
        [Input("relativeRecordSetName", required: true)]
        public Input<string> RelativeRecordSetName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SOA record in the record set.
        /// </summary>
        [Input("soaRecord")]
        public Input<Inputs.SoaRecordArgs>? SoaRecord { get; set; }

        [Input("srvRecords")]
        private InputList<Inputs.SrvRecordArgs>? _srvRecords;

        /// <summary>
        /// The list of SRV records in the record set.
        /// </summary>
        public InputList<Inputs.SrvRecordArgs> SrvRecords
        {
            get => _srvRecords ?? (_srvRecords = new InputList<Inputs.SrvRecordArgs>());
            set => _srvRecords = value;
        }

        /// <summary>
        /// The TTL (time-to-live) of the records in the record set.
        /// </summary>
        [Input("ttl")]
        public Input<double>? Ttl { get; set; }

        [Input("txtRecords")]
        private InputList<Inputs.TxtRecordArgs>? _txtRecords;

        /// <summary>
        /// The list of TXT records in the record set.
        /// </summary>
        public InputList<Inputs.TxtRecordArgs> TxtRecords
        {
            get => _txtRecords ?? (_txtRecords = new InputList<Inputs.TxtRecordArgs>());
            set => _txtRecords = value;
        }

        public RecordSetArgs()
        {
        }
    }
}
