number = 2**1000
#test 2**15 sum is 26
#number = 2**15

puts "number is #{number}"

sum = 0
while number > 0
  sum += number % 10
  number = number / 10
end

#1366
puts "sum is #{sum}"