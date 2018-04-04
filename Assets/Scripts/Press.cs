using UnityEngine;
using System.Collections;

public class Press : MonoBehaviour 
{
    public bool a = false;
    public bool s = false;
    public bool vali = false;
    private int i;
    public bool adev1;
    public int speed1;
    public int low;
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
        adev1 = reached.adev;
        if (adev1 == true)
        {
            if (Input.GetKeyUp("a"))
            {
                a = true;
            }
            if (Input.GetKeyUp("s"))
            {
                s = true;
            }
            //speedfin = speed1;
        }
        speedfin = speed1;
        if(a)
        {
            speed1 = speed1 + 1;
            FORWARD();
            a = false;
        }
        if (s)
        {
            speed1 = speed1 + 1;
            FORWARD();
            s = false;
        }
        vali = Winner.res2;
        if (vali)
        {
            speedfin = 0;
            Winner.res2 = false;
        }
        //speedfin = speed1;
        //low = 4;
        //if( adev1 == false && vali == false)
        //{
        //    for (i = 1; i <= 4; i++)
        //    {
        //        low = low - 1;
        //        FORWA();
        //    }
        //    if(i == 4)
        //    {
        //        vali = true;
        //    }
        //}
         //if (a == true && s == true)
         //{
         //    speed = speed + 1;
         //    FORWARD();
         //    Fals();
         //}
	}
    void FORWARD()
    {
        rb.AddRelativeForce(Vector3.forward * -speed1);
    }
    void FORWA()
    {
        rb.AddRelativeForce(Vector3.forward * low);
    }
    //void powermin()
    //{
    //    for(i=1;i<=5;i++)
    //    {
    //        low = low - 1;
    //        FORWA();
    //    }
    //}
}