using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCam : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;

    public bool onDie = false;
    
    private void Update()
    {
        transform.position = target.position + offset;

        if (onDie)
        {

        }
        else
        {
           
        }
    }
}
