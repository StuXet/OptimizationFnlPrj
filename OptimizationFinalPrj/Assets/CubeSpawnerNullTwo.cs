using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerNullTwo : MonoBehaviour
{
    private GameObject[] cubes;

    private float cubeSize = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubes = new GameObject[30000];

            for (int i = 0; i < cubes.Length; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(i % 100 * cubeSize, (i / 100) % 100 * cubeSize, (i / 10000) * cubeSize);
                cubes[i] = cube;
            }

            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i] = null;
            }

            for (int i = 0; i < cubes.Length; i++)
            {
                if (cubes[i] != null)
                {
                    Debug.Log("Cube at index " + i + " is not null.");
                }
            }
        }
    }
}