def palindrome?(number, base)
  str = number.to_s(base)
  is_palindrome = true
  length = str.length
  x = 0
  while ( x < length / 2)
    return false if (str[x] != str[length - x - 1])
    x += 1
  end  

  return is_palindrome
end

max = 1000000

def sum_of_palindromes(max)
  sum = 0
  max.times do |n|
    sum += n if (palindrome?(n, 10) && palindrome?(n, 2))
  end
  return sum
end

#872187
sum = sum_of_palindromes(max)
puts "The sum is #{sum}"

#test 
#number = 9
#result = palindrome?(number, 10)
#puts "#{number}: #{result}"
#number = 9
#result = palindrome?(number, 2)
#puts "#{number}: #{result}"

#number = 1000201
#result = palindrome?(number, 10)
#puts "#{number}: #{result}"
#number = 199991
#result = palindrome?(number, 10)
#puts "#{number}: #{result}"
#number = 2
#result = palindrome?(number, 2)
#puts "#{number}: #{result}"