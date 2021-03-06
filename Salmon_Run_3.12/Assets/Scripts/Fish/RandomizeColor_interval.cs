using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeColor_interval : MonoBehaviour{

	public Transform[] bones;
    
	Renderer rend;
	SkinnedMeshRenderer blendRenderer;

	void Start (){
		rend = GetComponent<Renderer> ();
		blendRenderer = GetComponent<SkinnedMeshRenderer> ();
        InvokeRepeating("GetRandomMonster",1f,1f);
	}
	void GetRandomMonster (){
		SetTints ();
		ResizeBones ();
		setBlendWeights ();
	
	}
	void SetTints (){
		rend.material.SetColor("_Color", GetAColor());
		rend.material.SetColor("_Color2", GetAColor());
		rend.material.SetColor("_Color3", GetAColor());
		rend.material.SetColor("_Color4", GetAColor());
		
	}
	Color GetAColor (){
		float h = Mathf.Pow(Random.Range(0f,1.0f),2);
        float s = 1.0f;						
		float v = Mathf.Pow(Random.Range(0.75f,1f),2);	
		return Color.HSVToRGB(h,s,v);
	}


	void ResizeBones (){
		for (int i=0; i<bones.Length-1; i+=1){
			var a = Random.Range(0.5f,1.5f);
			bones [i].localScale = new Vector3 (a, a, a);
		}
	}
	void setBlendWeights ()
        {
		    blendRenderer.SetBlendShapeWeight(0,Random.Range(0f,100f));
	    }
	
	bool randomBool (){
		return (Random.value > 0.5f);
	}
}