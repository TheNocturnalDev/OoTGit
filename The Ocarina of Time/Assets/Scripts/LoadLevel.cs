using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    // Use this for initialization
    public void NextLevelButton(int index)
    {
        Application.LoadLevel(index);
    }

    // Update is called once per frame
    void Update () {
	
	}
}