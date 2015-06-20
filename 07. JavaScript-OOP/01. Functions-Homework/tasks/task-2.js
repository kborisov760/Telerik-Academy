/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {

    function checkPrime(number)
    {

        if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            return true;
        }
        if (number == 1)
        {
            return false;
        }
        if (number % 2  == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    var primeNumbers = [], counter;

    if(arguments.length < 2) {
        throw Error('Some of parameters not passed!');
    }

    else if((isNaN(from) && from != 0) || (isNaN(to) && to != 0)) {
        throw Error('Some of parameters not a number!');
    }

    for(counter = parseInt(from); counter <= parseInt(to); counter++) {
        if(checkPrime(counter)) {
            primeNumbers.push(counter);
        }
    }

    return primeNumbers;
}

module.exports = findPrimes;
