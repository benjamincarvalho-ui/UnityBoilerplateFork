using System;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform Respawn;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var controller = FindAnyObjectByType<LevelUIController>();
            controller.Kill();
            other.transform.position = Respawn.position;
        }
    }
}
