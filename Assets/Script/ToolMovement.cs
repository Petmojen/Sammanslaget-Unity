using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolMovement:MonoBehaviour {

    public GameObject _start, _goal;
    public bool active = true;
    public float speed;

    bool atGoal, atStart;

    void FixedUpdate() {
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
                atGoal = true;
            } else {
                atStart = true;
                atGoal = false;
                if(atStart) {
                    active = true;
                    atStart = false;
                    gameObject.SetActive(false);
                }
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
