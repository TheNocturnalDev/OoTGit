using UnityEngine;
using System.Collections;

public class SpawnHField : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        var fromkak = GameObject.FindGameObjectWithTag("FromKak").transform;
        var fromlake = GameObject.FindGameObjectWithTag("FromLake").transform;
        var usual = GameObject.FindGameObjectWithTag("DefaultSpawn").transform;
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        if (check.Location == 3)
        {
            transform.position = fromkak.transform.position;
            check.Location = 0;
        }
        else if (check.Location == 6) {
            transform.position = fromlake.transform.position;
            check.Location = 0;
        }
        else
        {
            transform.position = usual.transform.position;
            check.Location = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
