using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    [SerializeField] GameObject objectForSpawn;
    [SerializeField] int poolSize;
    public float spawnDelay { get; set; }

    public List<GameObject> pool { get; private set; }

    public void FillPool(Transform spawnPoint)
    {
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectForSpawn, spawnPoint);
            obj.SetActive(false);
            obj.transform.parent = spawnPoint;
            pool.Add(obj);
        }
    }

    private void GetItPool(Transform positionSpawn)
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeSelf)
            {
                obj.transform.position = positionSpawn.position;
                obj.SetActive(true);
                break;
            }
        }
    }

    public IEnumerator Spawn(Transform spawnPoint)
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);

            GetItPool(spawnPoint);
        }
    }

    
}
