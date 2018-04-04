using UnityEngine;
using System.Collections;

public class CamSwitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public Transform Player1;
    public static float Boat1;
    public float boo;
    public bool dis = true;
    //public float Boat2;
    //public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
     {
         Boat1 = Vector3.Distance(Player1.position, transform.position);
         boo = Boat1;
        if(Boat1 > 15 && dis == true)
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            dis = false;
        }
        if (dis == false && Boat1 < 15)
        {
            dis = true;
            change();
        }
    }
    void change()
    {
        if (Boat1 > 15 && dis == true)
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            dis = false;
        }
    }
}
