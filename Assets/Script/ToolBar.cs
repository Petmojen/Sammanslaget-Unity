using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBar:MonoBehaviour {

    public GameObject[] tools;
    //Link script



    public void ToolPicker() {
        for(int i = 0; i < tools.Length; i++) {
            if(i == 0) {
                tools[i].SetActive(true);
            }
            
            //Link script and make them move back
        }
    }
}
