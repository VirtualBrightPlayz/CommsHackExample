using Exiled.API.Interfaces;

namespace OldMTFEnter
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string FileName { get; set; } = "mtf.raw";
        public float Volume { get; set; } = 0.5f;
    }
}