using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Move : MonoBehaviour
{
    [Header("Ÿ��")]
    [SerializeField] private Transform[] TargetPos;
    private Transform Target = null;
    private Animator ani;
    

    [SerializeField] private float MoveSpeed = 3f;    
    private void Start()
    {
        TryGetComponent<Animator>(out ani);
    }

    public void Move()
    {
        if (Target == null)
        {
            TargetSetting();
        }
        if (Target != null)
        {
            transform.position += transform.forward * Time.deltaTime * MoveSpeed;

            if (isArrive())
            {
                Target = null;
            }
        }
    }

    private void TargetSetting()
    {
        Target = TargetPos[Random.Range(0, TargetPos.Length)];           // ���� Ÿ�ټ���
        transform.forward = Target.position - transform.position;        // Ÿ�� �ٶ󺸱�
       
    }

    private bool isArrive()        // Ÿ�� �ֺ��� �ִ���
    {
        return (Vector3.Magnitude(transform.position - Target.position) < 1) ? true : false;
    }

}
