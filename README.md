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
----

## Entities
- All entities extend of the BaseEntity.
- Base entity not extend the MonoBehaviour class.
- Item entity contain main informations for this example.
- Inventory entity contain array of items.
- Don't forget to add [Serializable] attribute above the entity
