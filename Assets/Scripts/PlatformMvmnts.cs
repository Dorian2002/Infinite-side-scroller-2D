using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMvmnts : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    private void Start()
    {
        gm = GetComponentInParent<GameManager>();
    }
    void FixedUpdate()
    {
        float speed = 0.1f + ((float)gm.GetScore()/1000f);
        transform.Translate(new Vector3(-speed,0,0));
    }
}
