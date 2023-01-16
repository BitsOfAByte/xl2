﻿using System;

namespace XIVLauncher2.Common.Patching.ZiPatch
{
    public class ZiPatchException : Exception
    {
        public ZiPatchException(string message = "ZiPatch error", Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}
