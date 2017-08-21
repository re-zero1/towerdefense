using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inimigo : MonoBehaviour {
    [SerializeField] private int vida;

	// Use this for initialization
	void Start () {
        NavMeshAgent agente = GetComponent<NavMeshAgent> ();
        GameObject fimdocaminho = GameObject.Find("fimdocaminho");
        Vector3 posicaoDoFimCaminho = fimdocaminho.transform.position;
        agente.SetDestination(posicaoDoFimCaminho);
	}
    public void RecebeDano(int Damage){

        vida -= Damage;
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
   
	// Update is called once per frame
	
}
