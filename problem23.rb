require 'set'

def is_abundant?(number)
  divisors = get_divisors(number)
  if (divisors.inject(:+) > number)
    return true
  else
    return false
  end
end

def get_divisors(number)
  divisors = [1]
  2.upto(number/2) do |i|
    if (number % i == 0)
      divisors << i 
    end
  end
  return divisors
end

def get_abundant_numbers()
  list = []
  1.upto(28124) do |i|
    if (is_abundant?(i))
      list << i
    end
  end
  
  return list
end

AbundantNumbers = get_abundant_numbers()
def is_sum_of_abundant_numbers?(i)
  
  AbundantNumbers.each do |n|
    if (n > i)
      return false
    end
    
    
    AbundantNumbers.each do |j|
 #     puts "#{i}, #{j}, #{n}"
 #     next if j == n
      
      break if j + n > i

      return true if j + n == i
      
    end
    
  end
  
  return false
end

#puts "is #{28} abundant #{is_abundant?(28)}"
#puts "is #{12} abundant #{is_abundant?(12)}"

#puts "is #{23} the sum of 2 abundant numbers? #{is_sum_of_abundant_numbers(23)}"
#puts "is #{24} the sum of 2 abundant numbers? #{is_sum_of_abundant_numbers(24)}"
#puts "is #{25} the sum of 2 abundant numbers? #{is_sum_of_abundant_numbers(25)}"
set_of_numbers = Set.new
sum = 0
AbundantNumbers.each do |n|
  AbundantNumbers.each do |m|
    new_value = n + m
    break if new_value >= 28124
    
  #  if !set_of_numbers.include?(new_value) 
      set_of_numbers << new_value
 #     sum += new_value
  #  end
  end

end

1.upto(28124) do |n|
  if !set_of_numbers.include?(n) 
    sum += n
  end
end

puts "sum #{sum}"

#set_of_numbers.each do |i|
#  sum += i
#end
#1.upto(28123) do |n|
#  if (is_sum_of_abundant_numbers?(n))
#    sum += n
#  end
#end
puts 
