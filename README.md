# IMGD-4099 Topics

This repository contains a sample scene full of experimental projects that I created during VFX and Shaders.

I went into this class from a total beginner standpoint, so explain some of the things that I learned through self-study.

> Note: This project was made with Unity 2021.3.45f2.
> Not all assets may compile the same in other versions.

## Render Piplelines

### What is a Render Pipeline?

Unity goes through 3 phases when drawing an object onto your screen.

1. **Culling:**
Find all objects that are in the view of the camera, 
and what sides and angles are being rendered.

2. **Rendering:**
Draw the unculled, visible objects onto your screen, using lighting, shaders,
and visual quality settings

3. **Post-processing:**
Apply addtional effects onto objects.
This is done after the scene is rendered.

>    * I've used post processing in my own personal projects,
        for visual effects like:
>       * Bloom
>       * Digital/Analog Glitches
>       * Blur
>       * Depth-of-Field

A render pipeline, in the most simple terms, determines how Unity performs these 3 operations.
Each render pipleline has its own benefits and drawbacks. Unity provides 3 different render pipelines:

### Built-In Render Pipeline

This **legacy pipeline** uses simple culling and rendering techniques that work with most small/medium projects
without much setup. 

It is the most widely supported by assets on the Unity Asset Store, making it ideal for quick projects
or Game Jams where developers may want to drag and drop pre-made assets. being a legacy system, it is very stable.
It works well for prototypes, tools, and simple 2D or 3D games.
However, in terms of graphics quality, it can't compete with the other pipelines.

> This pipeline is the preferred option for beginners, asset-store heavy projects, or games built for VR, mobile, WebGL, or other low-performance environments.

### Universal Render Pipeline (URP)

The URP is the new standard being actively supported and maintained by Unity. Most projects made
with Unity 6 wil use this pipeline by default. This pipeline gives the best balance of performance and visual quality.
It's cross-platform (mobile, VR, PC, console), supports Shader Graph, and has really nice lighting and
rendering techniques out of the box.

However, it is really difficult to migrate older projects from Built-in to URP. It requires
upgrading assets, which can break some visual effects really easily.

> I recommend this pipeline for people who already have a basic understanding of using Unity.
> However, it is recommended to start with this pipeline rather than migrate an already-in-development
> project.

### High-Definition Render Pipeline (HDRP)

This is Unity's high-end render pipeline. You get the highest quality, photorealistic lighting,
support for ray-tracing, volumetrics, screen-space effects, and insanely high-quality shadows.

## Materials

## Shaders


## GLSL

## Shader Graph

Unity's shader graph provides a GUI-based, beginner-friendly mechanism for directly writing shaders. 
Instead of writing in a shading language like GLSL or HLSL, you can create 
a shader by connecting nodes with different properties into a final image. 
You can then create a material using this shader and apply it onto objects in your scene.

> I often stayed away from Shader Graph because I never fully understood what each node did.
> But for this course, I tried to experiment with different effects in order to learn what each node could do.
> Here are some cool nodes that I used and how can they manipulate a shader:

## Differences: Unity vs. Unreal