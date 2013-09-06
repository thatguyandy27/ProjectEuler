

def get_max_option(max)
  #options = []
  i= 1
  while (value = i**2) < max
    #options << i
    i += 1
  end
  return i - 1
end

def is_pythagorean_triplet?(a,b,c)
  
  return a**2 + b**2 == c**2

end

def get_answer(number)
  a,b,c = 0,0,0
  
  if a + b + c == number
    if is_pythagorean_triplet?(a,b,c)
      return a*b*c
    end
  end
end


#a**2 + b**2 = c**2
#a**2 + b**2 = (1000 + a + b)**2
def attempt2(number)

  #a, b, c = number, number - 1, 0
  
  number.times do |b|
    b.times do |a|
      c = Math.sqrt(a**2 + b**2)
      if c + a + b == number
        puts "a: #{a}, b: #{b}, c: #{c}"
        return c*a*b
      end
    end
    
  end
  
  return 0
    
end

number = 1000
#max_option = get_max_option(number)

#puts is_pythagorean_triplet?(3,4, 5)
#puts is_pythagorean_triplet?(4,4, 5)
#answer = get_answer(number)#, max_option)

answer = attempt2(1000)
puts "The answer is #{answer}"

#puts options
#puts "All available options: ", options