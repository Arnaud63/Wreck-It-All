using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysManager
{
    private Dictionary<GameObject, IEnemy> linksBetweenGameObjectAndEnemy;

    public EnemysManager()
    {
        linksBetweenGameObjectAndEnemy = new Dictionary<GameObject, IEnemy>();
    }

    public void LinkGameObjectToIEnemy(GameObject gameObject, IEnemy enemy)
    {
        linksBetweenGameObjectAndEnemy.Add(gameObject, enemy);
    }

    public void DestroyLinkGameObjectIEnemy(GameObject gameObject)
    {
        linksBetweenGameObjectAndEnemy.Remove(gameObject);
    }

    public bool ContainsGameObject(GameObject gameObject)
    {
        return linksBetweenGameObjectAndEnemy.ContainsKey(gameObject);
    }
}
