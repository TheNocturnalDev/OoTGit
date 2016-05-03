using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadKakoriko : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ToKakariko"))
        {
            SceneManager.LoadScene("Kakoriko");
        }
    }
}
