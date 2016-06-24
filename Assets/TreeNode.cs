using UnityEngine;
using System.Collections;

public class TreeNode : MonoBehaviour {

	public GameObject node;

	private double growthThreshold = 3;
	private double splitFactor = 2;
	private double childSize = .5;
	private double growthRate = .05;
	private double growthProgress = 0;
	private bool growing = true;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
//		if (!growing) return;
//		growthProgress += growthRate;
//		if (growthProgress >= growthThreshold) {
//			growthProgress = 0;
//			growing = false;
//			createChildren();
//		}
	}

	void createChildren(){
//		Component[] comps = node.GetComponents<Component>();
//		GameObject l = new GameObject();
//		GameObject r = new GameObject();
//		for (int i = 0; i < comps.Length; i++) {
//			l.AddComponent (comps[i].GetType);
//			r.AddComponent (comps[i].GetType);
//		}
//
//		float x = node.transform.position.x;
//		float y = node.transform.position.y;
//		float rad = node.GetComponent<CircleCollider2D>().radius;
//
//		l.transform.position.Set(x-rad, y+rad, 0);
//		r.transform.position.Set(x+rad, y+rad, 0);
//
//		l.SetActive (true);
//		r.SetActive(true);
	}
}
