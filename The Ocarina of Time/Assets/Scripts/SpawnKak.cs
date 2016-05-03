using UnityEngine;
using System.Collections;

public class SpawnKak : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var fromfield = GameObject.FindGameObjectWithTag("FromField").transform;
        var fromvolcano = GameObject.FindGameObjectWithTag("FromVolcano").transform;
        var usual = GameObject.FindGameObjectWithTag("DefaultSpawn").transform;
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        if (check.Location == 0)
        {
            transform.position = fromfield.transform.position;
            check.Location = 3;
        }
        else if (check.Location == 5)
        {
            transform.position = fromvolcano.transform.position;
            check.Location = 3;
        }
        else
        {
            transform.position = usual.transform.position;
            check.Location = 3;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
