﻿using System;

namespace Platformer2D.DesktopGL
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            using (var game = new PlatformerGame())
                game.Run();
        }
    }
}