using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveImage:MonoBehaviour {

    public GameObject infoBox;

    public void ScreenShot() {
        infoBox.SetActive(false);

        ScreenCapture.CaptureScreenshot("../ChangeYourFurniture.png");

    }
}
