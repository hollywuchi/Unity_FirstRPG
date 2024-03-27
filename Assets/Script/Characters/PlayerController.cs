using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        // MouseManager.Instance.p();
        anim = GetComponent<Animator>();

    }
    void OnEnable()
    {
        
    }
    void Start()
    {
        MouseManager.Instance.OnMouseClick += MoveToTarget;
    }
    void OnDisable()
    {
        MouseManager.Instance.OnMouseClick -= MoveToTarget;
    }

    void Update()
    {
        SwitchAnimation();
    }
    void MoveToTarget(Vector3 Target)
    {
        agent.destination = Target;
    }

    void SwitchAnimation()
    {
        anim.SetFloat("Speed",agent.velocity.sqrMagnitude);
        // 返回这个向量的长度的平方
        // 开根号的计算量是相当大的，计算长度的平方显然速度要更快
        // 如果仅仅是比较大小，那么是否开根号将会得到相同的结果
    }
}
