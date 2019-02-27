using System;

namespace WhiteNoise.Tools
{
    public static class AppRoot
    {
        public static string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
