using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace CybertoothTiger
{
    internal class CyberToothTiger
    {
        using var src = new Mat("lenna.png", ImreadModes.Grayscale);
        using var dst = new Mat();

    Cv2.Canny(src, dst, 50, 200);
        using (new Window("src image", src)) 
        using (new Window("dst image", dst)) 
        {
            Cv2.WaitKey();
        }

    }
}
