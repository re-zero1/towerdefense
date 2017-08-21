using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    [SerializeField] private GameObject inimigopre;
    private float tempoparaoproximo;
    [Range(0,3)]
    [SerializeField] private float criacao = 2f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Gerainimigo();
	}
    private void Gerainimigo(){
        float tempoatual = Time.time;
        if(tempoatual > tempoparaoproximo + criacao){
            tempoparaoproximo = tempoatual;
            Vector3 posicaodogerador = this.transform.position;
            Instantiate(inimigopre, posicaodogerador, Quaternion.identity);
        }
    }
   
}
