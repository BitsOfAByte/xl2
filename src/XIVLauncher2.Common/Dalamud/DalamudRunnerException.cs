using System;

namespace XIVLauncher2.Common.Dalamud;

public class DalamudRunnerException : Exception
{
     public DalamudRunnerException(string message, Exception innerException = null)
          : base(message, innerException)
     {
     }
}
