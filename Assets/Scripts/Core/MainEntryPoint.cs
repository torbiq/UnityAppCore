using UnityEngine;

namespace AppCore {
    public class MainEntryPoint : MonoBehaviour {
        private void Awake() {
            new AppInitializer().Initialize();
            Destroy(gameObject);
        }
    }
}
