using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class Item : BaseEntity {

	/********************************
	 * PROPERTIES
	 *******************************/

	public int id;
	public string name;
	public int size;
	public string icon;

	/********************************
	 * METHODS
	 *******************************/

	public Item (int id,  string name, int size) {
		this.id	  = id;
		this.name = name;
		this.size = size;
		this.icon = "";
	}
}
