def find_sum(max)
  sum = 0
  1.upto(max) do |x|
    sum += x**x
  end
  return sum
end

# for 10 the answer is 10405071317
#number = 10
number = 1000
puts "sum for #{number} is #{find_sum(number)}"