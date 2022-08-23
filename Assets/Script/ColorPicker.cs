using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker:MonoBehaviour {

    public Slider _hsvSlider;
    public GameObject furniture, _start, _goal;
    public bool active;
    public float speed;

    bool atGoal, atStart, setInactive;

    void Awake() {
        setInactive = true;
        active = true;
    }

    void Update() {
        if(active && !atGoal) {
            MoveTowards(_goal.transform.position);
        }

        if(!active && !atStart) {
            MoveTowards(_start.transform.position);
        }
    }

    void MoveTowards(Vector3 target) {
        if(Vector3.Distance(transform.position, target) <= 0.5f) {
            if(active) {
                atStart = false;
                atGoal = true;
            } else {
                atStart = true;
                atGoal = false;
                if(setInactive)
                    gameObject.SetActive(false);
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed);
    }
}
