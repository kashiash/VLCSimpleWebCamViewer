using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using OpenCvSharp;
using VideoInputDevices;

namespace ListWebCams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var sde = new SystemDeviceEnumerator())
            {
                var devices = sde.ListVideoInputDevice();
  
            }

        }
    }
}