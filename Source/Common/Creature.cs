namespace RPG;

// A Class to be inherited from. Creatures are units stats.
public partial class Creature : Node
{
    // Stats are objects that can be dynamically constructed and set!
    protected Dictionary<string, Stat> Stats;
    protected List<EquipSlot> Slots;
    protected string CreatureName;
    protected float Experience;

    // Enemies and Players can be assigned a job.
    JobSystem Job;

    // Can be used for UI in 3D games, or 2d games can be used for general world stuffs
    Sprite2D sprite;

    public override void _Ready()
    {
    }

    public void CreateWeaponSlots()
    {
        Slots ??= new List<EquipSlot>();
        for (int i = 0; i < 5; i++)
        {
            Slots.Add(new EquipSlot((SlotType)i));
        }
    }

    public override void _Process(double delta)
    {
    }
}
