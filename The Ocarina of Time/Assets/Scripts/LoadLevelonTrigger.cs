using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelonTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LoadFiled"))
        {
            SceneManager.LoadScene("Field");
        }
    }
}

