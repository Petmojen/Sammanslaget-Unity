using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTool:MonoBehaviour {

    public RawImage targetObject;
    public bool alphaOn;

    Color startColor;
    Slider slider;
    float alpha;

    void Start() {
        slider = GetComponent<Slider>();
        startColor = targetObject.color;
    }

    void Update() {
        if(alphaOn)
            targetObject.color = Color.HSVToRGB(slider.value, .85f, 1);
    }
}
