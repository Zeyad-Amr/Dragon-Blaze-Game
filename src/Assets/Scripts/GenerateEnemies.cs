using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int frameCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GenerateEnemies.Start");
    }

    // Update is called once per frame
    void Update()
    {
        // prefab size
        Vector3 prefabSize = enemyPrefab.GetComponent<Renderer>().bounds.size;
        if (frameCount % 100 == 0)
        {
            Debug.Log("GenerateEnemies.Update");
            Instantiate(enemyPrefab, new Vector3(Utils.xDimesion + 1f, Random.Range(-1.5f + prefabSize.y / 2, Utils.yDimesion - prefabSize.y / 2), -1f), Quaternion.identity);
            // Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
        frameCount++;
    }
}
