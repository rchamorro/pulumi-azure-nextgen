// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNextGen.AzureStack.V20200601Preview
{
    /// <summary>
    /// Location of the resource.
    /// </summary>
    [EnumType]
    public readonly struct Location : IEquatable<Location>
    {
        private readonly string _value;

        private Location(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Location @Global { get; } = new Location("global");

        public static bool operator ==(Location left, Location right) => left.Equals(right);
        public static bool operator !=(Location left, Location right) => !left.Equals(right);

        public static explicit operator string(Location value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Location other && Equals(other);
        public bool Equals(Location other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
