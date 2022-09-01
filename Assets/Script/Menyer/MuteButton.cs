using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton:MonoBehaviour {

    public SoundFX soundFXScript;
    public Sprite mute, unmute;
    public AudioSource source;
    
    float backgroundVolume, soundFXVolume;
    bool muted;

    RawImage muteImage;

    void Start() {
        backgroundVolume = source.volume;
        soundFXVolume = soundFXScript.volume;
        muteImage = GetComponent<RawImage>();
    }

    public void Mute() {
        if(muted) {
            //Unmuted
            source.volume = backgroundVolume;
            soundFXScript.volume = soundFXVolume;
            muteImage.texture = unmute.texture;
            muted = false;
        } else {
            //Muted
            source.volume = 0;
            soundFXScript.volume = 0;
            muteImage.texture = mute.texture;
            muted = true;
        }
    }
}
