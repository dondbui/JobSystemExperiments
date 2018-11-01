using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class Engine : MonoBehaviour
{
    private const int NUM_CUBES = 10000;

    private TransformAccessArray transformAA;
    private JobHandle jobHandle;

    public void Start ()
    {

        Transform[] transforms = new Transform[NUM_CUBES];

        // Initialize and create all the cubes
        for (int i = 0; i < NUM_CUBES; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Cube")) as GameObject;
            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));

            transforms[i] = inst.transform;
        }

        transformAA = new TransformAccessArray(transforms);

    }

    public void Update()
    {
        TestJob job = new TestJob();

        jobHandle = job.Schedule(transformAA);

        //Start the jobs
        JobHandle.ScheduleBatchedJobs();
    }

    private void LateUpdate()
    {
        jobHandle.Complete();
    }

    private void OnApplicationQuit()
    {
        transformAA.Dispose();
    }

}
