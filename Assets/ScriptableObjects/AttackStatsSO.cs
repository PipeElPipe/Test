using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack", menuName = "Add Attack")]
public class AttackStatsSO : ScriptableObject
{
    //This scritable objects can be easily added to create new attacks and modified for new characteristics.
    [SerializeField] public float recharge;
}
