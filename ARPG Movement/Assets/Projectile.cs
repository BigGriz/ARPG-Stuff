using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage;
    public float speed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.ToString() == "Enemy")
        {
            Debug.Log(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
