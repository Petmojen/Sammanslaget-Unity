using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolBar:MonoBehaviour {

    public GameObject[] tools;
    public RawImage basePatter;

    ToolMovement _toolMovement;

    public void ToolPicker(int choice) {
        for(int i = 0; i < tools.Length; i++) {
            if(choice == 0 && basePatter.texture.name == "Basfärg")
                basePatter.color = new Color(1, 1, 1, 0);

            if(i == choice) {
                tools[i].SetActive(true);
                tools[i].GetComponent<ToolMovement>().active = true;
            } else {
                tools[i].GetComponent<ToolMovement>().active = false;
            }
        }
    }
}
