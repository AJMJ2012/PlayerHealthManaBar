using Terraria.ModLoader;
using Terraria;

namespace PlayerHealthManaBar {
	public class PlayerHealthManaBar : Mod {
		public override void Load() {
			if (Main.netMode == 2) { return; }
			On.Terraria.Main.DrawInterface_14_EntityHealthBars += (DrawInterface_14_EntityHealthBars, instance) => {
				DrawInterface_14_EntityHealthBars(instance);
				Player player = Main.player[Main.myPlayer];
				if (player.active && !player.ghost && !player.dead) {
					if (Main.HealthBarDrawSettings == 1) {
						int num9 = 0;
						if (player.statLife < player.statLifeMax2 - 1) {
							num9 += 10;
							UI.DrawHealthBar(player.position.X + (float)(player.width / 2), player.position.Y + (float)player.height + (float)num9 + player.gfxOffY, player.statLife, player.statLifeMax2, 1f);
						}
						if (player.statMana < player.statManaMax2 - 1) {
							num9 += 10;
							UI.DrawManaBar(player.position.X + (float)(player.width / 2), player.position.Y + (float)player.height + (float)num9 + player.gfxOffY, player.statMana, player.statManaMax2, 1f);
						}
					}
					else if (Main.HealthBarDrawSettings == 2) {
						int num10 = -10;
						if (player.statLife < player.statLifeMax2 - 1) {
							num10 -= 10;
							UI.DrawHealthBar(player.position.X + (float)(player.width / 2), player.position.Y + (float)num10 + player.gfxOffY, player.statLife, player.statLifeMax2, 1f);
						}
						if (player.statMana < player.statManaMax2 - 1) {
							num10 -= 10;
							UI.DrawManaBar(player.position.X + (float)(player.width / 2), player.position.Y + (float)num10 + player.gfxOffY, player.statMana, player.statManaMax2, 1f);
						}
					}
				}
			};
		}
	}
}