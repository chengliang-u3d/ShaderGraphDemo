using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AccessProperty : MonoBehaviour {

    Material curMaterial;

    Light curLight;

	// Use this for initialization
	void Start () {
        curMaterial = GetComponent<MeshRenderer>().sharedMaterials[0];
        //Color tmp = curMaterial.GetColor("Color_CB4C3EA6");
        curMaterial.SetColor("Color_CB4C3EA6", Color.red);

        curLight = GameObject.Find("Directional Light").GetComponent<Light>();

        curMaterial.SetVector ("Vector3_6D9D3964", curLight.transform.forward);

        curMaterial.SetFloat("Vector1_54A6A2AC", curLight.intensity);

        //curMaterial.Set
        //Vector3_6D9D3964
	}
	
	// Update is called once per frame
	void Update () {

        curMaterial.SetVector("Vector3_6D9D3964", -curLight.transform.forward);

        curMaterial.SetFloat("Vector1_54A6A2AC", curLight.intensity);

	}
}
