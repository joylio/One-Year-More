using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class toGameplay : MonoBehaviour {

	private float time;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		time = Time.time - time;
		if(time > 9)
			SceneManager.LoadScene ("game");
	}

}


