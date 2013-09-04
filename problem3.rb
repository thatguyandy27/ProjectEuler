#What is the largest prime factor of the number 600851475143 ?
def is_prime(number)
  limit = number / 2
  puts "Testing for Prime #{number}"
  
  for i in 2...limit
    if number % i == 0
      return false
    end
  end
  
  return true
end

def attempt1(number)
  #if it is even then subtract 1
  max_prime = 1
  index = number / 2
  if index % 2 == 0 && index != 2
    index = index - 1
  end
  
  while index > 0
    puts index
    if number % index == 0 && is_prime(index)
      puts "Prime Number #{index}"
      max_prime = index
      break
    end
    #skip even and only go with odds for improved performance
    index = index -2
  end
  return max_prime
end

def attempt2(number)
  max_prime = 3
  max_number = number / 2
  index = 3
  while index < max_number
    if number % index == 0
      potential_prime = number / index
      puts "potential prime #{potential_prime}"
      if is_prime(potential_prime)
        max_prime = potential_prime
        break
      end 
    end 
    
    #only include odd
    index += 2
  end 
  return max_prime
end
#
number = 600851475143
#number = 10
#number = 14
max_prime = attempt2(number)
#puts is_prime(5)
#puts is_prime(10)
#puts is_prime(25)
#puts is_prime(19)
puts max_prime