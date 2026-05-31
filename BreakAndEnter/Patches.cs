using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Siege;

namespace BreakAndEnter
{
    [HarmonyPatch(typeof(DefaultTroopSacrificeModel))]
    public static class Patches
    {
        private static readonly ExplainedNumber zero = new ExplainedNumber(0);
        
        [HarmonyPrefix]
        [HarmonyPatch("GetLostTroopCountForBreakingInBesiegedSettlement")]
        private static bool GetLostTroopCountForBreakingInBesiegedSettlementPostfix(
            ref ExplainedNumber __result,
            MobileParty party,
            SiegeEvent siegeEvent)
        {
            __result = zero;
            return false;       
        }

        [HarmonyPrefix]
        [HarmonyPatch("GetLostTroopCountForBreakingOutOfBesiegedSettlement")]
        private static bool GetLostTroopCountForBreakingOutOfBesiegedSettlementPostfix(
            ref ExplainedNumber __result,
            MobileParty party,
            SiegeEvent siegeEvent)
        {
            __result = zero;
            return false;
        }
    }
}