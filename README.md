patient-assessment
==================


Direct your attention to the trauma.vb page that you've been working on. You should notice the extent of my boredom haha. My obnoxious amounts of comments in the code should help you figure out what I've done. In case it doesn’t, my boredom also managed to produce this little gen ^gem to explain it all. 

I will advise that the MVC shit was in a last minute thing before I left work when I was tired as shit and isn't totally functional. The only modifications I made to this are in the Trauma.vb file. 

Minor OCD CDO tweaks include: ‘My OCD says it should actually be “CDO” because that’s alphabetical order, as it should be. xD….
- changing Form1's visibility value to false when you click the Trauma option on Form1. The code for this is under the trauma_load sub.
- disabling the buttons on the trauma page depending on the value returned from the ROSC generator
- an error message when you and/or I forget to change the random limit to fit the amount of defined scenarios

Other tweaks:
- beginnings of MVC scenario value assignments 
- beginnings of other trauma scenario value assignments
- because I'm that lazy, If/Then config to enable/disable certain options based off the generators
- your original "button1" has been renamed to "btnMain" and has been re-purposed as the Scenario assignment button
- your "Label1" has a default value of "..." and has the same purpose as your original code, but instead of displaying the Integer value from the ROSC generator, it displays the String value from my "TraumaCC" value, overall accomplishes the same thing, just easier to decipher.  
- TraumaCC intended to provide a String value so that we know what's being dumped, and so that the end user has a clue as to what's being thrown in their face (more the first because I'm too lazy to sort out the test display shit for the generator when this is all said and done haha, we can leave it in and it won’t be crazy) ‘OM NOM NOM GIMME ALL DAT MEMORY…. Haha it’s there so fuck it 
- the MVC shit has its own generator to randomly select the different MVC calls (i.e. MVC w/Entrapment, MVC w/Fire, etc.) The current code for this is more or less a proof of concept so you can disregard the wording if you’d like. 
--since we are going with disregard memory, aquire all the funs, maybe we can just copy the idea of this generator and use it for all scenarios that are a subtype of the main scenario. ie burns,stabbings etc... possibly the vitals too cuz fuck it..
- the MVC section is currently set up to troll bypass my If/Then shitshow* due to the logical retardation that exists in that section. Instead of displaying the actual scenario (because it won’t. XD), it pops a message box up displaying "MVC" just to show that something is actually happening there, and that I'm not totally retarded at 3 in the morning haha. 
