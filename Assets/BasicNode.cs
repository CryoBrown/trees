using UnityEngine;
using System.Collections;

public class BasicNode : MonoBehaviour, TreeNode {
	public GameObject node;

	private TreeNode parent = null;
	private TreeNode[] children;

	private double growthThreshold = 3;
	private int splitFactor = 2;
	private double childScale = .5;
	private double growthRate = .05;
	private double growthProgress = 0;
	private bool growing = true;

	public void destroy()
	{
		Object.Destroy (node);
	}

	public void grow()
	{
		if (growing) {
			growthProgress += growthRate;
			if (growthProgress >= growthThreshold) {
				growthProgress = 0;
				growing = false;
				createChildren ();
			}
		}
	}

	// Use this for initialization
	void Start () {	
		children = new TreeNode[splitFactor];
		//node.transform.localScale.Scale();
		//parent.destroy();
		//parent = null;
	}

	// Update is called once per frame
	void Update () {
	}

	public TreeNode[] getChildren() {
		return children;
	}

	public TreeNode getParent() {
		return parent;
	}

	public void setParent(TreeNode t){
		parent = t;
	}

	void createChildren(){

		float x = node.transform.position.x;
		float y = node.transform.position.y;
		float rad = node.GetComponent<CircleCollider2D>().radius;

		float lx = Random.Range (x - rad, x - rad * 2);
		float ly = Random.Range (y + rad, y + rad * 2);

		float rx = Random.Range (x + rad, x + rad * 2);
		float ry = Random.Range (y + rad, y + rad * 2);

		TreeNode l = (Instantiate (node, new Vector3 (lx, ly), Quaternion.identity) as GameObject).GetComponent<TreeNode>();
		TreeNode r = (Instantiate (node, new Vector3 (rx, ry), Quaternion.identity) as GameObject).GetComponent<TreeNode>();
		l.setParent (this);
		r.setParent	(this);
		children [0] = l;
		children [1] = r;
	}
}
