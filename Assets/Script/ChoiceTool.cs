using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceTool:MonoBehaviour {

    public ColorTool colorChanger;
    public GameObject targetObject;
    public Sprite[] differentChoices;

    RawImage targetSprite;
    int choiceMade;

    void Start() {
        targetSprite = targetObject.GetComponent<RawImage>();
    }

    public void ChangeObject(int choice) {
        if(choice == 0) {
            colorChanger.alphaOn = false;
            targetSprite.color = new Color(1, 1, 1, 0);
            return;
        }
        colorChanger.alphaOn = true;
        targetSprite.color = new Color(1, 1, 1, 1);
        targetSprite.texture = differentChoices[choice - 1].texture;
    }

    public void AcivateColors() {
        if(targetSprite.texture.name == "Basfärg")
            return;

        if(colorChanger.alphaOn)
            return;

        colorChanger.alphaOn = true;
        targetSprite.color = new Color(1, 1, 1, 1);
    }
}
