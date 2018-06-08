using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {

	private void Awake() {
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
		Invoke("LoadFirstLevel", 2f);
	}

	private void LoadFirstLevel() {
		SceneManager.LoadScene(1);
	}
}
