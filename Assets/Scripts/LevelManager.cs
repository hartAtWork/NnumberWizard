using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("lvl reuqest "+name);
		Application.LoadLevel(name);
	}
	public void Quit(){
		Debug.Log("GoodBye");
		Application.Quit();
	}
}
