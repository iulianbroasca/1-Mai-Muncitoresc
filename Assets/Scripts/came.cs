using UnityEngine;
using System.Collections;

public class came : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public Transform Boat1;
    public Transform Boat2;

    public float vBoat1;
    public float vBoat2;
    public float suma;
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
         vBoat1 = Vector3.Distance(Boat1.position, transform.position);
         vBoat2 = Vector3.Distance(Boat2.position, transform.position);
         suma = vBoat1 - vBoat2;
    //    if(vBoat1 > 15 && dis == true)
    //    {
    //        camera1.enabled = !camera1.enabled;
    //        camera2.enabled = !camera2.enabled;
    //        dis = false;
    //    }
    //    if (dis == false && vBoat1 < 15)
    //    {
    //        dis = true;
    //        change();
    //    }
    }
    //void change()
    //{
    //    if (vBoat1 > 15 && dis == true)
    //    {
    //        camera1.enabled = !camera1.enabled;
    //        camera2.enabled = !camera2.enabled;
    //        dis = false;
    //    }
    //}
}
//suma += CamSwitch.Boat1 - CamSwitch2.Boat2;
