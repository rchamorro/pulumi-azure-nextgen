// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20150801Preview.Inputs
{

    public sealed class EdifactEnvelopeSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The application reference id.
        /// </summary>
        [Input("applicationReferenceId")]
        public Input<string>? ApplicationReferenceId { get; set; }

        /// <summary>
        /// The value indicating whether to apply delimiter string advice.
        /// </summary>
        [Input("applyDelimiterStringAdvice")]
        public Input<bool>? ApplyDelimiterStringAdvice { get; set; }

        /// <summary>
        /// The communication agreement id.
        /// </summary>
        [Input("communicationAgreementId")]
        public Input<string>? CommunicationAgreementId { get; set; }

        /// <summary>
        /// The value indicating whether to create grouping segments.
        /// </summary>
        [Input("createGroupingSegments")]
        public Input<bool>? CreateGroupingSegments { get; set; }

        /// <summary>
        /// The value indicating whether to enable default group headers.
        /// </summary>
        [Input("enableDefaultGroupHeaders")]
        public Input<bool>? EnableDefaultGroupHeaders { get; set; }

        /// <summary>
        /// The functional group id.
        /// </summary>
        [Input("functionalGroupId")]
        public Input<string>? FunctionalGroupId { get; set; }

        /// <summary>
        /// The group application password.
        /// </summary>
        [Input("groupApplicationPassword")]
        public Input<string>? GroupApplicationPassword { get; set; }

        /// <summary>
        /// The group application receiver id.
        /// </summary>
        [Input("groupApplicationReceiverId")]
        public Input<string>? GroupApplicationReceiverId { get; set; }

        /// <summary>
        /// The group application receiver qualifier.
        /// </summary>
        [Input("groupApplicationReceiverQualifier")]
        public Input<string>? GroupApplicationReceiverQualifier { get; set; }

        /// <summary>
        /// The group application sender id.
        /// </summary>
        [Input("groupApplicationSenderId")]
        public Input<string>? GroupApplicationSenderId { get; set; }

        /// <summary>
        /// The group application sender qualifier.
        /// </summary>
        [Input("groupApplicationSenderQualifier")]
        public Input<string>? GroupApplicationSenderQualifier { get; set; }

        /// <summary>
        /// The group association assigned code.
        /// </summary>
        [Input("groupAssociationAssignedCode")]
        public Input<string>? GroupAssociationAssignedCode { get; set; }

        /// <summary>
        /// The group control number lower bound.
        /// </summary>
        [Input("groupControlNumberLowerBound")]
        public Input<double>? GroupControlNumberLowerBound { get; set; }

        /// <summary>
        /// The group control number prefix.
        /// </summary>
        [Input("groupControlNumberPrefix")]
        public Input<string>? GroupControlNumberPrefix { get; set; }

        /// <summary>
        /// The group control number suffix.
        /// </summary>
        [Input("groupControlNumberSuffix")]
        public Input<string>? GroupControlNumberSuffix { get; set; }

        /// <summary>
        /// The group control number upper bound.
        /// </summary>
        [Input("groupControlNumberUpperBound")]
        public Input<double>? GroupControlNumberUpperBound { get; set; }

        /// <summary>
        /// The group controlling agency code.
        /// </summary>
        [Input("groupControllingAgencyCode")]
        public Input<string>? GroupControllingAgencyCode { get; set; }

        /// <summary>
        /// The group message release.
        /// </summary>
        [Input("groupMessageRelease")]
        public Input<string>? GroupMessageRelease { get; set; }

        /// <summary>
        /// The group message version.
        /// </summary>
        [Input("groupMessageVersion")]
        public Input<string>? GroupMessageVersion { get; set; }

        /// <summary>
        /// The interchange control number lower bound.
        /// </summary>
        [Input("interchangeControlNumberLowerBound")]
        public Input<double>? InterchangeControlNumberLowerBound { get; set; }

        /// <summary>
        /// The interchange control number prefix.
        /// </summary>
        [Input("interchangeControlNumberPrefix")]
        public Input<string>? InterchangeControlNumberPrefix { get; set; }

        /// <summary>
        /// The interchange control number suffix.
        /// </summary>
        [Input("interchangeControlNumberSuffix")]
        public Input<string>? InterchangeControlNumberSuffix { get; set; }

        /// <summary>
        /// The interchange control number upper bound.
        /// </summary>
        [Input("interchangeControlNumberUpperBound")]
        public Input<double>? InterchangeControlNumberUpperBound { get; set; }

        /// <summary>
        /// The value indicating whether the message is a test interchange.
        /// </summary>
        [Input("isTestInterchange")]
        public Input<bool>? IsTestInterchange { get; set; }

        /// <summary>
        /// The value indicating whether to overwrite existing transaction set control number.
        /// </summary>
        [Input("overwriteExistingTransactionSetControlNumber")]
        public Input<bool>? OverwriteExistingTransactionSetControlNumber { get; set; }

        /// <summary>
        /// The processing priority code.
        /// </summary>
        [Input("processingPriorityCode")]
        public Input<string>? ProcessingPriorityCode { get; set; }

        /// <summary>
        /// The receiver internal identification.
        /// </summary>
        [Input("receiverInternalIdentification")]
        public Input<string>? ReceiverInternalIdentification { get; set; }

        /// <summary>
        /// The receiver internal sub identification.
        /// </summary>
        [Input("receiverInternalSubIdentification")]
        public Input<string>? ReceiverInternalSubIdentification { get; set; }

        /// <summary>
        /// The receiver reverse routing address.
        /// </summary>
        [Input("receiverReverseRoutingAddress")]
        public Input<string>? ReceiverReverseRoutingAddress { get; set; }

        /// <summary>
        /// The recipient reference password qualifier.
        /// </summary>
        [Input("recipientReferencePasswordQualifier")]
        public Input<string>? RecipientReferencePasswordQualifier { get; set; }

        /// <summary>
        /// The recipient reference password value.
        /// </summary>
        [Input("recipientReferencePasswordValue")]
        public Input<string>? RecipientReferencePasswordValue { get; set; }

        /// <summary>
        /// The value indicating whether to rollover group control number.
        /// </summary>
        [Input("rolloverGroupControlNumber")]
        public Input<bool>? RolloverGroupControlNumber { get; set; }

        /// <summary>
        /// The value indicating whether to rollover interchange control number.
        /// </summary>
        [Input("rolloverInterchangeControlNumber")]
        public Input<bool>? RolloverInterchangeControlNumber { get; set; }

        /// <summary>
        /// The value indicating whether to rollover transaction set control number.
        /// </summary>
        [Input("rolloverTransactionSetControlNumber")]
        public Input<bool>? RolloverTransactionSetControlNumber { get; set; }

        /// <summary>
        /// The sender internal identification.
        /// </summary>
        [Input("senderInternalIdentification")]
        public Input<string>? SenderInternalIdentification { get; set; }

        /// <summary>
        /// The sender internal sub identification.
        /// </summary>
        [Input("senderInternalSubIdentification")]
        public Input<string>? SenderInternalSubIdentification { get; set; }

        /// <summary>
        /// The sender reverse routing address.
        /// </summary>
        [Input("senderReverseRoutingAddress")]
        public Input<string>? SenderReverseRoutingAddress { get; set; }

        /// <summary>
        /// The transaction set control number lower bound.
        /// </summary>
        [Input("transactionSetControlNumberLowerBound")]
        public Input<double>? TransactionSetControlNumberLowerBound { get; set; }

        /// <summary>
        /// The transaction set control number prefix.
        /// </summary>
        [Input("transactionSetControlNumberPrefix")]
        public Input<string>? TransactionSetControlNumberPrefix { get; set; }

        /// <summary>
        /// The transaction set control number suffix.
        /// </summary>
        [Input("transactionSetControlNumberSuffix")]
        public Input<string>? TransactionSetControlNumberSuffix { get; set; }

        /// <summary>
        /// The transaction set control number upper bound.
        /// </summary>
        [Input("transactionSetControlNumberUpperBound")]
        public Input<double>? TransactionSetControlNumberUpperBound { get; set; }

        public EdifactEnvelopeSettingsArgs()
        {
        }
    }
}
