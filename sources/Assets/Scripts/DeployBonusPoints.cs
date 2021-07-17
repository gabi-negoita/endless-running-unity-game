using System.Collections;
using UnityEngine;

public class DeployBonusPoints : MonoBehaviour
{
    public GameObject diamond;

    private int offset = 150;
    private Vector3 position;
    
    private void Start()
    {
/*        Vector3 pos = new Vector3(0, 1, 60);
        GenerateObject(diamond, pos);

        Collider[] intersecting = Physics.OverlapSphere(pos, 0.01f);
        if (intersecting.Length == 0)
        {
            Debug.Log("Empty");
        } 
        else
        {
            Debug.Log("Occupied");
        }*/

        StartCoroutine(skipBonusPoints());
    }

    void GenerateObject(GameObject objectToRender, Vector3 position)
    {
        GameObject point;
        point = Instantiate(objectToRender) as GameObject;
        point.transform.position = position;
    }

    IEnumerator skipBonusPoints()
    {
        while (true)
        {
            if (this.enabled)
            {
                position = new Vector3(Mathf.Round(Random.Range(-6, 6)), 1f, (int)GameObject.Find("Player").transform.position.z + offset);
                int n = Random.Range(10, 50);
                for (int i = 1; i <=n; i++)
                {
                    GenerateObject(diamond, position);
                    position.z += 2;
                }
            }

            yield return new WaitForSeconds(Random.Range(5, 10));
            this.enabled = !this.enabled;
        }
    }
}
