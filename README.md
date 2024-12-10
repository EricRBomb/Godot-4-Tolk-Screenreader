# Godot 4 Tolk Screen Reader

Tolk is an excellent plugin that allows you to talk to multiple screen-readers.

# Plugin Test Folder

A test godot project showing c sharp code that allows sending to Screenreader and lag free windows TTS

# Standalone Folder 

The script and needed DLLS to make it work in another project

# About

This allows sending to a variety of screen readers using TOLK:
https://github.com/dkager/tolk

If no screen reader is detected, it will then send to Windows TTS with a new implementation. 
Godot 4.3 TTS currently lags out the project, but this one does not.

For new projects to work, make sure the DLLS go with the script, and TolkDotNet.Dll is added as a depedency.

Functions of script:

`_Ready()`

Load Tolk, inital load of script also readies the Synth which calls windows default TTS if no screen reader is found.

`Say(string text)`

Reads out string passed to it. If there's a screen reader connected, will send it to the screen reader. If none are connected or detected, will pass to Windows TTS.


`Set_rate(int val)`

This ONLY impacts Windows TTS and requires a number between -10 and 10. 
Default speed is bad, let your players choose it.

`ScreenCheck()`

Tells you if a screen reader is connected or not. 
Can use this to show option to change Windows TTS speed if no screen reader is connected. 

Licenses for DLLS included with attached DLLS.

# Want to make blind accessible games, but don't know where to start?

Discord for developers of blind accessible games and blind gamers:

https://discord.gg/tqQXqX8gEq

Wiki with resources and examples for making blind accessible games:

https://gamesforblindgamers.miraheze.org/wiki/Main_Page





This is mostly a wrappter, please expand on this and improve it and cite me or don't. I'm not a cop.
