using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Exitt()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#  else
        Debug.Log("You just quit the game");
        Application.Quit();
#endif
    }
    // Update is called once per frame
    void Update()
    {

    }
}
