
def get_answer(min_divisors)
  index = 1
  divisors = 0
  sum = 0
  while divisors < min_divisors
    sum += index
    divisors = 0
      
    if sum > min_divisors
      lastDivisor = 0
      (sum).times do |i|
        divisor = i+1
        #puts "#{sum /divisor} <= #{lastDivisor}"
        #we already took care of this so we can break the loop
        if (sum /divisor) <= lastDivisor
          break
        end
        
        if sum % divisor  == 0
          lastDivisor = divisor
          divisors +=2
          
        end
      end
      puts "index: #{index}: #{sum}, has #{divisors} divisors"
    end 
    index +=1
  end
  
  return sum

end

#test.  answer should be 28
#min_divisors = 5
min_divisors = 500
answer = get_answer(min_divisors)
# answer I got was 162160
puts "The first triangle number with #{min_divisors} is #{answer}."

