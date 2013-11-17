
@factorial_lookup = {
 0 => 1,
 1 => 1,
 2 => 2,
 3 => 6,
 4 => 24,
 5 => 120,
 6 => 720,
 7 => 5040,
 8 => 40320,
 9 => 362880
}


def sum_of_factorial?(n)

  sum = 0
  original_n = n
  
  while (n > 0)
    sum += @factorial_lookup[(n % 10)]
    n = n / 10
  end

  return original_n == sum 
end

def get_some(limit)
  
  sum = 0
  10.upto(limit) do |i|
    if sum_of_factorial?(i)
      sum += i
    end
  end
return sum
end

max = 10000000
sum = get_some(max)
puts "The sum is #{sum}"
#the answer is 40730


#number  = 145
#puts "Is #{number} a sum of factorials #{sum_of_factorial?(number)}"
#number  = 142
#puts "Is #{number} a sum of factorials #{sum_of_factorial?(number)}"