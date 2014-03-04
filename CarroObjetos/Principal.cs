using UnityEngine;
using System.Collections;

public class Principal : MonoBehaviour {
	
	void Start () {

		Carroceria carro = new Carroceria ();
		carro.CrearCarroceria ();
		Llantas llantas = new Llantas ();
		llantas.CrearLlantas ();
	
	}

	void Update () {
	
	}
}
