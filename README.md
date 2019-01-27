Pick5Grammar
============

The history of this project came from a problem I found with my study of Japanese.  I became skilled enough at reading Japanese, but when writing it, not quite so much. So my input was decent, my output was horrible.  Along with that, being able to take a grammar concept and remember it and actually write an example sentence with it was difficult.  This project's aim is to allow me to practice better output of Japanese.

To do this, there's an excel file (see Example.xlsx) that has a similar structure as what I'm personally aiming for.  In this, I have one grammar concept, and the various notes (including personal) that support that note.  As I learn something new, and write it down, my goal is to update my own version of the spreadsheet to include that entry.  Then, by running this every day - I get 5 entries that I should not only review, but also do a few example sentences from each.  These examples would then be corrected either through lang-8, tutor, etc.

Output is very important in language use, and while there are many ways of approaching the goal, there are none that do it this way (that I'm aware of).  Most online tools simply drill you on it through use of flashcards, fill in the blank, or cloze sentences.  While effective as well, I think being able to create your own example sentences are even better and are more applicable to your own daily life.

Building and Running
====================

Right now, this project is in .NET Core, as a console application.  I don't have pre-built binaries up here yet, but if people want them, please create an issue and I'll upload ones for Linux/Windows/OSX.

You can download .NET Core from https://dotnet.microsoft.com/download

Once you have it installed, and this repository checked out, cd into the directory and run:

```bash
dotnet run   # Gives command line options
dotnet run -i <INPUT_EXCEL>   # Load the identified excel file, use Excel.xlsx if you want to see the test output
dotnet run -i <INPUT_EXCEL -c N  # Same as above, but you can specify the number of entries you want to see
```

Limitations and Roadmap
=======================

Right now, this is a very simplisitic program.  Mostly because I'm starting my excel file out fresh on this and am going to re-review all concepts once again.  With that said, long term, my goal is to allow for a "weighted review", which is more akin to the idea of an SRS-style of review.  Meaning, it will keep a cached view of what has been assigned and then cycle them according to the SRS methodology.  This would be more beneficial for long-term remembering of the concept.

Also, the excel file is very strict on formatting.  It's expected to be the first tab of the excel file (but you can have others), and the columns must remain the same name.  If people are using this with other references/languages, please create an issue and I'd be more than willing to make this more flexible (e.g. concept as first column, any number of other columns allowed and dynamic names - which isn't too hard to add).