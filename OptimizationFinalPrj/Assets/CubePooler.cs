using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class CubePooler : MonoBehaviour
{
    private const int NumberOfCubes = 2000;

    private List<GameObject> cubePool = new List<GameObject>();

    private List<GameObject> activeCubes = new List<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < NumberOfCubes; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.SetActive(false);
            cubePool.Add(cube);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Profiler.BeginSample("CubePooler");
            for (int i = 0; i < NumberOfCubes; i++)
            {
                if (cubePool.Count > 0)
                {
                    GameObject cube = cubePool[0];
                    cubePool.RemoveAt(0);
                    cube.transform.position = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
                    cube.SetActive(true);
                    activeCubes.Add(cube);
                }
            }
            Profiler.EndSample();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Profiler.BeginSample("ClearCubePooler");
            foreach (GameObject cube in activeCubes)
            {
                cube.SetActive(false);
                cubePool.Add(cube);
            }

            activeCubes.Clear();
            Profiler.EndSample();
        }
    }
}