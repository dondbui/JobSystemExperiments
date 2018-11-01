# JobSystemExperiments
This tests the performance improvements of using Unity's job system to rotate 10k cubes

## Results:
- Standard Monobehavior on each cube: ~23FPS (43ms)
- A simple IJobParallelForTransform to handle the rotation: ~58FPS (17ms)

## Notes:
- Keep in mind that I did not limit to the **desiredJobCount** for the **TransformAccessArray** and allowed the maximum number of jobs to scheduled for each frame. 
- I also forced the job to wrap up on **LateUpdate** to ensure all cubes were rotated each frame. I imagine things could be faster if I allowed the job to run it's course before rescheduling.
