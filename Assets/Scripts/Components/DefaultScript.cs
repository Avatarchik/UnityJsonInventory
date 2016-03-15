using UnityEngine;
using System.Collections;

public class DefaultScript : MonoBehaviour {

	void Start () {
		//create json
		//this.generateJson ();

		//load from json file
		//this.loadJson();
	}

	private void loadJson() {
		Inventory inventory = new Inventory ();
		JsonInterpreter.getDataFromJson<Inventory>(ref inventory, JsonInterpreter.getJsonFromFile("inventory"));
		if (null != inventory) {
			Debug.Log (inventory.items.Length);
		}
	} 

	private void generateJson() {
		//simulate content
		Item[] items = {
			new Item(1, "Potion", 6),
			new Item(2, "Ether", 3),
			new Item(3, "Boots", 1),
			new Item(4, "Sword", 5),
		};
		Inventory inventory = new Inventory (items);

		Debug.LogWarning(JsonInterpreter.getJsonWithEntity<Inventory>(inventory));
	}
}
