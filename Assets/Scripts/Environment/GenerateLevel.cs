using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPosition = 100;
    public bool creatingSection = false;
    public int sectionNumber;
    public NavMeshSurface navMeshSurface;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(-3.848811f, -25.32956f, zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(4);
        creatingSection = false;
        navMeshSurface.BuildNavMesh();

    }
}
