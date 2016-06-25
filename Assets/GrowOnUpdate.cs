using UnityEngine;
using System.Collections;

public class GrowOnUpdate : MonoBehaviour {

	public GameObject node;

	public TreeNode tn;

	// Use this for initialization
	void Start () {
		tn = node.GetComponent<BasicNode> ();
	}
	
	// Update is called once per frame
	void Update () {
		tn.grow ();
	}
}
