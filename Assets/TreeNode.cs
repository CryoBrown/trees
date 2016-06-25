using UnityEngine;
using System.Collections;

public interface TreeNode {

	TreeNode[] getChildren();
	TreeNode getParent();

	void grow();

	void setParent(TreeNode t);
	void destroy();
}
