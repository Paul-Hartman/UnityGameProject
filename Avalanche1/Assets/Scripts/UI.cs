using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
	GameObject pauseObjects;
	

	// Use this for initialization
	void Start()
	{
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectWithTag("ShowOnPaused");
		hidePaused();
	}

	// Update is called once per frame
	void Update()
	{

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			}
			else if (Time.timeScale == 0)
			{
				
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}

	
	//Reloads the Level
	public void Reload()
	{
		SceneManager.LoadScene("AvalanchePlay");
	}

	//controls the pausing of the scene
	public void pauseControl()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
			hidePaused();
		}
	}

	//shows objects with ShowOnPause tag
	
	public void showPaused()
	{
		
			pauseObjects.SetActive(true);
		
	}

	//hides objects with ShowOnPause tag
	public void hidePaused()
	{
		
		
			pauseObjects.SetActive(false);
		
	}

	//loads inputted level
	public void LoadLevel(string level)
	{
		SceneManager.LoadScene("MainMenu");
	}
	
    
}
