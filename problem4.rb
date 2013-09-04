def isPalindrome?(number)

  list = []
  is_palindrome = true
  
  while number > 0
    list.push(number % 10)
    number = number / 10   
  end
  
  length = list.length / 2
  
  length.times do |i|
    if not( is_palindrome = (list[i] == list[list.length - i - 1]))
      break
    end

  end
  
  return is_palindrome
end

def attempt1(max)

  palindrome_max = 0
  
  max.downto(1) do |i|
  
    i.downto(1) do |j|
      number = i *j
      
      #if it is less then we don't need to process these numbers anymore
      if number < palindrome_max
        break
      elsif isPalindrome?(number)
        palindrome_max = number
        break
      end
    end
  end
  
  return palindrome_max
end


#puts "Is 1234 a palindrome? ", isPalindrome?(1234)
#puts "Is 1001 a palindrome? ", isPalindrome?(1001)
#puts "Is 1900019 a palindrome? ", isPalindrome?(1900019)
#puts "Is 11011 a palindrome? ", isPalindrome?(11011)
#puts "Is 999999999999 a palindrome? ", isPalindrome?(999999999999)

#do the test case = 9009
#puts attempt1(99)

puts attempt1(999)
