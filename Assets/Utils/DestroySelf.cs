using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    //Can be used for animators or accessed by other scripts
    public void SelfDestroy() {
        Destroy(this);
    }
    public void SelfDestroyInSeconds(float seconds) {
        Destroy(this, seconds);
    }
}
