// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview.Outputs
{

    [OutputType]
    public sealed class MongoDbCollectionProgressResponse
    {
        /// <summary>
        /// The number of document bytes copied during the Copying stage
        /// </summary>
        public readonly int BytesCopied;
        /// <summary>
        /// The number of documents copied during the Copying stage
        /// </summary>
        public readonly int DocumentsCopied;
        /// <summary>
        /// The elapsed time in the format [ddd.]hh:mm:ss[.fffffff] (i.e. TimeSpan format)
        /// </summary>
        public readonly string ElapsedTime;
        /// <summary>
        /// The errors and warnings that have occurred for the current object. The keys are the error codes.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.MongoDbErrorResponse> Errors;
        /// <summary>
        /// The number of oplog events awaiting replay
        /// </summary>
        public readonly int EventsPending;
        /// <summary>
        /// The number of oplog events replayed so far
        /// </summary>
        public readonly int EventsReplayed;
        /// <summary>
        /// The timestamp of the last oplog event received, or null if no oplog event has been received yet
        /// </summary>
        public readonly string? LastEventTime;
        /// <summary>
        /// The timestamp of the last oplog event replayed, or null if no oplog event has been replayed yet
        /// </summary>
        public readonly string? LastReplayTime;
        /// <summary>
        /// The name of the progress object. For a collection, this is the unqualified collection name. For a database, this is the database name. For the overall migration, this is null.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The qualified name of the progress object. For a collection, this is the database-qualified name. For a database, this is the database name. For the overall migration, this is null.
        /// </summary>
        public readonly string? QualifiedName;
        /// <summary>
        /// The type of progress object
        /// Expected value is 'Collection'.
        /// </summary>
        public readonly string ResultType;
        public readonly string State;
        /// <summary>
        /// The total number of document bytes on the source at the beginning of the Copying stage, or -1 if the total size was unknown
        /// </summary>
        public readonly int TotalBytes;
        /// <summary>
        /// The total number of documents on the source at the beginning of the Copying stage, or -1 if the total count was unknown
        /// </summary>
        public readonly int TotalDocuments;

        [OutputConstructor]
        private MongoDbCollectionProgressResponse(
            int bytesCopied,

            int documentsCopied,

            string elapsedTime,

            ImmutableDictionary<string, Outputs.MongoDbErrorResponse> errors,

            int eventsPending,

            int eventsReplayed,

            string? lastEventTime,

            string? lastReplayTime,

            string? name,

            string? qualifiedName,

            string resultType,

            string state,

            int totalBytes,

            int totalDocuments)
        {
            BytesCopied = bytesCopied;
            DocumentsCopied = documentsCopied;
            ElapsedTime = elapsedTime;
            Errors = errors;
            EventsPending = eventsPending;
            EventsReplayed = eventsReplayed;
            LastEventTime = lastEventTime;
            LastReplayTime = lastReplayTime;
            Name = name;
            QualifiedName = qualifiedName;
            ResultType = resultType;
            State = state;
            TotalBytes = totalBytes;
            TotalDocuments = totalDocuments;
        }
    }
}
