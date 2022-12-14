using OpenCvSharp;

namespace CybertoothTiger
{
   
public class CyberToothTiger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            run();
        }
        public static void run() {

            VideoCapture capture = new VideoCapture(0, VideoCaptureAPIs.DSHOW);

            if (!capture.IsOpened()){
            
            }
            capture.FrameWidth = 1920;
            capture.FrameHeight = 1280;
            capture.AutoFocus = true;
            const int sleepTime = 1;

            Window window = new Window("capture");
            Mat image = new Mat();
            
            while (true)
            {
                capture.Read(image); 
                if (image.Empty())
                    break;

                window.ShowImage(image);
                int c = Cv2.WaitKey(sleepTime);
                if (c >= 0)
                {
                    break;
                }
            }
        }

    }
}
