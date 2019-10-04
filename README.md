# Word Counter

#### A console application to count the number of times a word is present in a sentence, 04-Oct-2019

#### By **Christine Frank**

## Description

This is a console application which counts the number of instances a word is in a sentence. The user must first input a sentence and the word of which the application counts instances thereof.

## Setup/Installation Requirements

* Clone this repository to your desktop
* Install .NET Core SDK (if not already installed)
* Install REPL *dotnet script* (if not already installed)
    * Command: 'dotnet tool install -g dotnet-script'
* Open a new Command Terminal and route to the root of the local repository
* Enter command 'dotnet run' into the Terminal


## Known Bugs

None known at this time.

## Support and contact details

Find a bug?! Add an issue to the GitHub Repo.
Repo: https://github.com/christinelfrank16/NumbersToWords.Solution

Other Contact
Email: christine.braun13@gmail.com
LinkedIn: https://www.linkedin.com/in/christine-frank/

## Application Specifications

| Behavior | Input | Output |
|:-----|:-----:|:-----:|
| App accepts any character input for the user input (sentence and search word) <!-- Simplest: requires a direct return of user input --> | "I ate 2 2# pies!" | "I ate 2 2# pies!" |
| App returns 1 when search term is an exact match to user input sentence (single word) <!-- Next Simplest: assumes 1 word value for sentence and word - performs 1 step (direct) check if input 'sentence' equals input word --> | Search term: place <br> Sentence: place | 1 |
| App returns 0 when search term is present in user input sentence (single word) but is not exact match <!-- Next Simplest: assumes 1 word value for sentence and word - performs direct check if input 'sentence' equals input word (equal complexity to above spec) --> | Search term: book <br> Sentence: bookkeeper | 0 |
| App returns 1 when search term is an exact match to user input sentence (single word) but has at least one character of a different case <!-- Next Simplest: assumes 1 word value for sentence and word - modifies above functionality to ignore letter case --> |Search term: place <br> Sentence: Place | 1 |
| App ignores multiple word input for the word input <!-- Next Simplest: No longer assumes 1 word search term input by user -  2 step check: trims input and checks if a space is present --> | "2 pies" | "Please enter a single word to search for"|
| App places sentence words into an array using spaces to identify word boundaries <!-- Next Simplest: No longer assumes 1 word sentence input by user - must iterate over sentence and find spaces, then put into array --> | A cat jumped | ["A","cat","jumped"]|
| App iterates over sentence word array to count instances of exact word match <!-- Next Simplest: assumes no punctuation - requires all above steps to function -->|Search term: cat <br> Sentence: A cat jumped near a cathedral |1|
| App removes end punctuation from around words in input sentence when placing into the word array <!-- Next Simplest: Assumes punctuation only at end - requires all above steps to function --> | Search term: cat <br> Sentence: A cat! |1|
| App removes all front and end punctuation from around words in input sentence when placing into the word array <!-- Next Simplest: No longer assumes no punctuation - requires all above steps to function --> | Search term: cat <br> Sentence: A thing (cat)!? |1|



## Technologies Used

* C#
* MS Test

### License

*This application is licensed under the MIT license*

Copyright (c) 2019 **Christine Frank**