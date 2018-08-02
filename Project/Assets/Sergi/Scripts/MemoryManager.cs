using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MemoryManager : MonoBehaviour
{
    public static MemoryManager instance;

    [SerializeField]
    public List<Memories> _memories;
    public List<Memories> _seenmemories;

    [SerializeField]
    public Memories _currentmemory;

    // Makes sure the App_Manager does not get destroyed & Singleton 
    void Awake()
    {
        if (instance != null)
            Debug.LogError("More than one Memory Manager in the scene");
        else
            instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        Request_Items();
    }
    public void Request_Items()
    {
        StartCoroutine("RequestMemories");
    }
    public IEnumerator RequestMemories()
    {
        _memories.Clear();
        //_itemid.Clear();
        WWWForm patient_ID = new WWWForm();
        patient_ID.AddField("patient_ID", AppManager.instance.User.ID);
        WWW itemdata = new WWW("http://81.169.177.181/RT/PHP/owned_items.php", patient_ID);
        yield return itemdata;
        if (string.IsNullOrEmpty(itemdata.error))
        {
            _memories = new List<Memories>();
            _memories = JsonHelper.getJsonArray<Memories>(itemdata.text).ToList<Memories>();
            _seenmemories.Clear();
            _seenmemories = new List<Memories>();
            foreach (Memories _m in _memories)
            {
                if(_m.seen == 1)
                {
                    _seenmemories.Add(_m);
                    _memories.Remove(_m);
                }
            }
            Debug.Log("got items");
        }
        else
        {
            Debug.LogError("ERROR FATAL");
        }
    }

}

[System.Serializable]
public class Memories
{
    public int ID;
    public string caretaker_id;
    public string name;
    public string description;
    public string video;
    public string sound;
    public string date;
    public int seen;
}
