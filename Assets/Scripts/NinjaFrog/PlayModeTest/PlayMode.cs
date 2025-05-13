using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class NinjaFrogMovementTest
{
    private GameObject NinjaFrog;
    private GameObject Ground;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator NinjaFrogSpawnsWithCorrectComponents_Case()
    {
        yield return new WaitForSeconds(1);

        NinjaFrog = GameObject.Find("NinjaFrog");
        Assert.IsNotNull(NinjaFrog, "No hay rana en la escena");

        var sprite = NinjaFrog.GetComponent<SpriteRenderer>();
        Assert.IsNotNull(sprite, "La rana no tiene un spriteRenderer");

        var collider = NinjaFrog.GetComponent<Collider2D>();
        Assert.IsNotNull(collider, "La rana no tiene Collider 3D");

        var rb = NinjaFrog.GetComponent<Rigidbody2D>();
        Assert.IsNotNull(rb, "NinjaFrog does not have a Rigidbody2D");
        
        yield return null;
    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
