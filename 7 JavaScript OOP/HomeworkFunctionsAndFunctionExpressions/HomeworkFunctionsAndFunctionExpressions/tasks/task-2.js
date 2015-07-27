/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
    var divisor,
        maxDivisor,
        n,
        isPrime,
        primes = [];

    if (from == undefined || to == undefined) {
        throw new Error();
    }

    from = parseInt(from);
    to = parseInt(to);
    

    for (n = from; n <= to; n++) {

        maxDivisor = Math.sqrt(n);
        isPrime = true;
        for (divisor = 2; divisor <= maxDivisor; divisor++) {
            if (n % divisor === 0) {
                isPrime = false;

            }
        }
        if (isPrime && n > 1) {
            primes.push(n);
        }
    }
    return primes;
}

module.exports = findPrimes;
