using System;
using Exiled.API.Features;
using Exiled.API.Enums;
using CustomHint.API;
using Respawning.Waves;

namespace RespawnTimer
{
    public class Plugin : Plugin<Config, Translations>
    {
        public override string Name => "RespawnTimer";
        public override string Author => "Narin";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public override void OnEnabled()
        {
            PlaceholderManager.RegisterGlobalPlaceholder("{respawn_mtf}", () => FormatRespawnTime(GetNtfRespawnTime(), Translation.MtfRespawnFormat));
            PlaceholderManager.RegisterGlobalPlaceholder("{respawn_ci}", () => FormatRespawnTime(GetChaosRespawnTime(), Translation.ChaosRespawnFormat));

            Log.Debug("Registered {respawn_mtf} and {respawn_ci} placeholders.");
            base.OnEnabled();
        }

        private float GetNtfRespawnTime()
        {
            if (Respawn.TryGetWaveBase(SpawnableFaction.NtfWave, out SpawnableWaveBase wave) && wave is TimeBasedWave timeWave)
            {
                return timeWave.Timer.TimeLeft;
            }
            return 0f;
        }

        private float GetChaosRespawnTime()
        {
            if (Respawn.TryGetWaveBase(SpawnableFaction.ChaosWave, out SpawnableWaveBase wave) && wave is TimeBasedWave timeWave)
            {
                return timeWave.Timer.TimeLeft;
            }
            return 0f;
        }

        private string FormatRespawnTime(float time, string format)
        {
            if (time <= 0)
                return Translation.NoRespawnFormat;

            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            return format
                .Replace("{minutes}", timeSpan.Minutes.ToString("D2"))
                .Replace("{seconds}", timeSpan.Seconds.ToString("D2"));
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}