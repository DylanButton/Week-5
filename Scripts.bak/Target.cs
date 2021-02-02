
using UnityEngine;

public class Target : MonoBehaviour
{
public float health = 50f;
public GameObject DeathParticles;


public void takeDamage(float damage)
{
    
    health -= damage;
    if (health<=0f){
        Instantiate(DeathParticles, transform.position, transform.rotation);
        Die();

    }

    void Die()
    {
        Destroy(gameObject);
    }
}
    }

