using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private const int NumberOfCubes = 2000;

    private List<GameObject> spawnedCubes = new List<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < NumberOfCubes; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                spawnedCubes.Add(cube);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (GameObject cube in spawnedCubes)
            {
                Destroy(cube);
            }

            spawnedCubes.Clear();
        }
    }
}