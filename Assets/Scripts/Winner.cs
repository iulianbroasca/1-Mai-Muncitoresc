using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Winner : MonoBehaviour
{
    public bool a1 = false;
    public bool a2 = false;
    public static bool res = false;
    public static bool res2 = false;
    public static float sec = 0;
    public string name1;
    public string name2;
    public Text text;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        a1 = boat1.atins1;
        a2 = boat2.atins2;
        if(a1)
        {
            name1 = Player.NamePlayer1;
            text.text = "Winner: " + name1;
        }
        if (a2)
        {
            name2 = Player.NamePlayer2;
            text.text = "Winner: " + name2;
        }
        if(a1 || a2)
        {
            sec += Time.deltaTime;
        }
        if(sec > 5)
        {
            //name1 = "";
            //name1 = "";
            a1 = false;
            a2 = false;
            res = true;
            res2 = true;
            boat1.atins1 = false;
            boat2.atins2 = false;
            sec = 0;
            menu();
        }
    }
    void menu()
    {
        Application.LoadLevel("MENU");
    }
}
