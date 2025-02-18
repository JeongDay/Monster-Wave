using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public float rotationSpeed = 3f;

    private float theta;
    
    void Update()
    {
        // this.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        
        theta += Time.deltaTime * rotationSpeed;
        this.transform.localRotation = Quaternion.Euler(Vector3.up * 45f * Mathf.Sin(theta));

        Vector3 vecA = new Vector3(0, 3, 5);
        Vector3 vecB = new Vector3(7, 2, 1);

        float result1 = Vector3.Magnitude(vecB - vecA);
        float result2 = Vector3.Distance(vecB, vecA);
    }
}