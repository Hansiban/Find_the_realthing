using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_State : MonoBehaviour
{
    private AI_Move ai_Move;
    private Animator animator;

    private bool isDie = false;     // �׾�����

    private void Awake()
    {
        TryGetComponent<AI_Move>(out ai_Move);
        TryGetComponent<Animator>(out animator);
    }

    private void Update()
    {
        if (!isDie)
        {
            ai_Move.Move();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        OnDie();    // �÷��̾�� �¾��� �� OnDie �޼ҵ� ȣ��
    }

    private void OnDie()
    {
        isDie = true;
    }
}
