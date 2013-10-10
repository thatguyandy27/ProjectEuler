
max = 10000

def get_sum(max)
	
	sum = 0
	1.upto(max) do |n|
	
		if amicable?(n)
			sum += n
		end
	end
	
	return sum
end

def amicable?(num)
	sum = get_divisors_sum(num)
	divisorsSum = get_divisors_sum(sum)
	if num == divisorsSum && (num != sum)
		puts "num  #{num}: sum#{sum}"
	end
	return num == divisorsSum && (num != sum)

end

def get_divisors_sum(num)

	sum = 0
	1.upto(num /2) do |n|
	
		if num % n == 0
			sum += n
		end
		
	end
	
	return sum
end


#sum = get_divisors_sum(220)

#puts "Sum of 220 #{sum}"

sum = get_sum(max)
puts "The sum of all amicable numbers under #{max} is #{sum}"