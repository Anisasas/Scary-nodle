using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public string nextLevelName = "Level 2"; // Kito lygio pavadinimas

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Patikrina, ar þaidëjas susidûrë su teleportacijos zona
        if (collision.CompareTag("Player"))
        {
            // Perkelia þaidëjà á nurodytà lygá
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
