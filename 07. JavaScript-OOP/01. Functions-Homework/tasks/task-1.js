/* Task Description */
/*
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number

*/

function sum(arr) {
	arr = arr || 'empty';

    var sumOfNumbers = 0,
        arrToNumbers,
        numCounter;

    if(arr === 'empty') {
        throw Error("Parameter not passed");

    }


    if(arr.length === 0) {
        return null;
    }

    arrToNumbers = arr.map(Number);

    for(numCounter = 0; numCounter < arrToNumbers.length; numCounter++) {
        if(isNaN(arrToNumbers[numCounter])) {
            throw Error("Element not convertable");
        }
    }

    for(numCounter = 0; numCounter < arrToNumbers.length; numCounter++) {
        sumOfNumbers += arrToNumbers[numCounter];
    }

    return sumOfNumbers;
}

module.exports = sum;
