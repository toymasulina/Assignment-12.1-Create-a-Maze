# Assignment 12.1: Create a Maze

Utilizing what you have learned, put together your own maze using the XR toolkit and Snaps prototype package. Make sure your maze has some sort of interactable “key” that is used to open a door or otherwise progress through the level. This will enhance your VR environment to allow a user to interact directly with the space and with specific items in an immersive context. Feel free to get creative with any other models or assets you are interested in!

Use this assignment to familiarize yourself with the XR Rig and its various components—in particular, the locomotion system and its associated providers as well as the XR Direct/Ray Interactors. This is the crucial foundation that can turn any 3D environment into an explorable and interactive VR app.

It is also important that you use GitHub as a place to store your source files and as practice in version control since you will soon be sharing this particular project with your peers.

Requirements checklist:

- The maze includes at least four turns.
- The maze includes at least two dead ends.
- The environment objects are aligned to the grid.
- The player must use a grabbable object to progress further.
- A win state is activated upon entering the final section.
- The maze must be playable with the VR headset.
- The project must be on GitHub and marked public.

Edit your GitHub ReadMe to include notes about your experience building the maze, such as the challenges you overcame, links to other assets you may have added on your own, and specifically the resources you found to be most helpful. This will be important for your next assignment, where another learner will be reading your notes and entering your maze.

# Build Notes

Initially, I built a dungeon layout using the "Low Poly Dungeons Lite" free pack from the Unity store because the Snaps pack was deprecated. When someone shared the Snaps file in Slack, I decided to restart the project because I was curious about the functionality of the Snaps assets.

The bulk of the layout was designed using the Snaps office assets. Additional assets were found on the Unity Asset Store, inlcuding a set of keys and a skeleton. An audio file for the "win" sound was downloaded from freesound.org

I customized a few of the prefabs. Because I decided to create two doors that needed to be opened with key colliders, to add an extra element of gameplay, I colored one key silver and the other gold. I updated the color of the door handles on the door instances, one with silver and the other with gold, to correlate with each key. The keys have separate tags, so I updated the scripts, and the keys will only work on the respective door handle color. This ensures that the player can't open the "Win" door without first finding the appropriate key.

A preliminary challege was figuring out how to properly use the XR Layer Mask system, as the tutorial videos were outdated and used the normal layer system.

A more serious issue was that the teleportation line was flickering, and the teleportation wouldn't always work immediately when I used the Select button. This was a frustrating issue because I didn't know if it had to do with the reticle, XR Ray Interactor, or Teleportation Area. When I eventually removed the reticle, I got a solid white line and consistent teleportation, so I figured there was something wrong with the reticle. Eventually, I disabled the sphere collider on the reticle, and it worked properly! This shouldn't have an effect on any other part of the game, as the reticle is strictly used for teleportation and not any other interaction.

QA note: When the player picks up the keys, they are held upside down (the notches should be pointing up).