using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Renderer rend;
    private string camInst = "";

    private bool show = false;

    // Use this for display your text on monitor
    void Start()
    {
        rend = GetComponent<Renderer>();
        camInst = "";
        camInst += "Enter your name \n";
        //camInst += "                     Enter your name \n";
        camInst += " \n";
        camInst += "Player1: \n";
        camInst += " \n";
        camInst += " \n";
        camInst += "Player2: \n";

    }
    void OnMouseEnter()
    {
        rend.material.color = Color.blue;
    }
    //void OnMouseOver()
    //{
    //    rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    //}
    void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
    void OnMouseDown()
    {
        show = !show;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static string NamePlayer1 = "";
    public static string NamePlayer2 = "";

    void OnGUI()
    {

        //if (GUI.Button(new Rect(Screen.width - 45, 10, 35, 35), "!"))
        //{
        //    show = !show;
        //}

        if (show)
        {
            //GUI.Label(new Rect(Screen.width - 1350, 170, 300, 500), camInst);
            //GUI.Button(new Rect(Screen.width - 1350, 150, 250, 130), camInst);
            // GUI.Box(new Rect(Screen.width - 1300, 150, 250, 180), camInst);//130
            GUI.Box(new Rect(Screen.width - 1275, 75, 250, 180), camInst);//130
            NamePlayer1 = GUI.TextField(new Rect(Screen.width - 1225, 125, 150, 20), NamePlayer1);
            NamePlayer2 = GUI.TextField(new Rect(Screen.width - 1225, 170, 150, 20), NamePlayer2);
            //GUI.Button(new Rect(Screen.width - 1240, 300, 50, 35), "Play");
            if (GUI.Button(new Rect(Screen.width - 1175, 205, 50, 35), "Play"))
            {
                Application.LoadLevel("1MAI");
            }
        }
        //if(GUI.Button(new Rect(Screen.width - 1240, 300, 50, 35), "Play"))
        //{
        //    Application.LoadLevel("1MAI");
        //}
    }
}