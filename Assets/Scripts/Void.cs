using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            gm.SetGameOver();
        }
    }
}
