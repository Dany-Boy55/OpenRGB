# Open RGB project
The spiritual succesor of my previous [WS2812 controller](https://github.com/Dany-Boy55/Addressable-WS2812-LED-controller)
OpenRGB is a project aimed at controlling all sorts of RGB lights! Remotely, locally, in gaming preripherals, motherboards, custom cotrollers, you name it. Not yet though, I have to finish my exams first.
Written in C# for UI and C++ for embeded micros

### Note:
For now the project is in early stages of development. Most parts of the code are already functional on their own but they need to be unified.
* UI needs to be finished
* Communication with embeded OpenRGB is partially finished
* Controlling Logitech mice is done, needs to be tested with more device

## Missing feature for Beta release:
* A functional UI
* A stable link between hardware and software
* Unification of all devices under a single interface to facilitate user experience
* Corsair CUE SDK support

## Features I want to implement (eventually):
- Simple and intuitive UI
- Sync multiple lights, regardless of brand, location, etc
- Have the hability to download and flash the latest custom controller firmware witouth the need of arduino, keil or the likes
- Object oriented light pattern generation to allow almost limitless customizability
- Hardware monitoring reactivity
- Efficient FFT for sound reactivity
