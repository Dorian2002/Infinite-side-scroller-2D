using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMvmnts : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(new Vector3(-0.1f,0,0));
    }
}
