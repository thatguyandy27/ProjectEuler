
def min_multiple_of(number)
  smallest_number = 0
  list_of_divisors = (2..number).to_a
  is_found = false
  while not is_found
    smallest_number += number
    is_found = true
    
    list_of_divisors.reverse_each do |i| 
      if smallest_number % i != 0
        is_found = false
        break
      end
    end
  end
  
  return smallest_number

end

#test case 10 = 2520
#number = 10
number = 20
smallest_multiple = min_multiple_of(number)
puts "The smallest number divisible by all numbers up to #{number} is #{smallest_multiple}."