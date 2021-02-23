using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Moveinto : MonoBehaviour
{
    public GameObject game;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            game.SetActive(true);
        }
    }
}
