using UnityEngine;
using System.Collections;

public class spawnkokiri : MonoBehaviour {

	// Use this for initialization
	void Start () { //Will need to add a spawn for every single house -_-
        var fromfield = GameObject.FindGameObjectWithTag("FromField").transform;
        var fromwoods = GameObject.FindGameObjectWithTag("fromwoods").transform;
        var usual = GameObject.FindGameObjectWithTag("DefaultSpawn").transform;
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        var time = vars.GetComponent<timemanager>();
        //No Map So only time pause is here for now
        time.usetime = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
