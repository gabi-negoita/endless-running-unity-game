//using System;
using System.Collections;
using UnityEngine;

public class DeployDecor : MonoBehaviour
{
    public GameObject aloe;
    public GameObject cactus;
    public GameObject cactus_mini;
    public GameObject cactus_round;
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
    public GameObject rock5;
    public GameObject rock6;
    public GameObject rock7;
    public GameObject rock8;

    public float respawnTime;
    private Vector2 leftRange = new Vector2(-100, -10);
    private Vector2 rightRange = new Vector2(10, 100);
    private int offset = 150;

    void Start()
    {
        // Left side
        CreateEnvironmentObjects(aloe, 25, leftRange);
        CreateEnvironmentObjects(cactus, 20, leftRange);
        CreateEnvironmentObjects(cactus_mini, 25, leftRange);
        CreateEnvironmentObjects(cactus_round, 15, leftRange);
        CreateEnvironmentObjects(rock1, 5, leftRange);
        CreateEnvironmentObjects(rock2, 5, leftRange);
        CreateEnvironmentObjects(rock3, 5, leftRange);
        CreateEnvironmentObjects(rock4, 5, leftRange);
        CreateEnvironmentObjects(rock5, 5, leftRange);
        CreateEnvironmentObjects(rock6, 5, leftRange);
        CreateEnvironmentObjects(rock7, 5, leftRange);
        CreateEnvironmentObjects(rock8, 5, leftRange);

        // Right side
        CreateEnvironmentObjects(aloe, 25, rightRange);
        CreateEnvironmentObjects(cactus, 20, rightRange);
        CreateEnvironmentObjects(cactus_mini, 25, rightRange);
        CreateEnvironmentObjects(cactus_round, 15, rightRange);
        CreateEnvironmentObjects(rock1, 5, rightRange);
        CreateEnvironmentObjects(rock2, 5, rightRange);
        CreateEnvironmentObjects(rock3, 5, rightRange);
        CreateEnvironmentObjects(rock4, 5, rightRange);
        CreateEnvironmentObjects(rock5, 5, rightRange);
        CreateEnvironmentObjects(rock6, 5, rightRange);
        CreateEnvironmentObjects(rock7, 5, rightRange);
        CreateEnvironmentObjects(rock8, 5, rightRange);

        // Creating dynamic environment objects
        StartCoroutine(EnvironmentObjectsWave());
    }

    private void SpawnEnvironmentObjects()
    {
        // Left side
        CreateEnvironmentObjects(aloe, 5, leftRange, true);
        CreateEnvironmentObjects(cactus, 5, leftRange, true);
        CreateEnvironmentObjects(cactus_mini, 5, leftRange, true);
        CreateEnvironmentObjects(cactus_round, 5, leftRange, true);
        CreateEnvironmentObjects(rock1, 1, leftRange, true);
        CreateEnvironmentObjects(rock2, 1, leftRange, true);
        CreateEnvironmentObjects(rock3, 1, leftRange, true);
        CreateEnvironmentObjects(rock4, 1, leftRange, true);
        CreateEnvironmentObjects(rock5, 1, leftRange, true);
        CreateEnvironmentObjects(rock6, 1, leftRange, true);
        CreateEnvironmentObjects(rock7, 1, leftRange, true);
        CreateEnvironmentObjects(rock8, 1, leftRange, true);

        // Right side
        CreateEnvironmentObjects(aloe, 5, rightRange, true);
        CreateEnvironmentObjects(cactus, 5, rightRange, true);
        CreateEnvironmentObjects(cactus_mini, 5, rightRange, true);
        CreateEnvironmentObjects(cactus_round, 5, rightRange, true);
        CreateEnvironmentObjects(rock1, 1, rightRange, true);
        CreateEnvironmentObjects(rock2, 1, rightRange, true);
        CreateEnvironmentObjects(rock3, 1, rightRange, true);
        CreateEnvironmentObjects(rock4, 1, rightRange, true);
        CreateEnvironmentObjects(rock5, 1, rightRange, true);
        CreateEnvironmentObjects(rock6, 1, rightRange, true);
        CreateEnvironmentObjects(rock7, 1, rightRange, true);
        CreateEnvironmentObjects(rock8, 1, rightRange, true);
    }

    IEnumerator EnvironmentObjectsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnvironmentObjects();
        }
    }

    void CreateEnvironmentObjects(GameObject obj, int numberOfObjects, Vector2 range, bool isDynamic = false)
    {
        GameObject objectToCreate;
        Vector3 position;
        for (int i = 0; i < numberOfObjects; i++)
        {
            objectToCreate = Instantiate(obj) as GameObject;
            if (isDynamic)
            {
                float playerPosZ = GameObject.Find("Player").transform.position.z;
                position = new Vector3(Random.Range(range.x, range.y), 0, Random.Range(playerPosZ + offset, playerPosZ + offset * 1.25f));
            }
            else
            {
                position = new Vector3(Random.Range(range.x, range.y), 0, Random.Range(0,   offset));
            }
            objectToCreate.transform.position = position;
        }
    }
}
