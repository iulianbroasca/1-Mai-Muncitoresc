using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour 
{
    public Text text;
    public float sec;

	// Use this for initialization
	void Start () 
    {
	
	}

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        sec += Time.deltaTime;
        //if(sec>0 && sec<=2)
        //{
        //    text.text = "3";
        //}
        //if (sec > 2 && sec <= 4)
        //{
        //    text.text = "2";
        //}
        //if (sec > 4 && sec <= 6)
        //{
        //    text.text = "1";
        //}
        //if (sec > 6 && sec <= 7)
        //{
        //    text.text = "Go!";
        //    reached.adev = true;
        //}
        if (sec > 0 && sec <= 1)
        {
            text.text = "3";
        }
        if (sec > 1 && sec <= 2)
        {
            text.text = "2";
        }
        if (sec > 2 && sec <= 3)
        {
            text.text = "1";
        }
        if (sec > 3 && sec <= 4)
        {
            text.text = "Start";
            reached.adev = true;
        }
        if( sec>4)
        {
            text.text = " ";
        }

	}
}
