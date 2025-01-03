// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt
using Robust.Shared.Serialization;

namespace Content.Shared.SS220.SuperMatter.Ui;

[Serializable, NetSerializable]
public enum SuperMatterEmitterExtensionUiKey : byte
{
    Key
}

/// <summary>
/// This event raise to give users information about server's component values after its flatting.
/// </summary>
[Serializable, NetSerializable]
public sealed class SuperMatterEmitterExtensionUpdate(int power, int ratio) : BoundUserInterfaceState
{
    public int PowerConsumption { get; } = power;
    public int EnergyToMatterRatio { get; } = ratio;
}


/// <summary>
/// This event raised when user applied changes in emitter interface
/// </summary>
[Serializable, NetSerializable]
public sealed class SuperMatterEmitterExtensionValueMessage(int power, int ratio) : BoundUserInterfaceMessage
{
    public int PowerConsumption = power;
    public int EnergyToMatterRatio = ratio;
}

[Serializable, NetSerializable]
public sealed class SuperMatterEmitterExtensionEmitterActivateMessage() : BoundUserInterfaceMessage { }
