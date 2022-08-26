using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomTool:MonoBehaviour {

    Slider slider;
    public GameObject drawer;

    float size;

    void Start() {
        slider = GetComponent<Slider>();
    }

    public void ChangeSize() {
        size = slider.value;
        drawer.transform.localScale = new Vector3(size, size, size);
    }

}
