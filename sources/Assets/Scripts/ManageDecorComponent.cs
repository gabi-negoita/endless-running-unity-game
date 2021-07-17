using UnityEngine;

public class ManageGround : MonoBehaviour
{
    private GameObject mainCamera;
    private int offset = 100;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }
    void Update()
    {
        if (transform.position.z + offset < mainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
