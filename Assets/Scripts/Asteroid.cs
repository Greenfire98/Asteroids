using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float CollisionDamage = 3f;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Spaceship ship = collision.gameObject.GetComponent <Spaceship> ();
        if (ship != null)
        {
            ship.TakeDamage (CollisionDamage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            // jdasklsdaklasdkl
    }


}

