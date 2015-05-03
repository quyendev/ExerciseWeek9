using UnityEngine;
using System.Collections;

//Thi has second commit
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
