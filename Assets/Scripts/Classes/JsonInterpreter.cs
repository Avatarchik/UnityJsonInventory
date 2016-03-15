using UnityEngine;
using System.Collections;

public class JsonInterpreter {

	public static string getJsonWithEntity<T>(T entity) {
		if (entity.GetType().BaseType == typeof(BaseEntity)) {
			return JsonUtility.ToJson(entity);
		} else {
			Debug.Log (string.Format("Entity is not a inheritance of BaseEntity class, given {0}", entity.GetType().BaseType));
		}

		return "";
	}

	public static void getDataFromJson<T>(ref T entity, string json) {
		if (entity.GetType().BaseType == typeof(BaseEntity) && json.Length > 0) {
			entity = JsonUtility.FromJson<T>(json);
		} else {
			Debug.Log (string.Format("Entity is not a inheritance of BaseEntity class, given {0}", entity.GetType().BaseType));
		}
	}

	public static string getJsonFromFile(string filePath) {
		TextAsset resource = Resources.Load<TextAsset> (filePath);
		return (null != resource) ? resource.text : "";
	}
}
