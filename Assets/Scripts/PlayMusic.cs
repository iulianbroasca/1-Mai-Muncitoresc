﻿using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour 
{
    public AudioClip impact;
    AudioSource audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        audio.PlayOneShot(impact);
	}
}
