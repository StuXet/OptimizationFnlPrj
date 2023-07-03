using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class CubeSpawner : MonoBehaviour
{
    private const int NumberOfCubes = 2000;

    private List<GameObject> spawnedCubes = new List<GameObject>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Profiler.BeginSample("CubeSpawner");
            for (int i = 0; i < NumberOfCubes; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                spawnedCubes.Add(cube);
            }
            Profiler.EndSample();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Profiler.BeginSample("ClearCubeSpawner");
            foreach (GameObject cube in spawnedCubes)
            {
                Destroy(cube);
            }

            spawnedCubes.Clear();
            Profiler.EndSample();
        }
    }
}