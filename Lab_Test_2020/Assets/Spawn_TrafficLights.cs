using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_TrafficLights : MonoBehaviour
{
    public GameObject cylinder;
    public int numberOfCylinders;
    public float radius = 5;
    
    private void Start()
    {
      for(int i = 0; i< numberOfCylinders; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfCylinders;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(cylinder, pos, rot);

        }
    }

    private void Update()
    {

    }

}

