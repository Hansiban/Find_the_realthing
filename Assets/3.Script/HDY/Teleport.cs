using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Renderer teleport_color;
    [SerializeField] private PlayerMove_imsi player;
    private void Start()
    {
        player = FindObjectOfType<PlayerMove_imsi>();
        teleport_color = gameObject.GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))//태그 플레이어 썼다고 꼭 말해주기
        {
            if (teleport_color.material.color != Color.yellow)
            {
                teleport_color.material.color = Color.yellow;
                Invoke("ReturnColor", 2f);
                
            }
        }
        else
        {
            return;
        }
    }
    private void ReturnColor()
    {
        teleport_color.material.color = Color.magenta;
    }

}
