def sum_of_squares(number)
  result =0
  number.times do |n|
    i = n+1
    result += i**2
    #puts i, result
  end
  
  return result
end

def square_of_sum(number)
  result = 0
  number.times do |n|
    i = n+1
    result += i
  end
  
  result = result**2
  return result
end



#test case 10 => 3025 - 385 = 2640
#number = 10
number = 100
sum_of_squares_result = sum_of_squares(number)
square_of_sum_result = square_of_sum(number)
puts "Sum of the squares of #{number} is #{sum_of_squares_result}."
puts "Square of the sum of #{number} is #{square_of_sum_result}."
puts "The difference is ", square_of_sum_result - sum_of_squares_result
