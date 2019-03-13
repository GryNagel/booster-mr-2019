# Task 2- Creating an application

We start by adding a 3D model we can manipulate. In this case we will use Chester, the cute penguin, made by Claudelle Girard. You can download Chester :penguin: from the root folder of the repository. 

:pencil2: Create an empty object in the Hierarchy and call it something like *SceneContent*. Add Chester  under it. Move Chester so that he is visible in the camera (4 meters away is a good starting position). He is also a bit large, so I suggest scaling him down to 0,25 in all axis. 

:information_source: If you are new to Unity: a component inherit the properties of it's parent. That means that if the *SceneContent* component has a position, Chester's default position will be inherited from the parent. 

To interact with Chester we need to add a collider to him. We do that by clicking on him in either the hierarchy or the scene panel and clicking *Add new component* in the inspector. Choose *Box collider*. 

Next let's use the *ManipulationHandler.cs*-script.

:pencil2: Search for *manipulationhandler* in the project panel and drag and drop it inside Chester's inspector window. 

A new set of options will appear. 

![ManipulationHandler](Screenshots/manipulationhandler.jpg).

Take a look through the different options. The MRTK takes care of the events for us and allows us to use the HoloLens gestures to manipulate the 3d-object. 

Set the **Hand Move Type** to One handed only

Duplicate Chester and place the two Chesters side by side. Change the **Hand Move Type** to Two handed only. 

Next let's add tool tips to the Chester's to indicate who's who. 

:pencil2: Search for **Simple line ToolTip** in the **Project view**. Drag it into the scene under **Scene content**. Under **Tool tip connector** add Chester's wingtip and move the ToolTip to a "sensible" location. 
Under **Tool Tip Script -> Content settings** add text for the manipulation mode (one or two handed). 

Repeat for the second Chester. 

:pencil2: Let's add a Placard to our scene to test out the **Billboard**-script. First add a new empty component called *Placard*. Find the **Billboard**-script and add it to the component. Next create a **Quad** by right clicking on the **Placard** in the hierarchy panel. Select **3D object -> Quad**. Find the one of the **MRTK**-standard shaders in the project view. Drag and drop it on to the Quad in the hierarchy panel. Move and scale the **Placard** and **Quad** as you see fit. 

To get some text on the **Placard** add an empty object called text under the **Placard**. Add a **Text mesh**-component. Set the scaling to 0,005 in all axis, font size to 100 and add some text. Add the **selawk** font to the **Text mesh**. Set the z-position to -0,01. You can change the text **anchor** and **alignment** to center the text. 

:arrow_backward: [Task 1 - Creating a new project in Unity](TASK1.md) | 
[Task 3 - Deploying to the HoloLens emulator](TASK3.md) :arrow_forward:
