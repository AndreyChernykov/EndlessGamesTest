using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] SpawnerObjects spawnerObjects;
    [SerializeField] BoxController boxController;
    [SerializeField] UI ui;
    [SerializeField] Transform spawnPoint;

    public float spawnDelay { get; set; }
    public float distance { get; set; }

    void Start()
    {
        
        spawnerObjects.FillPool(spawnPoint);

        IEnumerator Spawn = spawnerObjects.Spawn(spawnPoint);
        StartCoroutine(Spawn);

        IEnumerator Drag = boxController.Drag(spawnerObjects.pool, spawnPoint);
        StartCoroutine(Drag);

        ui.SetStart();
    }

    public void SetSpeed(float speed)
    {
        boxController.speed = speed;
    }

    public void SetDistance(float distance)
    {
        boxController.distance = distance;
    }

    public void SetDelay(float delay)
    {
        spawnerObjects.spawnDelay = delay;
    }

}
