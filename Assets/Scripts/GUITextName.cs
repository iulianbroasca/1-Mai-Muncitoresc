using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUITextName : MonoBehaviour
{
    public string name1;
    public Text text;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        name1 = Player.NamePlayer1;
        text.text = name1;
    }
    void menu()
    {
        Application.LoadLevel("MainMenu");
    }
}
