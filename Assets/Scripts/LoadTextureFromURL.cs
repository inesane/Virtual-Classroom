﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.Networking;



public class LoadTextureFromURL : MonoBehaviour

{

    public string TextureURL = "";

    // Start is called before the first frame update

    void Start()

    {

        StartCoroutine(DownloadImage());



        // InvokeRepeating("DownloadImage", 0.1f, 0.2f);

    }



    //    Update is called once per frame

    void Update()

    {

        StartCoroutine(DownloadImage());

    }



    IEnumerator DownloadImage()

    {

        UnityWebRequest request = UnityWebRequestTexture.GetTexture(TextureURL);

        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)

            Debug.Log(request.error);

        else

            this.gameObject.GetComponent<Renderer>().material.mainTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;



        yield return new WaitForSeconds(0.1f);

        request.Dispose();

    }

}