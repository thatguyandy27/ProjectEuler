require 'prime'
require 'set'

#may need to up this
@primes = Prime.each(100000).to_set

max = 1000

def find_consecutive_primes(a, b)
  n = 0
  
  while (@primes.include?(n**2 + n*a + b))
    n += 1
  end
  
  return n
  
end

puts "#{find_consecutive_primes( - 79, 1601)}"
def find_max_prime_values(min,max)
  a = min
  b = min
  return_value = 0
  count = 0
  
  a.upto(max) do |x|
    b.upto(max) do |y|
      prime_count = find_consecutive_primes(x, y)
      
      if prime_count > count
        return_value = x * y 
        count = prime_count
        puts "the new max is #{x} #{y} with sum of #{prime_count}"
      end
    end
  end
  
  return return_value
end

#solution = find_max_prime_values(max * -1, max)