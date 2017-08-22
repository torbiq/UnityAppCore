using System;
using UnityEngine;

[Serializable]
public class PlayerData {
    [SerializeField]
    private int _coins;
    [SerializeField]
    private Vector3 _position;

    public int coins { 
        get {
            return _coins;
        }
        set {
            _coins = value;
            if (OnCoinsChangedEvent != null) {
                OnCoinsChangedEvent(_coins);
            }
        }
    }
    public Vector3 position {
        get {
            return _position;
        }
        set {
            _position = value;
            if (OnPositionChangedEvent != null) {
                OnPositionChangedEvent(_position);
            }
        }
    }

    public Action<int> OnCoinsChangedEvent;
    public Action<Vector3> OnPositionChangedEvent;

    public PlayerData() {
        coins = 0;
        _position = new Vector3();
    }
}
