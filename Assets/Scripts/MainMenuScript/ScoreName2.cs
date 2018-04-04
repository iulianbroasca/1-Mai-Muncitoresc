using UnityEngine;
using System.Collections;

public class ScoreName2 : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    public static string NamePlayer2 = "";
    void OnGUI()
    {
        //stringToEdit = GUILayout.TextField( Rect(350, 225, 100, 20), stringToEdit);
            //(new Rect (0, 0, 100, 100), stringToEdit, 40, GUILayout.Width(300));
        GUI.Label(new Rect(290, 280, 100, 30), "Enter your name");
        NamePlayer2 = GUI.TextField(new Rect(240, 300, 200, 20), NamePlayer2);
        //stringToEdit = GUILayout.TextField(stringToEdit, GUILayout.Width(100));
    }
}
