using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class boat2 : MonoBehaviour 
{
     public static bool adev = true;
     //public float secunde;
     public GameObject other;
     public string name1;
     public static bool atins2 = false;

     public Text textWinner;

     // Use this for initialization
     void Awake()
     {
         // Set up the reference.
         textWinner = GetComponent<Text>();

     }
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        //secunde = Winner.sec;

        //if (atins1)
        //{
        //    name1 = Player.NamePlayer2;
        //    textWinner.text = name1;
        //}
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FinishLine")
        {
            atins2 = true;
            adev = false;
            Destroy(other);
            //Destroy(col.gameObject);
            //Application.Quit();
        }
    }
}
