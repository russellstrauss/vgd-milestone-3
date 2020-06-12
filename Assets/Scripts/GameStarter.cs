using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
	void Start() {
		
	}

	void Update() {
		
	}
	
	public void StartGame() {
		Debug.Log("Button Press");
		SceneManager.LoadScene("demo");
	}
	
	public void ExitGame() {
		Application.Quit();
	}
	
	public void RestartLevel() {
		SceneManager.LoadScene("demo");
	}
}
