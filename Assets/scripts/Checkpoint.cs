using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public string nextLevelName = "Level 2"; // Kito lygio pavadinimas

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Patikrina, ar �aid�jas susid�r� su teleportacijos zona
        if (collision.CompareTag("Player"))
        {
            // Perkelia �aid�j� � nurodyt� lyg�
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
