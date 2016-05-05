using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("respawntrigger"))
        {
            var respoint = GameObject.FindGameObjectWithTag("Respawn").transform;
            var vars = GameObject.FindGameObjectWithTag("GameController");
            var check = vars.GetComponent<VarTracker>();
            check.hp = check.hp - 2;
            transform.position = respoint.transform.position;
        }
    }
}
