# UnityJsonInventory
A small project with json serialization and loading datas to a simple inventory.
## How it's work ?
the UIManager class load the JSON file in the "Resources" folder and put the data in the JsonInterpreter  
class (all statics methods available anywhere in the code).  
Then the JsonInterpreter get the data with the json string and hydrate the generic type given.  
Return ready data !

## Caution
Your entity is like a "model", all variable should be in the json file,  
that's how Unity Json serialization parsing work.

## Example

### Items.json
```json
{
    "items":
    [
        {
            "id":1,
            "name": "Potion",
        },
        {
            "id":2,
            "name": "Ether",
        },
        {
            "id":3,
            "name": "Boots",
        },
        {
            "id":4,
            "name": "Sword",
        }
    ]
}
```

### Item.cs
```csharp
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

	/********************************
	 * METHODS
	 *******************************/

	public Item (int id,  string name, int size) {
		this.id	  = id;
		this.name = name;
	}
}
```

### DefaultBehaviour.cs
```csharp
using UnityEngine;
using System.Collections;

public class DefaultBehaviour : MonoBehaviour {

	void Start () {
		//create json
		this.generateJson ();

		//load from json file
		this.loadJson();
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
```

----

## Entities
- All entities extend of the BaseEntity.
- Base entity not extend the MonoBehaviour class.
- Item entity contain main informations for this example.
- Inventory entity contain array of items.
- Don't forget to add [Serializable] attribute above the entity
