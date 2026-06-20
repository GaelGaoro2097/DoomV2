using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationSpeed = new Vector3(0f,0f,0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public bool canRotate = true;

private void Update()
    {
        if (canRotate)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}
