using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace FishEyeDistortion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string inputImageFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\ImageFishEye.jpeg");
            string projectRootDir = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().IndexOf("\\bin\\Debug"));
            string outputImageFilePath = Path.Combine(projectRootDir, @"Data\Output.png");
            Bitmap bmp = (Bitmap)Bitmap.FromFile(inputImageFilePath);
            bmp = DistortionService.BarrelDistortion(bmp, 0.1, true, Color.White);
            bmp.Save(outputImageFilePath);
            bmp.Dispose();
            Console.WriteLine("subash");
        }
    }
}