using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;
    void FixedUpdate()
    {
        transform.Translate(0,0,_speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _speed = 0f;
        }
    }
}
