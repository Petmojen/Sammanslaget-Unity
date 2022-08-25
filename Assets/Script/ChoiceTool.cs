using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTool:MonoBehaviour {

    public GameObject targetObject;
    public Sprite[] differentChoices;

    RawImage legsSprite;
    int choiceMade;

    void Start() {
        legsSprite = targetObject.GetComponent<RawImage>();
    }

    public void ChangeObject(int choice) {
        if(choice == 0) {
            legsSprite.color = new Color(1, 1, 1, 0);
            return;
        }
        legsSprite.color = new Color(1, 1, 1, 1);
        legsSprite.texture = differentChoices[choice - 1].texture;
    }
}
