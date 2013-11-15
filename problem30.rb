
def sum_of_digits?(n, power)
  sum = 0
  original_n = n
  while n > 0
    sum += (n%10)**power
    n = n /10
  end
  
  return sum == original_n
end

def get_sum(limit, power)
  sum = 0
  10.upto(limit) do |n|
    if sum_of_digits?(n, power)
      puts "#{n}"
      sum += n
    end
  end 
  
  return sum
end

limit = 10000000
power = 5
sum = get_sum(limit, power)
puts "The sum is #{sum}"
#maybe 443839
#number = 1634
#power = 4
#puts "Is #{number} sum of digits #{sum_of_digits?(number, power)}"

#number = 8208
#power = 4
#puts "Is #{number} sum of digits #{sum_of_digits?(number, power)}"

#number = 9474
#power = 4
#puts "Is #{number} sum of digits #{sum_of_digits?(number, power)}"

#number = 1635
#power = 4
#puts "Is #{number} sum of digits #{sum_of_digits?(number, power)}"