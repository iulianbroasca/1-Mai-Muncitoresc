using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour
{
    public Renderer rend;
    private string camInst = "";

    private bool show = false;

    // Use this for display your text on monitor
    void Start()
    {
        rend = GetComponent<Renderer>();
        camInst = ""; 
        camInst += "\n";
        camInst += "The summer season began and you \n";
        camInst += "went to the seaside with your friends. \n";
        camInst += "A great race yacht is organized  \n";
        camInst += "on the seashore. To compete \n";
        camInst += "your friends, press alternatively \n";
        camInst += "A and S keys (player 1) or \n";
        camInst += "LEFT and DOWN (player 2). \n";

        //camInst += "- CLICK= throw eggs \n";
        //camInst += "- C= switch the camera  \n";
        //camInst += "- Look for the rabbits while you move the MOUSE. \n";

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

    void OnGUI()
    {

        //if (GUI.Button(new Rect(Screen.width - 45, 10, 35, 35), "!"))
        //{
        //    show = !show;
        //}

        if (show)
        {
            //GUI.Label(new Rect(Screen.width - 550, 50, 300, 500), camInst);
            //GUI.Box(new Rect(Screen.width - 400, 75, 300, 250), camInst);
            GUI.Button(new Rect(Screen.width - 400, 75, 250, 120), camInst);

        }
    }
}