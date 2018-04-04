using UnityEngine;
using System.Collections;

public class CamSwitch2 : MonoBehaviour
{

    public Transform Player2;
    public static float Boat2;
    public float boo2;
    //public float Boat2;
    //public Rigidbody rb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Boat2 = Vector3.Distance(Player2.position, transform.position);
        boo2 = Boat2;
    }
}
