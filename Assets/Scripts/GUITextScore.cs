using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUITextScore : MonoBehaviour
{
    public float spe1 = 0;
    public Text text;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        spe1 = Press.speedfin;
        if (spe1 > 0)
        {
            text.text = spe1 + " km/h";
        } 
    }
}
