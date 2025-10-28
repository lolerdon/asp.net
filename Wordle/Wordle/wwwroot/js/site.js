// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const word = "@ViewBag.Word";
let maxAttempts = 6;
let attempt = 0;
let guesses = [];
console.log(word);

function getGuess() {
    return document.getElementById('guess-input').value.toLowerCase();
}
function getMatchingLettersAndNotMatching(guess, word) {
    let matchingLetters = [];
    let notMatchingLetters = [];
    for (let i = 0; i < guess.length; i++) {
        if (word.indexOf(guess[i]) !== -1) {
            matchingLetters.push(guess[i]);
        } else {
            notMatchingLetters.push(guess[i]);
        }
    }
    return {matchingLetters: matchingLetters, notMatchingLetters: notMatchingLetters};
}

function submitGuess() {
    let guess = getGuess();
    if (guess.length === 5) {
        if (attempt < maxAttempts && guesses.indexOf(guess) === -1) {
            guesses.push(guess);
            attempt++;
            document.getElementById('guess-input').value = '';
            document.getElementById('message').innerHTML = '';
            document.getElementById('message').innerHTML = 'Guess ' + attempt + ' of ' + maxAttempts;
            if (guess === word) {
                document.getElementById('message').innerHTML = 'You Win! The word was ' + word + '.';
                return;
            }
            let matchingLetters = getMatchingLettersAndNotMatching(guess, word).matchingLetters;
            let currentMatchingLetters = document.getElementById('matchingLetters').innerHTML;
            let notMatchingLetters = getMatchingLettersAndNotMatching(guess, word).notMatchingLetters;
            let currentNotMatchingLetters = document.getElementById('notMatchingLetters').innerHTML;
            // make sure no duplicates in not matching letters
            for (let i = 0; i < notMatchingLetters.length; i++) {
                if (currentNotMatchingLetters.indexOf(notMatchingLetters[i]) === -1) {
                    document.getElementById('notMatchingLetters').innerHTML += notMatchingLetters[i];
                }
            }
            for (let j = 0; j < matchingLetters.length; j++) {
                if (currentMatchingLetters.indexOf(matchingLetters[j]) === -1) {
                    document.getElementById('matchingLetters').innerHTML += matchingLetters[j];
                }
            }
        }
    }
}