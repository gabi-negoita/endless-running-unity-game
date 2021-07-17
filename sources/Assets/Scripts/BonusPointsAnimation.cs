using UnityEngine;

public class BonusPointsAnimation : MonoBehaviour
{
    private float ratationAngle = 1f;
    private float positionOffset = 90f;
    
    void Update()
    {
        transform.rotation = Quaternion.Euler(-90, 0, ratationAngle);
        ratationAngle = ratationAngle == 360 ? 0 : ratationAngle + 0.5f;

        transform.position = new Vector3(transform.position.x,
                                         transform.position.y + Mathf.Sin(positionOffset * Mathf.Deg2Rad) * Time.deltaTime,
                                         transform.position.z);
        positionOffset = positionOffset == 360 ? 0 : positionOffset + 1f;
    }
}
