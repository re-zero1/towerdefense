using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misel : MonoBehaviour {
    private float velocidade = 5;
    private GameObject alvo;
    [SerializeField] private int pontosDeDanos;
	// Use this for initialization
	void Start () {
        alvo = GameObject.Find("inimigo(Clone)");
        Miseldestroy(3);
	}
	
	// Update is called once per frame
	void Update () {
        anda();
        if (GameObject.Find("inimigo(Clone)") != null)
        {
            AlteraDireção();
        }

	}
    private void anda(){
        Vector3 posicaoatual = transform.position;
        Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
        transform.position = posicaoatual + deslocamento;
    }
    private void AlteraDireção(){
        try{
        Vector3 posicaoatual = transform.position;
        Vector3 posicaoDoAlvo = alvo.transform.position;
        Vector3 direcaodoalvo = posicaoDoAlvo - posicaoatual;
            transform.rotation = Quaternion.LookRotation(direcaodoalvo);
        }
        catch{}
    }
    private void Miseldestroy(float segundos){
        Destroy(this.gameObject, segundos);
    }
   
    void OnTriggerEnter(Collider elementoColidido){
        if (elementoColidido.CompareTag("Inimigo"))
        {
            Destroy(this.gameObject);
            inimigo inimigo = elementoColidido.GetComponent<inimigo>();
            inimigo.RecebeDano(pontosDeDanos);

        }
    }
}
