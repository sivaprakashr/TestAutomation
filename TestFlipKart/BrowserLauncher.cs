using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlipKart
{
    class BrowserLauncher
    {
        [ClassInitialize]
        public static void LaunchBroswer(TestContext context)
        {
            Playback.Initialize();
            BrowserWindow browser = BrowserWindow.Launch(new System.Uri("about:blank"));
        }
    }
}
