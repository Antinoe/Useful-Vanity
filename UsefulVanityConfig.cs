using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace UsefulVanity
{
    [Label("Server Config")]
    public class UsefulVanityConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static UsefulVanityConfig Instance;
		
        [Header("Global Vanity Bonuses")]
		
        [Label("Enable Vanity Bonuses")]
        [Tooltip("If false, Players will not gain global bonuses from vanity.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableVanityBonuses {get; set;}
		
        [Label("Bonus Movement Speed")]
        [Tooltip("The Movement Speed bonus gained from Vanity.\n[Default: 0.10]")]
        [Slider]
        [DefaultValue(0.10f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float bonusMoveSpeed {get; set;}
		
        [Label("Bonus Melee Speed")]
        [Tooltip("The Melee Speed bonus gained from Vanity.\n[Default: 0.05]")]
        [Slider]
        [DefaultValue(0.05f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float bonusMeleeSpeed {get; set;}
		
        [Label("Bonus Damage")]
        [Tooltip("The Damage bonus gained from Vanity.\n[Default: 0.05]")]
        [Slider]
        [DefaultValue(0.05f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float bonusDamage {get; set;}
		
        [Label("Bonus Life Regeneration")]
        [Tooltip("The Life Regeneration bonus gained from Vanity.\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int bonusLifeRegen {get; set;}
		
        [Label("Bonus Max Minions")]
        [Tooltip("The amount of extra Minions gained from Vanity.\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int bonusMaxMinions {get; set;}
		
        [Label("Bonus Max Sentries")]
        [Tooltip("The amount of extra Sentries gained from Vanity.\n[Default: 1]")]
        [Slider]
        [DefaultValue(1)]
        [Range(0, 10)]
        [Increment(1)]
        public int bonusMaxTurrets {get; set;}
		
        [Header("Item-specific Vanity Bonuses")]
		
        [Label("Enable Gravedigger Set Bonuses")]
        [Tooltip("If false, Players will not gain the Gravedigger set's bonuses.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableVanityBonusesGravedigger {get; set;}
		
        [Label("Enable Funeral Set Bonuses")]
        [Tooltip("If false, Players will not gain the Funeral set's bonuses.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableVanityBonusesFuneral {get; set;}
    }
}