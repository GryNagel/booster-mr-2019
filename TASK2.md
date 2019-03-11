# Creating an application

We start by adding a 3D model we can manipulate. In this case we will use Chester, the cute penguin, made by Claudelle Girard. You can download Chester :penguin: from the root folder of the repository. 

:pencil2: Create an empty object in the Hierarchy and call it something like *SceneContent*. Add Chester  under it. Move Chester so that he is visible in the camera (4 meters away is a good starting position).

:information_source: If you are new to Unity: a component inherit the properties of it's parent. That means that if the *SceneContent* component has a position, Chester's default position will be inherited from the parent. 

Next let's use the *ManipulationHandler.cs*-script to give us the possibility to interact with Chester . First of all we need to add a box collider to Chester. We do that by clicking on him in either the hierarchy or the scene panel and clicking *Add new component* in the inspector. Choose *Box collider*. 

:information_source: Make sure the box collider covers Chester. 

:pencil2: Search for *manipulationhandler* in the project panel and drag and drop it inside Chester's inspector window. 

A new set of options will appear. 

![ManipulationaHandler](Screenshots/manipulationhandler.jpg).

Take a look through the different options. The MRTK takes care of the events for us and allows us to use the HoloLens gestures to manipulate the 3d-object. 

:arrow_back: [Task 1 - Creating a new project in Unity](TASK1.md)  :arrow_forward: [Task 3 - Deploying to the HoloLens emulator](TASK3.md) 
