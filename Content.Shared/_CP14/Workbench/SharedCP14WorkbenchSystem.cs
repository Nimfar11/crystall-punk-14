using Content.Shared._CP14.Workbench.Prototypes;
using Content.Shared.DoAfter;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared._CP14.Workbench;

public class SharedCP14WorkbenchSystem : EntitySystem
{
}

[Serializable, NetSerializable]
public sealed partial class CP14CraftDoAfterEvent : DoAfterEvent
{
    [DataField(required: true)]
    public ProtoId<CP14WorkbenchRecipePrototype> Recipe = default!;

    public override DoAfterEvent Clone() => this;
}