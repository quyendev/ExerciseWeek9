using UnityEngine;
using System.Collections;

public class MainMenuControl : MonoBehaviour {

	public void LoadNewGame(int startLevel)
	{
		Application.LoadLevel (startLevel); 
	}
	public void ExitGame()
	{
		Application.Quit (); 
	}
}
