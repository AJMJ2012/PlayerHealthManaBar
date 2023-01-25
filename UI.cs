using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.GameContent;
using Terraria;

namespace PlayerHealthManaBar {
	public static class UI {
		public static void DrawHealthBar(float X, float Y, int Health, int MaxHealth, float alpha, float scale = 1f, bool noFlip = false)
		{
			if (Health <= 0)
			{
				return;
			}
			float num = (float)Health / (float)MaxHealth;
			if (num > 1f)
			{
				num = 1f;
			}
			int num2 = (int)(36f * num);
			float num3 = X - 18f * scale;
			float num4 = Y;
			if (Main.player[Main.myPlayer].gravDir == -1f && !noFlip)
			{
				num4 -= Main.screenPosition.Y;
				num4 = Main.screenPosition.Y + (float)Main.screenHeight - num4;
			}
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			float num8 = 255f;
			num -= 0.1f;
			if ((double)num > 0.5)
			{
				num6 = 255f;
				num5 = 255f * (1f - num) * 2f;
			}
			else
			{
				num6 = 255f * num * 2f;
				num5 = 255f;
			}
			float num9 = 0.95f;
			num5 = num5 * alpha * num9;
			num6 = num6 * alpha * num9;
			num8 = num8 * alpha * num9;
			if (num5 < 0f)
			{
				num5 = 0f;
			}
			if (num5 > 255f)
			{
				num5 = 255f;
			}
			if (num6 < 0f)
			{
				num6 = 0f;
			}
			if (num6 > 255f)
			{
				num6 = 255f;
			}
			if (num8 < 0f)
			{
				num8 = 0f;
			}
			if (num8 > 255f)
			{
				num8 = 255f;
			}
			Color color = new Color((byte)num5, (byte)num6, (byte)num7, (byte)num8);
			if (num2 < 3)
			{
				num2 = 3;
			}
			if (num2 < 34)
			{
				if (num2 < 36)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)num2 * scale, num4 - Main.screenPosition.Y), new Rectangle(2, 0, 2, TextureAssets.Hb2.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				if (num2 < 34)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)(num2 + 2) * scale, num4 - Main.screenPosition.Y), new Rectangle(num2 + 2, 0, 36 - num2 - 2, TextureAssets.Hb2.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				if (num2 > 2)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X, num4 - Main.screenPosition.Y), new Rectangle(0, 0, num2 - 2, TextureAssets.Hb1.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X + (float)(num2 - 2) * scale, num4 - Main.screenPosition.Y), new Rectangle(32, 0, 2, TextureAssets.Hb1.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
			}
			else
			{
				if (num2 < 36)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)num2 * scale, num4 - Main.screenPosition.Y), new Rectangle(num2, 0, 36 - num2, TextureAssets.Hb2.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X, num4 - Main.screenPosition.Y), new Rectangle(0, 0, num2, TextureAssets.Hb1.Height()), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
			}
		}

		public static void DrawManaBar(float X, float Y, int Mana, int MaxMana, float alpha, float scale = 1f, bool noFlip = false)
		{
			float num = (float)Mana / (float)MaxMana;
			if (num > 1f)
			{
				num = 1f;
			}
			int num2 = (int)(36f * num);
			float num3 = X - 18f * scale;
			float num4 = Y;
			if (Main.player[Main.myPlayer].gravDir == -1f && !noFlip)
			{
				num4 -= Main.screenPosition.Y;
				num4 = Main.screenPosition.Y + (float)Main.screenHeight - num4;
			}
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			float num8 = 255f;
			num -= 0.1f;
			num5 = 64f + (32f * num);
			num6 = 64f + (32f * num);
			num7 = 64f + (192f * num);
			float num9 = 0.95f;
			num5 = num5 * alpha * num9;
			num6 = num6 * alpha * num9;
			num7 = num7 * alpha * num9;
			num8 = num8 * alpha * num9;
			if (num5 < 0f)
			{
				num5 = 0f;
			}
			if (num5 > 255f)
			{
				num5 = 255f;
			}
			if (num6 < 0f)
			{
				num6 = 0f;
			}
			if (num6 > 255f)
			{
				num6 = 255f;
			}
			if (num7 < 0f)
			{
				num7 = 0f;
			}
			if (num7 > 255f)
			{
				num7 = 255f;
			}
			if (num8 < 0f)
			{
				num8 = 0f;
			}
			if (num8 > 255f)
			{
				num8 = 255f;
			}
			Microsoft.Xna.Framework.Color color = new Microsoft.Xna.Framework.Color((byte)num5, (byte)num6, (byte)num7, (byte)num8);
			if (num2 < 3 && num2 > 0)
			{
				num2 = 3;
			}
			if (num2 < 34 && num2 > 0)
			{
				if (num2 < 36)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)num2 * scale, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(2, 0, 2, TextureAssets.Hb2.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				if (num2 < 34)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)(num2 + 2) * scale, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(num2 + 2, 0, 36 - num2 - 2, TextureAssets.Hb2.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				if (num2 > 2)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(0, 0, num2 - 2, TextureAssets.Hb1.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X + (float)(num2 - 2) * scale, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(32, 0, 2, TextureAssets.Hb1.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
			}
			else
			{
				if (num2 < 36)
				{
					Main.spriteBatch.Draw(TextureAssets.Hb2.Value, new Vector2(num3 - Main.screenPosition.X + (float)num2 * scale, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(num2, 0, 36 - num2, TextureAssets.Hb2.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
				}
				Main.spriteBatch.Draw(TextureAssets.Hb1.Value, new Vector2(num3 - Main.screenPosition.X, num4 - Main.screenPosition.Y), new Microsoft.Xna.Framework.Rectangle(0, 0, num2, TextureAssets.Hb1.Value.Height), color, 0f, new Vector2(0f, 0f), scale, SpriteEffects.None, 0f);
			}
		}
	}
}