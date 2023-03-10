# scriptable-object-architecture

This is my scriptable object architecture project. This system makes project more data-oriented. It's based on Ryan Hipple's 2017 Unite talk. (https://www.youtube.com/watch?v=raQ3iHhE_Kk)

With this architecture you can save too many different data types into scriptable objects. This is important for remote control because it helps you to change values of your game when the game is live, without any update. You can change economy, difficulty etc. of your game. 

When we test (ARPU) our game it really helped us to change values easily without any update. When the game is live, we changed the economy as feedbacks came. It was so easy to use.

![alt text](https://i.imgur.com/SkSIJCu.jpg)

It has references for 14 different value types:

- Bool
- Byte
- Char
- Color32
- Color
- Double
- Float
- GameObject
- Int
- Quaternion
- Scene
- Vector2
- Vector3
- Vector4

You can test it on TestScene with X (Game Event) and Z (Reference) shortcuts on runtime.

Add 'Reference' word end of the type that you want to use (for int, IntReference) 

![alt text](https://i.imgur.com/wVMt5Xx.jpg)

Create scriptable variable on project.

![alt text](https://i.imgur.com/pybcxVM.jpg)

Assign varible to reference variable. You can also use constant value for testing. (it always uses the same value)

![alt text](https://i.imgur.com/oC62Adp.jpg)

You can use Game Event Listener Component to invoke Game Event (as a scriptable object). It's easy to set on editor. (press X to invoke TestGameEvent on TestScene)

![alt text](https://i.imgur.com/24V0i9W.jpg)

![alt text](https://i.imgur.com/4CibpZz.jpg)

If Game Event Listener Component gets any references as an Event (like float, bool - any of 14 different value type), it invokes when the reference value is changed. (press Z to change testIntReference's value on TestScene)

![alt text](https://i.imgur.com/j6La50F.jpg)

![alt text](https://i.imgur.com/bML7Vbu.jpg)
