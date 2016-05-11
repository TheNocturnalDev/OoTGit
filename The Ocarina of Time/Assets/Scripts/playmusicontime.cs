using UnityEngine;
using System.Collections;

public class playmusicontime : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        var audio1 = GameObject.FindGameObjectWithTag("Audio1");
        var audio2 = GameObject.FindGameObjectWithTag("Audio2");
        audio2.SetActive(false);
        audio1.SetActive(false);
        if (check.time > 0 && < 16 ) {
          audio1.SetActive(true); // Audio 1 has both the intro and the loop, with simple scripting to use both, while Audio 2 has only the loop, whicj just plays in the ELSE Statement
        }
        else {
          audio2.SetActive(true);
        }
}
