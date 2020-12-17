using MelonLoader;
using Harmony;
using NKHook6.Api;
using NKHook6;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
namespace btd6mod
{
	public class Main : MelonMod
	{
		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			Logger.Log("btd6mod has loaded!");
		}
	}

	[HarmonyPatch(typeof(Weapon), "Initialise")]
	public class WeaponInitialise_Patch
	{
		[HarmonyPostfix]
		public static void Postfix(Weapon __instance)
		{
            InGame.instance.addCash(9999999);
			InGame.instance.addHealth(9999999);
		}
	}
}
