using UnityEngine;
using System.Collections;

public class reached : MonoBehaviour 
{
     public static bool adev = false;
     public GameObject other;
     public GameObject othe;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Boat")
        {
            adev = false;
            Destroy(other);
            //Destroy(col.gameObject);
            //Application.Quit();
        }
    }
}
