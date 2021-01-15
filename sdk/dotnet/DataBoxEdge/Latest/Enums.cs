// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNextGen.DataBoxEdge.Latest
{
    /// <summary>
    /// Type of storage accessed on the storage account.
    /// </summary>
    [EnumType]
    public readonly struct AccountType : IEquatable<AccountType>
    {
        private readonly string _value;

        private AccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static AccountType GeneralPurposeStorage { get; } = new AccountType("GeneralPurposeStorage");
        public static AccountType BlobStorage { get; } = new AccountType("BlobStorage");

        public static bool operator ==(AccountType left, AccountType right) => left.Equals(right);
        public static bool operator !=(AccountType left, AccountType right) => !left.Equals(right);

        public static explicit operator string(AccountType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AccountType other && Equals(other);
        public bool Equals(AccountType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Addon type.
    /// </summary>
    [EnumType]
    public readonly struct AddonType : IEquatable<AddonType>
    {
        private readonly string _value;

        private AddonType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static AddonType IotEdge { get; } = new AddonType("IotEdge");
        public static AddonType ArcForKubernetes { get; } = new AddonType("ArcForKubernetes");

        public static bool operator ==(AddonType left, AddonType right) => left.Equals(right);
        public static bool operator !=(AddonType left, AddonType right) => !left.Equals(right);

        public static explicit operator string(AddonType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AddonType other && Equals(other);
        public bool Equals(AddonType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Storage format used for the file represented by the share.
    /// </summary>
    [EnumType]
    public readonly struct AzureContainerDataFormat : IEquatable<AzureContainerDataFormat>
    {
        private readonly string _value;

        private AzureContainerDataFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static AzureContainerDataFormat BlockBlob { get; } = new AzureContainerDataFormat("BlockBlob");
        public static AzureContainerDataFormat PageBlob { get; } = new AzureContainerDataFormat("PageBlob");
        public static AzureContainerDataFormat AzureFile { get; } = new AzureContainerDataFormat("AzureFile");

        public static bool operator ==(AzureContainerDataFormat left, AzureContainerDataFormat right) => left.Equals(right);
        public static bool operator !=(AzureContainerDataFormat left, AzureContainerDataFormat right) => !left.Equals(right);

        public static explicit operator string(AzureContainerDataFormat value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is AzureContainerDataFormat other && Equals(other);
        public bool Equals(AzureContainerDataFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of access to be allowed for the client.
    /// </summary>
    [EnumType]
    public readonly struct ClientPermissionType : IEquatable<ClientPermissionType>
    {
        private readonly string _value;

        private ClientPermissionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ClientPermissionType NoAccess { get; } = new ClientPermissionType("NoAccess");
        public static ClientPermissionType ReadOnly { get; } = new ClientPermissionType("ReadOnly");
        public static ClientPermissionType ReadWrite { get; } = new ClientPermissionType("ReadWrite");

        public static bool operator ==(ClientPermissionType left, ClientPermissionType right) => left.Equals(right);
        public static bool operator !=(ClientPermissionType left, ClientPermissionType right) => !left.Equals(right);

        public static explicit operator string(ClientPermissionType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ClientPermissionType other && Equals(other);
        public bool Equals(ClientPermissionType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The etag for the devices.
    /// </summary>
    [EnumType]
    public readonly struct DataBoxEdgeDeviceKind : IEquatable<DataBoxEdgeDeviceKind>
    {
        private readonly string _value;

        private DataBoxEdgeDeviceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DataBoxEdgeDeviceKind AzureDataBoxGateway { get; } = new DataBoxEdgeDeviceKind("AzureDataBoxGateway");
        public static DataBoxEdgeDeviceKind AzureStackEdge { get; } = new DataBoxEdgeDeviceKind("AzureStackEdge");
        public static DataBoxEdgeDeviceKind AzureStackHub { get; } = new DataBoxEdgeDeviceKind("AzureStackHub");
        public static DataBoxEdgeDeviceKind AzureModularDataCentre { get; } = new DataBoxEdgeDeviceKind("AzureModularDataCentre");

        public static bool operator ==(DataBoxEdgeDeviceKind left, DataBoxEdgeDeviceKind right) => left.Equals(right);
        public static bool operator !=(DataBoxEdgeDeviceKind left, DataBoxEdgeDeviceKind right) => !left.Equals(right);

        public static explicit operator string(DataBoxEdgeDeviceKind value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DataBoxEdgeDeviceKind other && Equals(other);
        public bool Equals(DataBoxEdgeDeviceKind other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The status of the Data Box Edge/Gateway device.
    /// </summary>
    [EnumType]
    public readonly struct DataBoxEdgeDeviceStatus : IEquatable<DataBoxEdgeDeviceStatus>
    {
        private readonly string _value;

        private DataBoxEdgeDeviceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DataBoxEdgeDeviceStatus ReadyToSetup { get; } = new DataBoxEdgeDeviceStatus("ReadyToSetup");
        public static DataBoxEdgeDeviceStatus Online { get; } = new DataBoxEdgeDeviceStatus("Online");
        public static DataBoxEdgeDeviceStatus Offline { get; } = new DataBoxEdgeDeviceStatus("Offline");
        public static DataBoxEdgeDeviceStatus NeedsAttention { get; } = new DataBoxEdgeDeviceStatus("NeedsAttention");
        public static DataBoxEdgeDeviceStatus Disconnected { get; } = new DataBoxEdgeDeviceStatus("Disconnected");
        public static DataBoxEdgeDeviceStatus PartiallyDisconnected { get; } = new DataBoxEdgeDeviceStatus("PartiallyDisconnected");
        public static DataBoxEdgeDeviceStatus Maintenance { get; } = new DataBoxEdgeDeviceStatus("Maintenance");

        public static bool operator ==(DataBoxEdgeDeviceStatus left, DataBoxEdgeDeviceStatus right) => left.Equals(right);
        public static bool operator !=(DataBoxEdgeDeviceStatus left, DataBoxEdgeDeviceStatus right) => !left.Equals(right);

        public static explicit operator string(DataBoxEdgeDeviceStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DataBoxEdgeDeviceStatus other && Equals(other);
        public bool Equals(DataBoxEdgeDeviceStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Data policy of the storage Account.
    /// </summary>
    [EnumType]
    public readonly struct DataPolicy : IEquatable<DataPolicy>
    {
        private readonly string _value;

        private DataPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DataPolicy Cloud { get; } = new DataPolicy("Cloud");
        public static DataPolicy Local { get; } = new DataPolicy("Local");

        public static bool operator ==(DataPolicy left, DataPolicy right) => left.Equals(right);
        public static bool operator !=(DataPolicy left, DataPolicy right) => !left.Equals(right);

        public static explicit operator string(DataPolicy value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DataPolicy other && Equals(other);
        public bool Equals(DataPolicy other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct DayOfWeek : IEquatable<DayOfWeek>
    {
        private readonly string _value;

        private DayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DayOfWeek Sunday { get; } = new DayOfWeek("Sunday");
        public static DayOfWeek Monday { get; } = new DayOfWeek("Monday");
        public static DayOfWeek Tuesday { get; } = new DayOfWeek("Tuesday");
        public static DayOfWeek Wednesday { get; } = new DayOfWeek("Wednesday");
        public static DayOfWeek Thursday { get; } = new DayOfWeek("Thursday");
        public static DayOfWeek Friday { get; } = new DayOfWeek("Friday");
        public static DayOfWeek Saturday { get; } = new DayOfWeek("Saturday");

        public static bool operator ==(DayOfWeek left, DayOfWeek right) => left.Equals(right);
        public static bool operator !=(DayOfWeek left, DayOfWeek right) => !left.Equals(right);

        public static explicit operator string(DayOfWeek value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DayOfWeek other && Equals(other);
        public bool Equals(DayOfWeek other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The algorithm used to encrypt "Value".
    /// </summary>
    [EnumType]
    public readonly struct EncryptionAlgorithm : IEquatable<EncryptionAlgorithm>
    {
        private readonly string _value;

        private EncryptionAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static EncryptionAlgorithm None { get; } = new EncryptionAlgorithm("None");
        public static EncryptionAlgorithm AES256 { get; } = new EncryptionAlgorithm("AES256");
        public static EncryptionAlgorithm RSAES_PKCS1_v_1_5 { get; } = new EncryptionAlgorithm("RSAES_PKCS1_v_1_5");

        public static bool operator ==(EncryptionAlgorithm left, EncryptionAlgorithm right) => left.Equals(right);
        public static bool operator !=(EncryptionAlgorithm left, EncryptionAlgorithm right) => !left.Equals(right);

        public static explicit operator string(EncryptionAlgorithm value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EncryptionAlgorithm other && Equals(other);
        public bool Equals(EncryptionAlgorithm other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Current monitoring status of the share.
    /// </summary>
    [EnumType]
    public readonly struct MonitoringStatus : IEquatable<MonitoringStatus>
    {
        private readonly string _value;

        private MonitoringStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static MonitoringStatus Enabled { get; } = new MonitoringStatus("Enabled");
        public static MonitoringStatus Disabled { get; } = new MonitoringStatus("Disabled");

        public static bool operator ==(MonitoringStatus left, MonitoringStatus right) => left.Equals(right);
        public static bool operator !=(MonitoringStatus left, MonitoringStatus right) => !left.Equals(right);

        public static explicit operator string(MonitoringStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MonitoringStatus other && Equals(other);
        public bool Equals(MonitoringStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Identity type
    /// </summary>
    [EnumType]
    public readonly struct MsiIdentityType : IEquatable<MsiIdentityType>
    {
        private readonly string _value;

        private MsiIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static MsiIdentityType None { get; } = new MsiIdentityType("None");
        public static MsiIdentityType SystemAssigned { get; } = new MsiIdentityType("SystemAssigned");
        public static MsiIdentityType UserAssigned { get; } = new MsiIdentityType("UserAssigned");

        public static bool operator ==(MsiIdentityType left, MsiIdentityType right) => left.Equals(right);
        public static bool operator !=(MsiIdentityType left, MsiIdentityType right) => !left.Equals(right);

        public static explicit operator string(MsiIdentityType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is MsiIdentityType other && Equals(other);
        public bool Equals(MsiIdentityType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Status of the order as per the allowed status types.
    /// </summary>
    [EnumType]
    public readonly struct OrderState : IEquatable<OrderState>
    {
        private readonly string _value;

        private OrderState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static OrderState Untracked { get; } = new OrderState("Untracked");
        public static OrderState AwaitingFulfilment { get; } = new OrderState("AwaitingFulfilment");
        public static OrderState AwaitingPreparation { get; } = new OrderState("AwaitingPreparation");
        public static OrderState AwaitingShipment { get; } = new OrderState("AwaitingShipment");
        public static OrderState Shipped { get; } = new OrderState("Shipped");
        public static OrderState Arriving { get; } = new OrderState("Arriving");
        public static OrderState Delivered { get; } = new OrderState("Delivered");
        public static OrderState ReplacementRequested { get; } = new OrderState("ReplacementRequested");
        public static OrderState LostDevice { get; } = new OrderState("LostDevice");
        public static OrderState Declined { get; } = new OrderState("Declined");
        public static OrderState ReturnInitiated { get; } = new OrderState("ReturnInitiated");
        public static OrderState AwaitingReturnShipment { get; } = new OrderState("AwaitingReturnShipment");
        public static OrderState ShippedBack { get; } = new OrderState("ShippedBack");
        public static OrderState CollectedAtMicrosoft { get; } = new OrderState("CollectedAtMicrosoft");
        public static OrderState AwaitingPickup { get; } = new OrderState("AwaitingPickup");
        public static OrderState PickupCompleted { get; } = new OrderState("PickupCompleted");
        public static OrderState AwaitingDrop { get; } = new OrderState("AwaitingDrop");

        public static bool operator ==(OrderState left, OrderState right) => left.Equals(right);
        public static bool operator !=(OrderState left, OrderState right) => !left.Equals(right);

        public static explicit operator string(OrderState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is OrderState other && Equals(other);
        public bool Equals(OrderState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Denotes whether move operation is in progress
    /// </summary>
    [EnumType]
    public readonly struct ResourceMoveStatus : IEquatable<ResourceMoveStatus>
    {
        private readonly string _value;

        private ResourceMoveStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ResourceMoveStatus None { get; } = new ResourceMoveStatus("None");
        public static ResourceMoveStatus ResourceMoveInProgress { get; } = new ResourceMoveStatus("ResourceMoveInProgress");
        public static ResourceMoveStatus ResourceMoveFailed { get; } = new ResourceMoveStatus("ResourceMoveFailed");

        public static bool operator ==(ResourceMoveStatus left, ResourceMoveStatus right) => left.Equals(right);
        public static bool operator !=(ResourceMoveStatus left, ResourceMoveStatus right) => !left.Equals(right);

        public static explicit operator string(ResourceMoveStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ResourceMoveStatus other && Equals(other);
        public bool Equals(ResourceMoveStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Role type.
    /// </summary>
    [EnumType]
    public readonly struct RoleTypes : IEquatable<RoleTypes>
    {
        private readonly string _value;

        private RoleTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static RoleTypes IOT { get; } = new RoleTypes("IOT");
        public static RoleTypes ASA { get; } = new RoleTypes("ASA");
        public static RoleTypes Functions { get; } = new RoleTypes("Functions");
        public static RoleTypes Cognitive { get; } = new RoleTypes("Cognitive");
        public static RoleTypes MEC { get; } = new RoleTypes("MEC");
        public static RoleTypes CloudEdgeManagement { get; } = new RoleTypes("CloudEdgeManagement");
        public static RoleTypes Kubernetes { get; } = new RoleTypes("Kubernetes");

        public static bool operator ==(RoleTypes left, RoleTypes right) => left.Equals(right);
        public static bool operator !=(RoleTypes left, RoleTypes right) => !left.Equals(right);

        public static explicit operator string(RoleTypes value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RoleTypes other && Equals(other);
        public bool Equals(RoleTypes other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Signifies whether SSL needs to be enabled or not.
    /// </summary>
    [EnumType]
    public readonly struct SSLStatus : IEquatable<SSLStatus>
    {
        private readonly string _value;

        private SSLStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SSLStatus Enabled { get; } = new SSLStatus("Enabled");
        public static SSLStatus Disabled { get; } = new SSLStatus("Disabled");

        public static bool operator ==(SSLStatus left, SSLStatus right) => left.Equals(right);
        public static bool operator !=(SSLStatus left, SSLStatus right) => !left.Equals(right);

        public static explicit operator string(SSLStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SSLStatus other && Equals(other);
        public bool Equals(SSLStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Access protocol to be used by the share.
    /// </summary>
    [EnumType]
    public readonly struct ShareAccessProtocol : IEquatable<ShareAccessProtocol>
    {
        private readonly string _value;

        private ShareAccessProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ShareAccessProtocol SMB { get; } = new ShareAccessProtocol("SMB");
        public static ShareAccessProtocol NFS { get; } = new ShareAccessProtocol("NFS");

        public static bool operator ==(ShareAccessProtocol left, ShareAccessProtocol right) => left.Equals(right);
        public static bool operator !=(ShareAccessProtocol left, ShareAccessProtocol right) => !left.Equals(right);

        public static explicit operator string(ShareAccessProtocol value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ShareAccessProtocol other && Equals(other);
        public bool Equals(ShareAccessProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of access to be allowed for the user.
    /// </summary>
    [EnumType]
    public readonly struct ShareAccessType : IEquatable<ShareAccessType>
    {
        private readonly string _value;

        private ShareAccessType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ShareAccessType Change { get; } = new ShareAccessType("Change");
        public static ShareAccessType Read { get; } = new ShareAccessType("Read");
        public static ShareAccessType Custom { get; } = new ShareAccessType("Custom");

        public static bool operator ==(ShareAccessType left, ShareAccessType right) => left.Equals(right);
        public static bool operator !=(ShareAccessType left, ShareAccessType right) => !left.Equals(right);

        public static explicit operator string(ShareAccessType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ShareAccessType other && Equals(other);
        public bool Equals(ShareAccessType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Current status of the share.
    /// </summary>
    [EnumType]
    public readonly struct ShareStatus : IEquatable<ShareStatus>
    {
        private readonly string _value;

        private ShareStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ShareStatus Offline { get; } = new ShareStatus("Offline");
        public static ShareStatus Unknown { get; } = new ShareStatus("Unknown");
        public static ShareStatus OK { get; } = new ShareStatus("OK");
        public static ShareStatus Updating { get; } = new ShareStatus("Updating");
        public static ShareStatus NeedsAttention { get; } = new ShareStatus("NeedsAttention");

        public static bool operator ==(ShareStatus left, ShareStatus right) => left.Equals(right);
        public static bool operator !=(ShareStatus left, ShareStatus right) => !left.Equals(right);

        public static explicit operator string(ShareStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ShareStatus other && Equals(other);
        public bool Equals(ShareStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// ShipmentType of the order
    /// </summary>
    [EnumType]
    public readonly struct ShipmentType : IEquatable<ShipmentType>
    {
        private readonly string _value;

        private ShipmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ShipmentType NotApplicable { get; } = new ShipmentType("NotApplicable");
        public static ShipmentType ShippedToCustomer { get; } = new ShipmentType("ShippedToCustomer");
        public static ShipmentType SelfPickup { get; } = new ShipmentType("SelfPickup");

        public static bool operator ==(ShipmentType left, ShipmentType right) => left.Equals(right);
        public static bool operator !=(ShipmentType left, ShipmentType right) => !left.Equals(right);

        public static explicit operator string(ShipmentType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ShipmentType other && Equals(other);
        public bool Equals(ShipmentType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// SKU name.
    /// </summary>
    [EnumType]
    public readonly struct SkuName : IEquatable<SkuName>
    {
        private readonly string _value;

        private SkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SkuName Gateway { get; } = new SkuName("Gateway");
        public static SkuName Edge { get; } = new SkuName("Edge");
        public static SkuName TEA_1Node { get; } = new SkuName("TEA_1Node");
        public static SkuName TEA_1Node_UPS { get; } = new SkuName("TEA_1Node_UPS");
        public static SkuName TEA_1Node_Heater { get; } = new SkuName("TEA_1Node_Heater");
        public static SkuName TEA_1Node_UPS_Heater { get; } = new SkuName("TEA_1Node_UPS_Heater");
        public static SkuName TEA_4Node_Heater { get; } = new SkuName("TEA_4Node_Heater");
        public static SkuName TEA_4Node_UPS_Heater { get; } = new SkuName("TEA_4Node_UPS_Heater");
        public static SkuName TMA { get; } = new SkuName("TMA");
        public static SkuName TDC { get; } = new SkuName("TDC");
        public static SkuName TCA_Small { get; } = new SkuName("TCA_Small");
        public static SkuName GPU { get; } = new SkuName("GPU");
        public static SkuName TCA_Large { get; } = new SkuName("TCA_Large");
        public static SkuName EdgeP_Base { get; } = new SkuName("EdgeP_Base");
        public static SkuName EdgeP_High { get; } = new SkuName("EdgeP_High");
        public static SkuName EdgePR_Base { get; } = new SkuName("EdgePR_Base");
        public static SkuName EdgePR_Base_UPS { get; } = new SkuName("EdgePR_Base_UPS");
        public static SkuName EdgeMR_Mini { get; } = new SkuName("EdgeMR_Mini");
        public static SkuName RCA_Small { get; } = new SkuName("RCA_Small");
        public static SkuName RCA_Large { get; } = new SkuName("RCA_Large");
        public static SkuName RDC { get; } = new SkuName("RDC");

        public static bool operator ==(SkuName left, SkuName right) => left.Equals(right);
        public static bool operator !=(SkuName left, SkuName right) => !left.Equals(right);

        public static explicit operator string(SkuName value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SkuName other && Equals(other);
        public bool Equals(SkuName other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The SKU tier. This is based on the SKU name.
    /// </summary>
    [EnumType]
    public readonly struct SkuTier : IEquatable<SkuTier>
    {
        private readonly string _value;

        private SkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SkuTier Standard { get; } = new SkuTier("Standard");

        public static bool operator ==(SkuTier left, SkuTier right) => left.Equals(right);
        public static bool operator !=(SkuTier left, SkuTier right) => !left.Equals(right);

        public static explicit operator string(SkuTier value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SkuTier other && Equals(other);
        public bool Equals(SkuTier other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Current status of the storage account
    /// </summary>
    [EnumType]
    public readonly struct StorageAccountStatus : IEquatable<StorageAccountStatus>
    {
        private readonly string _value;

        private StorageAccountStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static StorageAccountStatus OK { get; } = new StorageAccountStatus("OK");
        public static StorageAccountStatus Offline { get; } = new StorageAccountStatus("Offline");
        public static StorageAccountStatus Unknown { get; } = new StorageAccountStatus("Unknown");
        public static StorageAccountStatus Updating { get; } = new StorageAccountStatus("Updating");
        public static StorageAccountStatus NeedsAttention { get; } = new StorageAccountStatus("NeedsAttention");

        public static bool operator ==(StorageAccountStatus left, StorageAccountStatus right) => left.Equals(right);
        public static bool operator !=(StorageAccountStatus left, StorageAccountStatus right) => !left.Equals(right);

        public static explicit operator string(StorageAccountStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is StorageAccountStatus other && Equals(other);
        public bool Equals(StorageAccountStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct SubscriptionState : IEquatable<SubscriptionState>
    {
        private readonly string _value;

        private SubscriptionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SubscriptionState Registered { get; } = new SubscriptionState("Registered");
        public static SubscriptionState Warned { get; } = new SubscriptionState("Warned");
        public static SubscriptionState Suspended { get; } = new SubscriptionState("Suspended");
        public static SubscriptionState Deleted { get; } = new SubscriptionState("Deleted");
        public static SubscriptionState Unregistered { get; } = new SubscriptionState("Unregistered");

        public static bool operator ==(SubscriptionState left, SubscriptionState right) => left.Equals(right);
        public static bool operator !=(SubscriptionState left, SubscriptionState right) => !left.Equals(right);

        public static explicit operator string(SubscriptionState value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SubscriptionState other && Equals(other);
        public bool Equals(SubscriptionState other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Trigger Kind.
    /// </summary>
    [EnumType]
    public readonly struct TriggerEventType : IEquatable<TriggerEventType>
    {
        private readonly string _value;

        private TriggerEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static TriggerEventType FileEvent { get; } = new TriggerEventType("FileEvent");
        public static TriggerEventType PeriodicTimerEvent { get; } = new TriggerEventType("PeriodicTimerEvent");

        public static bool operator ==(TriggerEventType left, TriggerEventType right) => left.Equals(right);
        public static bool operator !=(TriggerEventType left, TriggerEventType right) => !left.Equals(right);

        public static explicit operator string(TriggerEventType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is TriggerEventType other && Equals(other);
        public bool Equals(TriggerEventType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of the user.
    /// </summary>
    [EnumType]
    public readonly struct UserType : IEquatable<UserType>
    {
        private readonly string _value;

        private UserType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static UserType Share { get; } = new UserType("Share");
        public static UserType LocalManagement { get; } = new UserType("LocalManagement");
        public static UserType ARM { get; } = new UserType("ARM");

        public static bool operator ==(UserType left, UserType right) => left.Equals(right);
        public static bool operator !=(UserType left, UserType right) => !left.Equals(right);

        public static explicit operator string(UserType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is UserType other && Equals(other);
        public bool Equals(UserType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
