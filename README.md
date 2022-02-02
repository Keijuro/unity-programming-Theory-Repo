# unity-programming-Theory-Repo
submission 2 for jr programmer pathway

There are three different colored shapes that inherit from a base “shape” class (inheritance).
Each shape move differently through an overriden OriginalMove() function (polymorphism).
Each shape contains data, such as its name or color, which are stored as properties with getters and setters (encapsulation).
Code is organized in a way that reduces duplicate code through higher level methods (abstraction).

1. Inheritance
	- Shape -> Cube / capsule / sphere
	- All have name/color/rotationSpeed
		- Initialised in their own Start function

2. Polymorphisme
	- OriginalMove() is overriden for each child class

3. Encapsulation
	- Use of getters and setters with limit scope

4. Abstraction
	- Update is only define in Shape that call Rotate() and ChangeColor() functions