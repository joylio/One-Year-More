﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class toStory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space"))
			SceneManager.LoadScene ("storyScene");
	}
}
