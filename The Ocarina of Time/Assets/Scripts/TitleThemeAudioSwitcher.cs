using UnityEngine;
using System.Collections;

public class TitleThemeAudioSwitcher : MonoBehaviour {
    public AudioClip otherClip;
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (!audio.isPlaying) {
            audio.clip = otherClip;
            audio.Play();
        }
	}
}
