using UnityEngine;
using System.Collections;

public class Llantas {

	public void CrearLlantas(){

		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3(1.081525f,0.8510752f,0.2259815f);
		cylinder.transform.Rotate(90f,270f,0f);
		cylinder.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);

		GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder2.transform.position = new Vector3(-0.7125183f,0.8510752f,-2.906469f);
		cylinder2.transform.Rotate(90f,270f,0f);
		cylinder2.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);

		GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder3.transform.position = new Vector3(1.081525f,0.8510752f,-2.906469f);
		cylinder3.transform.Rotate(90f,270f,0f);
		cylinder3.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);

		GameObject cylinder4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder4.transform.position = new Vector3(-0.7125183f,0.8510752f,0.2259815f);
		cylinder4.transform.Rotate(90f,270f,0f);
		cylinder4.transform.localScale= new Vector3(1.225088f,0.09770568f,1.225088f);

		}
}
