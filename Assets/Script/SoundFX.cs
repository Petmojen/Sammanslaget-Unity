using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX:MonoBehaviour {

    AudioSource source;
    public float volume = 0.75f;

    void Start() {
        source = GetComponent<AudioSource>();
    }

    public void PlaySoundFX(AudioClip clip) {
        source.PlayOneShot(clip, volume);
    }
}
