# Instructions to assist the workshop runner in keeping the workshop on track

## Setup Instructions

1. Have the attendees clone the repo, and checkout tag: `unsolved`

1. Have the workshop attendees set up an environment variable for:  
   `ASPNETCORE_ENVIRONMENT=development`

1. Have the workshop attendees set up an environment variable or secret store for:  
   `WeatherApiKey=<your weather api key>`

1. Have the attendees run the console app to see that it works  
   `dotnet run --project TheStillHeron.TestWorkshop.Console\TheStillHeron.TestWorkshop.Console.csproj`

## Exercise One instructions

1. Have the attendees Ctrl+Shift+F for "e_x\_._1" (without the underscores)

1. Draw the attendees attention to the test, and the fact that it doesn't pass (reliably)

1. Talk the attendees through writing and passing an interface for the api

1. Talk the attendees through creating a mock (using moq) for the api

## Exercise Two instructions

1. Have the attendees Ctrl+Shift+F for "e_x\_._2" (without the underscores)

1. Draw the attendees attention to the test, and the fact that they cannot control whether it will pass because of the lack of determinism with system date times

1. Talk the attendees through writing an abstraction to wrap System.DateTime

1. Talk the attendees through providing that abstraction to the DayPlan() and IsDue() functions

1. Talk the attendees through creating a mock for the abstraction to use in the test

## Exercise Three instructions

1. Have the attendees Ctrl+Shift+F for "e_x\_._1" (without the underscores)

1. Draw the attendees attention to the test, and the fact that we can't get the match to confirm the outcome of the test

1. Talk the attendees through refactoring the `get` endpoint into a command so it can be tested end-to-end easily
