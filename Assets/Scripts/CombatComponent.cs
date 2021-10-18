using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatComponent : MonoBehaviour
{
    //all projectile paterns.
    [SerializeField] ParticleSystem attackPatern;

    [SerializeField] ParticleSystem defensePatern;

    [SerializeField] ParticleSystem superPatern;


    //The scriptable object containing the stats.
    [SerializeField] AttackStatsSO[] attack = new AttackStatsSO[3];

    //a bool to know if the attacks is on cooldown.
    bool fireCooldown = false;
    bool defenseCooldown = false;
    bool superCooldown = false;

    //This three functions "On(...)" come from the input manager.
    void OnFire()
    {
        if (fireCooldown == false)
        {
            attackPatern.Play();
            fireCooldown = true;
            StartCoroutine(Recharge(attack[0].recharge, 0));
        }
    }

    void OnDefense()
    {
        if (defenseCooldown == false)
        {
            defensePatern.Play();
            defenseCooldown = true;
            StartCoroutine(Recharge(attack[1].recharge, 1));
        }
    }

    void OnSuper()
    {
        if(superCooldown == false)
        {
            superPatern.Play();
            superCooldown = true;
            StartCoroutine(Recharge(attack[2].recharge, 2));
        }
    }

    //handles cooldown for each attack
    IEnumerator Recharge(float recharge, int indicator)
    {
        yield return new WaitForSeconds(recharge);

        switch (indicator)
        {
            case 0:
                fireCooldown = false;
                break;

            case 1:
                defenseCooldown = false;
                break;

            case 2:
                superCooldown = false;
                break;
        }
    }
}
