using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;

namespace UsefulVanity
{
    public class UsefulVanityGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item Item)
        {
        }
		
        public override void UpdateEquip (Item Item, Player Player)
        {
		//Global Vanity effects.
            if(Item.vanity == true && UsefulVanityConfig.Instance.enableVanityBonuses)
            {
				Player.moveSpeed += UsefulVanityConfig.Instance.bonusMoveSpeed;
				Player.GetAttackSpeed(DamageClass.Melee) += UsefulVanityConfig.Instance.bonusMeleeSpeed;
				Player.GetDamage(DamageClass.Generic) += UsefulVanityConfig.Instance.bonusDamage;
				Player.lifeRegen += UsefulVanityConfig.Instance.bonusLifeRegen;
				Player.maxMinions += UsefulVanityConfig.Instance.bonusMaxMinions;
				Player.maxTurrets += UsefulVanityConfig.Instance.bonusMaxTurrets;
            }
			
		//Set-specific effects.
			//Gravedigger set.
			if (UsefulVanityConfig.Instance.enableVanityBonusesGravedigger)
			{
				if(Item.type == ItemID.UndertakerCoat)
				{
					Player.GetDamage(DamageClass.Melee) += 0.20f;
				}
				if(Item.type == ItemID.UndertakerHat)
				{
					Player.GetDamage(DamageClass.Melee) += 0.15f;
				}
			}
			//Funeral set.
			if (UsefulVanityConfig.Instance.enableVanityBonusesFuneral)
			{
				if(Item.type == ItemID.FuneralPants)
				{
					Player.GetDamage(DamageClass.Ranged) += 0.10f;
				}
				if(Item.type == ItemID.FuneralCoat)
				{
					Player.GetDamage(DamageClass.Ranged) += 0.20f;
				}
				if(Item.type == ItemID.FuneralHat)
				{
					Player.GetDamage(DamageClass.Ranged) += 0.05f;
				}
			}
        }
		
		public override void ModifyTooltips(Item Item, List<TooltipLine> tooltips)
		{
		//Global Vanity effects.
			if (Item.vanity == true && UsefulVanityConfig.Instance.enableVanityBonuses)
			{
				var line = new TooltipLine(Mod, "UsefulVanity:IsVanity", "Grants certain bonuses to most stats.");
				tooltips.Add(line);
			}
			
		//Set-specific effects.
			//Gravedigger set.
			if (UsefulVanityConfig.Instance.enableVanityBonusesGravedigger)
			{
				if (Item.type == ItemID.UndertakerCoat)
				{
					var line = new TooltipLine(Mod, "UsefulVanity:GravediggerCoat", "+20% Melee damage.");
					tooltips.Add(line);
				}
				if (Item.type == ItemID.UndertakerHat)
				{
					var line = new TooltipLine(Mod, "UsefulVanity:GravediggerCoat", "+15% Melee damage.");
					tooltips.Add(line);
				}
			}
			//Funeral set.
			if (UsefulVanityConfig.Instance.enableVanityBonusesFuneral)
			{
				if (Item.type == ItemID.FuneralPants)
				{
					var line = new TooltipLine(Mod, "UsefulVanity:FuneralPants", "+10% Ranged damage.");
					tooltips.Add(line);
				}
				if (Item.type == ItemID.FuneralCoat)
				{
					var line = new TooltipLine(Mod, "UsefulVanity:FuneralPants", "+20% Ranged damage.");
					tooltips.Add(line);
				}
				if (Item.type == ItemID.FuneralHat)
				{
					var line = new TooltipLine(Mod, "UsefulVanity:FuneralPants", "+5% Ranged damage.");
					tooltips.Add(line);
				}
			}
		}
	}
}