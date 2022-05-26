using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContactScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy") || other.tag == "Zombiee")
        {
            DestroyObject(this.gameObject);
            LoadEndScene();
        }
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene(2);
    }
}
