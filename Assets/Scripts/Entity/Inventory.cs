using UnityEngine;
using System.Collections;

public class Inventory : BaseEntity {

	/********************************
	 * PROPERTIES
	 *******************************/

	public Item[] items;

	/********************************
	 * METHODS
	 *******************************/

	public Inventory () {}

	public Inventory (Item[] items) {
		this.items = items;
	}
}
