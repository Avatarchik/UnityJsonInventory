using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemBehavior : MonoBehaviour {
	
	public Item item;

	public void init(Item item) {
		this.item = item;

		//update icon
		this.updateIcon();
	}

	protected void updateIcon() {
		// get the sprite at the path
		Sprite sprite = Resources.Load<Sprite> (item.icon);
		if (sprite) {
			this.GetComponent<Image> ().sprite = sprite;
		}
	}
}
