// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class TextFormatResponse
    {
        /// <summary>
        /// The column delimiter. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ColumnDelimiter;
        /// <summary>
        /// Deserializer. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Deserializer;
        /// <summary>
        /// The code page name of the preferred encoding. If miss, the default value is ΓÇ£utf-8ΓÇ¥, unless BOM denotes another Unicode encoding. Refer to the ΓÇ£NameΓÇ¥ column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncodingName;
        /// <summary>
        /// The escape character. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EscapeChar;
        /// <summary>
        /// When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? FirstRowAsHeader;
        /// <summary>
        /// The null value string. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? NullValue;
        /// <summary>
        /// The quote character. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? QuoteChar;
        /// <summary>
        /// The row delimiter. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? RowDelimiter;
        /// <summary>
        /// Serializer. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Serializer;
        /// <summary>
        /// The number of lines/rows to be skipped when parsing text files. The default value is 0. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SkipLineCount;
        /// <summary>
        /// Treat empty column values in the text file as null. The default value is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? TreatEmptyAsNull;
        /// <summary>
        /// Type of dataset storage format.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private TextFormatResponse(
            object? columnDelimiter,

            object? deserializer,

            object? encodingName,

            object? escapeChar,

            object? firstRowAsHeader,

            object? nullValue,

            object? quoteChar,

            object? rowDelimiter,

            object? serializer,

            object? skipLineCount,

            object? treatEmptyAsNull,

            string type)
        {
            ColumnDelimiter = columnDelimiter;
            Deserializer = deserializer;
            EncodingName = encodingName;
            EscapeChar = escapeChar;
            FirstRowAsHeader = firstRowAsHeader;
            NullValue = nullValue;
            QuoteChar = quoteChar;
            RowDelimiter = rowDelimiter;
            Serializer = serializer;
            SkipLineCount = skipLineCount;
            TreatEmptyAsNull = treatEmptyAsNull;
            Type = type;
        }
    }
}
