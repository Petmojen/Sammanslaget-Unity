using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneGame:MonoBehaviour {

    public GameObject[] _gameObjects;
    public GameObject roomBackground, drawerRoomPos;

    public void ChangeRoom() {
        for(int i = 0; i < _gameObjects.Length; i++) {
            _gameObjects[i].SetActive(false);
        }
        roomBackground.SetActive(true);
        transform.position = drawerRoomPos.transform.position;
        transform.localScale = new Vector3(1, 1, 1);
    }

}
