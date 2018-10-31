using OpenCvSharp;


namespace imageProcessing
{
    class Test
    {
        public void test()
        {
            Mat source = new Mat(@"1.bmp", ImreadModes.Color);
            Cv2.ImShow("Demo", source);
            Cv2.WaitKey(0);
        }
    }
}
