# EconomaticsBox
.net DLL for Economatics Smart Box

The Economatics Smart Box is an archaic piece of hardware that was likely to be sold for education in the UK/Europe in the Mid 90's, relatively little is on the internet about this device but it is a device that historically had software for the MAC, BBC Micro, PC and others. The device has eight digital inputs, eight digital outputs, four eight bit analogue inputs and four directional motor outputs. The device itself is designed for students so it is fairly well protected against short circuits and overloads. 

The serial protocol has been decoded from a similar VB6 library released by another developer in 2003. This is a work in progress and has most of the code available, the digital outputs work and the digital inputs work. A better method should be developed for handling the serial return from the analogue inputs, presently if you send the characters to read a specified analogue input then it will return with a byte representing the analogue value. It will not give you anything more than the byte so it is important to keep track of what that return may be. Better methods should be added to the plugin as it appears possible for it to get confused over which byte refers to which input.

An example forms application is included in this that will show the relevant calls to the DLL.
