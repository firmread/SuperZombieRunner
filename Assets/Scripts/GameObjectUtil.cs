﻿using UnityEngine;
using System.Collections;

public class GameObjectUtil {
	public static GameObject Instantiate(GameObject prefab, Vector3 pos){
		GameObject instance = null;
		instance = GameObject.Instantiate (prefab);
		instance.transform.position = pos;

		return instance;
	
	}
	public static void Destroy(GameObject gameObject){

		var recycleGameObject = gameObject.GetComponent<RecycleGameObject> ();

		if(recycleGameObject != null) {
			recycleGameObject.Shutdown ();
		}else {
			GameObject.Destroy (gameObject);
		}
	}


}
