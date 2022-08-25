using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTool:MonoBehaviour {

    public GameObject drawer;
    Transform drawerTransform;

    void Start() {
        drawerTransform = drawer.GetComponent<Transform>();
    }

    void ChangeSize() {
        
    }

}
