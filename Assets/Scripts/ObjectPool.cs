using UnityEngine;
using System.Collections.Generic;

public class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    protected T prefab;

    protected List<T> pool = new List<T>();

    public virtual T GetObject()
    {
        foreach (var obj in pool)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                return obj;
            }
        }

        return CreateObject();
    }

    protected T CreateObject()
    {
        var newObj = Instantiate(prefab) as T;
        newObj.gameObject.SetActive(false);
        pool.Add(newObj);
        return newObj;
    }
}