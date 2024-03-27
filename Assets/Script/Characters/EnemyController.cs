using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    public EnemyState enemyState;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        SwitchEnemyState();
    }
    void SwitchEnemyState()
    {
        switch (enemyState)
        {
            case EnemyState.Gruad:
                break;
            case EnemyState.Patrol:
                break;
            case EnemyState.Chase:
                break;
            case EnemyState.Dead:
                break;
        }
    }
}
