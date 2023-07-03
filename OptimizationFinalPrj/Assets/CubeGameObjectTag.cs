using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class CubeGameObjectTag : MonoBehaviour
{
    public GameObject cubePrefab;

    private GameObject[] cubes;

    private float cubeSize = 1f;

    void Start()
    {
        cubes = new GameObject[40000];

        for (int i = 0; i < cubes.Length; i++)
        {
            GameObject cube = Instantiate(cubePrefab);
            cube.transform.position = new Vector3(i % 100 * cubeSize, (i / 100) % 100 * cubeSize, (i / 10000) * cubeSize);
            cubes[i] = cube;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Profiler.BeginSample("tag==");
            foreach (var cube in cubes)
            {
                if (cube.tag == "Cube")
                {
                }
            }
            Profiler.EndSample();
        }
    }
}