# BsuTest
Welcome to Bath Spa's Software Development recruitment test! <br/>
This little test has been put together to get to know you better and assess both your coding knowledge and determination, we are sure you'll do great! <br/>
Bath Spa University has recently opened a new sister Academy to teach anyone from the galaxy how to become a Jedi. <br/>
The Software Development team has been tasked to create a little web application to enroll new Students and retrieve a list of existing ones. <br/>
The solution project you'll find in this repository has the main interface consisting of a Form to enroll new students and a page listing all students already enrolled. <br/>
You'll also find two MicroServices exposed by their APIs to retrieve general data and to manage our JediStudents Data. <br/>
Let's get a couple of questions out of the way before we get to the challenges young Padawan! 

# What do I need to complete the test?
To complete the test you will need an IDE supporting .net core. Our instructions are for Visual Studio (which we use in our day to day job) you can download the community edition [here](https://visualstudio.microsoft.com/)

# How long do I have to complete the test?
There is no rush, however it would be great if you could complete this within a week from receiving our invitation. <br/>
If you need more time let us know!

# What is your expectation?
Within the last year our development team has started working its way into microservices and clean architecture. <br/>
The application you'll find in this repository will give you a hint on the way we are aiming to structure our code from now on.<br/>
While we get that this code may be quite challenging to understand, depending on the level you are applying for, we believe a developer is before anything else a problem solver eager to learn new and exciting technologies and ways of working. <br/>
That said, what we would like to see is a general understanding of what the code is doing and possibly your solution to some if not all the challenges. <br/>
On the file Resources.DM you'll find links to documentation/videos that may help you, if you need more info pop us an email and remember that Google and stack overflow are your friends! :)

# How do I send you my solution?
We would like for you to create a private repository on your GitHub account and invite BSUSoftware as collaborator.
If this is not possible please contact us so we can find an alternative solution.

# How do I run the application?
Clone this repository to your local machine and open it in Visual Studio. <br/>
Once the application has loaded, right click on the solution name and select "Set Startup Projects..." <br/>
On the window that will pop up (this should be Common Properties => Startup Project) select "Multiple startup projects:" <br/>
From the list of project Set the "Action" tab to "Start" for the following projects:
- JediAcademy.Back.Api
- StarWars.Api
- JediAcademy.Presentation
Press Ok and Click Start.

# Ok I am bored, give me the task!
Ok Ok... Geez you can't wait to start the test eh?? <br/>
Here's the challenges, we do not expect you to complete all of them but the more you can complete, the better we can get to know you (no pressure).

# Challenge 1:
The developer who wrote the view for the "Currently Enrolled" page listing all external students that are already enrolled, has decided to display the Id referring to the species of our student. <br/>
We do not think that's really user friendly, could you change that so that the species name is retrieved? <br />
E.G. Luke Skywalker species should read Human not 0.

# Challenge 2:
The "Enroll new Jedi" form is currently not saving any data to the Students in memory DB. <br/>
Could you make it so that on pressing Enroll, a student record is saved to the database?

# Challenge 3:
Our compliance team has just come back with more requirements, now they want the planet of Origin for each student we enroll...<br/>
Could you add the option of selecting a planet of origin in the form? (brownie points if you also store the planet on db when enrolling students)<br/>
(A Planet.Json file is already in the StarWars.Api project containing all known planets in the galaxy)

# Bonus Points:
- Any improvement you can make (with comment on how it makes the application better)
- Write Unit Tests for the Projects (the more the merrier).
- Dockerize the solution so that it's runnable using a dockerCompose as startup project

# Sounds good?
Great! Good luck and may the force be with you!









