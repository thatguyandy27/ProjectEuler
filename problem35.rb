require 'prime'
require 'set'

def include_in_set?(num)
  return true if num < 10
     
  while num > 0
    return false if (num.even? || num.to_s.include?('5'))
    num = num / 10
  end

  return true
end


def get_primes(limit)
  set = Set.new
  Prime.each(limit) do |n|
    set << n if include_in_set?(n)
  end
  
  return set
  
end

limit = 1000000

primes = get_primes(limit)

def rotate_number(num)

  return num if  num < 10 
  
  str_num = num.to_s
  
  temp = str_num[0]
  
  return (str_num.slice(1, str_num.length - 1) + temp).to_i

end


#can't contain an even number
def circular_prime?(prime, set)

  num = rotate_number(prime)
  is_circular = true
  
  while num != prime
    if !set.include?(num)
      is_circular = false
      break
    end
    num = rotate_number(num)
  end
  
  return is_circular

end

def get_count_of_primes(primes)
  count = 0
  primes.each do |n|
    if circular_prime? n, primes
      count += 1
    end
  end
  
  return count

end

puts primes
#test 
#number = rotate_number(197)
count = get_count_of_primes(primes)
puts count