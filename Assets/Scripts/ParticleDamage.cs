using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDamage : MonoBehaviour
{
    //the stats
    [SerializeField] Stats stats;
    [SerializeField] float particleDamage;

    //each time a particle collides, deals damage.
    private void OnParticleCollision()
    {
        if (true)
        {
            stats.health -= particleDamage;
        }
    }
}
