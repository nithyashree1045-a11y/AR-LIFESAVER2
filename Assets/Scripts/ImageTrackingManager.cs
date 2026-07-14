using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTrackingManager : MonoBehaviour
{
    private ARTrackedImageManager trackedImageManager;

    public GameObject burnCube;

    private void Awake()
    {
        trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        trackedImageManager.trackablesChanged.AddListener(OnTrackablesChanged);
    }

    private void OnDisable()
    {
        trackedImageManager.trackablesChanged.RemoveListener(OnTrackablesChanged);
    }

    private void OnTrackablesChanged(ARTrackablesChangedEventArgs<ARTrackedImage> args)
    {
        foreach (var trackedImage in args.added)
        {
            Instantiate(burnCube, trackedImage.transform.position, trackedImage.transform.rotation);
        }
    }
}