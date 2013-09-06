require 'prime'

def find_nth_prime(n)
  prime = 0
  i = 0
  Prime.each do |num|
    #puts "prime #{num}, i #{i}"
    if i >= n
      break
    end
    prime = num
    
    i += 1
  end
  
  return prime

end

# 6th prime is 13
#number = 6
number = 10001

prime = find_nth_prime(number)

puts "The #{number} pime is #{prime}."