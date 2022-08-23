using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBar:MonoBehaviour {

    public GameObject[] tools;
    ColorPicker _colorScript;

    public void ToolPicker(int choice) {
        for(int i = 0; i < tools.Length; i++) {
            if(i == choice) {
                tools[i].SetActive(true);
            } else {
                
            }
        }
    }
}
