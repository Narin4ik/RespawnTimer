using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RespawnTimer
{
    public class Translations : ITranslation
    {
        [Description("Format for the MTF respawn timer.")]
        public string MtfRespawnFormat { get; set; } = "{minutes} min. {seconds} sec.";

        [Description("Format for the Chaos Insurgency respawn timer.")]
        public string ChaosRespawnFormat { get; set; } = "{minutes} min. {seconds} sec.";

        [Description("Format when no respawn is scheduled.")]
        public string NoRespawnFormat { get; set; } = "Waiting...";
    }
}