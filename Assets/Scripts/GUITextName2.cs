using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUITextName2 : MonoBehaviour
{
    public string name2 ;
    public Text text;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        name2 = Player.NamePlayer2;
        text.text = name2;
    }
    void menu()
    {
        Application.LoadLevel("MainMenu");
    }
}
