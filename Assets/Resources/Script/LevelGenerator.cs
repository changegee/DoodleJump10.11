using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject Prefab;
    public float levelWidth = 2f;
    /// <summary>
    /// 输入总数，最小值，最大值
    /// </summary>

    //Normoal Platform
    public float[] data = new float[] { 400f, .6f, 1.5f };

    // Use this for initialization
    void Start()
    {
        NewMethod(Prefab, data);
    }

    void NewMethod(GameObject Prefab, float[] data)
    {
        Vector3 spawnPosition = new Vector3();
        for (var i = 0; i < data[0]; i++)
        {
            spawnPosition.y += Random.Range(data[1], data[2]);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(Prefab, spawnPosition, Quaternion.identity);
        }
    }
}
