using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    
    public float EnginePower = 50f;
    public float TurnPower = 50f;
    public float HealthMax = 3f;
    private float healthCurrent;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        healthCurrent = HealthMax;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        ApplyThrust(vert);
        ApplyTorque(horiz);
    }
    public void ApplyThrust (float amount)
    {
        Vector2 thrust = transform.up * EnginePower * Time.deltaTime * amount;
        rb2d.AddForce(thrust);
    }
    
    public void ApplyTorque (float amount)
    {
        float torque = amount * TurnPower * Time.deltaTime;
        rb2d.AddTorque(torque);
    }

// reduce HP
    public void TakeDamage(float damage)
    {
        healthCurrent = healthCurrent - damage;
        if (healthCurrent <= 0f)
        {
            Explode();
        }
    }

// player dies
    public void Explode()
    {
        Debug.Log("You DIED!!!!!");
        Destroy(gameObject);
    }
}
