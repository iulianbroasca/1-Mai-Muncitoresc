using UnityEngine;
using System.Collections;

public class Press2 : MonoBehaviour 
{
    public bool a = false;
    public bool s = false;
    public bool vali = false;
    public bool adev2;
    public int speed2;
    public int low;
    private int i;
    public static int speedfin;
    public Rigidbody rb;
	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
         adev2 = reached.adev;
         if (adev2 == true)
         {
             if (Input.GetKeyUp("left"))
             {
                 a = true;
             }
             if (Input.GetKeyUp("down"))
             {
                 s = true;
             }
             //speedfin = speed2;
         }

         speedfin = speed2;

       if (a)
       {
           speed2 = speed2 + 1;
           FORWARD();
           a = false;
       }

       if (s)
       {
           speed2 = speed2 + 1;
           FORWARD();
           s = false;
       }

       vali = Winner.res;
        if(vali)
        {
            speedfin = 0;
            Winner.res = false;
        }
       //speedfin = speed2;
       //low = 4;
       //if (adev2 == false && vali == false)
       //{
       //    for (i = 1; i <= 4; i++)
       //    {
       //        low = low - 1;
       //        FORWA();
       //    }
       //    if (i == 4)
       //    {
       //        vali = true;
       //    }
       //}
       //if (adev2 == false)
       //{
       //    powermin();
       //    //FORWA();
       //}

       //if (a == true && w == true)
       //{
       //     Fals();
       //     speed = speed + 1;
       //     FORWARD();
       //}
	}
    void FORWARD()
    {
        rb.AddRelativeForce(Vector3.forward * -speed2);
    }
    void FORWA()
    {
        rb.AddRelativeForce(Vector3.forward * speed2);
    }
    void powermin()
    {
        for (i = 1; i <=5; i++)
        {
            low = low - 1;
            FORWA();
        }
    }
}