using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mats : MonoBehaviour
{
    public Color32 Test;
    private Mesh newMesh;
    private Renderer Mat;
    void Start()
    {
        var mesh = new Mesh();

        var verts = new Vector3[4];
        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(0, 1, 0);
        verts[2] = new Vector3(1, 0, 0);
        verts[3] = new Vector3(1, 1, 0);

        mesh.vertices = verts;

        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 1;
        indices[2] = 2;
        indices[3] = 1;
        indices[4] = 3;
        indices[5] = 2;



        mesh.triangles = indices;

      
        var norms = new Vector3[4];

        for (int i = 0; i < norms.Length; i++)
        {
            norms[i] = -Vector3.forward;
        }


        mesh.normals = norms;


        var UVs = new Vector2[4];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(0, 1);
        UVs[2] = new Vector2(1, 0);
        UVs[3] = new Vector2(1, 1);
    

        mesh.uv = UVs;

        var filter = GetComponent<MeshFilter>();
        filter.mesh = mesh;
        newMesh = mesh;
        Mat = GetComponent<Renderer>();
    }
    void OnDestroy()
    {
        if (newMesh != null)
        {
            Destroy(newMesh);
        }
    }



    void Update()
    {
        Mat.material.color = Test;



    }
}
