using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RespawnTimer
{
    public class Config : IConfig
    {
        [Description("Enable or disable the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug mode?")]
        public bool Debug { get; set; } = false;
    }
}
