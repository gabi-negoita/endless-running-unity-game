using UnityEngine;

public class DeployGround : MonoBehaviour
{
    public GameObject ground;

    private int startGroundObjects = 5;
    private int offset = 200;
    private int groundOffset = 0;

    void Start()
    {
        for (int i = 0; i < startGroundObjects; i++)
        {
            CreateGroundObject(ground);
        }
    }

    private void Update()
    {
        if (GameObject.Find("Player").transform.position.z + offset > groundOffset)
        {
            CreateGroundObject(ground);
            Debug.Log(groundOffset);
        }
    }

    void CreateGroundObject(GameObject obj)
    {
        GameObject objectToCreate;
        objectToCreate = Instantiate(obj) as GameObject;
        objectToCreate.transform.position = new Vector3(0, 0, groundOffset);
        groundOffset += 100;
    }
}
