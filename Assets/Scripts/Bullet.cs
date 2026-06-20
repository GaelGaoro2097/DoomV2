using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
[SerializeField]
private float speed = 20f;
private float damage = 10f;
public float Damage{set{damage=value;}}
void Awake()
    {
        GetComponent<Rigidbody>().linearVelocity = transform.forward*speed;
    }
    private void OnCollisionEnter(Collision collision)
     {
        Destroy(gameObject);
    }
}
