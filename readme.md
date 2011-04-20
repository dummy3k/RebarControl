Introduction
============

When Microsoft released its .NET framework I'm sure that many of you were as surprised as I was that the Rebar or "Coolbar" control was not included. So, I fired up the Customize Toolbar window and added the Microsoft Coolbar Control (everyone knows that .NET works perfectly with COM). Maybe your results were different than mine, but I found the wrapped version to be completely useless. I couldn't find any way to add child controls or attach them to bands. I briefly fiddled with COM interop, but that seemed to be a dead end. The end result was that I decided to implement a .NET Rebar control using the ll and native API calls.


First of several Disclaimers
----------------------------

The code is functional, but not all of the bugs have been fixed. There is a bunch of stuff that hasn't been completed at this point (chevron functionality; certain properties; some Unicode stuff; a resizing bug; problems with `MouseEnter`, `MouseHover` and `MouseLeave`; comments in the source), but I'll periodically post updates along the way.


About the control Source Code
-----------------------------

This is the first control I've developed using C#, and it's also one of my first few C# projects. Please, keep that in mind when reviewing the code. Along the way I found that frequently there were better ways of doing things. In most (but not all) cases I fixed the code. There is also a fair amount of unused code lying around. I'll clean it up when I get a chance. That said, the source code may still be interesting to programmers who are looking for sample code covering one or more of the following areas: Windows API Calls, Control Attributes, the `ControlDesigner` class, `CollectionBase` class, `Component` class, `Control` class, `CollectionEditor` class and/or Windows Messages.


Using the RebarWrapper Control
-------------------------------

Using the Rebar should be relatively self explanatory. Drop it into your form using the toolbox. The initial instance is created without any bands. To add bands, click on the `Bands` property of the `RebarWrapper` in the Property Browser. The Bands Collection Editor will allow you to Add, Remove and Edit the Rebar Bands. Each Band's properties are controlled via a `BandWrapper` Component. As you add bands you'll see them pile up in the component tray at the bottom of the Form Designer. Clicking on a band in the Rebar brings up the Rebar's properties in the Property Browser. It does *not* select the `BandWrapper` Component. Use the dropdown at the top of the Property Browser, Band Collection Editor or the icon in the component tray to access the band's property.

Each Band can act as the Parent for one control (although this can be circumvented by hosting several controls inside of a panel or other container control). Designate the control to be parented by editing the `Child` property of the band. For the control to behave properly, the child control **must** be parented by the `RebarWrapper` control. Use the `MinHeight` and `MinWidth` properties to size the band to fit the control it is parenting.

Conclusion and Final Disclaimer
-------------------------------

Play around with the various properties, events and settings. I'd be very interested to hear about any improvements/fixes/adaptations. As I mentioned before, I'll try to take care of bug fixes when I have the time and interest, but use this code at your own risk. Future versions may drop or add functionality, not be compatible with the old version, or never be developed at all. With all that said, enjoy.

*This text and most of the code is the work of Anthony Baraff.*