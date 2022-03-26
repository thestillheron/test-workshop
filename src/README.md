TODO:

Write a readme explaining what to do with this repo

Rearrange the project as a daily planner app
Have the weather recommendation be one part of that.
Use the weather recommendation to teach about inversion of control.

Need to come up with an excuse to create builders.
Scenario would be, you either need a lot of objects, or you need a few very large/complex objects.
Could be something like a personal TODO list generator, or a chore picker.

Make it a family planner as the aggregate root.
It has family members, events and tasks.
Tasks have a cadence.
It can generate a day plan.
Day plan randomly allocates a daily chore to to each of the family members.

Having to construct the aggregate root gives us an excuse to use a builder.
With the random allocation of daily chores, we have the opportunity to talk about the importance of wrapping system utilities in our own classes so we can test them.

Need to find a sensible case to test a subcutaneous test. This would be a mater of testing all the different
behaviour of personal planner.

# Pre-requisites

- You should have a basic understanding of coding in C#. Broader knowledge of the .Net framework will benefit you.

# Prep

- Get an API key: Head here and click "Get API Key" in the Free Tier to get started. (don't worry - it's genuinely free)
- Make sure you have a an IDE that supports C#/.Net, such as Visual Studio Code, or Visual Studio
- Make sure you have the the .Net Core 3.1 SDK installed: https://dotnet.microsoft.com/en-us/download
- Specs: Don't worry, what we'll be doing could run on a raspberry pi 3
