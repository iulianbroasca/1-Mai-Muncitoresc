using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour
{
            //public void Quit()
            //{
            //    #if UNITY_EDITOR
            //            UnityEditor.EditorApplication.isPlaying = false;
            //    #else
            //        Application.LoadLevel("1MAI");
            //    #endif
            //}

    void OnMouseDown()
    {
        Application.LoadLevel("1MAI");
    }
}