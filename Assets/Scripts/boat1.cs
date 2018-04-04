using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class boat1 : MonoBehaviour 
{
     public static bool adev = true;
     public GameObject other;
     public Text textWinner;
     public static bool atins1 = false;
     public string name1;
     //public Text textSpeed;

	// Use this for initialization
     void Awake()
     {
         // Set up the reference.
         textWinner = GetComponent<Text>();

     }
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        //if (atins)
        //{
        //    name1 = Player.NamePlayer1;
        //    textWinner.text = name1;
        //}
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FinishLine")
        {
           atins1 = true;
            adev = false;
            Destroy(other);

            //Destroy(col.gameObject);
            //Application.Quit();
        }
    }
}
