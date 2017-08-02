using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_CameraScreen : MonoBehaviour {

    [Header("Camera Settings")]
    [SerializeField] private Camera m_frontCamera;
    [SerializeField] private Camera m_backCamera;

    [Header("Render Texture Settings")]
    [SerializeField] private RenderTexture m_frontTex;
    [SerializeField] private RenderTexture m_backTex;

    [Header("Material Settings")]
    [SerializeField] private MeshRenderer m_cameraScreen;
    [SerializeField] private MeshRenderer m_outputFrame;

    private Camera m_activeCamera;
    private RenderTexture m_activeRendText;
    private bool m_isBackCam;
    
	void Start () {
        m_isBackCam = true;
        m_activeRendText = m_backTex;
        m_activeCamera = m_backCamera;
	}

	void Update () {
        
        if(m_isBackCam) {
            // Set render tcture to be the back texture
            m_cameraScreen.material.mainTexture = m_backTex;
            m_activeRendText = m_backTex;
            m_activeCamera = m_backCamera;
        } else {
            // set the render tecture to be the front texture
            m_cameraScreen.material.mainTexture = m_frontTex;
            m_activeRendText = m_frontTex;
            m_activeCamera = m_frontCamera;
        }
        
    }

    public void SwapCamera() {
        m_isBackCam = !m_isBackCam;
    }


    public IEnumerator TakePhoto() {

        yield return new WaitForEndOfFrame();

        RenderTexture.active = m_activeRendText; // one camera is only ever rendering in a scene at once
                                                 // therefore, for this frame I have to update the active render texture,
                                                 // in order to be taking the correct photo.

        Texture2D photoText = new Texture2D(m_activeRendText.width, m_activeRendText.height, TextureFormat.RGB24, false);
        photoText.ReadPixels(new Rect(0, 0, m_activeRendText.width, m_activeRendText.height), 0, 0);
        photoText.Apply();

        PrintPhoto(photoText);

        m_outputFrame.material.mainTexture = photoText;
    }

    void PrintPhoto(Texture2D a_photoText) {

    }
}
