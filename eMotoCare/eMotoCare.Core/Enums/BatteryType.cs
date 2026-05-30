namespace eMotoCare.Core.Enums
{
    public enum BatteryType
    {
        LEAD_ACID = 1,             // Ắc quy chì
        AGM = 2,                   // Absorbent Glass Mat
        GEL = 3,                   // Gel Battery
        NMC = 4,                   // Lithium Nickel Manganese Cobalt
        LFP = 5,                   // Lithium Iron Phosphate
        NCA = 6,                   // Lithium Nickel Cobalt Aluminum
        LTO = 7,                   // Lithium Titanate
        SOLID_STATE = 8,           // Pin thể rắn
        SWAPPABLE_LFP = 9,         // Pin LFP đổi pin
        OTHER = 99
    }
}