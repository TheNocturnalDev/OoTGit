using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadKokiri : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("toforest"))
        {
            SceneManager.LoadScene("Kokiri Forest");
        }
    }
}
