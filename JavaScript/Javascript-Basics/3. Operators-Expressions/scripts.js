function isOddNumber(number) {
	if (!number) {
		console.log("The isOddNumber function parameter is undefined");
	}
	
	if (number % 2 === 1) {
		return true;
	}
	
	return false;
}

function isDividedBySevenAndFive(number) {
	if (!number) {
		console.log("The isDividedBySevenAndFive function parameter is undefined");
	}
	
	if (number % 7 === 0 && number % 5 === 0) {
		return true;
	}
	
	return false;
}

function calcRectangleArea(width, height) {
	return width * height;
}

function isThirdDigitSeven(number) {
	var thirdDigit = parseInt((number / 100) % 10);
	
	if (thirdDigit === 7) {
		return true;
	}
	
	return false;
}

function getNthBitOfNumber(number, bitPosition) {
	if (number & (1 << bitPosition)) {
		return 1;
	} else {
		return 0;
	}
}

function isWithinCircle(x, y, radius) {
	if (((x*x) + (y*y)) <= radius*radius) {
		return true;
	}
	
	return false;
}

function isPrime(number) {
	if (number === 1) {
		return false;
	}	
	if (number === 2) {
		return true;
	}

	var divider = 2,
		maxDivider = parseInt(Math.sqrt(number));
		
	while (divider <= maxDivider) {
		if (number % divider === 0) {
			return false;
		}
		divider++;
	}
	
	return true;
}

function calcTrapezoidArea(sideA, sideB, height) {
	return ((sideA + sideB) / 2) * height;
}