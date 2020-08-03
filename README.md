# MarsRover
## Design
The design of the Rover uses a simple 2D Vector system for position and movement. By using a simple map between a particular compass heading and the vector that would result in a 1 grid unit movement forward, the Rover can easily rotate and move through the rectangular plateau without needing any overhead of mapping a full MxN grid. The Rover's movement also clamps between the two extreme Vector values (0, 0) and (M, N), so that the Rover will not fall from the plateau.

This assumes that there are no complexities in the plateau, such as impassible regions within the boundaries, and that the rover does not need to store any additional data about the plateau outside of its own position and heading.
