using Microsoft.Xna.Framework.Input;
using StardewModdingAPI;

namespace MonsterFurnitureDrop
{
    public sealed class ModConfig
    {
        public float GlobalDropChance { get; set; }

        public int DefaultItemDropRate { get; set; }

        public float DefaultMonsterDropRate { get; set; }

        public bool RemoveFurnitureCatalogue { get; set; }

        public bool LogDropMessages { get; set; }

        public Dictionary<string, int> ItemDropRates { get; set; } = new();

        public Dictionary<string, float> MonsterDropRates { get; set; } = new();

        public ModConfig()
        {
            ResetToDefaults();
        }

        public void ResetToDefaults()
        {
            GlobalDropChance = 0.01f;
            RemoveFurnitureCatalogue = true;
            LogDropMessages = false;

            foreach (var entry in ItemDropRates)
                ItemDropRates[entry.Key] = DefaultItemDropRate;

            foreach (var entry in MonsterDropRates)
                MonsterDropRates[entry.Key] = DefaultMonsterDropRate;
        }
    }
}
