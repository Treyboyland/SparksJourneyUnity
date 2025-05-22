using System;
using System.IO;
using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
#if UNITY_WEBGL || UNITY_ANDROID
    string screenshotDirectory = Application.dataPath;
#else
    string screenshotDirectory = Application.dataPath + "/../Logs";
#endif

    public void TakeScreenshot()
    {
        if (Directory.Exists(screenshotDirectory))
        {
            string fileName = Application.productName + "-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff") + ".png";
            ScreenCapture.CaptureScreenshot(screenshotDirectory + "/" + fileName);
        }
    }
}
