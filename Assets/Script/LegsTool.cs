using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegsTool:MonoBehaviour {

    public GameObject legsObject;
    public Sprite[] legChoices;

    RawImage legsSprite;
    int choiceMade;

    void Start() {
        legsSprite = legsObject.GetComponent<RawImage>();    
    }

    public void ChangeLegs(int choice) {
        legsSprite.texture = legChoices[choice].texture;
    }
}
