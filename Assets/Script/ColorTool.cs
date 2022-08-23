using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTool:MonoBehaviour {

    public RawImage chelf;
    Slider slider;

    void Start() {
        slider = GetComponent<Slider>();
        
        //Debug.Log(Color.RGBToHSV(new Color(140, 98, 57)));
    }

    void Update() {
        chelf.color = Color.HSVToRGB(slider.value, 0.85f, 0.85f);
    }
}
