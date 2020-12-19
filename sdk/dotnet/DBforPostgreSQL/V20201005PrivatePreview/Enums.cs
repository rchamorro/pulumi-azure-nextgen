// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNextGen.DBforPostgreSQL.V20201005PrivatePreview
{
    /// <summary>
    /// The Citus version of server group.
    /// </summary>
    [EnumType]
    public readonly struct CitusVersion : IEquatable<CitusVersion>
    {
        private readonly string _value;

        private CitusVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static CitusVersion CitusVersion_8_3 { get; } = new CitusVersion("8.3");
        public static CitusVersion CitusVersion_9_0 { get; } = new CitusVersion("9.0");
        public static CitusVersion CitusVersion_9_1 { get; } = new CitusVersion("9.1");
        public static CitusVersion CitusVersion_9_2 { get; } = new CitusVersion("9.2");
        public static CitusVersion CitusVersion_9_3 { get; } = new CitusVersion("9.3");
        public static CitusVersion CitusVersion_9_4 { get; } = new CitusVersion("9.4");
        public static CitusVersion CitusVersion_9_5 { get; } = new CitusVersion("9.5");

        public static bool operator ==(CitusVersion left, CitusVersion right) => left.Equals(right);
        public static bool operator !=(CitusVersion left, CitusVersion right) => !left.Equals(right);

        public static explicit operator string(CitusVersion value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is CitusVersion other && Equals(other);
        public bool Equals(CitusVersion other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The mode to create a new server group.
    /// </summary>
    [EnumType]
    public readonly struct CreateMode : IEquatable<CreateMode>
    {
        private readonly string _value;

        private CreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static CreateMode Default { get; } = new CreateMode("Default");
        public static CreateMode PointInTimeRestore { get; } = new CreateMode("PointInTimeRestore");

        public static bool operator ==(CreateMode left, CreateMode right) => left.Equals(right);
        public static bool operator !=(CreateMode left, CreateMode right) => !left.Equals(right);

        public static explicit operator string(CreateMode value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is CreateMode other && Equals(other);
        public bool Equals(CreateMode other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The PostgreSQL version of server group.
    /// </summary>
    [EnumType]
    public readonly struct PostgreSQLVersion : IEquatable<PostgreSQLVersion>
    {
        private readonly string _value;

        private PostgreSQLVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static PostgreSQLVersion PostgreSQLVersion_11 { get; } = new PostgreSQLVersion("11");
        public static PostgreSQLVersion PostgreSQLVersion_12 { get; } = new PostgreSQLVersion("12");

        public static bool operator ==(PostgreSQLVersion left, PostgreSQLVersion right) => left.Equals(right);
        public static bool operator !=(PostgreSQLVersion left, PostgreSQLVersion right) => !left.Equals(right);

        public static explicit operator string(PostgreSQLVersion value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is PostgreSQLVersion other && Equals(other);
        public bool Equals(PostgreSQLVersion other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The edition of a server (default: GeneralPurpose).
    /// </summary>
    [EnumType]
    public readonly struct ServerEdition : IEquatable<ServerEdition>
    {
        private readonly string _value;

        private ServerEdition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ServerEdition GeneralPurpose { get; } = new ServerEdition("GeneralPurpose");
        public static ServerEdition MemoryOptimized { get; } = new ServerEdition("MemoryOptimized");

        public static bool operator ==(ServerEdition left, ServerEdition right) => left.Equals(right);
        public static bool operator !=(ServerEdition left, ServerEdition right) => !left.Equals(right);

        public static explicit operator string(ServerEdition value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ServerEdition other && Equals(other);
        public bool Equals(ServerEdition other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The role of servers in the server role group.
    /// </summary>
    [EnumType]
    public readonly struct ServerRole : IEquatable<ServerRole>
    {
        private readonly string _value;

        private ServerRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ServerRole Coordinator { get; } = new ServerRole("Coordinator");
        public static ServerRole Worker { get; } = new ServerRole("Worker");

        public static bool operator ==(ServerRole left, ServerRole right) => left.Equals(right);
        public static bool operator !=(ServerRole left, ServerRole right) => !left.Equals(right);

        public static explicit operator string(ServerRole value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ServerRole other && Equals(other);
        public bool Equals(ServerRole other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
