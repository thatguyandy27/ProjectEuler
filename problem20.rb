
#number = 10
number = 100

def factorial(num)
	return num.downto(1).reduce(:*)
end

def get_sum_of_digits(num)
	sum = 0
	while num > 0 
		sum += num % 10
		num = num / 10
	
	end
	
	return sum
end

result = factorial(number)
puts "The result of the factorial is #{result}"
result = get_sum_of_digits(result)
puts "The sum of the digits is #{result}"