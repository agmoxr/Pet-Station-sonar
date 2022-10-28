using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
	public void MainMenu()
	{
		SceneManager.LoadScene (00);
	}
    public void ARScene()
	{
		SceneManager.LoadScene (01);
	}
	public void Exit()
	{
		Application.Quit ();
	}
}