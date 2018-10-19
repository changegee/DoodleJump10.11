using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject Prefab;
    public float levelWidth = 2f;

    //Normoal Platform
    public float[] data = new float[] { 400f, .6f, 1.5f };

    // Use this for initialization
    void Start()
    {
        BuidePlatform(Prefab, data);
    }
    /// <summary>
    /// 设置新的平台
    /// </summary>
    /// <param name="Prefab">平台预制物</param>
    /// <param name="data">平台间隔分布范围（最小间距，最大间距）</param>
    void BuidePlatform(GameObject Prefab, float[] data)
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
