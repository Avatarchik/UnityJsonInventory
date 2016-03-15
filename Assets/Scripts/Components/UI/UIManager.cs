using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

	public GameObject 	SlotPrefab;
	public GameObject[] InventorySlots;

	public void Start() {
		this.loadJson ();
	}

	private void loadJson() {
		Inventory inventory = new Inventory ();
		JsonInterpreter.getDataFromJson<Inventory>(ref inventory, JsonInterpreter.getJsonFromFile("inventory"));
		if (null != inventory) {
			//create all dynamic slot
			foreach (Item item in inventory.items) {
				//instantiate slot
				GameObject SlotInstance = Instantiate (SlotPrefab);

				//update the item component
				ItemBehavior itemComponent = SlotInstance.GetComponent<ItemBehavior>();
				if (itemComponent) {
					itemComponent.init (item);
				}

				//add to the grid
				SlotInstance.transform.SetParent(this.transform);
			}
		}
	} 
}
