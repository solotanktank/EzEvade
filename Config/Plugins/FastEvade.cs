using System.Collections.Generic;
using System.Drawing;
using EloBuddy;

namespace ezEvade.Config.Plugins
{
    [ConfigPlugin(Author = "MeLoDag", Name = "Fast EzEvade", Version = "2.0.1.6", RecomendedChampions = new[] { "All" },
        Description = "Use this config preset For Fast reaction and Fast Ezevade" +
                      "")]
    public class FastEvade : ConfigPreset
    {
        public override void LoadConfig()
        {
            SetValue(ConfigValue.ExtraDetectionRange, 2500);
            SetValue(ConfigValue.ExtraLineWidth, 0);
            SetValue(ConfigValue.ExtraSpellRadius, 40); //ExtraAvoidDistance
            SetValue(ConfigValue.ExtraPingBuffer, 65);
            SetValue(ConfigValue.ExtraCpaDistance, 60);
            SetValue(ConfigValue.RejectMinDistance, 10);
            SetValue(ConfigValue.MinimumComfortZone, 10);
            SetValue(ConfigValue.ExtraEvadeDistance, 40);
            SetValue(ConfigValue.EvadeMode, EvadeMode.Fast);
            SetValue(ConfigValue.FastEvadeActivationTime, 0);
            SetValue(ConfigValue.SpellActivationTime, 0);
            SetValue(ConfigValue.TickLimiter, 100);
            SetValue(ConfigValue.SpellDetectionTime, 20);
            SetValue(ConfigValue.ReactionTime, 20);
            SetValue(ConfigValue.DodgeInterval, 0);

            //Booleans
            SetValue(ConfigValue.DodgeSkillShots, true);
            SetValue(ConfigValue.DrawSkillShots, true);
            SetValue(ConfigValue.PreventDodgingNearEnemy, false);
            SetValue(ConfigValue.CalculateWindupDelay, true);
            SetValue(ConfigValue.HighPrecision, true);
            SetValue(ConfigValue.PreventDodgingUnderTower, false);
            SetValue(ConfigValue.ClickOnlyOnce, false);
            SetValue(ConfigValue.OnlyDodgeDangerous, false);
            SetValue(ConfigValue.DodgeDangerousKeysEnabled, false);
            SetValue(ConfigValue.DodgeFowSpells, false);
            SetValue(ConfigValue.DodgeCircularSpells, false);
            SetValue(ConfigValue.ActivateEvadeSpells, false);
            SetValue(ConfigValue.DodgeDangerousKey1, false);
            SetValue(ConfigValue.DodgeDangerousKey2, false);
            SetValue(ConfigValue.RecalculatePath, true);
            SetValue(ConfigValue.ContinueMovement, false);
            SetValue(ConfigValue.CheckSpellCollision, false);
            SetValue(ConfigValue.AdvancedSpellDetection, false);
            SetValue(ConfigValue.FastMovementBlock, true);
            SetValue(ConfigValue.EnableEvadeDistance, false);
            SetValue(ConfigValue.ShowDebugInfo, false);
            SetValue(ConfigValue.EnableSpellTester, false);
            SetValue(ConfigValue.DrawEvadeStatus, true);
            SetValue(ConfigValue.DrawSpellPosition, true);
            SetValue(ConfigValue.DrawEvadePosition, false);
            SetValue(ConfigValue.AutoSetPing, false);
        }
    }
}