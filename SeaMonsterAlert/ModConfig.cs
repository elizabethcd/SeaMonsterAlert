using System;

namespace SeaMonsterAlert
{
    public class ModConfig
    {
        // Add an config for turning on different options
        public bool doBeachWarp { get; set; }
        public bool doScream { get; set; }
        public bool showMessage { get; set; }
        public bool takeScreenshot { get; set; }
        public bool forceSpawn { get; set; }

    public ModConfig()
        {
            // By default, scream and show message and take screenshot, but don't warp and don't force spawn
            this.doBeachWarp = false;
            this.doScream = true;
            this.showMessage = true;
            this.takeScreenshot = true;
            this.forceSpawn = false;
        }
    }
}