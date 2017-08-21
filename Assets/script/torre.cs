using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class torre : MonoBehaviour {
    public GameObject projetilPrefab;
    public float tempoDerecarga = 1f;
    private float momentoDoDisparo;
	// Use this for initialization
	void Update () {
        atirar();
	}
    private void atirar(){
        float tempoatual = Time.time;
        if(tempoatual > momentoDoDisparo + tempoDerecarga){
            momentoDoDisparo = tempoatual;
        GameObject pontoDeDisparo = this.transform.Find("CanhaoDaTorre/PontodeDisparo").gameObject;
        Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
        Instantiate(projetilPrefab, posicaoDoPontoDeDisparo, Quaternion.identity);
        }
    }
	// Update is called once per frame
	
}
