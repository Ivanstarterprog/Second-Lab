using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript : MonoBehaviour
{
    public int _intValue;
    public float _floatValue;
    public double _doubleValue;
    public string _stringValue;
    public bool _booleanValue;
    public char _charValue;
    public List<int> _list;
    // Start is called before the first frame update
    void Start()
    {
        _intValue = 5;
        _floatValue = 5f;
        _doubleValue = 5.0;
        _stringValue = "HelloWorld";
        _booleanValue = true;
        _charValue = 'K';
        _list = new List<int>();
        Debug.Log(_intValue);
        Debug.Log(_floatValue);
        Debug.Log(_doubleValue);
        Debug.Log(_stringValue);
        Debug.Log(_booleanValue);
        Debug.Log(_charValue);
        Debug.Log(_list[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
