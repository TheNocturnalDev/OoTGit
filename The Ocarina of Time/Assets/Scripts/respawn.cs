using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {
public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("respawntrigger"))
        {
            var respoint = GameObject.FindGameObjectWithTag("respawn").transform;
            var vars = GameObject.FindGameObjectWithTag("GameController");
            var check = vars.GetComponent<VarTracker>();
            check.health = check.health - 2;
            transform.position = respawn.transform.position;
        }
    }
}
