//using System;
using System.Collections;
using UnityEngine;

public class DeployDelimiters : MonoBehaviour
{
    public GameObject delimiter;

    private int offset = 150;
    private int delimPos = 0;

    // Once per frame
    private void Update()
    {
        float playerPosZ = GameObject.Find("Player").transform.position.z;
        while (delimPos <= playerPosZ + offset)
        {
            CreateDelimitator(delimiter, 7);
        }
    }

    void CreateDelimitator(GameObject obj, int offsetFromCenter)
    {
        GameObject delimLeft;
        GameObject delimRight;

        Vector3 posLeft;
        Vector3 posRight;

        delimLeft = Instantiate(obj) as GameObject;
        delimRight= Instantiate(obj) as GameObject;

        posLeft = new Vector3(-offsetFromCenter, 0, delimPos);
        posRight= new Vector3(offsetFromCenter, 0, delimPos);

        delimLeft.transform.position = posLeft;
        delimRight.transform.position = posRight;

        delimPos++;
    }
}
