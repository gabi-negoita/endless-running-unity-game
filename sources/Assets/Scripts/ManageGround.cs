using UnityEngine;

public class ManageDecorComponent : MonoBehaviour
{
    private GameObject mainCamera;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }
    void Update()
    {
        if (transform.position.z < mainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
