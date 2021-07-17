using System.Collections;
using UnityEngine;

public class DeployObstacles : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;

    public float respawnTime;
    private Vector2 range1 = new Vector2(-6, 3);
    private Vector2 range2 = new Vector2(-4, 5);
    private Vector2 range3 = new Vector2(0, 0);
    private int offset = 150;

    void Start()
    {
        // Creating dynamic environment objects
        StartCoroutine(EnvironmentObjectsWave());
    }

    private void SpawnEnvironmentObjects()
    {
        // Spawing based on 
        int number = Random.Range(0, 100);
        if (number < 45)
        {
            CreateObstacles(obstacle2, 1, range2);
        } else if (number < 90)
        {
            CreateObstacles(obstacle1, 1, range1);
        } else
        {
            CreateObstacles(obstacle3, 1, range3);
        }

    }

    IEnumerator EnvironmentObjectsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnvironmentObjects();
        }
    }

    void CreateObstacles(GameObject obj, int numberOfObjects, Vector2 range)
    {
        GameObject obstacleToCreate;
        Vector3 position;

        for (int i = 0; i < numberOfObjects; i++)
        {
            obstacleToCreate = Instantiate(obj) as GameObject;
            
            float playerPosZ = GameObject.Find("Player").transform.position.z;
            position = new Vector3(Random.Range(range.x, range.y), 0.5f, playerPosZ + offset);

            Vector3 newScale = new Vector3(5, 5, 5);                // linie adaugata
            obstacleToCreate.transform.localScale = newScale;       // linie adaugata

            Quaternion newRotation = Quaternion.Euler(0, 45, 0);    // linie adaugata
            obstacleToCreate.transform.rotation = newRotation;      // linie adaugata

            obstacleToCreate.transform.position = position;
        }
    }
}
