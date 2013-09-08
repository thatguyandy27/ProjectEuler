require "Prime"
limit = 1000000

def find_prime(limit)

  largest_prime = 0
  primes = Prime.each(limit).to_a()
  prime_length = 0
  primes.length.times do |i|
    sum = 0
    
    #(primes.length - i).times do |index|
    i.upto(primes.length - 1) do |index|
      #puts "#{index}"
      prime = primes[index]
      sum += prime
      
      #puts "sum: #{sum}"
      if sum > limit
        break
      end
      current_length = index - i + 1
      if current_length > prime_length && Prime.prime?(sum)
        prime_length = current_length
        puts "i #{i}, index: #{index}, length: #{primes.length - 1}, Consecutive Primes #{prime_length}"
        
        largest_prime = sum
      end
    end
    
  end
  
  return largest_prime
end

# Test case 100 = 41
#limit = 100 

# Test case 2 1000 = 953
#limit = 1000
solution = find_prime(limit)
puts "The max prime that is the sum of all previous primes under #{limit} is #{solution}."