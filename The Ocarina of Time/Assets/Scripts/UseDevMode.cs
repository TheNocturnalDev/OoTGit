using UnityEngine;
using System.Collections;
using System;

public class UseDevMode : MonoBehaviour {
    public GameObject ToActive;
    // Use this for initialization
    void Start()
    {
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        if (check.devmode == 1)
        {
            ToActive.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update ()
    {
	}
}
